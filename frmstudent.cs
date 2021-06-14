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
    public partial class frmstudent : Form
    {
        public frmstudent()
        {
            InitializeComponent();
        }
        private void frmstudent_Load(object sender, EventArgs e)
        {

            // TODO: 这行代码将数据加载到表“dB_SMISDataSet1.School”中。您可以根据需要移动或删除它。
            this.schoolTableAdapter.Fill(this.dB_SMISDataSet1.School);
            bindprm();
            btn_chpic.Enabled = false;
            btn_savepic.Enabled = false;
            btn_save.Enabled = false;
        }

        public void showlistview()
        {

            lvstudent.Clear();
            if (comboBox3.Text != "" && comboBox2.Text != "" && comboBox1.Text != "")
            {
                lvstudent.Columns.Clear();
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
                int count = lvstudent.Items.Count;
                stu_count.Text = count.ToString();
                sqlConnection.Close();
            }
        }
     

        private void lvstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_chpic.Enabled = true;
            btn_savepic.Enabled = true;
            pictureBox.Image = null;
            if (lvstudent.SelectedIndices.Count==0)
            {
                return;
            }
            string id = lvstudent.SelectedItems[0].Text;
            txt_ID.Enabled = false;
            DBUtils dBUtils = new DBUtils();
            SqlConnection sqlConnection = dBUtils.DBConn();
            String sql = String.Format("select * from student where id='{0}'", id);
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            String birth = "";
            String gender = "";
            String ethricity = "";
            String politicalstaus = "";
            String idcard = "";
            String po = "";
            String phone = "";
            String address = "";
            String name = "";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
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
                birth=dateTime.ToString("yyyy-MM-dd");
                MessageBox.Show(birth);
            }
                gender=reader.GetString(reader.GetOrdinal("gender"));
                ethricity=reader.GetString(reader.GetOrdinal("ethnicity"));
                politicalstaus=reader.GetString(reader.GetOrdinal("politicalstaus"));
                idcard=reader.GetString(reader.GetOrdinal("idcard"));
                po=reader.GetString(reader.GetOrdinal("placeoforigin"));
                phone=reader.GetString(reader.GetOrdinal("phone"));
                address=reader.GetString(reader.GetOrdinal("address"));
                name=reader.GetString(reader.GetOrdinal("studentname"));
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
                

            txt_address.Text = address;
            txt_birth.Text = birth;
            txt_home.Text = po;
            txt_ID.Text = id;
            txt_name.Text = name;
            txt_identID.Text = idcard;
            txt_nation.Text = ethricity;
            txt_phone.Text = phone;
            comb_sex.Text = gender;
            comb_polit.Text = politicalstaus;
            
            }
            sqlConnection.Close();
        }
       
        public void cleanstuInfo()
        {
            txt_address.Text = "";
            txt_birth.Text = "";
            txt_home.Text = "";
            txt_ID.Text = "";
            txt_name.Text = "";
            txt_identID.Text = "";
            txt_nation.Text ="";
            txt_phone.Text = "";
            comb_sex.Text = "";
            comb_polit.Text = "";
            btn_chpic.Enabled = false;
            btn_savepic.Enabled = false;
            pictureBox.Image = null;
            lvstudent.Items.Clear();
            btn_save.Enabled = false;
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

       
       
   
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanstuInfo();
           


            comboBox2.Text = "";
            comboBox2.Items.Clear();
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            
            bindprm();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanstuInfo();

            comboBox1.Text = "";
            comboBox1.Items.Clear();
            bindclass();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanstuInfo();

            showlistview();
          
        }

        private void btn_chpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = " 请选择客户端longin的图片";
            openfile.Filter = "Login图片 (*.jpg;*.bmp;*png)|*.jpeg;*.jpg;*.bmp;*.png|AllFiles(*.*)|*.*";
            if (DialogResult.OK==openfile.ShowDialog())
            {
                try
                {
                    Bitmap bmp = new Bitmap(openfile.FileName);
                    pictureBox.Image = bmp;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    //字面是对当前图片进行了二进制转换
                    MemoryStream ms = new MemoryStream();
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    byte[] arr = new byte[ms.Length];
                    ms.Seek(0, SeekOrigin.Begin);
                    ms.Read(arr, 0, (int)ms.Length);
                    ms.Close();
                    //直接返这个值放到数据就行了
                    string ee = Convert.ToBase64String(arr);
                }
                catch { }
            }
        }
        public byte[] PhotoImageInsert(System.Drawing.Image imgPhoto)
        {
            //将Image转换成流数据，并保存为byte[] 
            MemoryStream mstream = new MemoryStream();
            imgPhoto.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] byData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byData, 0, byData.Length);
            mstream.Close();
            return byData;
        }
        private void btn_savepic_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = PhotoImageInsert(pictureBox.Image);
            String sql = "update student set photo=@photo where ID = @id";
            DBUtils dBUtils = new DBUtils();
            SqlConnection sqlConnection = dBUtils.DBConn();
            SqlCommand comm = new SqlCommand(sql,sqlConnection);
            comm.Parameters.Add("@photo",SqlDbType.Image);
            comm.Parameters["@photo"].Value = imageBytes;
            comm.Parameters.Add("@id", SqlDbType.NVarChar);
            comm.Parameters["@id"].Value = txt_ID.Text;
            int v = comm.ExecuteNonQuery();
            if (v>0)
            {
                MessageBox.Show("照片输入成功");
            }
            else
            {
                MessageBox.Show("照片输入失败");
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            if (lvstudent.SelectedItems.Count>0)
            {
                lvstudent.Items[lvstudent.SelectedIndices[0]].Selected=false;
                lvstudent.Items[0].Selected = true;
                lvstudent.Focus();
            }
            else
            {
                if (lvstudent.Items.Count>0)
            {
                lvstudent.Items[0].Selected = true;
                lvstudent.Focus();
            }
            }
            

        }

        private void btn_front_Click(object sender, EventArgs e)
        {

            int count = lvstudent.Items.Count;
            if (lvstudent.SelectedIndices.Count>0)
            {
                int index = lvstudent.SelectedIndices[0];
                if (count>0&&index!=0)
                    {
                    lvstudent.Items[index - 1].Selected = true;
                    lvstudent.Items[index].Selected = false;
                    lvstudent.Focus();
                    }
            }
            else
            {
                MessageBox.Show("请先选择一项");
            }
            
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int count = lvstudent.Items.Count;
            if (lvstudent.SelectedIndices.Count > 0)
            {
                int index = lvstudent.SelectedIndices[0];
                if (count > 0 && index < count-1)
                {
                    lvstudent.Items[index+1].Selected = true;
                    lvstudent.Items[index].Selected = false;
                    lvstudent.Focus();
                }
            }
            else
            {
                MessageBox.Show("请先选择一项");
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int count = lvstudent.Items.Count;
            if (lvstudent.SelectedItems.Count > 0)
            {
                lvstudent.Items[lvstudent.SelectedIndices[0]].Selected = false;
                lvstudent.Items[count-1].Selected = true;
                lvstudent.Focus();
            }else
            {
                if (lvstudent.Items.Count > 0)
                {
                    lvstudent.Items[count-1].Selected = true;
                    lvstudent.Focus();
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text!=""&&comboBox2.Text!=""&&comboBox3.Text!="")
            {
                txt_ID.Enabled = true;
                txt_birth.Text = "";
                txt_home.Text = "";
                txt_ID.Text = "";
                txt_name.Text = "";
                txt_identID.Text = "";
                txt_nation.Text = "";
                txt_phone.Text = "";
                comb_sex.Text = "";
                comb_polit.Text = "";
                txt_address.Text = "";
                btn_save.Enabled = true;
                pictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("请选择学院，专业，班级");
            }
           
 
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text==""&&txt_name.Text=="")
            {
                MessageBox.Show("学号或姓名不能为空");
                showlistview();
                return;
            }
            DBUtils dBUtils = new DBUtils();
            SqlConnection sqlConnection = dBUtils.DBConn();

            String idsql= String.Format("select id from student where id='{0}'", txt_ID.Text);
            SqlCommand sqlCommand1 = new SqlCommand(idsql, sqlConnection);
            object selectid = sqlCommand1.ExecuteScalar();
            if (selectid!=null)
            {
                MessageBox.Show("该ID号已被注册，请重新输入");
                showlistview();
                sqlConnection.Close();
                return;
            }
           
            String sql = String.Format("select id from class where classname='{0}'",comboBox1.Text);
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            object v = sqlCommand.ExecuteScalar();
            String sql1 = String.Format("insert into student(id,studentname,birth,gender,ethnicity,politicalstaus,idcard,placeoforigin,phone,address,classid) " +
            "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
            txt_ID.Text, txt_name.Text, txt_birth.Text, comb_sex.Text, txt_nation.Text, comb_polit.Text, txt_identID.Text, txt_home.Text, txt_phone.Text, txt_address.Text, v.ToString());


            
           
            SqlCommand com1 = new SqlCommand(sql1, sqlConnection);
            int v1 = com1.ExecuteNonQuery();
            if (v1>0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            btn_save.Enabled = false;
            txt_ID.Enabled = false;
            showlistview();
            sqlConnection.Close();
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            if (lvstudent.SelectedIndices.Count==0)
            {
                MessageBox.Show("请先选择一个学生");
                return;
            }
            DBUtils dBUtils = new DBUtils();
            SqlConnection sqlConnection = dBUtils.DBConn();
            String sql = String.Format("update student set studentname=" +
                "'{0}',birth='{1}',gender='{2}',ethnicity='{3}',politicalstaus='{4}',idcard='{5}',placeoforigin='{6}',address='{7}',phone='{8}' where id='{9}'",
                 txt_name.Text, txt_birth.Text, comb_sex.Text, txt_nation.Text, comb_polit.Text, txt_identID.Text, txt_home.Text, txt_address.Text, txt_phone.Text,txt_ID.Text);

            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            int v = sqlCommand.ExecuteNonQuery();
            if (v>0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            sqlConnection.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要删除这个节点吗？", "提示", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                String id = txt_ID.Text;
                String sql = "delete from student where id=@id";
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
                showlistview();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cleanstuInfo();
        }
    }
}
