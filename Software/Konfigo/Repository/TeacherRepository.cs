using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Konfigo.Model;
using Konfigo;
using System.Data.SqlClient;

namespace Konfigo.Repository
{
    public class TeacherRepository
    {
        public static Teacher GetTeacher(string username)
        {
           
            DB.OpenConnection();
            var dr = DB.GetDataReader($"SELECT * FROM Teachers WHERE Username = '{username}'");

            Teacher teacher = null;

            if (dr.Read())
            {
                teacher = new Teacher
                {
                    Id = (int)dr["Id"],
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    Username = dr["Username"].ToString(),
                    Password = dr["Password"].ToString()
                };
            }

            dr.Close();
            DB.CloseConnection();

            return teacher;
        }
    }
}
