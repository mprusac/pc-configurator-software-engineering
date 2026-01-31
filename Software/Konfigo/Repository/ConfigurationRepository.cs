using Konfigo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Konfigo.Repository
{
    public class ConfigurationRepository
    {
        public static void Save(Configuration config)
        {
            DB.OpenConnection();

            string insertConfigSql = $@"
                INSERT INTO Configurations (CustomerId, TotalPrice, DateCreated)
                VALUES ({config.CustomerId}, {config.TotalPrice.ToString(System.Globalization.CultureInfo.InvariantCulture)}, '{config.DateCreated:yyyy-MM-dd HH:mm:ss}');
                SELECT SCOPE_IDENTITY();
            ";

            SqlCommand cmd = new SqlCommand(insertConfigSql, DB.GetConnection());
            int configId = Convert.ToInt32(cmd.ExecuteScalar());

            foreach (var component in config.Components)
            {
                string insertRelSql = $@"
                    INSERT INTO ConfigurationComponents (ConfigurationId, ComponentId)
                    VALUES ({configId}, {component.Id});
                ";
                DB.ExecuteCommand(insertRelSql);
            }

            DB.CloseConnection();
        }

        public static List<Configuration> GetAll()
        {
            var list = new List<Configuration>();

            DB.OpenConnection();

            string sql = "SELECT * FROM Configurations";
            var reader = DB.GetDataReader(sql);

           
            while (reader.Read())
            {
                var config = new Configuration
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                    TotalPrice = Convert.ToDecimal(reader["TotalPrice"]),
                    DateCreated = Convert.ToDateTime(reader["DateCreated"]),
                    Components = new List<Component>() 
                };

                list.Add(config);
            }

            reader.Close();

            foreach (var config in list)
            {
                string sql2 = $@"
            SELECT c.Id, c.Name, c.ComponentTypeId, c.Price, c.StockQuantity,
                   c.Manufacturer, c.Specifications, ct.Name AS TypeName
            FROM ConfigurationComponents cc
            JOIN Components c ON cc.ComponentId = c.Id
            JOIN ComponentTypes ct ON c.ComponentTypeId = ct.Id
            WHERE cc.ConfigurationId = {config.Id}
        ";

                var reader2 = DB.GetDataReader(sql2);
                while (reader2.Read())
                {
                    var comp = new Component
                    {
                        Id = Convert.ToInt32(reader2["Id"]),
                        Name = reader2["Name"].ToString(),
                        ComponentTypeId = Convert.ToInt32(reader2["ComponentTypeId"]),
                        Price = Convert.ToDecimal(reader2["Price"]),
                        StockQuantity = Convert.ToInt32(reader2["StockQuantity"]),
                        Manufacturer = reader2["Manufacturer"].ToString(),
                        Specifications = reader2["Specifications"].ToString(),
                        TypeName = reader2["TypeName"].ToString()
                    };
                    config.Components.Add(comp);
                }
                reader2.Close();
            }

            DB.CloseConnection();
            return list;
        }

    }
}
