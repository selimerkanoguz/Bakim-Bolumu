namespace Bakım_Bölümü
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vardiya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ekleyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enduktif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapasitif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnduktifDeger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KapasitifDeger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.kutu_ilkkapasitifyuzde = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.kutu_ilkenduktiftyuzde = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yeni_kapasitifyuzde = new System.Windows.Forms.Label();
            this.yeni_kapasitif = new System.Windows.Forms.TextBox();
            this.yeni_enduktifyuzde = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kutu_ilkkapasitif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kutu_ilkenduktif = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kutu_ilkaktif = new System.Windows.Forms.TextBox();
            this.c_ayilk = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kutu_kapasitif = new System.Windows.Forms.TextBox();
            this.kutu_enduktif = new System.Windows.Forms.TextBox();
            this.kutu_aktif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.zg2 = new ZedGraph.ZedGraphControl();
            this.button3 = new System.Windows.Forms.Button();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(186, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Örn: xx.x";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(186, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Örn: xxx.x";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Örn: xxxx.x";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarih,
            this.Vardiya,
            this.Ekleyen,
            this.Enduktif,
            this.Kapasitif,
            this.Id,
            this.Aktif,
            this.EnduktifDeger,
            this.KapasitifDeger});
            this.dataGridView1.Location = new System.Drawing.Point(14, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 218);
            this.dataGridView1.TabIndex = 48;
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.Width = 70;
            // 
            // Vardiya
            // 
            this.Vardiya.HeaderText = "Vardiya";
            this.Vardiya.Name = "Vardiya";
            this.Vardiya.Width = 80;
            // 
            // Ekleyen
            // 
            this.Ekleyen.HeaderText = "Ekleyen";
            this.Ekleyen.Name = "Ekleyen";
            this.Ekleyen.Width = 102;
            // 
            // Enduktif
            // 
            this.Enduktif.HeaderText = "Endüktif%";
            this.Enduktif.Name = "Enduktif";
            this.Enduktif.Width = 60;
            // 
            // Kapasitif
            // 
            this.Kapasitif.HeaderText = "Kapasitif%";
            this.Kapasitif.Name = "Kapasitif";
            this.Kapasitif.Width = 60;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 5;
            // 
            // Aktif
            // 
            this.Aktif.HeaderText = "Aktif";
            this.Aktif.Name = "Aktif";
            this.Aktif.Width = 60;
            // 
            // EnduktifDeger
            // 
            this.EnduktifDeger.HeaderText = "Endüktif";
            this.EnduktifDeger.Name = "EnduktifDeger";
            this.EnduktifDeger.Width = 60;
            // 
            // KapasitifDeger
            // 
            this.KapasitifDeger.HeaderText = "Kapasitif";
            this.KapasitifDeger.Name = "KapasitifDeger";
            this.KapasitifDeger.Width = 60;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.kutu_ilkkapasitifyuzde);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.kutu_ilkenduktiftyuzde);
            this.groupBox3.Location = new System.Drawing.Point(206, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 80);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Önceki  Yüzdeler";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Kapasitif %";
            // 
            // kutu_ilkkapasitifyuzde
            // 
            this.kutu_ilkkapasitifyuzde.Enabled = false;
            this.kutu_ilkkapasitifyuzde.Location = new System.Drawing.Point(74, 49);
            this.kutu_ilkkapasitifyuzde.Name = "kutu_ilkkapasitifyuzde";
            this.kutu_ilkkapasitifyuzde.Size = new System.Drawing.Size(100, 20);
            this.kutu_ilkkapasitifyuzde.TabIndex = 25;
            this.kutu_ilkkapasitifyuzde.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Endüktif %";
            // 
            // kutu_ilkenduktiftyuzde
            // 
            this.kutu_ilkenduktiftyuzde.Enabled = false;
            this.kutu_ilkenduktiftyuzde.Location = new System.Drawing.Point(74, 23);
            this.kutu_ilkenduktiftyuzde.Name = "kutu_ilkenduktiftyuzde";
            this.kutu_ilkenduktiftyuzde.Size = new System.Drawing.Size(100, 20);
            this.kutu_ilkenduktiftyuzde.TabIndex = 24;
            this.kutu_ilkenduktiftyuzde.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yeni_kapasitifyuzde);
            this.groupBox1.Controls.Add(this.yeni_kapasitif);
            this.groupBox1.Controls.Add(this.yeni_enduktifyuzde);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(424, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 80);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Değer Sonrası Yüzdeler";
            // 
            // yeni_kapasitifyuzde
            // 
            this.yeni_kapasitifyuzde.AutoSize = true;
            this.yeni_kapasitifyuzde.Location = new System.Drawing.Point(7, 46);
            this.yeni_kapasitifyuzde.Name = "yeni_kapasitifyuzde";
            this.yeni_kapasitifyuzde.Size = new System.Drawing.Size(58, 13);
            this.yeni_kapasitifyuzde.TabIndex = 18;
            this.yeni_kapasitifyuzde.Text = "Kapasitif %";
            // 
            // yeni_kapasitif
            // 
            this.yeni_kapasitif.Enabled = false;
            this.yeni_kapasitif.Location = new System.Drawing.Point(72, 45);
            this.yeni_kapasitif.Name = "yeni_kapasitif";
            this.yeni_kapasitif.Size = new System.Drawing.Size(100, 20);
            this.yeni_kapasitif.TabIndex = 21;
            this.yeni_kapasitif.Text = "0";
            // 
            // yeni_enduktifyuzde
            // 
            this.yeni_enduktifyuzde.Enabled = false;
            this.yeni_enduktifyuzde.Location = new System.Drawing.Point(72, 19);
            this.yeni_enduktifyuzde.Name = "yeni_enduktifyuzde";
            this.yeni_enduktifyuzde.Size = new System.Drawing.Size(100, 20);
            this.yeni_enduktifyuzde.TabIndex = 20;
            this.yeni_enduktifyuzde.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Endüktif %";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.kutu_ilkkapasitif);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.kutu_ilkenduktif);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.kutu_ilkaktif);
            this.groupBox2.Location = new System.Drawing.Point(2, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 99);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ayın İlk Değerleri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kapasitif";
            // 
            // kutu_ilkkapasitif
            // 
            this.kutu_ilkkapasitif.Enabled = false;
            this.kutu_ilkkapasitif.Location = new System.Drawing.Point(71, 66);
            this.kutu_ilkkapasitif.Name = "kutu_ilkkapasitif";
            this.kutu_ilkkapasitif.Size = new System.Drawing.Size(100, 20);
            this.kutu_ilkkapasitif.TabIndex = 21;
            this.kutu_ilkkapasitif.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Aktif";
            // 
            // kutu_ilkenduktif
            // 
            this.kutu_ilkenduktif.Enabled = false;
            this.kutu_ilkenduktif.Location = new System.Drawing.Point(71, 40);
            this.kutu_ilkenduktif.Name = "kutu_ilkenduktif";
            this.kutu_ilkenduktif.Size = new System.Drawing.Size(100, 20);
            this.kutu_ilkenduktif.TabIndex = 20;
            this.kutu_ilkenduktif.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Endüktif";
            // 
            // kutu_ilkaktif
            // 
            this.kutu_ilkaktif.Enabled = false;
            this.kutu_ilkaktif.Location = new System.Drawing.Point(71, 14);
            this.kutu_ilkaktif.Name = "kutu_ilkaktif";
            this.kutu_ilkaktif.Size = new System.Drawing.Size(100, 20);
            this.kutu_ilkaktif.TabIndex = 19;
            this.kutu_ilkaktif.Text = "0";
            // 
            // c_ayilk
            // 
            this.c_ayilk.AutoSize = true;
            this.c_ayilk.Location = new System.Drawing.Point(18, 154);
            this.c_ayilk.Name = "c_ayilk";
            this.c_ayilk.Size = new System.Drawing.Size(94, 17);
            this.c_ayilk.TabIndex = 44;
            this.c_ayilk.Text = "Ayın İlk Değeri";
            this.c_ayilk.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 61);
            this.button1.TabIndex = 43;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ekleyen";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(331, 132);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Vardiya";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "24-08 Vardiyası",
            "08-16 Vardiyası",
            "16-24 Vardiyası",
            "Genel"});
            this.comboBox1.Location = new System.Drawing.Point(331, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // kutu_kapasitif
            // 
            this.kutu_kapasitif.Location = new System.Drawing.Point(80, 128);
            this.kutu_kapasitif.MaxLength = 4;
            this.kutu_kapasitif.Name = "kutu_kapasitif";
            this.kutu_kapasitif.Size = new System.Drawing.Size(100, 20);
            this.kutu_kapasitif.TabIndex = 36;
            // 
            // kutu_enduktif
            // 
            this.kutu_enduktif.Location = new System.Drawing.Point(80, 102);
            this.kutu_enduktif.MaxLength = 5;
            this.kutu_enduktif.Name = "kutu_enduktif";
            this.kutu_enduktif.Size = new System.Drawing.Size(100, 20);
            this.kutu_enduktif.TabIndex = 35;
            // 
            // kutu_aktif
            // 
            this.kutu_aktif.Location = new System.Drawing.Point(80, 76);
            this.kutu_aktif.MaxLength = 6;
            this.kutu_aktif.Name = "kutu_aktif";
            this.kutu_aktif.Size = new System.Drawing.Size(100, 20);
            this.kutu_aktif.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Kapasitif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Endüktif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Aktif";
            // 
            // zg1
            // 
            this.zg1.Location = new System.Drawing.Point(620, 82);
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.Size = new System.Drawing.Size(342, 267);
            this.zg1.TabIndex = 56;
            this.zg1.UseExtendedPrintDialog = true;
            // 
            // zg2
            // 
            this.zg2.Location = new System.Drawing.Point(621, 355);
            this.zg2.Name = "zg2";
            this.zg2.ScrollGrace = 0D;
            this.zg2.ScrollMaxX = 0D;
            this.zg2.ScrollMaxY = 0D;
            this.zg2.ScrollMaxY2 = 0D;
            this.zg2.ScrollMinX = 0D;
            this.zg2.ScrollMinY = 0D;
            this.zg2.ScrollMinY2 = 0D;
            this.zg2.Size = new System.Drawing.Size(342, 267);
            this.zg2.TabIndex = 57;
            this.zg2.UseExtendedPrintDialog = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 70);
            this.button3.TabIndex = 58;
            this.button3.Text = "Tarihi Getir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(475, 574);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(139, 23);
            this.materialRaisedButton1.TabIndex = 60;
            this.materialRaisedButton1.Text = "Ayarlar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(18, 574);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(191, 23);
            this.materialRaisedButton2.TabIndex = 61;
            this.materialRaisedButton2.Text = "Seçiliyi Sil";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.MaterialRaisedButton2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(-2, 641);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(721, 19);
            this.materialLabel1.TabIndex = 62;
            this.materialLabel1.Text = "Her Ayın Başında İlk Sayaç Değerlerini Hesaplama İçin irmelisiniz. Ondalık basama" +
    "ğı yazmayı unutmayınız. ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(823, 625);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(139, 13);
            this.linkLabel1.TabIndex = 63;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Öneri,Görüş İçin SelimErkan";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(755, 641);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(207, 13);
            this.linkLabel2.TabIndex = 64;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Versiyon 1.0 Güncel Versiyon Kontrolü İçin";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 663);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.zg2);
            this.Controls.Add(this.zg1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.c_ayilk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.kutu_kapasitif);
            this.Controls.Add(this.kutu_enduktif);
            this.Controls.Add(this.kutu_aktif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kompanzasyon Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vardiya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ekleyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enduktif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapasitif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktif;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnduktifDeger;
        private System.Windows.Forms.DataGridViewTextBoxColumn KapasitifDeger;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox kutu_ilkkapasitifyuzde;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox kutu_ilkenduktiftyuzde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label yeni_kapasitifyuzde;
        private System.Windows.Forms.TextBox yeni_kapasitif;
        private System.Windows.Forms.TextBox yeni_enduktifyuzde;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kutu_ilkkapasitif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kutu_ilkenduktif;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kutu_ilkaktif;
        private System.Windows.Forms.CheckBox c_ayilk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox kutu_kapasitif;
        private System.Windows.Forms.TextBox kutu_enduktif;
        private System.Windows.Forms.TextBox kutu_aktif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zg1;
        private ZedGraph.ZedGraphControl zg2;
        private System.Windows.Forms.Button button3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

