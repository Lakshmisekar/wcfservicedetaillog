﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class Student : object
    {
        
        private System.DateTime DateOfBirthField;
        
        private ServiceReference1.StudentGroup GroupField;
        
        private bool IsMaleField;
        
        private string NameField;
        
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth
        {
            get
            {
                return this.DateOfBirthField;
            }
            set
            {
                this.DateOfBirthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.StudentGroup Group
        {
            get
            {
                return this.GroupField;
            }
            set
            {
                this.GroupField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsMale
        {
            get
            {
                return this.IsMaleField;
            }
            set
            {
                this.IsMaleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumberField;
            }
            set
            {
                this.PhoneNumberField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudentGroup", Namespace="http://schemas.datacontract.org/2004/07/")]
    public enum StudentGroup : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Maths = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Science = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Commerce = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IStudentService")]
    public interface IStudentService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/RegisterStudent", ReplyAction="http://tempuri.org/IStudentService/RegisterStudentResponse")]
        System.Threading.Tasks.Task RegisterStudentAsync(ServiceReference1.Student student);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IStudentServiceChannel : ServiceReference1.IStudentService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class StudentServiceClient : System.ServiceModel.ClientBase<ServiceReference1.IStudentService>, ServiceReference1.IStudentService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public StudentServiceClient() : 
                base(StudentServiceClient.GetDefaultBinding(), StudentServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IStudentService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StudentServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(StudentServiceClient.GetBindingForEndpoint(endpointConfiguration), StudentServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StudentServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(StudentServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StudentServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(StudentServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StudentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task RegisterStudentAsync(ServiceReference1.Student student)
        {
            return base.Channel.RegisterStudentAsync(student);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IStudentService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IStudentService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:50635/Service.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return StudentServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IStudentService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return StudentServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IStudentService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IStudentService,
        }
    }
}
