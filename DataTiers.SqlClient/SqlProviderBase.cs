using System;
using System.Data;
using System.Data.SqlClient;

namespace DataTiers.SqlClient {
    public abstract class SqlProviderBase {
        private readonly ITransactionManager transactionManager;

        protected SqlProviderBase(ITransactionManager transactionManager) {
            this.transactionManager = transactionManager;
        }

        public ITransactionManager TransactionManager { get { return this.transactionManager; } }

        protected IDataReader ExecuteReader(IDbCommand command) {
            if (!transactionManager.IsOpen || transactionManager.TransactionObject == null)
                throw new InvalidOperationException("Transaction must be open before executing a query.");
            PrepareCommand(command, transactionManager.TransactionObject);
            return command.ExecuteReader(CommandBehavior.Default);
        }

        protected int ExecuteNonQuery(IDbCommand command) {
            if (!transactionManager.IsOpen || transactionManager.TransactionObject == null)
                throw new InvalidOperationException("Transaction must be open before executing a query.");
            PrepareCommand(command, transactionManager.TransactionObject);
            return command.ExecuteNonQuery();
        }

        protected object ExecuteScalar(IDbCommand command) {
            if (!transactionManager.IsOpen || transactionManager.TransactionObject == null)
                throw new InvalidOperationException("Transaction must be open before executing a query.");
            PrepareCommand(command, transactionManager.TransactionObject);
            return command.ExecuteScalar();
        }

        protected IDbCommand GetCommand(string storedProcedureName) {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;
            return command;
        }

        protected bool OpenTransactionIfNecessary() {
            if (!transactionManager.IsOpen) {
                transactionManager.BeginTransaction();
                return true;
            }
            return false;
        }

        private static void PrepareCommand(IDbCommand command, IDbTransaction transaction) {
            if (command == null)
                throw new ArgumentNullException("command");
            if (transaction == null)
                throw new ArgumentNullException("transaction");
            PrepareCommand(command, transaction.Connection);
            command.Transaction = transaction;
        }

        private static void PrepareCommand(IDbCommand command, IDbConnection connection) {
            if (command == null)
                throw new ArgumentNullException("command");
            if (connection == null)
                throw new ArgumentNullException("connection");
            command.Connection = connection;
        }
    }
}
