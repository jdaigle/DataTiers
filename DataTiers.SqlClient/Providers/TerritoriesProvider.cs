using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DataTiers.SqlClient.Entities;

namespace DataTiers.SqlClient.Providers {
    public class TerritoriesProvider : SqlProviderBase<Territory> {

        public TerritoriesProvider(ITransactionManager transactionManager) : base(transactionManager) { }

        //public Territory GetByCategoryId(int categoryid) {
        //    var command = GetCommand("_Categories_GetByCategoryId");
        //    command.Parameters.Add(new SqlParameter("@CategoryId", categoryid));
        //    var count = 1;
        //    var results = ExecuteReader(command, 0, int.MaxValue, out count);
        //    if (results.Count == 1)
        //        return results[0];
        //    else if (results.Count == 0)
        //        return null;
        //    else
        //        throw new DataException("Cannot find the unique instance of the class.");
        //}

        public IList<Territory> GetAll(out int count) {
            var command = GetCommand("sp_cw_Territories_Get_All");
            return ExecuteReader(command, 0, int.MaxValue, out count);
        }

        //public bool Update(Territory entity) {
        //    var command = GetCommand("_Categories_Update");
        //    command.Parameters.Add(new SqlParameter("@CategoryId", entity.CategoryId));
        //    command.Parameters.Add(new SqlParameter("@CategoryName", entity.CategoryName));
        //    command.Parameters.Add(new SqlParameter("@Description", entity.Description));
        //    command.Parameters.Add(new SqlParameter("@Picture", entity.Picture));

        //    var count = 0;
        //    var outParams = ExecuteNonQuery(command, out count);

        //    if (count == 1)
        //        (entity as IEntity).EntityData.AcceptChanges();

        //    return count == 1;
        //}

        //public bool Insert(Territory entity) {
        //    var command = GetCommand("_Categories_Insert");
        //    command.Parameters.Add(new SqlParameter("@CategoryId", SqlDbType.Int) { Direction = ParameterDirection.Output });
        //    command.Parameters.Add(new SqlParameter("@CategoryName", entity.CategoryName));
        //    command.Parameters.Add(new SqlParameter("@Description", entity.Description));
        //    command.Parameters.Add(new SqlParameter("@Picture", entity.Picture));

        //    var count = 0;
        //    var outParams = ExecuteNonQuery(command, out count);

        //    if (count == 1) {
        //        var entityData = (entity as IEntity).EntityData as CategoriesEntityData;
        //        entityData.SuppressEvents = true;
        //        entityData.CategoryId = (Int32)outParams.Single(x => x.ParameterName == "@CategoryId").Value;
        //        entityData.SuppressEvents = false;
        //        entityData.AcceptChanges();
        //    }

        //    return count == 1;
        //}

        protected override Territory FillRow(IDataReader reader) {
            var row = new Territory();
            var entityData = (row as IEntity).EntityData as TerritoryEntityData;
            entityData.SuppressEvents = true;
            entityData.TerritoryID = (string)reader[TerritoryColumnsHelper.GetColumnName(TerritoryColumn.TerritoryID)];
            entityData.TerritoryDescription = (string)reader[TerritoryColumnsHelper.GetColumnName(TerritoryColumn.TerritoryDescription)];
            entityData.RegionID = (int)reader[TerritoryColumnsHelper.GetColumnName(TerritoryColumn.RegionID)];
            entityData.SuppressEvents = false;
            entityData.AcceptChanges();
            return row;
        }
    }
}