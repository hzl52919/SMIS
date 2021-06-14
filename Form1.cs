using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            toolStripStatusLabel3.Text = frmLogin.LoginName;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
           
         
            
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departseting_Click(object sender, EventArgs e)
        {
            frmSchool frmSchool = new frmSchool();
            frmSchool.ShowDialog();
        }

        private void 学生信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstudent frmstudent = new frmstudent();
            frmstudent.ShowDialog();
        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentSelect studentSelect = new studentSelect();
            studentSelect.ShowDialog();
        }

        private void 班级信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classForm classForm = new classForm();
            classForm.ShowDialog();
        }

        private void 专业信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            majorForm majorForm = new majorForm();
            majorForm.ShowDialog();
        }
    }
}
