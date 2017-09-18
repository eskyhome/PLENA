﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M4.SymbolService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SymbolService.SymbolSoap")]
    public interface SymbolSoap {
        
        // CODEGEN: Generating message contract since element name identificacao from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistroAtivos", ReplyAction="*")]
        M4.SymbolService.RegistroAtivosResponse RegistroAtivos(M4.SymbolService.RegistroAtivosRequest request);
        
        // CODEGEN: Generating message contract since element name identificacao from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TodosRegistros", ReplyAction="*")]
        M4.SymbolService.TodosRegistrosResponse TodosRegistros(M4.SymbolService.TodosRegistrosRequest request);
        
        // CODEGEN: Generating message contract since element name identificacao from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllSymbolCript", ReplyAction="*")]
        M4.SymbolService.GetAllSymbolCriptResponse GetAllSymbolCript(M4.SymbolService.GetAllSymbolCriptRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistroAtivosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistroAtivos", Namespace="http://tempuri.org/", Order=0)]
        public M4.SymbolService.RegistroAtivosRequestBody Body;
        
        public RegistroAtivosRequest() {
        }
        
        public RegistroAtivosRequest(M4.SymbolService.RegistroAtivosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistroAtivosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string identificacao;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string crc;
        
        public RegistroAtivosRequestBody() {
        }
        
        public RegistroAtivosRequestBody(string identificacao, string crc) {
            this.identificacao = identificacao;
            this.crc = crc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistroAtivosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistroAtivosResponse", Namespace="http://tempuri.org/", Order=0)]
        public M4.SymbolService.RegistroAtivosResponseBody Body;
        
        public RegistroAtivosResponse() {
        }
        
        public RegistroAtivosResponse(M4.SymbolService.RegistroAtivosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistroAtivosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement RegistroAtivosResult;
        
        public RegistroAtivosResponseBody() {
        }
        
        public RegistroAtivosResponseBody(System.Xml.Linq.XElement RegistroAtivosResult) {
            this.RegistroAtivosResult = RegistroAtivosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TodosRegistrosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TodosRegistros", Namespace="http://tempuri.org/", Order=0)]
        public M4.SymbolService.TodosRegistrosRequestBody Body;
        
        public TodosRegistrosRequest() {
        }
        
        public TodosRegistrosRequest(M4.SymbolService.TodosRegistrosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TodosRegistrosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string identificacao;
        
        public TodosRegistrosRequestBody() {
        }
        
        public TodosRegistrosRequestBody(string identificacao) {
            this.identificacao = identificacao;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TodosRegistrosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TodosRegistrosResponse", Namespace="http://tempuri.org/", Order=0)]
        public M4.SymbolService.TodosRegistrosResponseBody Body;
        
        public TodosRegistrosResponse() {
        }
        
        public TodosRegistrosResponse(M4.SymbolService.TodosRegistrosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TodosRegistrosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement TodosRegistrosResult;
        
        public TodosRegistrosResponseBody() {
        }
        
        public TodosRegistrosResponseBody(System.Xml.Linq.XElement TodosRegistrosResult) {
            this.TodosRegistrosResult = TodosRegistrosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllSymbolCriptRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllSymbolCript", Namespace="http://tempuri.org/", Order=0)]
        public M4.SymbolService.GetAllSymbolCriptRequestBody Body;
        
        public GetAllSymbolCriptRequest() {
        }
        
        public GetAllSymbolCriptRequest(M4.SymbolService.GetAllSymbolCriptRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllSymbolCriptRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string identificacao;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string crc;
        
        public GetAllSymbolCriptRequestBody() {
        }
        
        public GetAllSymbolCriptRequestBody(string identificacao, string crc) {
            this.identificacao = identificacao;
            this.crc = crc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllSymbolCriptResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllSymbolCriptResponse", Namespace="http://tempuri.org/", Order=0)]
        public M4.SymbolService.GetAllSymbolCriptResponseBody Body;
        
        public GetAllSymbolCriptResponse() {
        }
        
        public GetAllSymbolCriptResponse(M4.SymbolService.GetAllSymbolCriptResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllSymbolCriptResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetAllSymbolCriptResult;
        
        public GetAllSymbolCriptResponseBody() {
        }
        
        public GetAllSymbolCriptResponseBody(string GetAllSymbolCriptResult) {
            this.GetAllSymbolCriptResult = GetAllSymbolCriptResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SymbolSoapChannel : M4.SymbolService.SymbolSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SymbolSoapClient : System.ServiceModel.ClientBase<M4.SymbolService.SymbolSoap>, M4.SymbolService.SymbolSoap {
        
        public SymbolSoapClient() {
        }
        
        public SymbolSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SymbolSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SymbolSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SymbolSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        M4.SymbolService.RegistroAtivosResponse M4.SymbolService.SymbolSoap.RegistroAtivos(M4.SymbolService.RegistroAtivosRequest request) {
            return base.Channel.RegistroAtivos(request);
        }
        
        public System.Xml.Linq.XElement RegistroAtivos(string identificacao, string crc) {
            M4.SymbolService.RegistroAtivosRequest inValue = new M4.SymbolService.RegistroAtivosRequest();
            inValue.Body = new M4.SymbolService.RegistroAtivosRequestBody();
            inValue.Body.identificacao = identificacao;
            inValue.Body.crc = crc;
            M4.SymbolService.RegistroAtivosResponse retVal = ((M4.SymbolService.SymbolSoap)(this)).RegistroAtivos(inValue);
            return retVal.Body.RegistroAtivosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        M4.SymbolService.TodosRegistrosResponse M4.SymbolService.SymbolSoap.TodosRegistros(M4.SymbolService.TodosRegistrosRequest request) {
            return base.Channel.TodosRegistros(request);
        }
        
        public System.Xml.Linq.XElement TodosRegistros(string identificacao) {
            M4.SymbolService.TodosRegistrosRequest inValue = new M4.SymbolService.TodosRegistrosRequest();
            inValue.Body = new M4.SymbolService.TodosRegistrosRequestBody();
            inValue.Body.identificacao = identificacao;
            M4.SymbolService.TodosRegistrosResponse retVal = ((M4.SymbolService.SymbolSoap)(this)).TodosRegistros(inValue);
            return retVal.Body.TodosRegistrosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        M4.SymbolService.GetAllSymbolCriptResponse M4.SymbolService.SymbolSoap.GetAllSymbolCript(M4.SymbolService.GetAllSymbolCriptRequest request) {
            return base.Channel.GetAllSymbolCript(request);
        }
        
        public string GetAllSymbolCript(string identificacao, string crc) {
            M4.SymbolService.GetAllSymbolCriptRequest inValue = new M4.SymbolService.GetAllSymbolCriptRequest();
            inValue.Body = new M4.SymbolService.GetAllSymbolCriptRequestBody();
            inValue.Body.identificacao = identificacao;
            inValue.Body.crc = crc;
            M4.SymbolService.GetAllSymbolCriptResponse retVal = ((M4.SymbolService.SymbolSoap)(this)).GetAllSymbolCript(inValue);
            return retVal.Body.GetAllSymbolCriptResult;
        }
    }
}