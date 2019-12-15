﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientToService.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuctionModel", Namespace="http://schemas.datacontract.org/2004/07/DataLibrary1.Models")]
    [System.SerializableAttribute()]
    public partial class AuctionModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal CurrentPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CurrentWinnerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MaxPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public decimal Bid {
            get {
                return this.BidField;
            }
            set {
                if ((this.BidField.Equals(value) != true)) {
                    this.BidField = value;
                    this.RaisePropertyChanged("Bid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal CurrentPrice {
            get {
                return this.CurrentPriceField;
            }
            set {
                if ((this.CurrentPriceField.Equals(value) != true)) {
                    this.CurrentPriceField = value;
                    this.RaisePropertyChanged("CurrentPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CurrentWinner {
            get {
                return this.CurrentWinnerField;
            }
            set {
                if ((object.ReferenceEquals(this.CurrentWinnerField, value) != true)) {
                    this.CurrentWinnerField = value;
                    this.RaisePropertyChanged("CurrentWinner");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((this.EndDateField.Equals(value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
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
        public decimal MaxPrice {
            get {
                return this.MaxPriceField;
            }
            set {
                if ((this.MaxPriceField.Equals(value) != true)) {
                    this.MaxPriceField = value;
                    this.RaisePropertyChanged("MaxPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadAuctions", ReplyAction="http://tempuri.org/IService1/LoadAuctionsResponse")]
        ClientToService.ServiceReference1.AuctionModel[] LoadAuctions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadAuctions", ReplyAction="http://tempuri.org/IService1/LoadAuctionsResponse")]
        System.Threading.Tasks.Task<ClientToService.ServiceReference1.AuctionModel[]> LoadAuctionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateAuction", ReplyAction="http://tempuri.org/IService1/CreateAuctionResponse")]
        void CreateAuction(decimal bid, int status, decimal currentPrice, decimal maxPrice, System.DateTime endDate, string title, string description, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateAuction", ReplyAction="http://tempuri.org/IService1/CreateAuctionResponse")]
        System.Threading.Tasks.Task CreateAuctionAsync(decimal bid, int status, decimal currentPrice, decimal maxPrice, System.DateTime endDate, string title, string description, string category);




        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/EditAuction", ReplyAction = "http://tempuri.org/IService1/EditAuctionResponse")]
        void EditAuction(int id, decimal bid, int status, decimal currentPrice, decimal maxPrice, System.DateTime endDate, string title, string description, string category);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/EditAuction", ReplyAction = "http://tempuri.org/IService1/EditAuctionResponse")]
        System.Threading.Tasks.Task EditAuctionAsync(int id, decimal bid, int status, decimal currentPrice, decimal maxPrice, System.DateTime endDate, string title, string description, string category);





        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/DeleteAuction", ReplyAction = "http://tempuri.org/IService1/DeleteAuctionResponse")]
        void DeleteAuction(int Id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/DeleteAuction", ReplyAction = "http://tempuri.org/IService1/DeleteAuctionResponse")]
        System.Threading.Tasks.Task DeleteAuctionAsync(int Id);


        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BidOnAuction", ReplyAction="http://tempuri.org/IService1/BidOnAuctionResponse")]
        void BidOnAuction(decimal bid, decimal currentPrice, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BidOnAuction", ReplyAction="http://tempuri.org/IService1/BidOnAuctionResponse")]
        System.Threading.Tasks.Task BidOnAuctionAsync(decimal bid, decimal currentPrice, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuyoutAuction", ReplyAction="http://tempuri.org/IService1/BuyoutAuctionResponse")]
        void BuyoutAuction(int id, decimal maxPrice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuyoutAuction", ReplyAction="http://tempuri.org/IService1/BuyoutAuctionResponse")]
        System.Threading.Tasks.Task BuyoutAuctionAsync(int id, decimal maxPrice);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientToService.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientToService.ServiceReference1.IService1>, ClientToService.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientToService.ServiceReference1.AuctionModel[] LoadAuctions() {
            return base.Channel.LoadAuctions();
        }
        
        public System.Threading.Tasks.Task<ClientToService.ServiceReference1.AuctionModel[]> LoadAuctionsAsync() {
            return base.Channel.LoadAuctionsAsync();
        }
        
        public void CreateAuction(decimal bid, int status, decimal currentPrice, decimal maxPrice, System.DateTime endDate, string title, string description, string category) {
            base.Channel.CreateAuction(bid, status, currentPrice, maxPrice, endDate, title, description, category);
        }
        
        public System.Threading.Tasks.Task CreateAuctionAsync(decimal bid, int status, decimal currentPrice, decimal maxPrice, System.DateTime endDate, string title, string description, string category) {
            return base.Channel.CreateAuctionAsync(bid, status, currentPrice, maxPrice, endDate, title, description, category);
        }


        public void EditAuction(int id, decimal bid, int status, decimal currentPrice, decimal maxPrice, System.DateTime endDate, string title, string description, string category)
        {
            base.Channel.EditAuction(id, bid, status, currentPrice, maxPrice, endDate, title, description, category);
        }

        public System.Threading.Tasks.Task EditAuctionAsync(int id, decimal bid, int status, decimal currentPrice, decimal maxPrice, System.DateTime endDate, string title, string description, string category)
        {
            return base.Channel.EditAuctionAsync(id, bid, status, currentPrice, maxPrice, endDate, title, description, category);
        }

        public void DeleteAuction(int Id)
        {
            base.Channel.DeleteAuction(Id);
        }

        public System.Threading.Tasks.Task DeleteAuctionAsync(int Id)
        {
            return base.Channel.DeleteAuctionAsync(Id);
        }



        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public void BidOnAuction(decimal bid, decimal currentPrice, int id) {
            base.Channel.BidOnAuction(bid, currentPrice, id);
        }
        
        public System.Threading.Tasks.Task BidOnAuctionAsync(decimal bid, decimal currentPrice, int id) {
            return base.Channel.BidOnAuctionAsync(bid, currentPrice, id);
        }
        
        public void BuyoutAuction(int id, decimal maxPrice) {
            base.Channel.BuyoutAuction(id, maxPrice);
        }
        
        public System.Threading.Tasks.Task BuyoutAuctionAsync(int id, decimal maxPrice) {
            return base.Channel.BuyoutAuctionAsync(id, maxPrice);
        }
    }
}
