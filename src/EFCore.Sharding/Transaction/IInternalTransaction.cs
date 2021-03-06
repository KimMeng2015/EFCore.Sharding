﻿using System.Data;
using System.Threading.Tasks;

namespace EFCore.Sharding
{
    internal interface IInternalTransaction : ITransaction
    {
        void BeginTransaction(IsolationLevel isolationLevel);
        Task BeginTransactionAsync(IsolationLevel isolationLevel);
        void CommitTransaction();
        void RollbackTransaction();
        void DisposeTransaction();
    }
}
