﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dome.R201 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.partner.dome.fr/", ConfigurationName="R201.DOME_BUS_EAI_R201eventCreateWS")]
    internal interface DOME_BUS_EAI_R201eventCreateWS {
        
        // CODEGEN: Parameter 'createEventResponse' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeResponseDto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeCommonDto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeDto))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="createEventResponse")]
        Dome.R201.createEventResponse createEvent(Dome.R201.createEvent request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class createEventDto : domeDto {
        
        private createEventInnerDto dOME_eventCreateField;
        
        private createEventContactDto[] dOME_eventContactListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public createEventInnerDto DOME_eventCreate {
            get {
                return this.dOME_eventCreateField;
            }
            set {
                this.dOME_eventCreateField = value;
                this.RaisePropertyChanged("DOME_eventCreate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DOME_eventContactList", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public createEventContactDto[] DOME_eventContactList {
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
    public partial class createEventInnerDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int eventCategoryIdField;
        
        private bool eventCategoryIdFieldSpecified;
        
        private string eventTitleField;
        
        private string eventDescriptionField;
        
        private System.DateTime eventTimeStartField;
        
        private bool eventTimeStartFieldSpecified;
        
        private System.DateTime eventTimeEndField;
        
        private bool eventTimeEndFieldSpecified;
        
        private int eventAlarmField;
        
        private bool eventAlarmFieldSpecified;
        
        private string eventCommentField;
        
        private int eventPeriodicityField;
        
        private bool eventPeriodicityFieldSpecified;
        
        private System.DateTime eventRecurrenceEndField;
        
        private bool eventRecurrenceEndFieldSpecified;
        
        private int benefProfileIdField;
        
        private bool benefProfileIdFieldSpecified;
        
        private int eventProIdMetierField;
        
        private bool eventProIdMetierFieldSpecified;
        
        private int intervenantProfileIDField;
        
        private bool intervenantProfileIDFieldSpecified;
        
        private int eventStateField;
        
        private bool eventStateFieldSpecified;
        
        private string eventServiceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int eventAlarm {
            get {
                return this.eventAlarmField;
            }
            set {
                this.eventAlarmField = value;
                this.RaisePropertyChanged("eventAlarm");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventAlarmSpecified {
            get {
                return this.eventAlarmFieldSpecified;
            }
            set {
                this.eventAlarmFieldSpecified = value;
                this.RaisePropertyChanged("eventAlarmSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int benefProfileId {
            get {
                return this.benefProfileIdField;
            }
            set {
                this.benefProfileIdField = value;
                this.RaisePropertyChanged("benefProfileId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool benefProfileIdSpecified {
            get {
                return this.benefProfileIdFieldSpecified;
            }
            set {
                this.benefProfileIdFieldSpecified = value;
                this.RaisePropertyChanged("benefProfileIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int eventProIdMetier {
            get {
                return this.eventProIdMetierField;
            }
            set {
                this.eventProIdMetierField = value;
                this.RaisePropertyChanged("eventProIdMetier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventProIdMetierSpecified {
            get {
                return this.eventProIdMetierFieldSpecified;
            }
            set {
                this.eventProIdMetierFieldSpecified = value;
                this.RaisePropertyChanged("eventProIdMetierSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string eventService {
            get {
                return this.eventServiceField;
            }
            set {
                this.eventServiceField = value;
                this.RaisePropertyChanged("eventService");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createEventResponseDto))]
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
        
        private string userMessageField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string userMessage {
            get {
                return this.userMessageField;
            }
            set {
                this.userMessageField = value;
                this.RaisePropertyChanged("userMessage");
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
        
        private string softwareNameField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string softwareName {
            get {
                return this.softwareNameField;
            }
            set {
                this.softwareNameField = value;
                this.RaisePropertyChanged("softwareName");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class createEventResponseDto : domeResponseDto {
        
        private int eventIdField;
        
        private bool eventIdFieldSpecified;
        
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class createEventContactDto : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createEventDto))]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="createEvent", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    internal partial class createEvent {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dome.R201.createEventDto createEventDto;
        
        public createEvent() {
        }
        
        public createEvent(Dome.R201.createEventDto createEventDto) {
            this.createEventDto = createEventDto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createEventResponse", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    internal partial class createEventResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="createEventResponse", Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dome.R201.createEventResponseDto createEventResponse1;
        
        public createEventResponse() {
        }
        
        public createEventResponse(Dome.R201.createEventResponseDto createEventResponse1) {
            this.createEventResponse1 = createEventResponse1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface DOME_BUS_EAI_R201eventCreateWSChannel : Dome.R201.DOME_BUS_EAI_R201eventCreateWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class DOME_BUS_EAI_R201eventCreateWSClient : System.ServiceModel.ClientBase<Dome.R201.DOME_BUS_EAI_R201eventCreateWS>, Dome.R201.DOME_BUS_EAI_R201eventCreateWS {
        
        public DOME_BUS_EAI_R201eventCreateWSClient() {
        }
        
        public DOME_BUS_EAI_R201eventCreateWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DOME_BUS_EAI_R201eventCreateWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R201eventCreateWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R201eventCreateWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dome.R201.createEventResponse Dome.R201.DOME_BUS_EAI_R201eventCreateWS.createEvent(Dome.R201.createEvent request) {
            return base.Channel.createEvent(request);
        }
        
        public Dome.R201.createEventResponseDto createEvent(Dome.R201.createEventDto createEventDto) {
            Dome.R201.createEvent inValue = new Dome.R201.createEvent();
            inValue.createEventDto = createEventDto;
            Dome.R201.createEventResponse retVal = ((Dome.R201.DOME_BUS_EAI_R201eventCreateWS)(this)).createEvent(inValue);
            return retVal.createEventResponse1;
        }
    }
}
