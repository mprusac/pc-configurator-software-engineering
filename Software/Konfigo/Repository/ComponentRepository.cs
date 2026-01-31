using Konfigo;
using Konfigo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Konfigo.Repository
{
    public class ComponentRepository
    {
        public static List<ComponentView> GetAllForView()
        {
            List<ComponentView> list = new List<ComponentView>();

                        DB.OpenConnection();

            SqlDataReader dr = DB.GetDataReader(@"
                SELECT c.Id, c.Name, ct.Name AS TypeName,
                       c.Price, c.StockQuantity,
                       c.Manufacturer, c.Specifications,
                       c.ComponentTypeId AS ComponentTypeId
                FROM Components c
                JOIN ComponentTypes ct ON c.ComponentTypeId = ct.Id
            ");

            while (dr.Read())
            {
                ComponentView view = new ComponentView
                {
                    Id = int.Parse(dr["Id"].ToString()),
                    Name = dr["Name"].ToString(),
                    TypeName = dr["TypeName"].ToString(),
                    Price = decimal.Parse(dr["Price"].ToString()),
                    StockQuantity = int.Parse(dr["StockQuantity"].ToString()),
                    Manufacturer = dr["Manufacturer"].ToString(),
                    Specifications = dr["Specifications"].ToString(),
                    ComponentTypeId = int.Parse(dr["ComponentTypeId"].ToString())
                };

                list.Add(view);
            }

            dr.Close();
            DB.CloseConnection();

            return list;
        }

        public static void DeleteById(int id)
        {
            
            DB.OpenConnection();
            string query = $"DELETE FROM Components WHERE Id = {id}";
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }

        public static List<string> GetAllTypes()
        {
            List<string> types = new List<string>();

            string sql = "SELECT Name FROM ComponentTypes";
            DB.OpenConnection();

         

           
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                types.Add(reader["Name"].ToString());
            }

            reader.Close();
            DB.CloseConnection();

            return types;
        }


        public static List<Component> GetComponentsByType(string typeName)
        {
            List<Component> components = new List<Component>();

            string sql = $@"
                SELECT c.Id, c.Name, c.ComponentTypeId, c.Price, c.StockQuantity, 
                       c.Manufacturer, c.Specifications, t.Name AS TypeName
                FROM Components c
                JOIN ComponentTypes t ON c.ComponentTypeId = t.Id
                WHERE t.Name = '{typeName.Replace("'", "''")}'
            ";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                var component = new Component
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    ComponentTypeId = Convert.ToInt32(reader["ComponentTypeId"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                    StockQuantity = Convert.ToInt32(reader["StockQuantity"]),
                    Manufacturer = reader["Manufacturer"].ToString(),
                    Specifications = reader["Specifications"].ToString(),
                    TypeName = reader["TypeName"].ToString()
                };

                components.Add(component);
            }

            reader.Close();
            DB.CloseConnection();

            return components;
        }
    }
}
