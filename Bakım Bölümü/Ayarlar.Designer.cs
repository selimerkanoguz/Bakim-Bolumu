namespace Bakım_Bölümü
{
    partial class Ayarlar
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_smtpadres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t_smtpport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_mailadresi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.t_gonderen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.t_mailkonusu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.t_sifre = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.t_mailadresleri = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.n_enduktif = new System.Windows.Forms.NumericUpDown();
            this.n_kapasitif = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Mail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_enduktif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_kapasitif)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(161, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 160);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kişi Listesi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Seçiliyi Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 193);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekleyen Kişi Ayarları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.t_sifre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.t_mailkonusu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.t_gonderen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.t_mailadresi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.t_smtpport);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.t_smtpadres);
            this.groupBox2.Location = new System.Drawing.Point(430, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 193);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail Konusu";
            // 
            // t_smtpadres
            // 
            this.t_smtpadres.Location = new System.Drawing.Point(97, 20);
            this.t_smtpadres.Name = "t_smtpadres";
            this.t_smtpadres.Size = new System.Drawing.Size(100, 20);
            this.t_smtpadres.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SMTP Adresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Örnek: smtp.gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Örnek: 587";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "SMTP Port";
            // 
            // t_smtpport
            // 
            this.t_smtpport.Location = new System.Drawing.Point(97, 50);
            this.t_smtpport.Name = "t_smtpport";
            this.t_smtpport.Size = new System.Drawing.Size(100, 20);
            this.t_smtpport.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Örnek: ornek@gmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mail Adresi";
            // 
            // t_mailadresi
            // 
            this.t_mailadresi.Location = new System.Drawing.Point(97, 76);
            this.t_mailadresi.Name = "t_mailadresi";
            this.t_mailadresi.Size = new System.Drawing.Size(100, 20);
            this.t_mailadresi.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Örnek: Kompanzasyon Uyarı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Gönderen İsmi";
            // 
            // t_gonderen
            // 
            this.t_gonderen.Location = new System.Drawing.Point(97, 101);
            this.t_gonderen.Name = "t_gonderen";
            this.t_gonderen.Size = new System.Drawing.Size(100, 20);
            this.t_gonderen.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Örnek: Kompanzasyon Sistemi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mail Konusu";
            // 
            // t_mailkonusu
            // 
            this.t_mailkonusu.Location = new System.Drawing.Point(97, 127);
            this.t_mailkonusu.Name = "t_mailkonusu";
            this.t_mailkonusu.Size = new System.Drawing.Size(100, 20);
            this.t_mailkonusu.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Şifre";
            // 
            // t_sifre
            // 
            this.t_sifre.Location = new System.Drawing.Point(97, 155);
            this.t_sifre.Name = "t_sifre";
            this.t_sifre.PasswordChar = '*';
            this.t_sifre.Size = new System.Drawing.Size(100, 20);
            this.t_sifre.TabIndex = 15;
            // 
            // Mail
            // 
            this.Mail.Controls.Add(this.n_kapasitif);
            this.Mail.Controls.Add(this.n_enduktif);
            this.Mail.Controls.Add(this.label17);
            this.Mail.Controls.Add(this.label16);
            this.Mail.Controls.Add(this.label13);
            this.Mail.Controls.Add(this.label15);
            this.Mail.Controls.Add(this.t_mailadresleri);
            this.Mail.Location = new System.Drawing.Point(13, 212);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(395, 209);
            this.Mail.TabIndex = 8;
            this.Mail.TabStop = false;
            this.Mail.Text = "Mail Ayarları";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(305, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Örnek: abc@abc.com,cbd@abc.com(Aralarına Virgül Koyunuz)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Gönderilecek Mail Adresleri";
            // 
            // t_mailadresleri
            // 
            this.t_mailadresleri.Location = new System.Drawing.Point(18, 45);
            this.t_mailadresleri.Name = "t_mailadresleri";
            this.t_mailadresleri.Size = new System.Drawing.Size(371, 20);
            this.t_mailadresleri.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Endüktif Uyarı Yüzdesi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Kapasitif Uyarı Yüzdesi";
            // 
            // n_enduktif
            // 
            this.n_enduktif.Location = new System.Drawing.Point(44, 108);
            this.n_enduktif.Name = "n_enduktif";
            this.n_enduktif.Size = new System.Drawing.Size(46, 20);
            this.n_enduktif.TabIndex = 22;
            // 
            // n_kapasitif
            // 
            this.n_kapasitif.Location = new System.Drawing.Point(44, 148);
            this.n_kapasitif.Name = "n_kapasitif";
            this.n_kapasitif.Size = new System.Drawing.Size(46, 20);
            this.n_kapasitif.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(554, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 87);
            this.button3.TabIndex = 9;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Mail.ResumeLayout(false);
            this.Mail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_enduktif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_kapasitif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_smtpport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_smtpadres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_mailadresi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox t_gonderen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox t_mailkonusu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox t_sifre;
        private System.Windows.Forms.GroupBox Mail;
        private System.Windows.Forms.NumericUpDown n_kapasitif;
        private System.Windows.Forms.NumericUpDown n_enduktif;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox t_mailadresleri;
        private System.Windows.Forms.Button button3;
    }
}