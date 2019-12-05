using System;
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

                cmd.Parameters.AddWithValue ("@name", product.Name);
                cmd.Parameters.AddWithValue ("@price", product.Price);
                cmd.Parameters.AddWithValue ("@description", product.Description);
                cmd.Parameters.AddWithValue ("@isDiscontinued", product.IsDiscontinued);

                conn.Open ();
                var result = (decimal)cmd.ExecuteNonQuery ();
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
                        var IsDiscontinuedIndex = reader.GetOrdinal ("IsDiscontinued");

                        var product = new Product () {
                            Id = (int)reader[0],
                            Name = reader["Name"] as string,

                            Description = !reader.IsDBNull (3) ? reader.GetString (3) : "",
                            Price = (decimal)reader.GetValue (2),
                            IsDiscontinued = reader.GetBoolean(4)                            
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
                    cmd.CommandText = "GetAllProducts";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    var da = new SqlDataAdapter () {
                        SelectCommand = cmd
                    };                  

                    da.Fill (ds);
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
                        Price = row.Field<decimal> ("Price"),
                        IsDiscontinued = row.Field<bool>("IsDiscontinued")
                    };

                    yield return product;
                };
            };
        }

        // removes it added isDiscontinued
        public void Remove ( int id )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("RemoveProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add ("@id", SqlDbType.Int);
                cmd.Parameters[0].Value = id;

                conn.Open ();
                cmd.ExecuteScalar ();
            };
        }

        public Product Update ( Product product )
        {
            using (var conn = CreateConnection ())
            using (var cmd = new SqlCommand ("UpdateProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue ("@description", product.Description);
                cmd.Parameters.AddWithValue ("@price", product.Price);
                cmd.Parameters.AddWithValue ("@id", product.Id);
                cmd.Parameters.AddWithValue ("@isDiscontinued", product.IsDiscontinued);

                conn.Open ();
                cmd.ExecuteNonQuery ();

                return product;
            };
        }

        private SqlConnection CreateConnection ()
        {
            var conn = new SqlConnection (_connectionString);
            return conn;
        }

        private readonly string _connectionString;
    }
}
