﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dome.Service_References.R543b {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.partner.dome.fr/", ConfigurationName="R543b.DOME_BUS_EAI_R543bSwitchReferentWS")]
    public interface DOME_BUS_EAI_R543bSwitchReferentWS {
        
        // CODEGEN: Parameter 'domeResponse' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeCommonDto))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(domeDto))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="domeResponse")]
        updatereferentResponse updatereferent(updatereferent request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<updatereferentResponse> updatereferentAsync(updatereferent request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.partner.dome.fr/")]
    public partial class updateReferentDto : domeDto {
        
        private int benefProfileIdField;
        
        private bool benefProfileIdFieldSpecified;
        
        private int newReferentProfileIdField;
        
        private bool newReferentProfileIdFieldSpecified;
        
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
        public int newReferentProfileId {
            get {
                return this.newReferentProfileIdField;
            }
            set {
                this.newReferentProfileIdField = value;
                this.RaisePropertyChanged("newReferentProfileId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newReferentProfileIdSpecified {
            get {
                return this.newReferentProfileIdFieldSpecified;
            }
            set {
                this.newReferentProfileIdFieldSpecified = value;
                this.RaisePropertyChanged("newReferentProfileIdSpecified");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(updateReferentDto))]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updatereferent", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    public partial class updatereferent {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public updateReferentDto updateReferentDto;
        
        public updatereferent() {
        }
        
        public updatereferent(updateReferentDto updateReferentDto) {
            this.updateReferentDto = updateReferentDto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updatereferentResponse", WrapperNamespace="http://webservices.partner.dome.fr/", IsWrapped=true)]
    public partial class updatereferentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.partner.dome.fr/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public domeResponseDto domeResponse;
        
        public updatereferentResponse() {
        }
        
        public updatereferentResponse(domeResponseDto domeResponse) {
            this.domeResponse = domeResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DOME_BUS_EAI_R543bSwitchReferentWSChannel : DOME_BUS_EAI_R543bSwitchReferentWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DOME_BUS_EAI_R543bSwitchReferentWSClient : System.ServiceModel.ClientBase<DOME_BUS_EAI_R543bSwitchReferentWS>, DOME_BUS_EAI_R543bSwitchReferentWS {
        
        public DOME_BUS_EAI_R543bSwitchReferentWSClient() {
        }
        
        public DOME_BUS_EAI_R543bSwitchReferentWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DOME_BUS_EAI_R543bSwitchReferentWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R543bSwitchReferentWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DOME_BUS_EAI_R543bSwitchReferentWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        updatereferentResponse DOME_BUS_EAI_R543bSwitchReferentWS.updatereferent(updatereferent request) {
            return base.Channel.updatereferent(request);
        }
        
        public domeResponseDto updatereferent(updateReferentDto updateReferentDto) {
            updatereferent inValue = new updatereferent();
            inValue.updateReferentDto = updateReferentDto;
            updatereferentResponse retVal = ((DOME_BUS_EAI_R543bSwitchReferentWS)(this)).updatereferent(inValue);
            return retVal.domeResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<updatereferentResponse> DOME_BUS_EAI_R543bSwitchReferentWS.updatereferentAsync(updatereferent request) {
            return base.Channel.updatereferentAsync(request);
        }
        
        public System.Threading.Tasks.Task<updatereferentResponse> updatereferentAsync(updateReferentDto updateReferentDto) {
            updatereferent inValue = new updatereferent();
            inValue.updateReferentDto = updateReferentDto;
            return ((DOME_BUS_EAI_R543bSwitchReferentWS)(this)).updatereferentAsync(inValue);
        }
    }
}
