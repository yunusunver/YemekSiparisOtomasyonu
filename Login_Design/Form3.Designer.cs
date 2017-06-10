namespace Login_Design
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.yenilebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuGuncellebtn = new System.Windows.Forms.Button();
            this.menuSilbtn = new System.Windows.Forms.Button();
            this.menuEklebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menufirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuismiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menufiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denemeYemekDataSet3 = new Login_Design.DenemeYemekDataSet3();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adreslbl = new System.Windows.Forms.Label();
            this.telefonlbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.sehirlbl = new System.Windows.Forms.Label();
            this.firmaadilbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuTableAdapter = new Login_Design.DenemeYemekDataSet3TableAdapters.MenuTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.denemeYemekDataSet6 = new Login_Design.DenemeYemekDataSet6();
            this.siparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisTableAdapter = new Login_Design.DenemeYemekDataSet6TableAdapters.SiparisTableAdapter();
            this.siparisidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparistarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisfiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeYemekDataSet3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeYemekDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.yenilebtn);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.menuGuncellebtn);
            this.tabPage1.Controls.Add(this.menuSilbtn);
            this.tabPage1.Controls.Add(this.menuEklebtn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menüler";
            // 
            // yenilebtn
            // 
            this.yenilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenilebtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.yenilebtn.Image = ((System.Drawing.Image)(resources.GetObject("yenilebtn.Image")));
            this.yenilebtn.Location = new System.Drawing.Point(436, 0);
            this.yenilebtn.Name = "yenilebtn";
            this.yenilebtn.Size = new System.Drawing.Size(83, 29);
            this.yenilebtn.TabIndex = 5;
            this.yenilebtn.UseVisualStyleBackColor = true;
            this.yenilebtn.Click += new System.EventHandler(this.yenilebtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(436, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 82);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuGuncellebtn
            // 
            this.menuGuncellebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuGuncellebtn.BackgroundImage")));
            this.menuGuncellebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuGuncellebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.menuGuncellebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuGuncellebtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuGuncellebtn.Location = new System.Drawing.Point(436, 192);
            this.menuGuncellebtn.Name = "menuGuncellebtn";
            this.menuGuncellebtn.Size = new System.Drawing.Size(83, 82);
            this.menuGuncellebtn.TabIndex = 3;
            this.menuGuncellebtn.UseVisualStyleBackColor = true;
            this.menuGuncellebtn.Click += new System.EventHandler(this.menuGuncellebtn_Click);
            // 
            // menuSilbtn
            // 
            this.menuSilbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuSilbtn.BackgroundImage")));
            this.menuSilbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuSilbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.menuSilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuSilbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuSilbtn.Location = new System.Drawing.Point(436, 110);
            this.menuSilbtn.Name = "menuSilbtn";
            this.menuSilbtn.Size = new System.Drawing.Size(83, 82);
            this.menuSilbtn.TabIndex = 2;
            this.menuSilbtn.UseVisualStyleBackColor = true;
            this.menuSilbtn.Click += new System.EventHandler(this.menuSilbtn_Click);
            // 
            // menuEklebtn
            // 
            this.menuEklebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuEklebtn.BackgroundImage")));
            this.menuEklebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuEklebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.menuEklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuEklebtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuEklebtn.Location = new System.Drawing.Point(436, 28);
            this.menuEklebtn.Name = "menuEklebtn";
            this.menuEklebtn.Size = new System.Drawing.Size(83, 82);
            this.menuEklebtn.TabIndex = 1;
            this.menuEklebtn.UseVisualStyleBackColor = true;
            this.menuEklebtn.Click += new System.EventHandler(this.menuEklebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuidDataGridViewTextBoxColumn,
            this.menufirmaDataGridViewTextBoxColumn,
            this.menuismiDataGridViewTextBoxColumn,
            this.menufiyatıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menuBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuidDataGridViewTextBoxColumn
            // 
            this.menuidDataGridViewTextBoxColumn.DataPropertyName = "menuid";
            this.menuidDataGridViewTextBoxColumn.HeaderText = "menuid";
            this.menuidDataGridViewTextBoxColumn.Name = "menuidDataGridViewTextBoxColumn";
            this.menuidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menufirmaDataGridViewTextBoxColumn
            // 
            this.menufirmaDataGridViewTextBoxColumn.DataPropertyName = "menufirma";
            this.menufirmaDataGridViewTextBoxColumn.HeaderText = "menufirma";
            this.menufirmaDataGridViewTextBoxColumn.Name = "menufirmaDataGridViewTextBoxColumn";
            this.menufirmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuismiDataGridViewTextBoxColumn
            // 
            this.menuismiDataGridViewTextBoxColumn.DataPropertyName = "menuismi";
            this.menuismiDataGridViewTextBoxColumn.HeaderText = "menuismi";
            this.menuismiDataGridViewTextBoxColumn.Name = "menuismiDataGridViewTextBoxColumn";
            this.menuismiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menufiyatıDataGridViewTextBoxColumn
            // 
            this.menufiyatıDataGridViewTextBoxColumn.DataPropertyName = "menufiyatı";
            this.menufiyatıDataGridViewTextBoxColumn.HeaderText = "menufiyatı";
            this.menufiyatıDataGridViewTextBoxColumn.Name = "menufiyatıDataGridViewTextBoxColumn";
            this.menufiyatıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.denemeYemekDataSet3;
            // 
            // denemeYemekDataSet3
            // 
            this.denemeYemekDataSet3.DataSetName = "DenemeYemekDataSet3";
            this.denemeYemekDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Siparişler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.adreslbl);
            this.tabPage3.Controls.Add(this.telefonlbl);
            this.tabPage3.Controls.Add(this.emaillbl);
            this.tabPage3.Controls.Add(this.sehirlbl);
            this.tabPage3.Controls.Add(this.firmaadilbl);
            this.tabPage3.Controls.Add(this.passwordlbl);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.usernamelbl);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(519, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kullanıcı Bilgileri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(347, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(438, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adreslbl
            // 
            this.adreslbl.AutoSize = true;
            this.adreslbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adreslbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.adreslbl.Location = new System.Drawing.Point(344, 275);
            this.adreslbl.Name = "adreslbl";
            this.adreslbl.Size = new System.Drawing.Size(0, 18);
            this.adreslbl.TabIndex = 13;
            // 
            // telefonlbl
            // 
            this.telefonlbl.AutoSize = true;
            this.telefonlbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefonlbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.telefonlbl.Location = new System.Drawing.Point(344, 237);
            this.telefonlbl.Name = "telefonlbl";
            this.telefonlbl.Size = new System.Drawing.Size(0, 18);
            this.telefonlbl.TabIndex = 12;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emaillbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.emaillbl.Location = new System.Drawing.Point(344, 198);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(0, 18);
            this.emaillbl.TabIndex = 11;
            // 
            // sehirlbl
            // 
            this.sehirlbl.AutoSize = true;
            this.sehirlbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sehirlbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sehirlbl.Location = new System.Drawing.Point(117, 275);
            this.sehirlbl.Name = "sehirlbl";
            this.sehirlbl.Size = new System.Drawing.Size(0, 18);
            this.sehirlbl.TabIndex = 10;
            // 
            // firmaadilbl
            // 
            this.firmaadilbl.AutoSize = true;
            this.firmaadilbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmaadilbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.firmaadilbl.Location = new System.Drawing.Point(117, 237);
            this.firmaadilbl.Name = "firmaadilbl";
            this.firmaadilbl.Size = new System.Drawing.Size(0, 18);
            this.firmaadilbl.TabIndex = 9;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordlbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.passwordlbl.Location = new System.Drawing.Point(117, 198);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(78, 18);
            this.passwordlbl.TabIndex = 8;
            this.passwordlbl.Text = "*******";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(251, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(251, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(251, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(17, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(17, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Firma Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(17, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernamelbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.usernamelbl.Location = new System.Drawing.Point(221, 154);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(0, 23);
            this.usernamelbl.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisidDataGridViewTextBoxColumn,
            this.siparisadiDataGridViewTextBoxColumn,
            this.siparistarihiDataGridViewTextBoxColumn,
            this.musteriDataGridViewTextBoxColumn,
            this.siparisfiyatıDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.siparisBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 15;
            this.dataGridView2.Size = new System.Drawing.Size(519, 193);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // denemeYemekDataSet6
            // 
            this.denemeYemekDataSet6.DataSetName = "DenemeYemekDataSet6";
            this.denemeYemekDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisBindingSource
            // 
            this.siparisBindingSource.DataMember = "Siparis";
            this.siparisBindingSource.DataSource = this.denemeYemekDataSet6;
            // 
            // siparisTableAdapter
            // 
            this.siparisTableAdapter.ClearBeforeFill = true;
            // 
            // siparisidDataGridViewTextBoxColumn
            // 
            this.siparisidDataGridViewTextBoxColumn.DataPropertyName = "siparisid";
            this.siparisidDataGridViewTextBoxColumn.HeaderText = "siparisid";
            this.siparisidDataGridViewTextBoxColumn.Name = "siparisidDataGridViewTextBoxColumn";
            this.siparisidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisadiDataGridViewTextBoxColumn
            // 
            this.siparisadiDataGridViewTextBoxColumn.DataPropertyName = "siparisadi";
            this.siparisadiDataGridViewTextBoxColumn.HeaderText = "siparisadi";
            this.siparisadiDataGridViewTextBoxColumn.Name = "siparisadiDataGridViewTextBoxColumn";
            this.siparisadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparistarihiDataGridViewTextBoxColumn
            // 
            this.siparistarihiDataGridViewTextBoxColumn.DataPropertyName = "siparistarihi";
            this.siparistarihiDataGridViewTextBoxColumn.HeaderText = "siparistarihi";
            this.siparistarihiDataGridViewTextBoxColumn.Name = "siparistarihiDataGridViewTextBoxColumn";
            this.siparistarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriDataGridViewTextBoxColumn
            // 
            this.musteriDataGridViewTextBoxColumn.DataPropertyName = "musteri";
            this.musteriDataGridViewTextBoxColumn.HeaderText = "musteri";
            this.musteriDataGridViewTextBoxColumn.Name = "musteriDataGridViewTextBoxColumn";
            this.musteriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisfiyatıDataGridViewTextBoxColumn
            // 
            this.siparisfiyatıDataGridViewTextBoxColumn.DataPropertyName = "siparisfiyatı";
            this.siparisfiyatıDataGridViewTextBoxColumn.HeaderText = "siparisfiyatı";
            this.siparisfiyatıDataGridViewTextBoxColumn.Name = "siparisfiyatıDataGridViewTextBoxColumn";
            this.siparisfiyatıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(6, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(72, 196);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(551, 413);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeYemekDataSet3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeYemekDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private DenemeYemekDataSet3 denemeYemekDataSet3;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private DenemeYemekDataSet3TableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menufirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuismiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menufiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button menuSilbtn;
        private System.Windows.Forms.Button menuEklebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button menuGuncellebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label adreslbl;
        private System.Windows.Forms.Label telefonlbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label sehirlbl;
        private System.Windows.Forms.Label firmaadilbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button yenilebtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DenemeYemekDataSet6 denemeYemekDataSet6;
        private System.Windows.Forms.BindingSource siparisBindingSource;
        private DenemeYemekDataSet6TableAdapters.SiparisTableAdapter siparisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparistarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisfiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}