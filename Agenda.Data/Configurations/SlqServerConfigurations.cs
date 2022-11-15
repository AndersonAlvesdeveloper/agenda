using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Data.Configurations
{
    /// <summary>
    /// Classe para configuração da connectionstring
    /// </summary>
    public class SqlServerConfiguration
    {
        public static string GetConnectionString
          // => @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBAgenda;Integrated Security=True;Connect Timeout=30;Encrypt=False; TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
          => @"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8fbc8_dbagenda;User Id=db_a8fbc8_dbagenda_admin;Password=mAninhO01";

    }

}


