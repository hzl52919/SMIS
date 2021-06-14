
namespace WindowsFormsApp1
{
    partial class studentSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stuid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lab_sex = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_birth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_class = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_major = new System.Windows.Forms.Label();
            this.lab_stuname = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lab_depart = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(174, 6);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(57, 39);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "学生学号：";
            // 
            // txt_stuid
            // 
            this.txt_stuid.Location = new System.Drawing.Point(62, 16);
            this.txt_stuid.Name = "txt_stuid";
            this.txt_stuid.Size = new System.Drawing.Size(106, 21);
            this.txt_stuid.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lab_depart);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lab_stuname);
            this.groupBox1.Controls.Add(this.lab_major);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lab_class);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lab_birth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lab_sex);
            this.groupBox1.Location = new System.Drawing.Point(5, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Location = new System.Drawing.Point(5, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 340);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "照片";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 17);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(208, 320);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lab_sex
            // 
            this.lab_sex.AutoSize = true;
            this.lab_sex.Location = new System.Drawing.Point(101, 69);
            this.lab_sex.Name = "lab_sex";
            this.lab_sex.Size = new System.Drawing.Size(0, 12);
            this.lab_sex.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "性别";
            // 
            // lab_birth
            // 
            this.lab_birth.AutoSize = true;
            this.lab_birth.Location = new System.Drawing.Point(101, 100);
            this.lab_birth.Name = "lab_birth";
            this.lab_birth.Size = new System.Drawing.Size(0, 12);
            this.lab_birth.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "生日";
            // 
            // lab_class
            // 
            this.lab_class.AutoSize = true;
            this.lab_class.Location = new System.Drawing.Point(101, 134);
            this.lab_class.Name = "lab_class";
            this.lab_class.Size = new System.Drawing.Size(0, 12);
            this.lab_class.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "班级";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "专业";
            // 
            // lab_major
            // 
            this.lab_major.AutoSize = true;
            this.lab_major.Location = new System.Drawing.Point(101, 169);
            this.lab_major.Name = "lab_major";
            this.lab_major.Size = new System.Drawing.Size(0, 12);
            this.lab_major.TabIndex = 7;
            // 
            // lab_stuname
            // 
            this.lab_stuname.AutoSize = true;
            this.lab_stuname.Location = new System.Drawing.Point(101, 37);
            this.lab_stuname.Name = "lab_stuname";
            this.lab_stuname.Size = new System.Drawing.Size(0, 12);
            this.lab_stuname.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "学生姓名";
            // 
            // lab_depart
            // 
            this.lab_depart.AutoSize = true;
            this.lab_depart.Location = new System.Drawing.Point(101, 196);
            this.lab_depart.Name = "lab_depart";
            this.lab_depart.Size = new System.Drawing.Size(0, 12);
            this.lab_depart.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "院系";
            // 
            // studentSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_stuid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_select);
            this.Name = "studentSelect";
            this.Text = "studentSelect";
            this.Load += new System.EventHandler(this.studentSelect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_stuid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lab_depart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lab_stuname;
        private System.Windows.Forms.Label lab_major;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_class;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_birth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_sex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}