﻿using System.Collections.Generic;
using System.Threading.Tasks;
using NeoModules.JsonRpc.Client;
using NeoModules.RPC.DTOs;
using IAccount = NeoModules.NEP6.Interfaces.IAccount;

namespace NeoModules.NEP6.TransactionManagers
{
    public interface ITransactionManager
    {
        IClient Client { get; set; }
        IAccount Account { get; set; }
        Task<decimal> EstimateGasAsync(string serializedScriptHash);
        Task<decimal> EstimateGasAsync(string scriptHash, string operation, List<InvokeParameter> parameterList);
        Task<bool> SendTransactionAsync(string serializedAndSignedTx);
        string SignMessage(string messageToSign);
        Task<Transaction> GetTransaction(string tx);
    }
}