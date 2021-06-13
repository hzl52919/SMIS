
namespace WindowsFormsApp1
{
    partial class frmstudent
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvstudent = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSMISDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SMISDataSet1 = new WindowsFormsApp1.DB_SMISDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_first = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_front = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_updata = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comb_sex = new System.Windows.Forms.ComboBox();
            this.comb_polit = new System.Windows.Forms.ComboBox();
            this.txt_nation = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_birth = new System.Windows.Forms.TextBox();
            this.txt_identID = new System.Windows.Forms.TextBox();
            this.txt_home = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new WindowsFormsApp1.DB_SMISDataSet1TableAdapters.ClassTableAdapter();
            this.schoolTableAdapter = new WindowsFormsApp1.DB_SMISDataSet1TableAdapters.SchoolTableAdapter();
            this.prgramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prgramTableAdapter = new WindowsFormsApp1.DB_SMISDataSet1TableAdapters.PrgramTableAdapter();
            this.classBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_savepic = new System.Windows.Forms.Button();
            this.btn_chpic = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.stu_count = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSMISDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMISDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stu_count);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lvstudent);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "一览表";
            // 
            // lvstudent
            // 
            this.lvstudent.FullRowSelect = true;
            this.lvstudent.HideSelection = false;
            this.lvstudent.Location = new System.Drawing.Point(0, 32);
            this.lvstudent.Name = "lvstudent";
            this.lvstudent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvstudent.Size = new System.Drawing.Size(237, 345);
            this.lvstudent.TabIndex = 0;
            this.lvstudent.UseCompatibleStateImageBehavior = false;
            this.lvstudent.View = System.Windows.Forms.View.Details;
            this.lvstudent.SelectedIndexChanged += new System.EventHandler(this.lvstudent_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(260, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 48);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分类查询";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(176, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(77, 20);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.schoolBindingSource;
            this.comboBox3.DisplayMember = "SchoolName";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(42, 21);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(83, 20);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.ValueMember = "SchoolName";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataMember = "School";
            this.schoolBindingSource.DataSource = this.dBSMISDataSet1BindingSource;
            // 
            // dBSMISDataSet1BindingSource
            // 
            this.dBSMISDataSet1BindingSource.DataSource = this.dB_SMISDataSet1;
            this.dBSMISDataSet1BindingSource.Position = 0;
            // 
            // dB_SMISDataSet1
            // 
            this.dB_SMISDataSet1.DataSetName = "DB_SMISDataSet1";
            this.dB_SMISDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "班级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "专业：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "院部：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_first);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btn_last);
            this.groupBox3.Controls.Add(this.btn_next);
            this.groupBox3.Controls.Add(this.btn_front);
            this.groupBox3.Location = new System.Drawing.Point(260, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 57);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "浏览按钮";
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(21, 19);
            this.btn_first.Margin = new System.Windows.Forms.Padding(2);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(63, 28);
            this.btn_first.TabIndex = 5;
            this.btn_first.Text = "第一条";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 19);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "关闭";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(239, 19);
            this.btn_last.Margin = new System.Windows.Forms.Padding(2);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(76, 28);
            this.btn_last.TabIndex = 3;
            this.btn_last.Text = "最后一条";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(173, 19);
            this.btn_next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(59, 28);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "下一条";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_front
            // 
            this.btn_front.Location = new System.Drawing.Point(95, 20);
            this.btn_front.Margin = new System.Windows.Forms.Padding(2);
            this.btn_front.Name = "btn_front";
            this.btn_front.Size = new System.Drawing.Size(65, 27);
            this.btn_front.TabIndex = 1;
            this.btn_front.Text = "上一条";
            this.btn_front.UseVisualStyleBackColor = true;
            this.btn_front.Click += new System.EventHandler(this.btn_front_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_save);
            this.groupBox4.Controls.Add(this.btn_delete);
            this.groupBox4.Controls.Add(this.btn_cancel);
            this.groupBox4.Controls.Add(this.btn_updata);
            this.groupBox4.Controls.Add(this.btn_add);
            this.groupBox4.Location = new System.Drawing.Point(260, 352);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 42);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "操作按钮";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(321, 13);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 29);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(176, 13);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 29);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(249, 13);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(56, 29);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_updata
            // 
            this.btn_updata.Location = new System.Drawing.Point(95, 14);
            this.btn_updata.Margin = new System.Windows.Forms.Padding(2);
            this.btn_updata.Name = "btn_updata";
            this.btn_updata.Size = new System.Drawing.Size(56, 27);
            this.btn_updata.TabIndex = 5;
            this.btn_updata.Text = "修改";
            this.btn_updata.UseVisualStyleBackColor = true;
            this.btn_updata.Click += new System.EventHandler(this.btn_updata_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(21, 15);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 25);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.comb_sex);
            this.groupBox5.Controls.Add(this.comb_polit);
            this.groupBox5.Controls.Add(this.txt_nation);
            this.groupBox5.Controls.Add(this.txt_ID);
            this.groupBox5.Controls.Add(this.txt_name);
            this.groupBox5.Controls.Add(this.txt_birth);
            this.groupBox5.Controls.Add(this.txt_identID);
            this.groupBox5.Controls.Add(this.txt_home);
            this.groupBox5.Controls.Add(this.txt_phone);
            this.groupBox5.Controls.Add(this.txt_address);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(260, 78);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 205);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "学生基本信息";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(187, 69);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "性别";
            // 
            // comb_sex
            // 
            this.comb_sex.FormattingEnabled = true;
            this.comb_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comb_sex.Location = new System.Drawing.Point(226, 66);
            this.comb_sex.Margin = new System.Windows.Forms.Padding(2);
            this.comb_sex.Name = "comb_sex";
            this.comb_sex.Size = new System.Drawing.Size(46, 20);
            this.comb_sex.TabIndex = 19;
            // 
            // comb_polit
            // 
            this.comb_polit.FormattingEnabled = true;
            this.comb_polit.Items.AddRange(new object[] {
            "群众",
            "共青团员",
            "党员",
            "党委"});
            this.comb_polit.Location = new System.Drawing.Point(88, 99);
            this.comb_polit.Margin = new System.Windows.Forms.Padding(2);
            this.comb_polit.Name = "comb_polit";
            this.comb_polit.Size = new System.Drawing.Size(114, 20);
            this.comb_polit.TabIndex = 18;
            // 
            // txt_nation
            // 
            this.txt_nation.Location = new System.Drawing.Point(336, 65);
            this.txt_nation.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nation.Name = "txt_nation";
            this.txt_nation.Size = new System.Drawing.Size(76, 21);
            this.txt_nation.TabIndex = 17;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(88, 26);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(116, 21);
            this.txt_ID.TabIndex = 16;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(276, 26);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(137, 21);
            this.txt_name.TabIndex = 15;
            // 
            // txt_birth
            // 
            this.txt_birth.Location = new System.Drawing.Point(88, 66);
            this.txt_birth.Margin = new System.Windows.Forms.Padding(2);
            this.txt_birth.Name = "txt_birth";
            this.txt_birth.Size = new System.Drawing.Size(72, 21);
            this.txt_birth.TabIndex = 14;
            // 
            // txt_identID
            // 
            this.txt_identID.Location = new System.Drawing.Point(275, 99);
            this.txt_identID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_identID.Name = "txt_identID";
            this.txt_identID.Size = new System.Drawing.Size(137, 21);
            this.txt_identID.TabIndex = 13;
            // 
            // txt_home
            // 
            this.txt_home.Location = new System.Drawing.Point(88, 135);
            this.txt_home.Margin = new System.Windows.Forms.Padding(2);
            this.txt_home.Name = "txt_home";
            this.txt_home.Size = new System.Drawing.Size(120, 21);
            this.txt_home.TabIndex = 12;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(275, 135);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(137, 21);
            this.txt_phone.TabIndex = 11;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(88, 166);
            this.txt_address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(325, 21);
            this.txt_address.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "学号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "民族";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "出生日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "身份证号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "政治面貌";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "联系电话";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "籍贯";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 169);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "家庭地址";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.dBSMISDataSet1BindingSource;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // schoolTableAdapter
            // 
            this.schoolTableAdapter.ClearBeforeFill = true;
            // 
            // prgramBindingSource
            // 
            this.prgramBindingSource.DataMember = "Prgram";
            this.prgramBindingSource.DataSource = this.dBSMISDataSet1BindingSource;
            // 
            // prgramTableAdapter
            // 
            this.prgramTableAdapter.ClearBeforeFill = true;
            // 
            // classBindingSource1
            // 
            this.classBindingSource1.DataMember = "Class";
            this.classBindingSource1.DataSource = this.dBSMISDataSet1BindingSource;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(718, 18);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(218, 314);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btn_savepic
            // 
            this.btn_savepic.Location = new System.Drawing.Point(844, 352);
            this.btn_savepic.Margin = new System.Windows.Forms.Padding(2);
            this.btn_savepic.Name = "btn_savepic";
            this.btn_savepic.Size = new System.Drawing.Size(73, 36);
            this.btn_savepic.TabIndex = 2;
            this.btn_savepic.Text = "保存";
            this.btn_savepic.UseVisualStyleBackColor = true;
            this.btn_savepic.Click += new System.EventHandler(this.btn_savepic_Click);
            // 
            // btn_chpic
            // 
            this.btn_chpic.Location = new System.Drawing.Point(743, 352);
            this.btn_chpic.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chpic.Name = "btn_chpic";
            this.btn_chpic.Size = new System.Drawing.Size(76, 36);
            this.btn_chpic.TabIndex = 3;
            this.btn_chpic.Text = "选择文件";
            this.btn_chpic.UseVisualStyleBackColor = true;
            this.btn_chpic.Click += new System.EventHandler(this.btn_chpic_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "学生人数：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(114, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 12);
            this.label15.TabIndex = 2;
            // 
            // stu_count
            // 
            this.stu_count.AutoSize = true;
            this.stu_count.Location = new System.Drawing.Point(103, 18);
            this.stu_count.Name = "stu_count";
            this.stu_count.Size = new System.Drawing.Size(11, 12);
            this.stu_count.TabIndex = 3;
            this.stu_count.Text = "0";
            // 
            // frmstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 406);
            this.Controls.Add(this.btn_chpic);
            this.Controls.Add(this.btn_savepic);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmstudent";
            this.Text = "frmstudent";
            this.Load += new System.EventHandler(this.frmstudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSMISDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMISDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvstudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dBSMISDataSet1BindingSource;
        private DB_SMISDataSet1 dB_SMISDataSet1;
        private System.Windows.Forms.BindingSource classBindingSource;
        private DB_SMISDataSet1TableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private DB_SMISDataSet1TableAdapters.SchoolTableAdapter schoolTableAdapter;
        private System.Windows.Forms.BindingSource prgramBindingSource;
        private DB_SMISDataSet1TableAdapters.PrgramTableAdapter prgramTableAdapter;
        private System.Windows.Forms.BindingSource classBindingSource1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_front;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_updata;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comb_sex;
        private System.Windows.Forms.ComboBox comb_polit;
        private System.Windows.Forms.TextBox txt_nation;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_birth;
        private System.Windows.Forms.TextBox txt_identID;
        private System.Windows.Forms.TextBox txt_home;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_savepic;
        private System.Windows.Forms.Button btn_chpic;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label stu_count;
    }
}