﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M4.SumariosService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SumariosService.SumariosSoap")]
    public interface SumariosSoap {
        
        // CODEGEN: Generating message contract since element name identificacao from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistrosSumario", ReplyAction="*")]
        M4.SumariosService.RegistrosSumarioResponse RegistrosSumario(M4.SumariosService.RegistrosSumarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrosSumarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrosSumario", Namespace="http://tempuri.org/", Order=0)]
        public M4.SumariosService.RegistrosSumarioRequestBody Body;
        
        public RegistrosSumarioRequest() {
        }
        
        public RegistrosSumarioRequest(M4.SumariosService.RegistrosSumarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistrosSumarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string identificacao;
        
        public RegistrosSumarioRequestBody() {
        }
        
        public RegistrosSumarioRequestBody(string identificacao) {
            this.identificacao = identificacao;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistrosSumarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistrosSumarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public M4.SumariosService.RegistrosSumarioResponseBody Body;
        
        public RegistrosSumarioResponse() {
        }
        
        public RegistrosSumarioResponse(M4.SumariosService.RegistrosSumarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistrosSumarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement RegistrosSumarioResult;
        
        public RegistrosSumarioResponseBody() {
        }
        
        public RegistrosSumarioResponseBody(System.Xml.Linq.XElement RegistrosSumarioResult) {
            this.RegistrosSumarioResult = RegistrosSumarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SumariosSoapChannel : M4.SumariosService.SumariosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SumariosSoapClient : System.ServiceModel.ClientBase<M4.SumariosService.SumariosSoap>, M4.SumariosService.SumariosSoap {
        
        public SumariosSoapClient() {
        }
        
        public SumariosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SumariosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SumariosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SumariosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        M4.SumariosService.RegistrosSumarioResponse M4.SumariosService.SumariosSoap.RegistrosSumario(M4.SumariosService.RegistrosSumarioRequest request) {
            return base.Channel.RegistrosSumario(request);
        }
        
        public System.Xml.Linq.XElement RegistrosSumario(string identificacao) {
            M4.SumariosService.RegistrosSumarioRequest inValue = new M4.SumariosService.RegistrosSumarioRequest();
            inValue.Body = new M4.SumariosService.RegistrosSumarioRequestBody();
            inValue.Body.identificacao = identificacao;
            M4.SumariosService.RegistrosSumarioResponse retVal = ((M4.SumariosService.SumariosSoap)(this)).RegistrosSumario(inValue);
            return retVal.Body.RegistrosSumarioResult;
        }
    }
}
