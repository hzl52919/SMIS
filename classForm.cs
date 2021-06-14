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
    public partial class classForm : Form
    {
        public classForm()
        {
            InitializeComponent();
        }

        private void classForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dB_SMISDataSet1.Prgram”中。您可以根据需要移动或删除它。
            this.prgramTableAdapter.Fill(this.dB_SMISDataSet1.Prgram);
            // TODO: 这行代码将数据加载到表“dB_SMISDataSet1.Class”中。您可以根据需要移动或删除它。
            this.classTableAdapter.Fill(this.dB_SMISDataSet1.Class);

        }

        public void clock()
        {
            txt_cid.Enabled = false;
            comb_program.Enabled = false;
            btn_save.Enabled = false;
        }
        public void unclock()
        {
            txt_cid.Enabled =true;
            comb_program.Enabled = true;
            btn_save.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clock();
            String tname = "";
            String classid = "";
            string pid = "";
            String classname = ((DataRowView)listBox_class.SelectedItem)["classname"].ToString();
            DBUtils dBUtils = new DBUtils();
            SqlConnection conn = dBUtils.DBConn();
            String sql1 = String.Format("select * from class where classname='{0}'",classname);
            SqlCommand comm = new SqlCommand(sql1, conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                pid = reader.GetString(reader.GetOrdinal("ProgramID"));
                tname = reader.GetString(reader.GetOrdinal("teachername"));
                classid = reader.GetString(reader.GetOrdinal("id"));
            }
            reader.Close();
            txt_classname.Text = classname;
            txt_teachername.Text = tname;
            txt_cid.Text = classid;
            String sql2 = String.Format("select programname from prgram where id='{0}'",pid);
            SqlCommand comm1 = new SqlCommand(sql2, conn);
            object v = comm1.ExecuteScalar();
            comb_program.Text = v.ToString();
            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            unclock();
            comb_program.Enabled = true;
            txt_classname.Text = "";
            txt_teachername.Text = "";
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String sql = String.Format("select id from prgram where programname='{0}'",comb_program.Text);
            DBUtils dBUtils = new DBUtils();
            SqlConnection conn = dBUtils.DBConn();
            SqlCommand comm = new SqlCommand(sql, conn);
            object v = comm.ExecuteScalar();
            String pid = v.ToString();
            if (txt_cid.Text == "")
            {
                MessageBox.Show("班级编号不能为空");
                conn.Close();
                clock();
                return;
            }
            String sql2 = String.Format("select * from class where id='{0}'",txt_cid.Text);
            SqlCommand sqlCommand1 = new SqlCommand(sql2,conn);
            object v2 = sqlCommand1.ExecuteScalar();
            if (v2!=null)
            {
                MessageBox.Show("班级编号重复，请重新输入");
                conn.Close();
                clock();
                return;
            }
            
            String sql1 = String.Format("insert into class values('{0}','{1}','{2}','{3}')", txt_cid.Text, txt_classname.Text, pid, txt_teachername.Text);
                SqlCommand sqlCommand = new SqlCommand(sql1, conn);
                int v1 = sqlCommand.ExecuteNonQuery();
                if (v1>0)
                {
                    MessageBox.Show("增加成功");
                    listbox_bind();

                }
                else
                {
                    MessageBox.Show("增加失败");
                    conn.Close();
                    clock();
                    return;
                }
            conn.Close();
            clock();
        }

        public void listbox_bind()
        {
            SqlConnection sqlConnection = new DBUtils().DBConn();
            String sql = "select classname from class";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            sqlConnection.Close();
            listBox_class.DataSource = ds.Tables[0];
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要删除这个节点吗？", "提示", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                String classname = ((DataRowView)listBox_class.SelectedItem)["classname"].ToString();
                String sql = String.Format("delete from class where classname='{0}'", classname);
                DBUtils dBUtils = new DBUtils();
                SqlConnection conn = dBUtils.DBConn();
                SqlCommand comm = new SqlCommand(sql, conn);
                int v = comm.ExecuteNonQuery();
                if (v > 0)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
;               }

                conn.Close();
                listbox_bind();
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_cid.Text=="")
            {
                MessageBox.Show("班级编号不能为空");
                return;
            }

            txt_cid.Enabled = false;
            comb_program.Enabled = false;
            SqlConnection conn = new DBUtils().DBConn();
            String sql1 = String.Format("update class set classname='{0}',teachername='{1}' where id='{2}'",txt_classname.Text, txt_teachername.Text,txt_cid.Text);
            SqlCommand sqlCommand = new SqlCommand(sql1, conn);
            int v1 = sqlCommand.ExecuteNonQuery();
            if (v1 > 0)
            {
                MessageBox.Show("修改成功");
                listbox_bind();

            }
            else
            {
                MessageBox.Show("修改失败");
                conn.Close();
                clock();
                return;
            }
            conn.Close();

        }
    }
}
