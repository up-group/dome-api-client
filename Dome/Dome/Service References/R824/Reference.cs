﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dome.R824 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.partner.dome.fr/", ConfigurationName="R824.DOME_BUS_EAI_R824deleteJourneyEntryWS")]
    internal interface DOME_BUS_EAI_R824deleteJourneyEntryWS {
        
        // CODEGEN: Parameter 'deleteCourseEntry' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeCommonDto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeDto))]
        Dome.R824.deleteCourseEntryResponse deleteCourseEntry(Dome.R824.deleteCourseEntry request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class deleteCourseEntryDto : domeDto {
        
        private int benefProfileIdField;
        
        private bool benefProfileIdFieldSpecified;
        
        private int parcoursPatientIdField;
        
        private bool parcoursPatientIdFieldSpecified;
        
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
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(deleteCourseEntryDto))]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteCourseEntry", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    internal partial class deleteCourseEntry {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deleteCourseEntry", Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dome.R824.deleteCourseEntryDto deleteCourseEntry1;
        
        public deleteCourseEntry() {
        }
        
        public deleteCourseEntry(Dome.R824.deleteCourseEntryDto deleteCourseEntry1) {
            this.deleteCourseEntry1 = deleteCourseEntry1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteCourseEntryResponse", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    internal partial class deleteCourseEntryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dome.R824.domeResponseDto deleteCourseEntry;
        
        public deleteCourseEntryResponse() {
        }
        
        public deleteCourseEntryResponse(Dome.R824.domeResponseDto deleteCourseEntry) {
            this.deleteCourseEntry = deleteCourseEntry;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface DOME_BUS_EAI_R824deleteJourneyEntryWSChannel : Dome.R824.DOME_BUS_EAI_R824deleteJourneyEntryWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class DOME_BUS_EAI_R824deleteJourneyEntryWSClient : System.ServiceModel.ClientBase<Dome.R824.DOME_BUS_EAI_R824deleteJourneyEntryWS>, Dome.R824.DOME_BUS_EAI_R824deleteJourneyEntryWS {
        
        public DOME_BUS_EAI_R824deleteJourneyEntryWSClient() {
        }
        
        public DOME_BUS_EAI_R824deleteJourneyEntryWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DOME_BUS_EAI_R824deleteJourneyEntryWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R824deleteJourneyEntryWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R824deleteJourneyEntryWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dome.R824.deleteCourseEntryResponse Dome.R824.DOME_BUS_EAI_R824deleteJourneyEntryWS.deleteCourseEntry(Dome.R824.deleteCourseEntry request) {
            return base.Channel.deleteCourseEntry(request);
        }
        
        public Dome.R824.domeResponseDto deleteCourseEntry(Dome.R824.deleteCourseEntryDto deleteCourseEntry1) {
            Dome.R824.deleteCourseEntry inValue = new Dome.R824.deleteCourseEntry();
            inValue.deleteCourseEntry1 = deleteCourseEntry1;
            Dome.R824.deleteCourseEntryResponse retVal = ((Dome.R824.DOME_BUS_EAI_R824deleteJourneyEntryWS)(this)).deleteCourseEntry(inValue);
            return retVal.deleteCourseEntry;
        }
    }
}
