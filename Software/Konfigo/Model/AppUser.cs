using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konfigo.Model;


namespace Konfigo.Model
{
    public static class AppUser
    {
        public static UserRole Role { get; set; }
        public static Teacher LoggedTeacher { get; set; }

        public static int Id { get; set; }

        public static Employee LoggedEmployee { get; set; }
        public static Customer LoggedCustomer { get; set; }


    }
}

