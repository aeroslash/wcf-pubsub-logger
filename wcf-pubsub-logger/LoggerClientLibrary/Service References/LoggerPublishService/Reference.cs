﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoggerClientLibrary.LoggerPublishService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Event", Namespace="http://schemas.datacontract.org/2004/07/LoggerHostLibrary.DataContracts")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LoggerClientLibrary.LoggerPublishService.StatisticEvent))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LoggerClientLibrary.LoggerPublishService.CounterEvent))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LoggerClientLibrary.LoggerPublishService.LoggingEvent))]
    public partial class Event : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeRouterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProcessNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubProcessNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateTimeRouter {
            get {
                return this.DateTimeRouterField;
            }
            set {
                if ((this.DateTimeRouterField.Equals(value) != true)) {
                    this.DateTimeRouterField = value;
                    this.RaisePropertyChanged("DateTimeRouter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProcessName {
            get {
                return this.ProcessNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProcessNameField, value) != true)) {
                    this.ProcessNameField = value;
                    this.RaisePropertyChanged("ProcessName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubProcessName {
            get {
                return this.SubProcessNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SubProcessNameField, value) != true)) {
                    this.SubProcessNameField = value;
                    this.RaisePropertyChanged("SubProcessName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatisticEvent", Namespace="http://schemas.datacontract.org/2004/07/LoggerHostLibrary.DataContracts")]
    [System.SerializableAttribute()]
    public partial class StatisticEvent : LoggerClientLibrary.LoggerPublishService.Event {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeSourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatisticCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatisticNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LoggerClientLibrary.LoggerPublishService.StatisticEvent.StatisticTypes StatisticTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double StatisticValueDoubleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatisticValueIntField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatisticValueStringField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan StatisticValueTimeSpanField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateTimeSource {
            get {
                return this.DateTimeSourceField;
            }
            set {
                if ((this.DateTimeSourceField.Equals(value) != true)) {
                    this.DateTimeSourceField = value;
                    this.RaisePropertyChanged("DateTimeSource");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatisticCategory {
            get {
                return this.StatisticCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.StatisticCategoryField, value) != true)) {
                    this.StatisticCategoryField = value;
                    this.RaisePropertyChanged("StatisticCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatisticName {
            get {
                return this.StatisticNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StatisticNameField, value) != true)) {
                    this.StatisticNameField = value;
                    this.RaisePropertyChanged("StatisticName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LoggerClientLibrary.LoggerPublishService.StatisticEvent.StatisticTypes StatisticType {
            get {
                return this.StatisticTypeField;
            }
            set {
                if ((this.StatisticTypeField.Equals(value) != true)) {
                    this.StatisticTypeField = value;
                    this.RaisePropertyChanged("StatisticType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double StatisticValueDouble {
            get {
                return this.StatisticValueDoubleField;
            }
            set {
                if ((this.StatisticValueDoubleField.Equals(value) != true)) {
                    this.StatisticValueDoubleField = value;
                    this.RaisePropertyChanged("StatisticValueDouble");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StatisticValueInt {
            get {
                return this.StatisticValueIntField;
            }
            set {
                if ((this.StatisticValueIntField.Equals(value) != true)) {
                    this.StatisticValueIntField = value;
                    this.RaisePropertyChanged("StatisticValueInt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatisticValueString {
            get {
                return this.StatisticValueStringField;
            }
            set {
                if ((object.ReferenceEquals(this.StatisticValueStringField, value) != true)) {
                    this.StatisticValueStringField = value;
                    this.RaisePropertyChanged("StatisticValueString");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan StatisticValueTimeSpan {
            get {
                return this.StatisticValueTimeSpanField;
            }
            set {
                if ((this.StatisticValueTimeSpanField.Equals(value) != true)) {
                    this.StatisticValueTimeSpanField = value;
                    this.RaisePropertyChanged("StatisticValueTimeSpan");
                }
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="StatisticEvent.StatisticTypes", Namespace="http://schemas.datacontract.org/2004/07/LoggerHostLibrary.DataContracts")]
        public enum StatisticTypes : int {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            None = 0,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Integer = 1,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Double = 2,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            TimeSpan = 3,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            String = 4,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            IntegerTimeSpan = 5,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            DoubleTimeSpan = 6,
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CounterEvent", Namespace="http://schemas.datacontract.org/2004/07/LoggerHostLibrary.DataContracts")]
    [System.SerializableAttribute()]
    public partial class CounterEvent : LoggerClientLibrary.LoggerPublishService.Event {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CounterCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CounterNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CounterCategory {
            get {
                return this.CounterCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CounterCategoryField, value) != true)) {
                    this.CounterCategoryField = value;
                    this.RaisePropertyChanged("CounterCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CounterName {
            get {
                return this.CounterNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CounterNameField, value) != true)) {
                    this.CounterNameField = value;
                    this.RaisePropertyChanged("CounterName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoggingEvent", Namespace="http://schemas.datacontract.org/2004/07/LoggerHostLibrary.DataContracts")]
    [System.SerializableAttribute()]
    public partial class LoggingEvent : LoggerClientLibrary.LoggerPublishService.Event {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeSourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LoggerClientLibrary.LoggerPublishService.LoggingEvent.LogLevels LogLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateTimeSource {
            get {
                return this.DateTimeSourceField;
            }
            set {
                if ((this.DateTimeSourceField.Equals(value) != true)) {
                    this.DateTimeSourceField = value;
                    this.RaisePropertyChanged("DateTimeSource");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogCategory {
            get {
                return this.LogCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.LogCategoryField, value) != true)) {
                    this.LogCategoryField = value;
                    this.RaisePropertyChanged("LogCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LoggerClientLibrary.LoggerPublishService.LoggingEvent.LogLevels LogLevel {
            get {
                return this.LogLevelField;
            }
            set {
                if ((this.LogLevelField.Equals(value) != true)) {
                    this.LogLevelField = value;
                    this.RaisePropertyChanged("LogLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogMessage {
            get {
                return this.LogMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.LogMessageField, value) != true)) {
                    this.LogMessageField = value;
                    this.RaisePropertyChanged("LogMessage");
                }
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="LoggingEvent.LogLevels", Namespace="http://schemas.datacontract.org/2004/07/LoggerHostLibrary.DataContracts")]
        public enum LogLevels : int {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Emergency = 1,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Critical = 2,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Error = 3,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Important = 4,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Informational = 5,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Debug = 6,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Trace = 7,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://algobox.net/PubSubLogger/2009/07", ConfigurationName="LoggerPublishService.ILogger")]
    public interface ILogger {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://algobox.net/PubSubLogger/2009/07/ILogger/Log")]
        void Log(LoggerClientLibrary.LoggerPublishService.LoggingEvent logEvent);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://algobox.net/PubSubLogger/2009/07/ILogger/Statistic")]
        void Statistic(LoggerClientLibrary.LoggerPublishService.StatisticEvent statEvent);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://algobox.net/PubSubLogger/2009/07/ILogger/Counter")]
        void Counter(LoggerClientLibrary.LoggerPublishService.CounterEvent counterEvent);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ILoggerChannel : LoggerClientLibrary.LoggerPublishService.ILogger, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class LoggerClient : System.ServiceModel.ClientBase<LoggerClientLibrary.LoggerPublishService.ILogger>, LoggerClientLibrary.LoggerPublishService.ILogger {
        
        public LoggerClient() {
        }
        
        public LoggerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoggerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoggerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoggerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Log(LoggerClientLibrary.LoggerPublishService.LoggingEvent logEvent) {
            base.Channel.Log(logEvent);
        }
        
        public void Statistic(LoggerClientLibrary.LoggerPublishService.StatisticEvent statEvent) {
            base.Channel.Statistic(statEvent);
        }
        
        public void Counter(LoggerClientLibrary.LoggerPublishService.CounterEvent counterEvent) {
            base.Channel.Counter(counterEvent);
        }
    }
}
