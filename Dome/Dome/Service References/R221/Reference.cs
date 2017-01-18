﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dome.R221 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.partner.dome.fr/", ConfigurationName="R221.DOME_BUS_EAI_R221eventUpdateWS")]
    public interface DOME_BUS_EAI_R221eventUpdateWS {
        
        // CODEGEN: Parameter 'updateEventResponse' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeCommonDto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeDto))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="updateEventResponse")]
        Dome.R221.updateEventResponse updateEvent(Dome.R221.updateEvent request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Dome.R221.updateEventResponse> updateEventAsync(Dome.R221.updateEvent request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class eventUpdateDto : domeDto {
        
        private eventDataUpdateDto dOME_eventDatasUpdateField;
        
        private eventContactFilterDto[] dOME_eventContactListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public eventDataUpdateDto DOME_eventDatasUpdate {
            get {
                return this.dOME_eventDatasUpdateField;
            }
            set {
                this.dOME_eventDatasUpdateField = value;
                this.RaisePropertyChanged("DOME_eventDatasUpdate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DOME_eventContactList", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public eventContactFilterDto[] DOME_eventContactList {
            get {
                return this.dOME_eventContactListField;
            }
            set {
                this.dOME_eventContactListField = value;
                this.RaisePropertyChanged("DOME_eventContactList");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class eventDataUpdateDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int eventIdField;
        
        private bool eventIdFieldSpecified;
        
        private string eventTitleField;
        
        private int eventCategoryIdField;
        
        private bool eventCategoryIdFieldSpecified;
        
        private string eventDescriptionField;
        
        private System.DateTime eventTimeStartField;
        
        private bool eventTimeStartFieldSpecified;
        
        private System.DateTime eventTimeEndField;
        
        private bool eventTimeEndFieldSpecified;
        
        private int eventAlarmTimeField;
        
        private bool eventAlarmTimeFieldSpecified;
        
        private string eventCommentField;
        
        private int eventPeriodicityField;
        
        private bool eventPeriodicityFieldSpecified;
        
        private System.DateTime eventRecurrenceEndField;
        
        private bool eventRecurrenceEndFieldSpecified;
        
        private int intervenantProfileIDField;
        
        private bool intervenantProfileIDFieldSpecified;
        
        private int eventStateField;
        
        private bool eventStateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int eventId {
            get {
                return this.eventIdField;
            }
            set {
                this.eventIdField = value;
                this.RaisePropertyChanged("eventId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventIdSpecified {
            get {
                return this.eventIdFieldSpecified;
            }
            set {
                this.eventIdFieldSpecified = value;
                this.RaisePropertyChanged("eventIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string eventTitle {
            get {
                return this.eventTitleField;
            }
            set {
                this.eventTitleField = value;
                this.RaisePropertyChanged("eventTitle");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int eventCategoryId {
            get {
                return this.eventCategoryIdField;
            }
            set {
                this.eventCategoryIdField = value;
                this.RaisePropertyChanged("eventCategoryId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventCategoryIdSpecified {
            get {
                return this.eventCategoryIdFieldSpecified;
            }
            set {
                this.eventCategoryIdFieldSpecified = value;
                this.RaisePropertyChanged("eventCategoryIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string eventDescription {
            get {
                return this.eventDescriptionField;
            }
            set {
                this.eventDescriptionField = value;
                this.RaisePropertyChanged("eventDescription");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime eventTimeStart {
            get {
                return this.eventTimeStartField;
            }
            set {
                this.eventTimeStartField = value;
                this.RaisePropertyChanged("eventTimeStart");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventTimeStartSpecified {
            get {
                return this.eventTimeStartFieldSpecified;
            }
            set {
                this.eventTimeStartFieldSpecified = value;
                this.RaisePropertyChanged("eventTimeStartSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public System.DateTime eventTimeEnd {
            get {
                return this.eventTimeEndField;
            }
            set {
                this.eventTimeEndField = value;
                this.RaisePropertyChanged("eventTimeEnd");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventTimeEndSpecified {
            get {
                return this.eventTimeEndFieldSpecified;
            }
            set {
                this.eventTimeEndFieldSpecified = value;
                this.RaisePropertyChanged("eventTimeEndSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int eventAlarmTime {
            get {
                return this.eventAlarmTimeField;
            }
            set {
                this.eventAlarmTimeField = value;
                this.RaisePropertyChanged("eventAlarmTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventAlarmTimeSpecified {
            get {
                return this.eventAlarmTimeFieldSpecified;
            }
            set {
                this.eventAlarmTimeFieldSpecified = value;
                this.RaisePropertyChanged("eventAlarmTimeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string eventComment {
            get {
                return this.eventCommentField;
            }
            set {
                this.eventCommentField = value;
                this.RaisePropertyChanged("eventComment");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int eventPeriodicity {
            get {
                return this.eventPeriodicityField;
            }
            set {
                this.eventPeriodicityField = value;
                this.RaisePropertyChanged("eventPeriodicity");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventPeriodicitySpecified {
            get {
                return this.eventPeriodicityFieldSpecified;
            }
            set {
                this.eventPeriodicityFieldSpecified = value;
                this.RaisePropertyChanged("eventPeriodicitySpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=9)]
        public System.DateTime eventRecurrenceEnd {
            get {
                return this.eventRecurrenceEndField;
            }
            set {
                this.eventRecurrenceEndField = value;
                this.RaisePropertyChanged("eventRecurrenceEnd");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventRecurrenceEndSpecified {
            get {
                return this.eventRecurrenceEndFieldSpecified;
            }
            set {
                this.eventRecurrenceEndFieldSpecified = value;
                this.RaisePropertyChanged("eventRecurrenceEndSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int intervenantProfileID {
            get {
                return this.intervenantProfileIDField;
            }
            set {
                this.intervenantProfileIDField = value;
                this.RaisePropertyChanged("intervenantProfileID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool intervenantProfileIDSpecified {
            get {
                return this.intervenantProfileIDFieldSpecified;
            }
            set {
                this.intervenantProfileIDFieldSpecified = value;
                this.RaisePropertyChanged("intervenantProfileIDSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int eventState {
            get {
                return this.eventStateField;
            }
            set {
                this.eventStateField = value;
                this.RaisePropertyChanged("eventState");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventStateSpecified {
            get {
                return this.eventStateFieldSpecified;
            }
            set {
                this.eventStateFieldSpecified = value;
                this.RaisePropertyChanged("eventStateSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class domeResponseDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private domeResponseHeaderDto dOME_headerField;
        
        private int statusIdField;
        
        private bool statusIdFieldSpecified;
        
        private string statusUserMessageField;
        
        private string statusErrorMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public domeResponseHeaderDto DOME_header {
            get {
                return this.dOME_headerField;
            }
            set {
                this.dOME_headerField = value;
                this.RaisePropertyChanged("DOME_header");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int statusId {
            get {
                return this.statusIdField;
            }
            set {
                this.statusIdField = value;
                this.RaisePropertyChanged("statusId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusIdSpecified {
            get {
                return this.statusIdFieldSpecified;
            }
            set {
                this.statusIdFieldSpecified = value;
                this.RaisePropertyChanged("statusIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string statusUserMessage {
            get {
                return this.statusUserMessageField;
            }
            set {
                this.statusUserMessageField = value;
                this.RaisePropertyChanged("statusUserMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string statusErrorMessage {
            get {
                return this.statusErrorMessageField;
            }
            set {
                this.statusErrorMessageField = value;
                this.RaisePropertyChanged("statusErrorMessage");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class domeResponseHeaderDto : domeCommonDto {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(domeResponseHeaderDto))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(domeHeaderDto))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class domeCommonDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        private string versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
                this.RaisePropertyChanged("date");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateSpecified {
            get {
                return this.dateFieldSpecified;
            }
            set {
                this.dateFieldSpecified = value;
                this.RaisePropertyChanged("dateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
                this.RaisePropertyChanged("version");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class domeHeaderDto : domeCommonDto {
        
        private int deviceTypeField;
        
        private bool deviceTypeFieldSpecified;
        
        private string langueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int deviceType {
            get {
                return this.deviceTypeField;
            }
            set {
                this.deviceTypeField = value;
                this.RaisePropertyChanged("deviceType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deviceTypeSpecified {
            get {
                return this.deviceTypeFieldSpecified;
            }
            set {
                this.deviceTypeFieldSpecified = value;
                this.RaisePropertyChanged("deviceTypeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string langue {
            get {
                return this.langueField;
            }
            set {
                this.langueField = value;
                this.RaisePropertyChanged("langue");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class eventContactFilterDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int contactIdField;
        
        private bool contactIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int contactId {
            get {
                return this.contactIdField;
            }
            set {
                this.contactIdField = value;
                this.RaisePropertyChanged("contactId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool contactIdSpecified {
            get {
                return this.contactIdFieldSpecified;
            }
            set {
                this.contactIdFieldSpecified = value;
                this.RaisePropertyChanged("contactIdSpecified");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(eventUpdateDto))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class domeDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private domeHeaderDto dOME_headerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public domeHeaderDto DOME_header {
            get {
                return this.dOME_headerField;
            }
            set {
                this.dOME_headerField = value;
                this.RaisePropertyChanged("DOME_header");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateEvent", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    public partial class updateEvent {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dome.R221.eventUpdateDto arg0;
        
        public updateEvent() {
        }
        
        public updateEvent(Dome.R221.eventUpdateDto arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateEventResponse", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    public partial class updateEventResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateEventResponse", Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dome.R221.domeResponseDto updateEventResponse1;
        
        public updateEventResponse() {
        }
        
        public updateEventResponse(Dome.R221.domeResponseDto updateEventResponse1) {
            this.updateEventResponse1 = updateEventResponse1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DOME_BUS_EAI_R221eventUpdateWSChannel : Dome.R221.DOME_BUS_EAI_R221eventUpdateWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DOME_BUS_EAI_R221eventUpdateWSClient : System.ServiceModel.ClientBase<Dome.R221.DOME_BUS_EAI_R221eventUpdateWS>, Dome.R221.DOME_BUS_EAI_R221eventUpdateWS {
        
        public DOME_BUS_EAI_R221eventUpdateWSClient() {
        }
        
        public DOME_BUS_EAI_R221eventUpdateWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DOME_BUS_EAI_R221eventUpdateWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R221eventUpdateWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R221eventUpdateWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dome.R221.updateEventResponse Dome.R221.DOME_BUS_EAI_R221eventUpdateWS.updateEvent(Dome.R221.updateEvent request) {
            return base.Channel.updateEvent(request);
        }
        
        public Dome.R221.domeResponseDto updateEvent(Dome.R221.eventUpdateDto arg0) {
            Dome.R221.updateEvent inValue = new Dome.R221.updateEvent();
            inValue.arg0 = arg0;
            Dome.R221.updateEventResponse retVal = ((Dome.R221.DOME_BUS_EAI_R221eventUpdateWS)(this)).updateEvent(inValue);
            return retVal.updateEventResponse1;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Dome.R221.updateEventResponse> Dome.R221.DOME_BUS_EAI_R221eventUpdateWS.updateEventAsync(Dome.R221.updateEvent request) {
            return base.Channel.updateEventAsync(request);
        }
        
        public System.Threading.Tasks.Task<Dome.R221.updateEventResponse> updateEventAsync(Dome.R221.eventUpdateDto arg0) {
            Dome.R221.updateEvent inValue = new Dome.R221.updateEvent();
            inValue.arg0 = arg0;
            return ((Dome.R221.DOME_BUS_EAI_R221eventUpdateWS)(this)).updateEventAsync(inValue);
        }
    }
}