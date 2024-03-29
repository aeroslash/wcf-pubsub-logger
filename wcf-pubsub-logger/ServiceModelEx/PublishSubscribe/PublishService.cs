// � 2008 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Diagnostics;
using ServiceModelEx.PublishSubscribeDataSetTableAdapters;
using System.Reflection;
using System.Threading;

namespace ServiceModelEx
{
   public abstract class PublishService<T> where T : class
   {
      protected static void FireEvent(params object[] args)
      {
         string action = OperationContext.Current.IncomingMessageHeaders.Action;
         string[] slashes = action.Split('/');
         string methodName = slashes[slashes.Length-1];

         FireEvent(methodName,args);
      }

      protected static void FireEvent(string methodName,params object[] args)
      {
         //PublishPersistent(methodName,args);
         PublishTransient(methodName,args);
      }

      static void PublishPersistent(string methodName,params object[] args)
      {
         T[] subscribers = SubscriptionManager<T>.GetPersistentList(methodName);
         Publish(subscribers,true,methodName,args);
      }

      static void PublishTransient(string methodName,params object[] args)
      {
         T[] subscribers = SubscriptionManager<T>.GetTransientList(methodName);
         Publish(subscribers,false,methodName,args);
      }

      static void Publish(T[] subscribers,bool closeSubscribers,string methodName,params object[] args)
      {
         WaitCallback fire = (subscriber)=>
                             {
                                Invoke(subscriber as T,methodName,args);
                                if(closeSubscribers)
                                {
                                   using(subscriber as IDisposable)
                                   {}
                                }
                             };
         Action<T> queueUp = (subscriber)=>
                             {
                                ThreadPool.QueueUserWorkItem(fire,subscriber);
                             };
         subscribers.ForEach(queueUp);
      }

      static void Invoke(T subscriber,string methodName,object[] args)
      {
         Debug.Assert(subscriber != null);
         Type type = typeof(T);
         MethodInfo methodInfo = type.GetMethod(methodName);
         try
         {
            methodInfo.Invoke(subscriber,args);
         }
         catch(Exception e)
         {
            Trace.WriteLine(e.Message);
         }
      }
   }
}