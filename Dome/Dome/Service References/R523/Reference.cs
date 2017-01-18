﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dome.R523 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.partner.dome.fr/", ConfigurationName="R523.DOME_BUS_EAI_R523benefSubscriptionWS")]
    public interface DOME_BUS_EAI_R523benefSubscriptionWS {
        
        // CODEGEN: Parameter 'subscriptionStructureResponse' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeResponseDto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeCommonDto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeDto))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="subscriptionStructureResponse")]
        Dome.R523.subscriptionPersonStructureResponse subscriptionPersonStructure(Dome.R523.subscriptionPersonStructure request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Dome.R523.subscriptionPersonStructureResponse> subscriptionPersonStructureAsync(Dome.R523.subscriptionPersonStructure request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class subscriptionStructureDto : domeDto {
        
        private int profileBenefIdField;
        
        private bool profileBenefIdFieldSpecified;
        
        private int profileStructureIdField;
        
        private bool profileStructureIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int profileBenefId {
            get {
                return this.profileBenefIdField;
            }
            set {
                this.profileBenefIdField = value;
                this.RaisePropertyChanged("profileBenefId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool profileBenefIdSpecified {
            get {
                return this.profileBenefIdFieldSpecified;
            }
            set {
                this.profileBenefIdFieldSpecified = value;
                this.RaisePropertyChanged("profileBenefIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int profileStructureId {
            get {
                return this.profileStructureIdField;
            }
            set {
                this.profileStructureIdField = value;
                this.RaisePropertyChanged("profileStructureId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool profileStructureIdSpecified {
            get {
                return this.profileStructureIdFieldSpecified;
            }
            set {
                this.profileStructureIdFieldSpecified = value;
                this.RaisePropertyChanged("profileStructureIdSpecified");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(subscriptionStructureDto))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(subscriptionStructureResponseDto))]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class subscriptionStructureResponseDto : domeResponseDto {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="subscriptionPersonStructure", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    public partial class subscriptionPersonStructure {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dome.R523.subscriptionStructureDto subscriptionStructureDto;
        
        public subscriptionPersonStructure() {
        }
        
        public subscriptionPersonStructure(Dome.R523.subscriptionStructureDto subscriptionStructureDto) {
            this.subscriptionStructureDto = subscriptionStructureDto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="subscriptionPersonStructureResponse", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    public partial class subscriptionPersonStructureResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dome.R523.subscriptionStructureResponseDto subscriptionStructureResponse;
        
        public subscriptionPersonStructureResponse() {
        }
        
        public subscriptionPersonStructureResponse(Dome.R523.subscriptionStructureResponseDto subscriptionStructureResponse) {
            this.subscriptionStructureResponse = subscriptionStructureResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DOME_BUS_EAI_R523benefSubscriptionWSChannel : Dome.R523.DOME_BUS_EAI_R523benefSubscriptionWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DOME_BUS_EAI_R523benefSubscriptionWSClient : System.ServiceModel.ClientBase<Dome.R523.DOME_BUS_EAI_R523benefSubscriptionWS>, Dome.R523.DOME_BUS_EAI_R523benefSubscriptionWS {
        
        public DOME_BUS_EAI_R523benefSubscriptionWSClient() {
        }
        
        public DOME_BUS_EAI_R523benefSubscriptionWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DOME_BUS_EAI_R523benefSubscriptionWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R523benefSubscriptionWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R523benefSubscriptionWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dome.R523.subscriptionPersonStructureResponse Dome.R523.DOME_BUS_EAI_R523benefSubscriptionWS.subscriptionPersonStructure(Dome.R523.subscriptionPersonStructure request) {
            return base.Channel.subscriptionPersonStructure(request);
        }
        
        public Dome.R523.subscriptionStructureResponseDto subscriptionPersonStructure(Dome.R523.subscriptionStructureDto subscriptionStructureDto) {
            Dome.R523.subscriptionPersonStructure inValue = new Dome.R523.subscriptionPersonStructure();
            inValue.subscriptionStructureDto = subscriptionStructureDto;
            Dome.R523.subscriptionPersonStructureResponse retVal = ((Dome.R523.DOME_BUS_EAI_R523benefSubscriptionWS)(this)).subscriptionPersonStructure(inValue);
            return retVal.subscriptionStructureResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Dome.R523.subscriptionPersonStructureResponse> Dome.R523.DOME_BUS_EAI_R523benefSubscriptionWS.subscriptionPersonStructureAsync(Dome.R523.subscriptionPersonStructure request) {
            return base.Channel.subscriptionPersonStructureAsync(request);
        }
        
        public System.Threading.Tasks.Task<Dome.R523.subscriptionPersonStructureResponse> subscriptionPersonStructureAsync(Dome.R523.subscriptionStructureDto subscriptionStructureDto) {
            Dome.R523.subscriptionPersonStructure inValue = new Dome.R523.subscriptionPersonStructure();
            inValue.subscriptionStructureDto = subscriptionStructureDto;
            return ((Dome.R523.DOME_BUS_EAI_R523benefSubscriptionWS)(this)).subscriptionPersonStructureAsync(inValue);
        }
    }
}