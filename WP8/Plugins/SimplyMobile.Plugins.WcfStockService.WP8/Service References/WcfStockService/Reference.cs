﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace SimplyMobile.Plugins.WcfStockService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StockQuote", Namespace="http://www.restfulwebservices.net/DataContracts/2008/01")]
    public partial class StockQuote : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string SymbolField;
        
        private string LastField;
        
        private string DateField;
        
        private string TimeField;
        
        private string ChangeField;
        
        private string OpenField;
        
        private string HighField;
        
        private string LowField;
        
        private string VolumeField;
        
        private string MktCapField;
        
        private string PreviousCloseField;
        
        private string PercentageChangeField;
        
        private string AnnRangeField;
        
        private string EarnsField;
        
        private string PEField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Symbol {
            get {
                return this.SymbolField;
            }
            set {
                if ((object.ReferenceEquals(this.SymbolField, value) != true)) {
                    this.SymbolField = value;
                    this.RaisePropertyChanged("Symbol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string Last {
            get {
                return this.LastField;
            }
            set {
                if ((object.ReferenceEquals(this.LastField, value) != true)) {
                    this.LastField = value;
                    this.RaisePropertyChanged("Last");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Date {
            get {
                return this.DateField;
            }
            set {
                if ((object.ReferenceEquals(this.DateField, value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Time {
            get {
                return this.TimeField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeField, value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string Change {
            get {
                return this.ChangeField;
            }
            set {
                if ((object.ReferenceEquals(this.ChangeField, value) != true)) {
                    this.ChangeField = value;
                    this.RaisePropertyChanged("Change");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string Open {
            get {
                return this.OpenField;
            }
            set {
                if ((object.ReferenceEquals(this.OpenField, value) != true)) {
                    this.OpenField = value;
                    this.RaisePropertyChanged("Open");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public string High {
            get {
                return this.HighField;
            }
            set {
                if ((object.ReferenceEquals(this.HighField, value) != true)) {
                    this.HighField = value;
                    this.RaisePropertyChanged("High");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public string Low {
            get {
                return this.LowField;
            }
            set {
                if ((object.ReferenceEquals(this.LowField, value) != true)) {
                    this.LowField = value;
                    this.RaisePropertyChanged("Low");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public string Volume {
            get {
                return this.VolumeField;
            }
            set {
                if ((object.ReferenceEquals(this.VolumeField, value) != true)) {
                    this.VolumeField = value;
                    this.RaisePropertyChanged("Volume");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=9)]
        public string MktCap {
            get {
                return this.MktCapField;
            }
            set {
                if ((object.ReferenceEquals(this.MktCapField, value) != true)) {
                    this.MktCapField = value;
                    this.RaisePropertyChanged("MktCap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public string PreviousClose {
            get {
                return this.PreviousCloseField;
            }
            set {
                if ((object.ReferenceEquals(this.PreviousCloseField, value) != true)) {
                    this.PreviousCloseField = value;
                    this.RaisePropertyChanged("PreviousClose");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=11)]
        public string PercentageChange {
            get {
                return this.PercentageChangeField;
            }
            set {
                if ((object.ReferenceEquals(this.PercentageChangeField, value) != true)) {
                    this.PercentageChangeField = value;
                    this.RaisePropertyChanged("PercentageChange");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=12)]
        public string AnnRange {
            get {
                return this.AnnRangeField;
            }
            set {
                if ((object.ReferenceEquals(this.AnnRangeField, value) != true)) {
                    this.AnnRangeField = value;
                    this.RaisePropertyChanged("AnnRange");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=13)]
        public string Earns {
            get {
                return this.EarnsField;
            }
            set {
                if ((object.ReferenceEquals(this.EarnsField, value) != true)) {
                    this.EarnsField = value;
                    this.RaisePropertyChanged("Earns");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=14)]
        public string PE {
            get {
                return this.PEField;
            }
            set {
                if ((object.ReferenceEquals(this.PEField, value) != true)) {
                    this.PEField = value;
                    this.RaisePropertyChanged("PE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=15)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DefaultFaultContract", Namespace="http://GOTLServices.FaultContracts/2008/01")]
    public partial class DefaultFaultContract : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int ErrorIdField;
        
        private string ErrorMessageField;
        
        private System.Guid CorrelationIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ErrorId {
            get {
                return this.ErrorIdField;
            }
            set {
                if ((this.ErrorIdField.Equals(value) != true)) {
                    this.ErrorIdField = value;
                    this.RaisePropertyChanged("ErrorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Guid CorrelationId {
            get {
                return this.CorrelationIdField;
            }
            set {
                if ((this.CorrelationIdField.Equals(value) != true)) {
                    this.CorrelationIdField = value;
                    this.RaisePropertyChanged("CorrelationId");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.restfulwebservices.net/ServiceContracts/2008/01", ConfigurationName="WcfStockService.IStockQuoteService")]
    public interface IStockQuoteService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="GetStockQuote", ReplyAction="http://www.restfulwebservices.net/ServiceContracts/2008/01/IStockQuoteService/Get" +
            "StockQuoteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SimplyMobile.Plugins.WcfStockService.DefaultFaultContract), Action="http://www.restfulwebservices.net/ServiceContracts/2008/01/IStockQuoteService/Get" +
            "StockQuoteDefaultFaultContractFault", Name="DefaultFaultContract", Namespace="http://GOTLServices.FaultContracts/2008/01")]
        System.IAsyncResult BeginGetStockQuote(string request, System.AsyncCallback callback, object asyncState);
        
        SimplyMobile.Plugins.WcfStockService.StockQuote EndGetStockQuote(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="GetWorldMajorIndices", ReplyAction="http://www.restfulwebservices.net/ServiceContracts/2008/01/IStockQuoteService/Get" +
            "WorldMajorIndicesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SimplyMobile.Plugins.WcfStockService.DefaultFaultContract), Action="http://www.restfulwebservices.net/ServiceContracts/2008/01/IStockQuoteService/Get" +
            "WorldMajorIndicesDefaultFaultContractFault", Name="DefaultFaultContract", Namespace="http://GOTLServices.FaultContracts/2008/01")]
        System.IAsyncResult BeginGetWorldMajorIndices(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<SimplyMobile.Plugins.WcfStockService.StockQuote> EndGetWorldMajorIndices(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStockQuoteServiceChannel : SimplyMobile.Plugins.WcfStockService.IStockQuoteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetStockQuoteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetStockQuoteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public SimplyMobile.Plugins.WcfStockService.StockQuote Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((SimplyMobile.Plugins.WcfStockService.StockQuote)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetWorldMajorIndicesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetWorldMajorIndicesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<SimplyMobile.Plugins.WcfStockService.StockQuote> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<SimplyMobile.Plugins.WcfStockService.StockQuote>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockQuoteServiceClient : System.ServiceModel.ClientBase<SimplyMobile.Plugins.WcfStockService.IStockQuoteService>, SimplyMobile.Plugins.WcfStockService.IStockQuoteService {
        
        private BeginOperationDelegate onBeginGetStockQuoteDelegate;
        
        private EndOperationDelegate onEndGetStockQuoteDelegate;
        
        private System.Threading.SendOrPostCallback onGetStockQuoteCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetWorldMajorIndicesDelegate;
        
        private EndOperationDelegate onEndGetWorldMajorIndicesDelegate;
        
        private System.Threading.SendOrPostCallback onGetWorldMajorIndicesCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public StockQuoteServiceClient() {
        }
        
        public StockQuoteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockQuoteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockQuoteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockQuoteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetStockQuoteCompletedEventArgs> GetStockQuoteCompleted;
        
        public event System.EventHandler<GetWorldMajorIndicesCompletedEventArgs> GetWorldMajorIndicesCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SimplyMobile.Plugins.WcfStockService.IStockQuoteService.BeginGetStockQuote(string request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetStockQuote(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SimplyMobile.Plugins.WcfStockService.StockQuote SimplyMobile.Plugins.WcfStockService.IStockQuoteService.EndGetStockQuote(System.IAsyncResult result) {
            return base.Channel.EndGetStockQuote(result);
        }
        
        private System.IAsyncResult OnBeginGetStockQuote(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string request = ((string)(inValues[0]));
            return ((SimplyMobile.Plugins.WcfStockService.IStockQuoteService)(this)).BeginGetStockQuote(request, callback, asyncState);
        }
        
        private object[] OnEndGetStockQuote(System.IAsyncResult result) {
            SimplyMobile.Plugins.WcfStockService.StockQuote retVal = ((SimplyMobile.Plugins.WcfStockService.IStockQuoteService)(this)).EndGetStockQuote(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetStockQuoteCompleted(object state) {
            if ((this.GetStockQuoteCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetStockQuoteCompleted(this, new GetStockQuoteCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetStockQuoteAsync(string request) {
            this.GetStockQuoteAsync(request, null);
        }
        
        public void GetStockQuoteAsync(string request, object userState) {
            if ((this.onBeginGetStockQuoteDelegate == null)) {
                this.onBeginGetStockQuoteDelegate = new BeginOperationDelegate(this.OnBeginGetStockQuote);
            }
            if ((this.onEndGetStockQuoteDelegate == null)) {
                this.onEndGetStockQuoteDelegate = new EndOperationDelegate(this.OnEndGetStockQuote);
            }
            if ((this.onGetStockQuoteCompletedDelegate == null)) {
                this.onGetStockQuoteCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetStockQuoteCompleted);
            }
            base.InvokeAsync(this.onBeginGetStockQuoteDelegate, new object[] {
                        request}, this.onEndGetStockQuoteDelegate, this.onGetStockQuoteCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SimplyMobile.Plugins.WcfStockService.IStockQuoteService.BeginGetWorldMajorIndices(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetWorldMajorIndices(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<SimplyMobile.Plugins.WcfStockService.StockQuote> SimplyMobile.Plugins.WcfStockService.IStockQuoteService.EndGetWorldMajorIndices(System.IAsyncResult result) {
            return base.Channel.EndGetWorldMajorIndices(result);
        }
        
        private System.IAsyncResult OnBeginGetWorldMajorIndices(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((SimplyMobile.Plugins.WcfStockService.IStockQuoteService)(this)).BeginGetWorldMajorIndices(callback, asyncState);
        }
        
        private object[] OnEndGetWorldMajorIndices(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<SimplyMobile.Plugins.WcfStockService.StockQuote> retVal = ((SimplyMobile.Plugins.WcfStockService.IStockQuoteService)(this)).EndGetWorldMajorIndices(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetWorldMajorIndicesCompleted(object state) {
            if ((this.GetWorldMajorIndicesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetWorldMajorIndicesCompleted(this, new GetWorldMajorIndicesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetWorldMajorIndicesAsync() {
            this.GetWorldMajorIndicesAsync(null);
        }
        
        public void GetWorldMajorIndicesAsync(object userState) {
            if ((this.onBeginGetWorldMajorIndicesDelegate == null)) {
                this.onBeginGetWorldMajorIndicesDelegate = new BeginOperationDelegate(this.OnBeginGetWorldMajorIndices);
            }
            if ((this.onEndGetWorldMajorIndicesDelegate == null)) {
                this.onEndGetWorldMajorIndicesDelegate = new EndOperationDelegate(this.OnEndGetWorldMajorIndices);
            }
            if ((this.onGetWorldMajorIndicesCompletedDelegate == null)) {
                this.onGetWorldMajorIndicesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetWorldMajorIndicesCompleted);
            }
            base.InvokeAsync(this.onBeginGetWorldMajorIndicesDelegate, null, this.onEndGetWorldMajorIndicesDelegate, this.onGetWorldMajorIndicesCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SimplyMobile.Plugins.WcfStockService.IStockQuoteService CreateChannel() {
            return new StockQuoteServiceClientChannel(this);
        }
        
        private class StockQuoteServiceClientChannel : ChannelBase<SimplyMobile.Plugins.WcfStockService.IStockQuoteService>, SimplyMobile.Plugins.WcfStockService.IStockQuoteService {
            
            public StockQuoteServiceClientChannel(System.ServiceModel.ClientBase<SimplyMobile.Plugins.WcfStockService.IStockQuoteService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetStockQuote(string request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("GetStockQuote", _args, callback, asyncState);
                return _result;
            }
            
            public SimplyMobile.Plugins.WcfStockService.StockQuote EndGetStockQuote(System.IAsyncResult result) {
                object[] _args = new object[0];
                SimplyMobile.Plugins.WcfStockService.StockQuote _result = ((SimplyMobile.Plugins.WcfStockService.StockQuote)(base.EndInvoke("GetStockQuote", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetWorldMajorIndices(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetWorldMajorIndices", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<SimplyMobile.Plugins.WcfStockService.StockQuote> EndGetWorldMajorIndices(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<SimplyMobile.Plugins.WcfStockService.StockQuote> _result = ((System.Collections.ObjectModel.ObservableCollection<SimplyMobile.Plugins.WcfStockService.StockQuote>)(base.EndInvoke("GetWorldMajorIndices", _args, result)));
                return _result;
            }
        }
    }
}