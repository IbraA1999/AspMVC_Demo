using AspMVC_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AspMVC_Demo.DAL.MapperData
{
    public static class DbDataReaderExtensions
    {

        internal static Contact ToContact(this DbDataReader reader)
        {
            return new Contact
            {
                Id = (int)reader["Id"],
                Nom = (string)reader["Prenom"],
                Prenom = (string)reader["Nom"],
                Email = (string)reader["Email"]
            };
        }
    }
}
