using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    public static class connection
    {
        public static string Conn(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;

        }
    }
}
