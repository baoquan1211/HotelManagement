using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace HotelManagement.DAO
{
    internal class PhieuDatPhongDAO
    {
        public MySqlConnection conn;
        public PhieuDatPhongDAO(MySqlConnection conn)
        {
            this.conn = conn;
        }

    }
}
