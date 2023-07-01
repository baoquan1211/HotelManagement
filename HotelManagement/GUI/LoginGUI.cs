using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.DAO;

namespace HotelManagement.GUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if(DBConnector.connect().State == ConnectionState.Open)
                {
                    MessageBox.Show("Thành công.");

                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được trống.", "Vui lòng nhập đầy đủ thông tin");
            }
        }
    }
}
