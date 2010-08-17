using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTiers.SqlClient.Entities;
using System.Data;

namespace DataTiers.SqlClient.Providers {
    public class CategoriesProvider : SqlProviderBase {

        public CategoriesProvider(ITransactionManager transactionManager) : base(transactionManager) { }

        public IList<Categories> GetAll(out int count) {
            var command = GetCommand("_Categories_Get_List");
            IDataReader reader = null;
            List<Categories> rows = new List<Categories>();
            var openedTransactionWithinScope = OpenTransactionIfNecessary();
            try {
                reader = ExecuteReader(command);
                count = -1;
                Fill(reader, rows, 0, int.MaxValue);
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

        private List<Categories> Fill(IDataReader reader, List<Categories> rows, int skip, int maxResults) {
            for (int i = 0; i < skip; i++) {
                if (!reader.Read())
                    return rows; // not enough rows, just return
            }

            for (int i = 0; i < maxResults; i++) {
                if (!reader.Read())
                    break; // we are done

                var entityData = new CategoriesEntityData();

                entityData.CategoryId = (Int32)reader[CategoriesColumnsHelper.GetColumnName(CategoriesColumn.CategoryId)];
                entityData.CategoryName = (string)reader[CategoriesColumnsHelper.GetColumnName(CategoriesColumn.CategoryName)];
                entityData.Description = (string)reader[CategoriesColumnsHelper.GetColumnName(CategoriesColumn.Description)];
                entityData.Picture = (Byte[])reader[CategoriesColumnsHelper.GetColumnName(CategoriesColumn.Picture)];

                var row = new Categories(entityData);

                rows.Add(row);
            }

            return rows;
        }
    }
}
