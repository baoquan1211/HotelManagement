using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace HotelManagement.DAO
{
    public class DBConnector
    {
        public static MySqlConnection conn;
        static string myConnectionString = "server=db-mysql-fra1-53705-do-user-14143572-0.b.db.ondigitalocean.com;port=25060;database=hotel_management;uid=doadmin;pwd=AVNS_NcCYeDJbKKFa6cA8zVS;";
        public DBConnector() { }

        public static MySqlConnection connect()
        {
            conn = new MySqlConnection(myConnectionString);
            conn.Open();
            return conn;
        }


    }
}
