using System;
using System.Data;

namespace DataTiers.SqlClient {
    public interface ITransactionManager : IDisposable {
        string ConnectionString { get; set; }
        bool IsOpen { get; }
        void BeginTransaction();
        void BeginTransaction(IsolationLevel isolationLevel);
        void Commit();
        void Rollback();
        IDbTransaction TransactionObject { get; }
    }
}
