using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace App_Camping_Entrance
{
    class DataHelper
    {
        public MySqlConnection connection;

        private List<int> listOfId;
        public DataHelper()
        {
            //Establishing the connection
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi339805;" +
                                    "user id=dbi339805;" +
                                    "password=1LD6XTYh06;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
            listOfId = new List<int>();
        }


    }
}
