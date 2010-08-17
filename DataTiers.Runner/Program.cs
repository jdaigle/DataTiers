using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTiers.SqlClient.Providers;
using DataTiers.SqlClient;
using DataTiers.SqlClient.Entities;

namespace DataTiers.Runner {
    class Program {
        static void Main(string[] args) {
            var connectionString = @"Server=.\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";

            var provider = new CategoriesProvider(new TransactionManager(connectionString));
            
            int count = 0;
            var rows = provider.GetAll(out count).ToArray();
            var row = provider.GetByCategoryId(rows[2].CategoryId);
            var newRow = new Categories() {
                Picture = row.Picture,
                Description = row.Description,
                CategoryName = row.CategoryName,
            };
            var updated = provider.Update(row);
            var updated2 = provider.Update(newRow);
            var inserted = provider.Insert(newRow);
        }
    }
}
