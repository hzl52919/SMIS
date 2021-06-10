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

namespace WindowsFormsApp1
{
    public partial class frmstudent : Form
    {
        public frmstudent()
        {
            InitializeComponent();
        }
       
        public void showlistview()
        {
            if (comboBox3.Text != "" && comboBox2.Text != "" && comboBox1.Text != "")
            {
                lvstudent.Columns.Add("学号").Width = 160;
                lvstudent.Columns.Add("姓名").Width = 70;
                DBUtils dBUtils = new DBUtils();
                SqlConnection sqlConnection = dBUtils.DBConn();
                String sql = String.Format("select ID,StudentName from studentInfo where SchoolName='{0}' and ProgramName='{1}' and ClassName='{2}'", comboBox3.Text,comboBox2.Text,comboBox1.Text);
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = reader["ID"].ToString();
                    lv.SubItems.Add(reader["studentname"].ToString());
                    lvstudent.Items.Add(lv);
                }
                sqlConnection.Close();
            }
        }
        private void lvstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void bindprm()
        {
            DBUtils dBUtils = new DBUtils();
            SqlConnection sqlConnection = dBUtils.DBConn();
            String sql = String.Format("select Prgram.ProgramName from Prgram left join School on Prgram.SchoolID=School.ID where School.SchoolName = '{0}'", comboBox3.Text);
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetString(0)); ;
            }

            sqlConnection.Close();
        }
        public void bindclass()
        {
            lvstudent.Items.Clear();
            DBUtils dBUtils = new DBUtils();
            SqlConnection sqlConnection = dBUtils.DBConn();
            String sql = String.Format("select class.classname from Prgram left join class on Prgram.ID=class.ProgramID where Prgram.ProgramName = '{0}'", comboBox2.Text);
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0)); ;
            }

            sqlConnection.Close();
        }

        private void frmstudent_Load(object sender, EventArgs e)
        {
 
            // TODO: 这行代码将数据加载到表“dB_SMISDataSet1.School”中。您可以根据需要移动或删除它。
            this.schoolTableAdapter.Fill(this.dB_SMISDataSet1.School);
            bindprm();
        
        }
       
   
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Text = "";
            comboBox2.Items.Clear();
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            bindprm();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            bindclass();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showlistview();
        }
    }
}
