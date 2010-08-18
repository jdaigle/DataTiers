using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DataTiers.SqlClient.Entities;

namespace DataTiers.SqlClient.Providers {
    public class CategoriesProvider : SqlProviderBase<Category> {

        public CategoriesProvider(ITransactionManager transactionManager) : base(transactionManager) { }

        public Category GetByCategoryId(int categoryid) {
            var command = GetCommand("sp_cw_Categories_Get_ByCategoryID");
            command.Parameters.Add(new SqlParameter("@CategoryID", categoryid));
            var count = 1;
            var results = ExecuteReader(command, 0, int.MaxValue, out count);
            if (results.Count == 1)
                return results[0];
            else if (results.Count == 0)
                return null;
            else
                throw new DataException("Cannot find the unique instance of the class.");
        }

        public IList<Category> GetAll(out int count) {
            var command = GetCommand("sp_cw_Categories_Get_All");
            return ExecuteReader(command, 0, int.MaxValue, out count);
        }

        public bool Update(Category entity) {
            var command = GetCommand("_Categories_Update");
            command.Parameters.Add(new SqlParameter("@CategoryId", entity.CategoryID));
            command.Parameters.Add(new SqlParameter("@CategoryName", entity.CategoryName));
            command.Parameters.Add(new SqlParameter("@Description", entity.Description));
            command.Parameters.Add(new SqlParameter("@Picture", entity.Picture));

            var count = 0;
            var outParams = ExecuteNonQuery(command, out count);

            if (count == 1)
                (entity as IEntity).EntityData.AcceptChanges();

            return count == 1;
        }

        public bool Insert(Category entity) {
            var command = GetCommand("_Categories_Insert");
            command.Parameters.Add(new SqlParameter("@CategoryId", SqlDbType.Int) { Direction = ParameterDirection.Output });
            command.Parameters.Add(new SqlParameter("@CategoryName", entity.CategoryName));
            command.Parameters.Add(new SqlParameter("@Description", entity.Description));
            command.Parameters.Add(new SqlParameter("@Picture", entity.Picture));

            var count = 0;
            var outParams = ExecuteNonQuery(command, out count);

            if (count == 1) {
                var entityData = (entity as IEntity).EntityData as CategoryEntityData;
                entityData.SuppressEvents = true;
                entityData.CategoryID = (Int32)outParams.Single(x => x.ParameterName == "@CategoryId").Value;
                entityData.SuppressEvents = false;
                entityData.AcceptChanges();
            }

            return count == 1;
        }

        protected override Category FillRow(IDataReader reader) {
            var row = new Category();
            var entityData = (row as IEntity).EntityData as CategoryEntityData;
            entityData.SuppressEvents = true;
            entityData.CategoryID = (Int32)reader[CategoryColumnsHelper.GetColumnName(CategoryColumn.CategoryID)];
            entityData.CategoryName = (string)reader[CategoryColumnsHelper.GetColumnName(CategoryColumn.CategoryName)];
            entityData.Description = (string)reader[CategoryColumnsHelper.GetColumnName(CategoryColumn.Description)];
            entityData.Picture = (Byte[])reader[CategoryColumnsHelper.GetColumnName(CategoryColumn.Picture)];
            entityData.SuppressEvents = false;
            entityData.AcceptChanges();
            return row;
        }
    }
}
