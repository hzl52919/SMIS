using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public static string LoginName = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String t1 = txtname.Text;
            String t2 = txtPassword.Text;
            if (t1==""||t2=="") {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                String sql1 = "select * from tb_User where username=@username and password=@password";
                DBUtils dBUtils = new DBUtils();
                SqlConnection conn = dBUtils.DBConn();
                SqlCommand command = new SqlCommand(sql1,conn);
                command.Parameters.Add("@username",SqlDbType.NVarChar);
                command.Parameters.Add("@password",SqlDbType.NVarChar);
                command.Parameters["@username"].Value = txtname.Text;
                command.Parameters["@password"].Value = txtPassword.Text;
                object v = command.ExecuteScalar();
                if (v!=null)
                {
                    MessageBox.Show("登陆成功");
                    LoginName = txtname.Text;
                    conn.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");

                }
                conn.Close();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
