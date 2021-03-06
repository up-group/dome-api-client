﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dome.R821 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.partner.dome.fr/", ConfigurationName="R821.DOME_BUS_EAI_R821getListJourneyEntryWS")]
    internal interface DOME_BUS_EAI_R821getListJourneyEntryWS {
        
        // CODEGEN: Parameter 'getListCourseEntryResponse' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeResponseDto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeCommonDto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeDto))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getListCourseEntryResponse")]
        Dome.R821.getListCourseEntryResponse getListCourseEntry(Dome.R821.getListCourseEntry request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class getListCourseEntryDto : domeDto {
        
        private int benefProfileIdField;
        
        private bool benefProfileIdFieldSpecified;
        
        private int nbParcoursField;
        
        private bool nbParcoursFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int nbParcours {
            get {
                return this.nbParcoursField;
            }
            set {
                this.nbParcoursField = value;
                this.RaisePropertyChanged("nbParcours");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nbParcoursSpecified {
            get {
                return this.nbParcoursFieldSpecified;
            }
            set {
                this.nbParcoursFieldSpecified = value;
                this.RaisePropertyChanged("nbParcoursSpecified");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getListCourseEntryDto))]
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
    public partial class courseEntryListItemDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int parcoursPatientIdField;
        
        private bool parcoursPatientIdFieldSpecified;
        
        private System.DateTime eventDateField;
        
        private bool eventDateFieldSpecified;
        
        private int sensParcoursIdField;
        
        private bool sensParcoursIdFieldSpecified;
        
        private string structureNameField;
        
        private int structureCityZipCodeField;
        
        private bool structureCityZipCodeFieldSpecified;
        
        private string structureCityNameField;
        
        private int structureServiceIdField;
        
        private bool structureServiceIdFieldSpecified;
        
        private int admissionTypeIdField;
        
        private bool admissionTypeIdFieldSpecified;
        
        private int parcoursPatientCreationProfileIdField;
        
        private bool parcoursPatientCreationProfileIdFieldSpecified;
        
        private string parcoursPatientCreatorNameField;
        
        private System.DateTime parcoursPatientCreationDateField;
        
        private bool parcoursPatientCreationDateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int parcoursPatientId {
            get {
                return this.parcoursPatientIdField;
            }
            set {
                this.parcoursPatientIdField = value;
                this.RaisePropertyChanged("parcoursPatientId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parcoursPatientIdSpecified {
            get {
                return this.parcoursPatientIdFieldSpecified;
            }
            set {
                this.parcoursPatientIdFieldSpecified = value;
                this.RaisePropertyChanged("parcoursPatientIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime eventDate {
            get {
                return this.eventDateField;
            }
            set {
                this.eventDateField = value;
                this.RaisePropertyChanged("eventDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventDateSpecified {
            get {
                return this.eventDateFieldSpecified;
            }
            set {
                this.eventDateFieldSpecified = value;
                this.RaisePropertyChanged("eventDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int sensParcoursId {
            get {
                return this.sensParcoursIdField;
            }
            set {
                this.sensParcoursIdField = value;
                this.RaisePropertyChanged("sensParcoursId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sensParcoursIdSpecified {
            get {
                return this.sensParcoursIdFieldSpecified;
            }
            set {
                this.sensParcoursIdFieldSpecified = value;
                this.RaisePropertyChanged("sensParcoursIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string structureName {
            get {
                return this.structureNameField;
            }
            set {
                this.structureNameField = value;
                this.RaisePropertyChanged("structureName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int structureCityZipCode {
            get {
                return this.structureCityZipCodeField;
            }
            set {
                this.structureCityZipCodeField = value;
                this.RaisePropertyChanged("structureCityZipCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool structureCityZipCodeSpecified {
            get {
                return this.structureCityZipCodeFieldSpecified;
            }
            set {
                this.structureCityZipCodeFieldSpecified = value;
                this.RaisePropertyChanged("structureCityZipCodeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string structureCityName {
            get {
                return this.structureCityNameField;
            }
            set {
                this.structureCityNameField = value;
                this.RaisePropertyChanged("structureCityName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int structureServiceId {
            get {
                return this.structureServiceIdField;
            }
            set {
                this.structureServiceIdField = value;
                this.RaisePropertyChanged("structureServiceId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool structureServiceIdSpecified {
            get {
                return this.structureServiceIdFieldSpecified;
            }
            set {
                this.structureServiceIdFieldSpecified = value;
                this.RaisePropertyChanged("structureServiceIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int admissionTypeId {
            get {
                return this.admissionTypeIdField;
            }
            set {
                this.admissionTypeIdField = value;
                this.RaisePropertyChanged("admissionTypeId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool admissionTypeIdSpecified {
            get {
                return this.admissionTypeIdFieldSpecified;
            }
            set {
                this.admissionTypeIdFieldSpecified = value;
                this.RaisePropertyChanged("admissionTypeIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int parcoursPatientCreationProfileId {
            get {
                return this.parcoursPatientCreationProfileIdField;
            }
            set {
                this.parcoursPatientCreationProfileIdField = value;
                this.RaisePropertyChanged("parcoursPatientCreationProfileId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parcoursPatientCreationProfileIdSpecified {
            get {
                return this.parcoursPatientCreationProfileIdFieldSpecified;
            }
            set {
                this.parcoursPatientCreationProfileIdFieldSpecified = value;
                this.RaisePropertyChanged("parcoursPatientCreationProfileIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string parcoursPatientCreatorName {
            get {
                return this.parcoursPatientCreatorNameField;
            }
            set {
                this.parcoursPatientCreatorNameField = value;
                this.RaisePropertyChanged("parcoursPatientCreatorName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public System.DateTime parcoursPatientCreationDate {
            get {
                return this.parcoursPatientCreationDateField;
            }
            set {
                this.parcoursPatientCreationDateField = value;
                this.RaisePropertyChanged("parcoursPatientCreationDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parcoursPatientCreationDateSpecified {
            get {
                return this.parcoursPatientCreationDateFieldSpecified;
            }
            set {
                this.parcoursPatientCreationDateFieldSpecified = value;
                this.RaisePropertyChanged("parcoursPatientCreationDateSpecified");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getListCourseEntryResponseDto))]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class getListCourseEntryResponseDto : domeResponseDto {
        
        private courseEntryListItemDto[] dOME_parcoursPatientListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DOME_parcoursPatientList", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public courseEntryListItemDto[] DOME_parcoursPatientList {
            get {
                return this.dOME_parcoursPatientListField;
            }
            set {
                this.dOME_parcoursPatientListField = value;
                this.RaisePropertyChanged("DOME_parcoursPatientList");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getListCourseEntry", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    internal partial class getListCourseEntry {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListCourseEntry", Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dome.R821.getListCourseEntryDto getListCourseEntry1;
        
        public getListCourseEntry() {
        }
        
        public getListCourseEntry(Dome.R821.getListCourseEntryDto getListCourseEntry1) {
            this.getListCourseEntry1 = getListCourseEntry1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getListCourseEntryResponse", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    internal partial class getListCourseEntryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListCourseEntryResponse", Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dome.R821.getListCourseEntryResponseDto getListCourseEntryResponse1;
        
        public getListCourseEntryResponse() {
        }
        
        public getListCourseEntryResponse(Dome.R821.getListCourseEntryResponseDto getListCourseEntryResponse1) {
            this.getListCourseEntryResponse1 = getListCourseEntryResponse1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface DOME_BUS_EAI_R821getListJourneyEntryWSChannel : Dome.R821.DOME_BUS_EAI_R821getListJourneyEntryWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class DOME_BUS_EAI_R821getListJourneyEntryWSClient : System.ServiceModel.ClientBase<Dome.R821.DOME_BUS_EAI_R821getListJourneyEntryWS>, Dome.R821.DOME_BUS_EAI_R821getListJourneyEntryWS {
        
        public DOME_BUS_EAI_R821getListJourneyEntryWSClient() {
        }
        
        public DOME_BUS_EAI_R821getListJourneyEntryWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DOME_BUS_EAI_R821getListJourneyEntryWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R821getListJourneyEntryWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R821getListJourneyEntryWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dome.R821.getListCourseEntryResponse Dome.R821.DOME_BUS_EAI_R821getListJourneyEntryWS.getListCourseEntry(Dome.R821.getListCourseEntry request) {
            return base.Channel.getListCourseEntry(request);
        }
        
        public Dome.R821.getListCourseEntryResponseDto getListCourseEntry(Dome.R821.getListCourseEntryDto getListCourseEntry1) {
            Dome.R821.getListCourseEntry inValue = new Dome.R821.getListCourseEntry();
            inValue.getListCourseEntry1 = getListCourseEntry1;
            Dome.R821.getListCourseEntryResponse retVal = ((Dome.R821.DOME_BUS_EAI_R821getListJourneyEntryWS)(this)).getListCourseEntry(inValue);
            return retVal.getListCourseEntryResponse1;
        }
    }
}
