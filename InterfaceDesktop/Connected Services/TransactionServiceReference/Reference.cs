﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterfaceDesktop.TransactionServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TransactionServiceReference.ServiceFinancialTransactionSoap")]
    public interface ServiceFinancialTransactionSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WithdrawMoney", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool WithdrawMoney(int accountID, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WithdrawMoney", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> WithdrawMoneyAsync(int accountID, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DepositMoney", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool DepositMoney(int accountID, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DepositMoney", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DepositMoneyAsync(int accountID, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowClientTransactions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable ShowClientTransactions(int accountID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowClientTransactions", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> ShowClientTransactionsAsync(int accountID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PerformExternalTransaction", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool PerformExternalTransaction(int accountID, decimal amount, string branchCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PerformExternalTransaction", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> PerformExternalTransactionAsync(int accountID, decimal amount, string branchCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TransferMoney", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool TransferMoney(int accountIDFrom, int accountIDTo, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TransferMoney", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> TransferMoneyAsync(int accountIDFrom, int accountIDTo, decimal amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceFinancialTransactionSoapChannel : InterfaceDesktop.TransactionServiceReference.ServiceFinancialTransactionSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceFinancialTransactionSoapClient : System.ServiceModel.ClientBase<InterfaceDesktop.TransactionServiceReference.ServiceFinancialTransactionSoap>, InterfaceDesktop.TransactionServiceReference.ServiceFinancialTransactionSoap {
        
        public ServiceFinancialTransactionSoapClient() {
        }
        
        public ServiceFinancialTransactionSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceFinancialTransactionSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceFinancialTransactionSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceFinancialTransactionSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool WithdrawMoney(int accountID, decimal amount) {
            return base.Channel.WithdrawMoney(accountID, amount);
        }
        
        public System.Threading.Tasks.Task<bool> WithdrawMoneyAsync(int accountID, decimal amount) {
            return base.Channel.WithdrawMoneyAsync(accountID, amount);
        }
        
        public bool DepositMoney(int accountID, decimal amount) {
            return base.Channel.DepositMoney(accountID, amount);
        }
        
        public System.Threading.Tasks.Task<bool> DepositMoneyAsync(int accountID, decimal amount) {
            return base.Channel.DepositMoneyAsync(accountID, amount);
        }
        
        public System.Data.DataTable ShowClientTransactions(int accountID) {
            return base.Channel.ShowClientTransactions(accountID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> ShowClientTransactionsAsync(int accountID) {
            return base.Channel.ShowClientTransactionsAsync(accountID);
        }
        
        public bool PerformExternalTransaction(int accountID, decimal amount, string branchCode) {
            return base.Channel.PerformExternalTransaction(accountID, amount, branchCode);
        }
        
        public System.Threading.Tasks.Task<bool> PerformExternalTransactionAsync(int accountID, decimal amount, string branchCode) {
            return base.Channel.PerformExternalTransactionAsync(accountID, amount, branchCode);
        }
        
        public bool TransferMoney(int accountIDFrom, int accountIDTo, decimal amount) {
            return base.Channel.TransferMoney(accountIDFrom, accountIDTo, amount);
        }
        
        public System.Threading.Tasks.Task<bool> TransferMoneyAsync(int accountIDFrom, int accountIDTo, decimal amount) {
            return base.Channel.TransferMoneyAsync(accountIDFrom, accountIDTo, amount);
        }
    }
}
