using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class studentSelect : Form
    {
        public studentSelect()
        {
            InitializeComponent();
        }

        private void studentSelect_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            String birth = "";
            String gender = "";
            String name = "";
            if (txt_stuid.Text=="")
            {
                MessageBox.Show("请输入学号");
                return;
            }
            DBUtils dBUtils = new DBUtils();
            SqlConnection conn = dBUtils.DBConn();
            String sql = String.Format("select * from student where id='{0}'",txt_stuid.Text);
            SqlCommand comm = new SqlCommand(sql, conn);
            object v = comm.ExecuteScalar();
            if (v == null)
            {
                MessageBox.Show("没有找到该学号的学生，请重新输入。");
                lab_birth.Text = "";
                lab_class.Text = "";
                lab_depart.Text = "";
                lab_major.Text = "";
                lab_sex.Text = "";
                lab_stuname.Text = "";
                conn.Close();
                return;
            }
            SqlDataReader reader = comm.ExecuteReader();
            String classid = "";
            while (reader.Read())
            {
                byte[] photo = null;
                DateTime dt = new DateTime();
                try
                {
                    dt = reader.GetDateTime(reader.GetOrdinal("birth"));
                    birth = dt.ToString("yyyy-MM-dd");
                }
                catch
                {
                    DateTime dateTime = Convert.ToDateTime(dt);
                    birth = dateTime.ToString("yyyy-MM-dd");
                    MessageBox.Show(birth);
                }
                gender = reader.GetString(reader.GetOrdinal("gender"));
                name = reader.GetString(reader.GetOrdinal("studentname"));
                classid = reader.GetString(reader.GetOrdinal("classid"));
                try
                {
                    photo = (byte[])reader.GetValue(reader.GetOrdinal("photo"));
                    MemoryStream ms = new MemoryStream(photo);
                    Bitmap bitmap = new Bitmap(ms);
                    pictureBox.Image = bitmap;
                }
                catch
                {
                    photo = null;
                }
                lab_stuname.Text = name;
                lab_sex.Text = gender;
                lab_birth.Text = birth;
            }
            reader.Close();
            
            String sql_from = String.Format("select * from student_from where id='{0}'",txt_stuid.Text);
            SqlCommand sqlCommand = new SqlCommand(sql_from, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lab_class.Text = sqlDataReader.GetString(sqlDataReader.GetOrdinal("classname"));
                lab_major.Text = sqlDataReader.GetString(sqlDataReader.GetOrdinal("programname"));
                lab_depart.Text = sqlDataReader.GetString(sqlDataReader.GetOrdinal("schoolname"));
            }
            sqlDataReader.Close();
            conn.Close();
        }
    }
}
