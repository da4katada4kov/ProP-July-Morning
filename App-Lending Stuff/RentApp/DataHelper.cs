using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Cashapp
{
    class DataHelper
    {
        public MySqlConnection connection;

        public DataHelper()
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi339805;" +
                                    "user id=dbi339805;" +
                                    "password=1LD6XTYh06;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }
    }
}
