using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmSchool : Form
    {
        public frmSchool()
        {
            InitializeComponent();
        }

        private void frmSchool_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dB_SMISDataSet1.School”中。您可以根据需要移动或删除它。
            this.schoolTableAdapter.Fill(this.dB_SMISDataSet1.School);

            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void IsSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            String schoolname = ((DataRowView)IsSchool.SelectedItem)["SchoolName"].ToString();

            DBUtils dBUtils = new DBUtils();
            SqlConnection conn = dBUtils.DBConn();
            String sql1 = "select ID,SchoolPhone,SchoolAddress from School where SchoolName=@SchoolName";
            SqlCommand da = new SqlCommand(sql1, conn);
            da.Parameters.Add("@SchoolName", SqlDbType.NVarChar);
            da.Parameters["@SchoolName"].Value = schoolname;
            SqlDataReader re = da.ExecuteReader();
            String id = "";
            String phone = "";
            String address = "";
            while (re.Read())
            {

                id = re.GetString(re.GetOrdinal("ID")).ToString();
                phone = re.GetString(1).ToString();
                address = re.GetString(2).ToString();
            }
            txtID.Text = id;
            txtName.Text = schoolname;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            txtID.Enabled = false;
            conn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "")
            {
                MessageBox.Show("输入的ID号不能为空");
                return;
            }
            String id = txtID.Text;
            String name = txtName.Text;
            String phone = txtPhone.Text;
            String address = txtAddress.Text;
            DBUtils dBUtils = new DBUtils();
            SqlConnection sqlConnection = dBUtils.DBConn();
            String sql1 = "select * from school where id=@id";

            SqlCommand sqlCommand = new SqlCommand(sql1, sqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar);
            sqlCommand.Parameters["@id"].Value = id;
            object v = sqlCommand.ExecuteScalar();
            if (v == null)
            {
                String sql2 = String.Format("insert into school values('{0}','{1}','{2}','{3}')", id, name, phone, address);

                SqlCommand comm = new SqlCommand(sql2, sqlConnection);
                int v1 = comm.ExecuteNonQuery();
                if (v1 > 0)
                {
                    MessageBox.Show("数据添加成功");

                }
                else
                {
                    MessageBox.Show("添加失败");
                }

            }
            else
            {
                MessageBox.Show("学员编号重复，请重新输入");

            }

            sqlConnection.Close();
            txtID.Enabled = false;
            btnSave.Enabled = false;
            listbox_bind();
        }

        public void listbox_bind()
        {
            SqlConnection sqlConnection = new DBUtils().DBConn();
            String sql = "select schoolname from school";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            sqlConnection.Close();
            IsSchool.DataSource = ds.Tables[0];


        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            listbox_bind();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            String id = txtID.Text;
            String name = txtName.Text;
            String phone = txtPhone.Text;
            String address = txtAddress.Text;
            DBUtils dBUtils = new DBUtils();
            SqlConnection sqlConnection = dBUtils.DBConn();
            String sql1 = "select * from school where id=@id";

            SqlCommand sqlCommand = new SqlCommand(sql1, sqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar);
            sqlCommand.Parameters["@id"].Value = id;
            object v = sqlCommand.ExecuteScalar();
            if (v != null)
            {
                String sql2 = String.Format("update school set schoolname='{0}',schoolphone='{1}',schooladdress='{2}' where id='{3}'", name, phone, address, id);

                SqlCommand comm = new SqlCommand(sql2, sqlConnection);
                int v1 = comm.ExecuteNonQuery();
                if (v1 > 0)
                {
                    MessageBox.Show("数据修改成功");

                }
                else
                {
                    MessageBox.Show("学员编号输入错误");
                }

            }
            else
            {
                MessageBox.Show("学员编号重复，请重新输入");

            }

            sqlConnection.Close();
            listbox_bind();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要删除这个节点吗？", "提示", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                String id = txtID.Text;
                String sql = "delete from school where id=@id";
                SqlConnection sqlConnection = new DBUtils().DBConn();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar);
                sqlCommand.Parameters["@id"].Value = id;
                int v = sqlCommand.ExecuteNonQuery();
                if (v > 0)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
                sqlConnection.Close();
                listbox_bind();
            }
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnClose_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
}
