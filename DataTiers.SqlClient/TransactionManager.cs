using System;
using System.Data;
using System.Data.SqlClient;

namespace DataTiers.SqlClient {

    public class TransactionManager : ITransactionManager, IDisposable {

        private IDbConnection connection;
        private IDbTransaction transaction;

        private string connectionString;
        private bool transactionOpen;

        private bool disposed;
        private static object syncRoot = new object();

        internal TransactionManager() {
        }

        public TransactionManager(string connectionString) {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
        }

        public string ConnectionString {
            get { return connectionString; }
            set {
                //make sure transaction is open
                if (IsOpen) {
                    throw new InvalidOperationException("Database cannot be changed during a transaction");
                }

                connectionString = value;
                if (connectionString.Length > 0) {
                    connection = new SqlConnection(connectionString);
                }
            }
        }

        public IDbTransaction TransactionObject {
            get { return transaction; }
        }

        public bool IsOpen {
            get { return transactionOpen; }
        }

        public void BeginTransaction() {
            BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void BeginTransaction(IsolationLevel isolationLevel) {
            if (IsOpen) {
                throw new InvalidOperationException("Transaction already open.");
            }

            //Open connection
            try {
                connection.Open();
                transaction = this.connection.BeginTransaction(isolationLevel);
                transactionOpen = true;
            } catch (Exception) {
                // in the event of an error, close the connection and destroy the transaction object.
                if (connection != null) {
                    connection.Close();
                }

                if (transaction != null) {
                    transaction.Dispose();
                }

                transactionOpen = false;
                throw;
            }
        }

        public void Commit() {
            if (!IsOpen) {
                throw new InvalidOperationException("Transaction needs to begin first.");
            }

            try {
                transaction.Commit(); // SqlClient could throw Exception or InvalidOperationException
            } finally {
                //assuming the commit was sucessful.
                connection.Close();
                transaction.Dispose();
                transactionOpen = false;
            }
        }

        public void Rollback() {
            if (IsOpen) {
                throw new InvalidOperationException("Transaction needs to begin first.");
            }

            try {
                transaction.Rollback(); // SqlClient could throw Exception or InvalidOperationException
            } finally {
                connection.Close();
                transaction.Dispose();
                transactionOpen = false;
            }
        }

        public void Dispose() {
            if (!disposed) {
                lock (syncRoot) {
                    disposed = true;

                    if (IsOpen) {
                        Rollback();
                    }
                }
            }
        }
    }
}
