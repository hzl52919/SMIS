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
    public partial class majorForm : Form
    {
        public majorForm()
        {
            InitializeComponent();
        }

        private void majorForm_Load(object sender, EventArgs e)
        {
           
            // TODO: 这行代码将数据加载到表“dB_SMISDataSet1.School”中。您可以根据需要移动或删除它。
            this.schoolTableAdapter.Fill(this.dB_SMISDataSet1.School);
            showlvmajor();
            comb_depart.Enabled = false;
            btn_save.Enabled = false;
        }

        public void showlvmajor()
        {
            lv_major.Clear();
            lv_major.Columns.Add("专业编号").Width = 140;
            lv_major.Columns.Add("专业名称").Width = 100;
            DBUtils dBUtils = new DBUtils();
            SqlConnection conn = dBUtils.DBConn();
            String sql1 = String.Format("select * from prgram");
            SqlCommand sqlCommand = new SqlCommand(sql1,conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = reader["id"].ToString();
                lv.SubItems.Add(reader["programname"].ToString());
                lv_major.Items.Add(lv);
            }
            conn.Close();
        }

        private void lv_major_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_major.SelectedIndices.Count==0)
            {
                return;
            }
            String schoolid = "";
            String id = lv_major.SelectedItems[0].Text;
            String name = lv_major.SelectedItems[0].SubItems[1].Text;
            DBUtils dBUtils = new DBUtils();
            SqlConnection conn = dBUtils.DBConn();
            String sql1 = String.Format("select * from prgram where id='{0}'",id);
            SqlCommand comm = new SqlCommand(sql1, conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                txt_id.Text = id;
                txt_name.Text = name;
                schoolid=reader["schoolid"].ToString();
                txt_year.Text = reader["majoryear"].ToString();
            }
            reader.Close();
            String sql2 = String.Format("select schoolname from school where id='{0}'",schoolid);
            SqlCommand comm1 = new SqlCommand(sql2, conn);
            object v = comm1.ExecuteScalar();
            comb_depart.Text = v.ToString();

            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_year.Text = "";
            btn_save.Enabled = true;
            comb_depart.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            comb_depart.Enabled = false;
            btn_save.Enabled = false;
            String sql = String.Format("select id from school where schoolname='{0}'", comb_depart.Text);
            DBUtils dBUtils = new DBUtils();
            SqlConnection conn = dBUtils.DBConn();
            SqlCommand comm = new SqlCommand(sql, conn);
            object v = comm.ExecuteScalar();
            String sid = v.ToString();
            if (txt_id.Text == "")
            {
                MessageBox.Show("专业编号不能为空");
                conn.Close();
                return;
            }
            String sql2 = String.Format("select * from prgram where id='{0}'", txt_id.Text);
            SqlCommand sqlCommand1 = new SqlCommand(sql2, conn);
            object v2 = sqlCommand1.ExecuteScalar();
            if (v2 != null)
            {
                MessageBox.Show("专业编号重复，请重新输入");
                conn.Close();
                return;
            }

            String sql1 = String.Format("insert into prgram values('{0}','{1}','{2}','{3}')", txt_id.Text, txt_name.Text,txt_year.Text, sid);
            SqlCommand sqlCommand = new SqlCommand(sql1, conn);
            int v1 = sqlCommand.ExecuteNonQuery();
            if (v1 > 0)
            {
                MessageBox.Show("增加成功");
                showlvmajor();

            }
            else
            {
                MessageBox.Show("增加失败");
                conn.Close();
   
                return;
            }
            conn.Close();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要删除这个节点吗？", "提示", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                String id = lv_major.SelectedItems[0].Text;
        
                String sql = String.Format("delete from prgram where id='{0}'", id);
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
                    ;
                }

                conn.Close();
                showlvmajor();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("专业编号不能为空");
                return;
            }

          
            SqlConnection conn = new DBUtils().DBConn();
            String sql1 = String.Format("update prgram set programname='{0}',majoryear='{1}' where id='{2}'", txt_name.Text, txt_year.Text, txt_id.Text);
            SqlCommand sqlCommand = new SqlCommand(sql1, conn);
            int v1 = sqlCommand.ExecuteNonQuery();
            if (v1 > 0)
            {
                MessageBox.Show("修改成功");
                showlvmajor();

            }
            else
            {
                MessageBox.Show("修改失败");
                conn.Close();
 
                return;
            }
            conn.Close();

        }
    }
}
