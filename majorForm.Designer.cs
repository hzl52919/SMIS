
namespace WindowsFormsApp1
{
    partial class majorForm
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
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("专业编号");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("专业名称");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_major = new System.Windows.Forms.ListView();
            this.lab_id = new System.Windows.Forms.Label();
            this.lab_pname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comb_depart = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dB_SMISDataSet1 = new WindowsFormsApp1.DB_SMISDataSet1();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolTableAdapter = new WindowsFormsApp1.DB_SMISDataSet1TableAdapters.SchoolTableAdapter();
            this.prgramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prgramTableAdapter = new WindowsFormsApp1.DB_SMISDataSet1TableAdapters.PrgramTableAdapter();
            this.schoolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_updata = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMISDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_major);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "一览表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.txt_year);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.comb_depart);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lab_pname);
            this.groupBox2.Controls.Add(this.lab_id);
            this.groupBox2.Location = new System.Drawing.Point(329, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 320);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "专业信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_updata);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Location = new System.Drawing.Point(12, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // lv_major
            // 
            this.lv_major.FullRowSelect = true;
            this.lv_major.HideSelection = false;
            this.lv_major.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10});
            this.lv_major.Location = new System.Drawing.Point(6, 17);
            this.lv_major.MultiSelect = false;
            this.lv_major.Name = "lv_major";
            this.lv_major.Size = new System.Drawing.Size(261, 297);
            this.lv_major.TabIndex = 0;
            this.lv_major.UseCompatibleStateImageBehavior = false;
            this.lv_major.View = System.Windows.Forms.View.Details;
            this.lv_major.SelectedIndexChanged += new System.EventHandler(this.lv_major_SelectedIndexChanged);
            // 
            // lab_id
            // 
            this.lab_id.AutoSize = true;
            this.lab_id.Location = new System.Drawing.Point(38, 44);
            this.lab_id.Name = "lab_id";
            this.lab_id.Size = new System.Drawing.Size(53, 12);
            this.lab_id.TabIndex = 0;
            this.lab_id.Text = "专业编号";
            // 
            // lab_pname
            // 
            this.lab_pname.AutoSize = true;
            this.lab_pname.Location = new System.Drawing.Point(38, 91);
            this.lab_pname.Name = "lab_pname";
            this.lab_pname.Size = new System.Drawing.Size(53, 12);
            this.lab_pname.TabIndex = 1;
            this.lab_pname.Text = "专业名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "专业年份";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "所属学院";
            // 
            // comb_depart
            // 
            this.comb_depart.DataSource = this.schoolBindingSource1;
            this.comb_depart.DisplayMember = "SchoolName";
            this.comb_depart.FormattingEnabled = true;
            this.comb_depart.Location = new System.Drawing.Point(128, 187);
            this.comb_depart.Name = "comb_depart";
            this.comb_depart.Size = new System.Drawing.Size(121, 20);
            this.comb_depart.TabIndex = 4;
            this.comb_depart.ValueMember = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(128, 41);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 21);
            this.txt_id.TabIndex = 5;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(128, 132);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(100, 21);
            this.txt_year.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(128, 91);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 7;
            // 
            // dB_SMISDataSet1
            // 
            this.dB_SMISDataSet1.DataSetName = "DB_SMISDataSet1";
            this.dB_SMISDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataMember = "School";
            this.schoolBindingSource.DataSource = this.dB_SMISDataSet1;
            // 
            // schoolTableAdapter
            // 
            this.schoolTableAdapter.ClearBeforeFill = true;
            // 
            // prgramBindingSource
            // 
            this.prgramBindingSource.DataMember = "Prgram";
            this.prgramBindingSource.DataSource = this.dB_SMISDataSet1;
            // 
            // prgramTableAdapter
            // 
            this.prgramTableAdapter.ClearBeforeFill = true;
            // 
            // schoolBindingSource1
            // 
            this.schoolBindingSource1.DataMember = "School";
            this.schoolBindingSource1.DataSource = this.dB_SMISDataSet1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(511, 30);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 47);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "关闭";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(388, 30);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 47);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(257, 30);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 47);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_updata
            // 
            this.btn_updata.Location = new System.Drawing.Point(133, 30);
            this.btn_updata.Name = "btn_updata";
            this.btn_updata.Size = new System.Drawing.Size(75, 47);
            this.btn_updata.TabIndex = 4;
            this.btn_updata.Text = "更新";
            this.btn_updata.UseVisualStyleBackColor = true;
            this.btn_updata.Click += new System.EventHandler(this.btn_updata_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(22, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 47);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "增加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // majorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "majorForm";
            this.Text = "majorForm";
            this.Load += new System.EventHandler(this.majorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMISDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lv_major;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox comb_depart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_pname;
        private System.Windows.Forms.Label lab_id;
        private DB_SMISDataSet1 dB_SMISDataSet1;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private DB_SMISDataSet1TableAdapters.SchoolTableAdapter schoolTableAdapter;
        private System.Windows.Forms.BindingSource prgramBindingSource;
        private DB_SMISDataSet1TableAdapters.PrgramTableAdapter prgramTableAdapter;
        private System.Windows.Forms.BindingSource schoolBindingSource1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_updata;
        private System.Windows.Forms.Button btn_add;
    }
}