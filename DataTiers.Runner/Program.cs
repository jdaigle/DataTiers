using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTiers.SqlClient.Providers;
using DataTiers.SqlClient;

namespace DataTiers.Runner {
    class Program {
        static void Main(string[] args) {
            var connectionString = @"Server=.\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";

            var provider = new CategoriesProvider(new TransactionManager(connectionString));
            
            int count = 0;
            var rows = provider.GetAll(out count).ToArray();
        }
    }
}
