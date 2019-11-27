﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : IProductDatabase
    {
        public SqlProductDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }
        public Product Add ( Product product )
        {
            using(var conn = CreateConnection())
            using(var cmd = new SqlCommand("AddProduct", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var parmName = new SqlParameter ("@name", product.Name);
                cmd.Parameters.Add (parmName);
                cmd.Parameters.AddWithValue ("@Description", product.Description);
                cmd.Parameters.AddWithValue ("@Price", product.Price);

                conn.Open ();
                var result = (decimal)cmd.ExecuteScalar ();
                product.Id = Convert.ToInt32 (result);

                return product;
            }
        }
        public Product Get ( int id )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("GetProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue ("@id", id);

                conn.Open ();
                using (var reader = cmd.ExecuteReader ())
                {
                    if (reader.Read ())
                    {
                        var NameIndex = reader.GetOrdinal ("Name");
                        var PriceIndex = reader.GetOrdinal ("Price");

                        var product = new Product () {
                            Id = (int)reader[0],
                            Name = reader["Name"] as string,

                            //FIX: Handle null
                            Description = !reader.IsDBNull (2) ? reader.GetString (2) : "",
                            Price = (decimal)reader.GetValue(3)
                        };

                        return product;
                    };
                };
            };

            return null;
        }
        public IEnumerable<Product> GetAll ()
        {
            var ds = new DataSet ();

            //Create a connection and open
            using (var conn = CreateConnection ())
            {
                using (var cmd = conn.CreateCommand ())
                {
                    cmd.CommandText = "GetProduct";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    var da = new SqlDataAdapter () {
                        SelectCommand = cmd
                    };

                    //da.Fill (ds);
                };
            };

            var table = ds.Tables.OfType<DataTable> ().FirstOrDefault ();
            if (table != null)
            {
                foreach (var row in table.Rows.OfType<DataRow> ())
                {
                    var product = new Product () {
                        Id = (int)row[0],
                        Name = row["Name"] as string,
                        Description = row.Field<string> ("Description"),
                        Price = row.Field<decimal> ("Price")
                    };

                    yield return product;
                };
            };
        }
        public void Remove ( int id )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("DeleteProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add ("@id", SqlDbType.Int);
                cmd.Parameters[0].Value = id;

                conn.Open ();
                cmd.ExecuteNonQuery ();
            };
        }
        public Product Update ( Product product )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("UpdateProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var parmName = new SqlParameter ("@name", product.Name);
                cmd.Parameters.Add (parmName);
                cmd.Parameters.AddWithValue ("@description", product.Description);
                cmd.Parameters.AddWithValue ("@price", product.Price);
                cmd.Parameters.AddWithValue ("@id", product.Id);

                conn.Open ();
                cmd.ExecuteNonQuery ();

                return product;
            };
        }

        private SqlConnection CreateConnection ()
        {
            var conn = new SqlConnection (_connectionString);
            //conn.Open();
            return conn;
        }

        private readonly string _connectionString;
    }
}
