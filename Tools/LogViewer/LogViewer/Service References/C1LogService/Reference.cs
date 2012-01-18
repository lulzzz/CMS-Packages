﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogViewer.C1LogService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LogEntry", Namespace="http://schemas.datacontract.org/2004/07/Composite.Logging.WCF")]
    [System.SerializableAttribute()]
    public partial class LogEntry : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ApplicationDomainIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DisplayOptionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SeverityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ThreadIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeStampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public int ApplicationDomainId {
            get {
                return this.ApplicationDomainIdField;
            }
            set {
                if ((this.ApplicationDomainIdField.Equals(value) != true)) {
                    this.ApplicationDomainIdField = value;
                    this.RaisePropertyChanged("ApplicationDomainId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayOptions {
            get {
                return this.DisplayOptionsField;
            }
            set {
                if ((object.ReferenceEquals(this.DisplayOptionsField, value) != true)) {
                    this.DisplayOptionsField = value;
                    this.RaisePropertyChanged("DisplayOptions");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Severity {
            get {
                return this.SeverityField;
            }
            set {
                if ((object.ReferenceEquals(this.SeverityField, value) != true)) {
                    this.SeverityField = value;
                    this.RaisePropertyChanged("Severity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ThreadId {
            get {
                return this.ThreadIdField;
            }
            set {
                if ((this.ThreadIdField.Equals(value) != true)) {
                    this.ThreadIdField = value;
                    this.RaisePropertyChanged("ThreadId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp {
            get {
                return this.TimeStampField;
            }
            set {
                if ((this.TimeStampField.Equals(value) != true)) {
                    this.TimeStampField = value;
                    this.RaisePropertyChanged("TimeStamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="C1LogService.ILogService")]
    public interface ILogService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/Authenticate", ReplyAction="http://tempuri.org/ILogService/AuthenticateResponse")]
        string Authenticate(string adminPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/GetLastStartupTime", ReplyAction="http://tempuri.org/ILogService/GetLastStartupTimeResponse")]
        System.DateTime GetLastStartupTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/GetServerTime", ReplyAction="http://tempuri.org/ILogService/GetServerTimeResponse")]
        System.DateTime GetServerTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/GetLoggingDates", ReplyAction="http://tempuri.org/ILogService/GetLoggingDatesResponse")]
        System.DateTime[] GetLoggingDates();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/GetLogEntriesCount", ReplyAction="http://tempuri.org/ILogService/GetLogEntriesCountResponse")]
        int GetLogEntriesCount(System.DateTime timeFrom, System.DateTime timeTo, bool includeVerbose);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/GetLogEntriesCountByDate", ReplyAction="http://tempuri.org/ILogService/GetLogEntriesCountByDateResponse")]
        int GetLogEntriesCountByDate(System.DateTime date, bool includeVerbose);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/GetLogEntries", ReplyAction="http://tempuri.org/ILogService/GetLogEntriesResponse")]
        LogViewer.C1LogService.LogEntry[] GetLogEntries(System.DateTime timeFrom, System.DateTime timeTo, bool includeVerbose, int maximumAmount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogService/GetLogEntriesFrom", ReplyAction="http://tempuri.org/ILogService/GetLogEntriesFromResponse")]
        LogViewer.C1LogService.LogEntry[] GetLogEntriesFrom(System.DateTime timeFrom, bool includeVerbose, int maximumAmount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILogServiceChannel : LogViewer.C1LogService.ILogService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LogServiceClient : System.ServiceModel.ClientBase<LogViewer.C1LogService.ILogService>, LogViewer.C1LogService.ILogService {
        
        public LogServiceClient() {
        }
        
        public LogServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LogServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Authenticate(string adminPassword) {
            return base.Channel.Authenticate(adminPassword);
        }
        
        public System.DateTime GetLastStartupTime() {
            return base.Channel.GetLastStartupTime();
        }
        
        public System.DateTime GetServerTime() {
            return base.Channel.GetServerTime();
        }
        
        public System.DateTime[] GetLoggingDates() {
            return base.Channel.GetLoggingDates();
        }
        
        public int GetLogEntriesCount(System.DateTime timeFrom, System.DateTime timeTo, bool includeVerbose) {
            return base.Channel.GetLogEntriesCount(timeFrom, timeTo, includeVerbose);
        }
        
        public int GetLogEntriesCountByDate(System.DateTime date, bool includeVerbose) {
            return base.Channel.GetLogEntriesCountByDate(date, includeVerbose);
        }
        
        public LogViewer.C1LogService.LogEntry[] GetLogEntries(System.DateTime timeFrom, System.DateTime timeTo, bool includeVerbose, int maximumAmount) {
            return base.Channel.GetLogEntries(timeFrom, timeTo, includeVerbose, maximumAmount);
        }
        
        public LogViewer.C1LogService.LogEntry[] GetLogEntriesFrom(System.DateTime timeFrom, bool includeVerbose, int maximumAmount) {
            return base.Channel.GetLogEntriesFrom(timeFrom, includeVerbose, maximumAmount);
        }
    }
}