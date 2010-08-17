using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DataTiers.SqlClient {
    public abstract class SqlProviderBase<TEntity> {
        private readonly ITransactionManager transactionManager;

        protected SqlProviderBase(ITransactionManager transactionManager) {
            this.transactionManager = transactionManager;
        }

        public ITransactionManager TransactionManager { get { return this.transactionManager; } }

        protected virtual IDataReader ExecuteReader(IDbCommand command) {
            if (!transactionManager.IsOpen || transactionManager.TransactionObject == null)
                throw new InvalidOperationException("Transaction must be open before executing a query.");
            PrepareCommand(command, transactionManager.TransactionObject);
            return command.ExecuteReader(CommandBehavior.Default);
        }

        protected virtual int ExecuteNonQuery(IDbCommand command) {
            if (!transactionManager.IsOpen || transactionManager.TransactionObject == null)
                throw new InvalidOperationException("Transaction must be open before executing a query.");
            PrepareCommand(command, transactionManager.TransactionObject);
            return command.ExecuteNonQuery();
        }

        protected virtual object ExecuteScalar(IDbCommand command) {
            if (!transactionManager.IsOpen || transactionManager.TransactionObject == null)
                throw new InvalidOperationException("Transaction must be open before executing a query.");
            PrepareCommand(command, transactionManager.TransactionObject);
            return command.ExecuteScalar();
        }

        protected virtual IDbCommand GetCommand(string storedProcedureName) {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;
            return command;
        }

        protected virtual bool OpenTransactionIfNecessary() {
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

        protected virtual List<TEntity> ExecuteReader(IDbCommand command, int skip, int maxResults, out int count) {
            IDataReader reader = null;
            List<TEntity> rows = new List<TEntity>();
            var openedTransactionWithinScope = OpenTransactionIfNecessary();
            try {
                reader = ExecuteReader(command);
                count = -1;
                Fill(reader, rows, skip, maxResults);
                if (reader.NextResult()) {
                    if (reader.Read()) {
                        count = reader.GetInt32(0);
                    }
                }
            } catch (Exception) {
                if (reader != null) {
                    reader.Close();
                    reader = null;
                }
                if (openedTransactionWithinScope)
                    TransactionManager.Rollback();
                throw;
            } finally {
                if (command != null)
                    command.Dispose();
            }
            return rows;
        }

        protected virtual List<TEntity> Fill(IDataReader reader, List<TEntity> rows, int skip, int maxResults) {
            for (int i = 0; i < skip; i++) {
                if (!reader.Read())
                    return rows; // not enough rows, just return
            }

            for (int i = 0; i < maxResults; i++) {
                if (!reader.Read())
                    break; // we are done

                var row = FillRow(reader);
                rows.Add(row);
            }

            return rows;
        }

        protected abstract TEntity FillRow(IDataReader reader);
    }
}
