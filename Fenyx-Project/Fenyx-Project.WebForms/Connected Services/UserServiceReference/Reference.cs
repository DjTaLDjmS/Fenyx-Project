﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fenyx_Project.WebForms.UserServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserListItemContract", Namespace="http://schemas.datacontract.org/2004/07/Fenyx_Project.WebService.Contracts")]
    [System.SerializableAttribute()]
    public partial class UserListItemContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhotoUrlField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Birthdate {
            get {
                return this.BirthdateField;
            }
            set {
                if ((this.BirthdateField.Equals(value) != true)) {
                    this.BirthdateField = value;
                    this.RaisePropertyChanged("Birthdate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhotoUrl {
            get {
                return this.PhotoUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoUrlField, value) != true)) {
                    this.PhotoUrlField = value;
                    this.RaisePropertyChanged("PhotoUrl");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserContract", Namespace="http://schemas.datacontract.org/2004/07/Fenyx_Project.WebService.Contracts")]
    [System.SerializableAttribute()]
    public partial class UserContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressStreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AddressZipcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhotoUrlField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressCity {
            get {
                return this.AddressCityField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressCityField, value) != true)) {
                    this.AddressCityField = value;
                    this.RaisePropertyChanged("AddressCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressStreet {
            get {
                return this.AddressStreetField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressStreetField, value) != true)) {
                    this.AddressStreetField = value;
                    this.RaisePropertyChanged("AddressStreet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AddressZipcode {
            get {
                return this.AddressZipcodeField;
            }
            set {
                if ((this.AddressZipcodeField.Equals(value) != true)) {
                    this.AddressZipcodeField = value;
                    this.RaisePropertyChanged("AddressZipcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Birthdate {
            get {
                return this.BirthdateField;
            }
            set {
                if ((this.BirthdateField.Equals(value) != true)) {
                    this.BirthdateField = value;
                    this.RaisePropertyChanged("Birthdate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhotoUrl {
            get {
                return this.PhotoUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoUrlField, value) != true)) {
                    this.PhotoUrlField = value;
                    this.RaisePropertyChanged("PhotoUrl");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindAllUsers", ReplyAction="http://tempuri.org/IUserService/FindAllUsersResponse")]
        Fenyx_Project.WebForms.UserServiceReference.UserListItemContract[] FindAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindAllUsers", ReplyAction="http://tempuri.org/IUserService/FindAllUsersResponse")]
        System.Threading.Tasks.Task<Fenyx_Project.WebForms.UserServiceReference.UserListItemContract[]> FindAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindUser", ReplyAction="http://tempuri.org/IUserService/FindUserResponse")]
        Fenyx_Project.WebForms.UserServiceReference.UserContract FindUser(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindUser", ReplyAction="http://tempuri.org/IUserService/FindUserResponse")]
        System.Threading.Tasks.Task<Fenyx_Project.WebForms.UserServiceReference.UserContract> FindUserAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddUser", ReplyAction="http://tempuri.org/IUserService/AddUserResponse")]
        Fenyx_Project.WebForms.UserServiceReference.UserContract AddUser(Fenyx_Project.WebForms.UserServiceReference.UserContract p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddUser", ReplyAction="http://tempuri.org/IUserService/AddUserResponse")]
        System.Threading.Tasks.Task<Fenyx_Project.WebForms.UserServiceReference.UserContract> AddUserAsync(Fenyx_Project.WebForms.UserServiceReference.UserContract p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/UpdateUser", ReplyAction="http://tempuri.org/IUserService/UpdateUserResponse")]
        Fenyx_Project.WebForms.UserServiceReference.UserContract UpdateUser(Fenyx_Project.WebForms.UserServiceReference.UserContract p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/UpdateUser", ReplyAction="http://tempuri.org/IUserService/UpdateUserResponse")]
        System.Threading.Tasks.Task<Fenyx_Project.WebForms.UserServiceReference.UserContract> UpdateUserAsync(Fenyx_Project.WebForms.UserServiceReference.UserContract p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        void DeleteUser(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(System.Guid id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : Fenyx_Project.WebForms.UserServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<Fenyx_Project.WebForms.UserServiceReference.IUserService>, Fenyx_Project.WebForms.UserServiceReference.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Fenyx_Project.WebForms.UserServiceReference.UserListItemContract[] FindAllUsers() {
            return base.Channel.FindAllUsers();
        }
        
        public System.Threading.Tasks.Task<Fenyx_Project.WebForms.UserServiceReference.UserListItemContract[]> FindAllUsersAsync() {
            return base.Channel.FindAllUsersAsync();
        }
        
        public Fenyx_Project.WebForms.UserServiceReference.UserContract FindUser(System.Guid id) {
            return base.Channel.FindUser(id);
        }
        
        public System.Threading.Tasks.Task<Fenyx_Project.WebForms.UserServiceReference.UserContract> FindUserAsync(System.Guid id) {
            return base.Channel.FindUserAsync(id);
        }
        
        public Fenyx_Project.WebForms.UserServiceReference.UserContract AddUser(Fenyx_Project.WebForms.UserServiceReference.UserContract p) {
            return base.Channel.AddUser(p);
        }
        
        public System.Threading.Tasks.Task<Fenyx_Project.WebForms.UserServiceReference.UserContract> AddUserAsync(Fenyx_Project.WebForms.UserServiceReference.UserContract p) {
            return base.Channel.AddUserAsync(p);
        }
        
        public Fenyx_Project.WebForms.UserServiceReference.UserContract UpdateUser(Fenyx_Project.WebForms.UserServiceReference.UserContract p) {
            return base.Channel.UpdateUser(p);
        }
        
        public System.Threading.Tasks.Task<Fenyx_Project.WebForms.UserServiceReference.UserContract> UpdateUserAsync(Fenyx_Project.WebForms.UserServiceReference.UserContract p) {
            return base.Channel.UpdateUserAsync(p);
        }
        
        public void DeleteUser(System.Guid id) {
            base.Channel.DeleteUser(id);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(System.Guid id) {
            return base.Channel.DeleteUserAsync(id);
        }
    }
}
