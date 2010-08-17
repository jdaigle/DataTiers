using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTiers.SqlClient.Entities;
using System.Data;

namespace DataTiers.SqlClient.Providers {
    public class CategoriesProvider : SqlProviderBase<Categories> {

        public CategoriesProvider(ITransactionManager transactionManager) : base(transactionManager) { }

        public IList<Categories> GetAll(out int count) {
            var command = GetCommand("_Categories_Get_List");
            return ExecuteReader(command, 0, int.MaxValue, out count);
        }

        protected override List<Categories> Fill(IDataReader reader, List<Categories> rows, int skip, int maxResults) {
            for (int i = 0; i < skip; i++) {
                if (!reader.Read())
                    return rows; // not enough rows, just return
            }

            for (int i = 0; i < maxResults; i++) {
                if (!reader.Read())
                    break; // we are done

                var row = new Categories();
                var entityData = (row as IEntity).EntityData as CategoriesEntityData;
                entityData.SuppressEvents = true;
                entityData.CategoryId = (Int32)reader[CategoriesColumnsHelper.GetColumnName(CategoriesColumn.CategoryId)];
                entityData.CategoryName = (string)reader[CategoriesColumnsHelper.GetColumnName(CategoriesColumn.CategoryName)];
                entityData.Description = (string)reader[CategoriesColumnsHelper.GetColumnName(CategoriesColumn.Description)];
                entityData.Picture = (Byte[])reader[CategoriesColumnsHelper.GetColumnName(CategoriesColumn.Picture)];
                entityData.SuppressEvents = false;
                entityData.EntityState = EntityState.Unchanged;

                rows.Add(row);
            }

            return rows;
        }
    }
}
