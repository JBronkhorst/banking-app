﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterfaceDesktop.AuthenticationServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthenticationServiceReference.AuthServiceSoap")]
    public interface AuthServiceSoap {
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthenticateUserByPassword", ReplyAction="*")]
        InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordResponse AuthenticateUserByPassword(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthenticateUserByPassword", ReplyAction="*")]
        System.Threading.Tasks.Task<InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordResponse> AuthenticateUserByPasswordAsync(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequest request);
        
        // CODEGEN: Generating message contract since element name pin from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthenticateUserByPin", ReplyAction="*")]
        InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinResponse AuthenticateUserByPin(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthenticateUserByPin", ReplyAction="*")]
        System.Threading.Tasks.Task<InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinResponse> AuthenticateUserByPinAsync(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateUserByPasswordRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateUserByPassword", Namespace="http://tempuri.org/", Order=0)]
        public InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequestBody Body;
        
        public AuthenticateUserByPasswordRequest() {
        }
        
        public AuthenticateUserByPasswordRequest(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateUserByPasswordRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public AuthenticateUserByPasswordRequestBody() {
        }
        
        public AuthenticateUserByPasswordRequestBody(string email, string password) {
            this.email = email;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateUserByPasswordResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateUserByPasswordResponse", Namespace="http://tempuri.org/", Order=0)]
        public InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordResponseBody Body;
        
        public AuthenticateUserByPasswordResponse() {
        }
        
        public AuthenticateUserByPasswordResponse(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateUserByPasswordResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AuthenticateUserByPasswordResult;
        
        public AuthenticateUserByPasswordResponseBody() {
        }
        
        public AuthenticateUserByPasswordResponseBody(int AuthenticateUserByPasswordResult) {
            this.AuthenticateUserByPasswordResult = AuthenticateUserByPasswordResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateUserByPinRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateUserByPin", Namespace="http://tempuri.org/", Order=0)]
        public InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequestBody Body;
        
        public AuthenticateUserByPinRequest() {
        }
        
        public AuthenticateUserByPinRequest(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateUserByPinRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int customerID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pin;
        
        public AuthenticateUserByPinRequestBody() {
        }
        
        public AuthenticateUserByPinRequestBody(int customerID, string pin) {
            this.customerID = customerID;
            this.pin = pin;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateUserByPinResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateUserByPinResponse", Namespace="http://tempuri.org/", Order=0)]
        public InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinResponseBody Body;
        
        public AuthenticateUserByPinResponse() {
        }
        
        public AuthenticateUserByPinResponse(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateUserByPinResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AuthenticateUserByPinResult;
        
        public AuthenticateUserByPinResponseBody() {
        }
        
        public AuthenticateUserByPinResponseBody(int AuthenticateUserByPinResult) {
            this.AuthenticateUserByPinResult = AuthenticateUserByPinResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthServiceSoapChannel : InterfaceDesktop.AuthenticationServiceReference.AuthServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServiceSoapClient : System.ServiceModel.ClientBase<InterfaceDesktop.AuthenticationServiceReference.AuthServiceSoap>, InterfaceDesktop.AuthenticationServiceReference.AuthServiceSoap {
        
        public AuthServiceSoapClient() {
        }
        
        public AuthServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordResponse InterfaceDesktop.AuthenticationServiceReference.AuthServiceSoap.AuthenticateUserByPassword(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequest request) {
            return base.Channel.AuthenticateUserByPassword(request);
        }
        
        public int AuthenticateUserByPassword(string email, string password) {
            InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequest inValue = new InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequest();
            inValue.Body = new InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordResponse retVal = ((InterfaceDesktop.AuthenticationServiceReference.AuthServiceSoap)(this)).AuthenticateUserByPassword(inValue);
            return retVal.Body.AuthenticateUserByPasswordResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordResponse> InterfaceDesktop.AuthenticationServiceReference.AuthServiceSoap.AuthenticateUserByPasswordAsync(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequest request) {
            return base.Channel.AuthenticateUserByPasswordAsync(request);
        }
        
        public System.Threading.Tasks.Task<InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordResponse> AuthenticateUserByPasswordAsync(string email, string password) {
            InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequest inValue = new InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequest();
            inValue.Body = new InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPasswordRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            return ((InterfaceDesktop.AuthenticationServiceReference.AuthServiceSoap)(this)).AuthenticateUserByPasswordAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinResponse InterfaceDesktop.AuthenticationServiceReference.AuthServiceSoap.AuthenticateUserByPin(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequest request) {
            return base.Channel.AuthenticateUserByPin(request);
        }
        
        public int AuthenticateUserByPin(int customerID, string pin) {
            InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequest inValue = new InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequest();
            inValue.Body = new InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequestBody();
            inValue.Body.customerID = customerID;
            inValue.Body.pin = pin;
            InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinResponse retVal = ((InterfaceDesktop.AuthenticationServiceReference.AuthServiceSoap)(this)).AuthenticateUserByPin(inValue);
            return retVal.Body.AuthenticateUserByPinResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinResponse> InterfaceDesktop.AuthenticationServiceReference.AuthServiceSoap.AuthenticateUserByPinAsync(InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequest request) {
            return base.Channel.AuthenticateUserByPinAsync(request);
        }
        
        public System.Threading.Tasks.Task<InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinResponse> AuthenticateUserByPinAsync(int customerID, string pin) {
            InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequest inValue = new InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequest();
            inValue.Body = new InterfaceDesktop.AuthenticationServiceReference.AuthenticateUserByPinRequestBody();
            inValue.Body.customerID = customerID;
            inValue.Body.pin = pin;
            return ((InterfaceDesktop.AuthenticationServiceReference.AuthServiceSoap)(this)).AuthenticateUserByPinAsync(inValue);
        }
    }
}
