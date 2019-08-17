using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Bakım_Bölümü
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);
        }
        public DataSet dtst = new DataSet();

        private OleDbCommand cmd;
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=plan.mdb");
        string aydegeri = "0";
        public void aydegerigetir()
        {
            string komut = "select * from Sayac Where AylikDeger ='1' Order By Kimlik ASC";

            OleDbCommand Cmd1 = new OleDbCommand(komut, baglanti);
            OleDbDataAdapter da1 = new OleDbDataAdapter(Cmd1);
            System.Data.DataTable _table = new System.Data.DataTable();

            da1.Fill(_table);
            DateTime date = System.DateTime.Now;

            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            foreach (DataRow _row in _table.Rows)
            {
                DateTime sayactarihi = Convert.ToDateTime(_row[5].ToString());
                if (sayactarihi <= lastDayOfMonth && sayactarihi >= firstDayOfMonth)
                {
                    kutu_ilkaktif.Text = _row[1].ToString();
                    kutu_ilkenduktif.Text = _row[2].ToString();
                    kutu_ilkkapasitif.Text = _row[3].ToString();
                    kutu_ilkenduktiftyuzde.Text = _row[9].ToString();
                    kutu_ilkkapasitifyuzde.Text = _row[10].ToString();


                }
            }
            string komut2 = "select * from Sayac Where AylikDeger ='0' Order By Kimlik DESC";

            OleDbCommand Cmd2 = new OleDbCommand(komut2, baglanti);
            OleDbDataAdapter da2 = new OleDbDataAdapter(Cmd2);
            System.Data.DataTable _table2 = new System.Data.DataTable();

            da2.Fill(_table2);
            int r = 0;
            foreach (DataRow _row in _table2.Rows)
            {
                if (r == 0)
                {
                    kutu_ilkenduktiftyuzde.Text = _row[9].ToString();
                    kutu_ilkkapasitifyuzde.Text = _row[10].ToString();
                }
                r = 1;
            }
        }


        private void baglan()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
            }
            catch (Exception hata)
            {

            }
        }

        public void grafikciz()
        {
            var pane = zg1.GraphPane;
            pane.CurveList.Clear();
            pane.Title.Text = "Endüktif Yüzde Değişimi";
            pane.YAxis.Title.Text = "Yüzde";
            pane.XAxis.Title.Text = "Tarih";

            pane.XAxis.Scale.IsVisible = true;
            pane.YAxis.Scale.IsVisible = true;

            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            double deger = 0;
            string[] tarih = new string[dataGridView1.Rows.Count];
            double[] enduktif = new double[dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                tarih[dataGridView1.Rows.Count-1 - i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                double.TryParse(dataGridView1.Rows[i].Cells[3].Value.ToString().Replace('%', ' ').Trim().Replace('.', ','), NumberStyles.Number, CultureInfo.CreateSpecificCulture("tr-TR"), out deger);

                enduktif[dataGridView1.Rows.Count-1 - i] = deger;
            }
            pane.XAxis.Scale.TextLabels = tarih;
            pane.XAxis.Type = AxisType.Text;


            //var pointsCurve;

            LineItem pointsCurve = pane.AddCurve("", null, enduktif, Color.Black);
            pointsCurve.Line.IsVisible = true;
            pointsCurve.Line.Width = 2.0F;
            //Create your own scale of colors.

            pointsCurve.Symbol.Fill = new Fill(new Color[] { Color.Blue, Color.Green, Color.Red });
            pointsCurve.Symbol.Fill.Type = FillType.Solid;
            pointsCurve.Symbol.Type = SymbolType.Circle;
            pointsCurve.Symbol.Border.IsVisible = true;



            pane.AxisChange();
            zg1.Refresh();
            this.Controls.Add(zg1);
        }
        public void sqlcek()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string komut = "select * from Sayac Where AylikDeger ='0' Order By Kimlik DESC";


            OleDbCommand Cmd1 = new OleDbCommand(komut, baglanti);
            OleDbDataAdapter da1 = new OleDbDataAdapter(Cmd1);
            System.Data.DataTable _table = new System.Data.DataTable();

            da1.Fill(_table);
            int i = 0;
            foreach (DataRow _row in _table.Rows)
            {
                if (i < 10)
                {
                    dataGridView1.Rows.Add();
                    int sayi = dataGridView1.Rows.Count;
                    dataGridView1[0, sayi - 1].Value = Convert.ToDateTime(_row[5].ToString()).ToShortDateString(); //id
                    dataGridView1[1, sayi - 1].Value = _row[4].ToString(); //id
                    dataGridView1[2, sayi - 1].Value = _row[6].ToString(); //yapılacakis
                    dataGridView1[3, sayi - 1].Value = "% " + _row[9].ToString();//yapılan
                    dataGridView1[4, sayi - 1].Value = "% " + _row[10].ToString(); //hol
                    dataGridView1[5, sayi - 1].Value = _row[0].ToString(); //hol
                    dataGridView1[5, sayi - 1].Value = _row[0].ToString(); //hol
                    dataGridView1[6, sayi - 1].Value = _row[1].ToString(); //hol
                    dataGridView1[7, sayi - 1].Value = _row[2].ToString(); //hol       
                    dataGridView1[8, sayi - 1].Value = _row[3].ToString(); //hol
                }
                i++;
            }

            dataGridView1.Columns[5].Visible = false;
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


        }
        public void grafikciz2()
        {
            var pane = zg2.GraphPane;
            pane.CurveList.Clear();
            pane.Title.Text = "Endüktif Yüzde Değişimi";
            pane.YAxis.Title.Text = "Yüzde";
            pane.XAxis.Title.Text = "Tarih";

            pane.XAxis.Scale.IsVisible = true;
            pane.YAxis.Scale.IsVisible = true;

            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            string[] tarih = new string[dataGridView1.Rows.Count];
            double[] kapasitif = new double[dataGridView1.Rows.Count];
            double deger = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                tarih[dataGridView1.Rows.Count-1 - i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                double.TryParse(dataGridView1.Rows[i].Cells[4].Value.ToString().Replace('%', ' ').Trim().Replace('.', ','), NumberStyles.Number, CultureInfo.CreateSpecificCulture("tr-TR"), out deger);

                kapasitif[dataGridView1.Rows.Count-1 - i] = deger;
            }
            pane.XAxis.Scale.TextLabels = tarih;
            pane.XAxis.Type = AxisType.Text;
            LineItem pointsCurve = pane.AddCurve("", null, kapasitif, Color.Black);
            pointsCurve.Line.IsVisible = true;
            pointsCurve.Line.Width = 2.0F;
            //Create your own scale of colors.

            pointsCurve.Symbol.Fill = new Fill(new Color[] { Color.Blue, Color.Green, Color.Red });
            pointsCurve.Symbol.Fill.Type = FillType.Solid;
            pointsCurve.Symbol.Type = SymbolType.Circle;
            pointsCurve.Symbol.Border.IsVisible = true;



            pane.AxisChange();
            zg1.Refresh();
            this.Controls.Add(zg1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            aydegerigetir();
            sqlcek();
            kisilerigetir();
            grafikciz();
            grafikciz2();
        }
        public void kisilerigetir()
        {
            comboBox2.Items.Clear();
            string komut = "select * from Kisiler Order By Kimlik ASC";

            OleDbCommand Cmd1 = new OleDbCommand(komut, baglanti);
            OleDbDataAdapter da1 = new OleDbDataAdapter(Cmd1);
            System.Data.DataTable _table = new System.Data.DataTable();

            da1.Fill(_table);

            foreach (DataRow _row in _table.Rows)
            {

                comboBox2.Items.Add(_row[1].ToString().Trim());

            }
        }
        string t_smtpadres = "";
       string t_smtpport = "";
       string t_mailadresi = "";
       string t_gonderen = "";
       string t_mailkonusu= "";
       string t_sifre= "";
       string t_mailadresleri = "";
       string n_enduktif="";
       string  n_kapasitif = "";
        public void mailgonder()
        {
            string komut = "select * from Ayarlar Where Kimlik = 1";

            OleDbCommand Cmd1 = new OleDbCommand(komut, baglanti);
            OleDbDataAdapter da1 = new OleDbDataAdapter(Cmd1);
            System.Data.DataTable _table = new System.Data.DataTable();

            da1.Fill(_table);
            
            foreach (DataRow _row in _table.Rows)
            {
                t_smtpadres = _row[1].ToString();
                t_smtpport = _row[2].ToString();
                t_mailadresi = _row[3].ToString();
                t_gonderen = _row[4].ToString();
                t_mailkonusu = _row[5].ToString();
                t_sifre = _row[6].ToString();
                t_mailadresleri = _row[7].ToString();
                n_enduktif = _row[8].ToString();
                n_kapasitif = _row[9].ToString();

            }
            try
            {
                SmtpClient client = new SmtpClient(t_smtpadres, Convert.ToInt32(t_smtpport));
                MailMessage mesaj = new MailMessage();
                mesaj.To.Add(t_mailadresleri);
                mesaj.From = new MailAddress(t_mailadresi, t_gonderen);
                mesaj.Subject = t_mailkonusu;
                mesaj.IsBodyHtml = true;
                mesaj.Body = "Endüktif Yüzdesi = %" + yeni_enduktifyuzde.Text + "<br/> Kapasitif Yüzdesi = %" + yeni_kapasitif.Text + "<br/> Ekleyen:" + comboBox2.Text + "<br/>Ekleme Tarihi: " + System.DateTime.Now.ToString();
                NetworkCredential guvenlik = new NetworkCredential(t_mailadresi, t_sifre);
                client.Credentials = guvenlik;
                client.EnableSsl = true;

                client.Send(mesaj);
                MessageBox.Show("Mail Başarıyla Gönderildi.");
                //     System.Threading.Thread.Sleep(60000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (kutu_aktif.Text.Length != 0 || kutu_enduktif.Text.Length != 0 ||  kutu_kapasitif.Text.Length != 0)
            {
                if (comboBox1.SelectedIndex != -1 || comboBox2.SelectedIndex != -1)
                {
                    DateTime tarih = dateTimePicker1.Value;
                    baglanti.Close();
                    if (c_ayilk.Checked)
                    {
                        aydegeri = "1";
                        string eklemetarihi = tarih.ToString("d.MM.yyyy");

                        cmd = new OleDbCommand();
                        baglanti.Open();
                        cmd.Connection = baglanti;

                        cmd.CommandText = "insert into Sayac (Aktif_Sayac,Enduktif_Sayac,Kapasitif_Sayac,Vardiya,Sayac_Tarih,Ekleyen,Ekleme_Tarih,AylikDeger,EnduktifYuzde,KapasitifYuzde) values ('"
                        + kutu_aktif.Text.Replace(',', '.') + "','" + kutu_enduktif.Text.Replace(',', '.') + "','" + kutu_kapasitif.Text.Replace(',', '.') + "','" + comboBox1.Text + "','" + eklemetarihi + "','" + comboBox2.Text
                        + "','" + System.DateTime.Now.ToString() + "','" + aydegeri + "','" + "0" + "','" + "0" + "')";

                        cmd.ExecuteNonQuery();
                        baglanti.Close();


                        MessageBox.Show("Ekleme Başarılı");
                    }
                    else
                    {

                        DateTime date = System.DateTime.Now;
                        var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
                        var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                        string ilkaydegerikomut = "select * from Sayac Where AylikDeger ='1' And Sayac_Tarih BETWEEN #" + firstDayOfMonth.ToString("MM/dd/yyyy").Replace(".", "/") + "# AND #" + lastDayOfMonth.ToString("MM/dd/yyyy").Replace(".", "/") + "#  ;";
                        OleDbCommand ilkdegercmd = new OleDbCommand(ilkaydegerikomut, baglanti);
                        OleDbDataAdapter ilkdegerda = new OleDbDataAdapter(ilkdegercmd);
                        System.Data.DataTable ilkdeger_table = new System.Data.DataTable();
                        ilkdegerda.Fill(ilkdeger_table);
                        int i = 0;
                        if (ilkdeger_table.Rows.Count > 0)
                        {

                            decimal aktif = 0;
                            decimal enduktif = 0;
                            decimal kapasitif = 0;
                            decimal ilkaktif = 0;
                            decimal ilkenduktif = 0;
                            decimal ilkkapasitif = 0;
                            decimal.TryParse(kutu_aktif.Text.Replace('.', ','), NumberStyles.Number, CultureInfo.CreateSpecificCulture("tr-TR"), out aktif);
                            decimal.TryParse(kutu_enduktif.Text.Replace('.', ','), NumberStyles.Number, CultureInfo.CreateSpecificCulture("tr-TR"), out enduktif);
                            decimal.TryParse(kutu_kapasitif.Text.Replace('.', ','), NumberStyles.Number, CultureInfo.CreateSpecificCulture("tr-TR"), out kapasitif);
                            decimal.TryParse(kutu_ilkaktif.Text.Replace('.', ','), NumberStyles.Number, CultureInfo.CreateSpecificCulture("tr-TR"), out ilkaktif);
                            decimal.TryParse(kutu_ilkenduktif.Text.Replace('.', ','), NumberStyles.Number, CultureInfo.CreateSpecificCulture("tr-TR"), out ilkenduktif);
                            decimal.TryParse(kutu_ilkkapasitif.Text.Replace('.', ','), NumberStyles.Number, CultureInfo.CreateSpecificCulture("tr-TR"), out ilkkapasitif);

                            decimal enduktifark = (enduktif - ilkenduktif);
                            decimal aktiffark = (aktif - ilkaktif);
                            decimal kapasitiffark = (kapasitif - ilkkapasitif);
                            decimal endüktifyuzde = ((enduktifark * 6900) / (aktiffark * 6900)) * 100;
                            decimal kapasitifyuzde = ((kapasitiffark * 6900) / (aktiffark * 6900)) * 100;
                            yeni_enduktifyuzde.Text = endüktifyuzde.ToString("N2");
                            yeni_kapasitif.Text = kapasitifyuzde.ToString("N2");

                            string eklemetarihi = tarih.ToString("d.MM.yyyy");
                            


                            cmd = new OleDbCommand();
                            baglanti.Open();
                            cmd.Connection = baglanti;

                            cmd.CommandText = "insert into Sayac (Aktif_Sayac,Enduktif_Sayac,Kapasitif_Sayac,Vardiya,Sayac_Tarih,Ekleyen,Ekleme_Tarih,AylikDeger,EnduktifYuzde,KapasitifYuzde) values ('"
                            + kutu_aktif.Text.Replace(',', '.') + "','" + kutu_enduktif.Text.Replace(',', '.') + "','" + kutu_kapasitif.Text.Replace(',', '.') + "','" + comboBox1.Text + "','" + eklemetarihi + "','" + comboBox2.Text
                            + "','" + System.DateTime.Now.ToString() + "','" + aydegeri + "','" + endüktifyuzde.ToString("N1").Replace(',', '.') + "','" + kapasitifyuzde.ToString("N1").Replace(',', '.') + "')";

                            cmd.ExecuteNonQuery();
                            baglanti.Close();


                            
                          


                            MessageBox.Show("Ekleme Başarılı");
                            string komut = "select * from Ayarlar Where Kimlik = 1";

                            OleDbCommand Cmd1 = new OleDbCommand(komut, baglanti);
                            OleDbDataAdapter da1 = new OleDbDataAdapter(Cmd1);
                            System.Data.DataTable _table = new System.Data.DataTable();

                            da1.Fill(_table);

                            foreach (DataRow _row in _table.Rows)
                            {
                                t_smtpadres = _row[1].ToString();
                                t_smtpport = _row[2].ToString();
                                t_mailadresi = _row[3].ToString();
                                t_gonderen = _row[4].ToString();
                                t_mailkonusu = _row[5].ToString();
                                t_sifre = _row[6].ToString();
                                t_mailadresleri = _row[7].ToString();
                                n_enduktif = _row[8].ToString();
                                n_kapasitif = _row[9].ToString();

                            }
                            if (endüktifyuzde > Convert.ToInt32(n_enduktif) || kapasitifyuzde > Convert.ToInt32(n_kapasitif))
                            {
                                yeni_enduktifyuzde.BackColor = Color.Red;
                                yeni_kapasitif.BackColor = Color.Red;
                                mailgonder();
                            }
                            sqlcek();
                            grafikciz();
                            grafikciz2();
                        }
                        else
                        {
                            MessageBox.Show("Ayın İlk Değeri Girilmemiş. Hesaplamaların Doğru Yapılması İçin Ayın İlk Değerini Giriniz.");

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vardiyayı veya ekleyeni seçiniz.");

                }
            }
            else
            {
                MessageBox.Show("Lütfen Aktif, Endüktif ve Kapasitif Değerlerini Doğru Formatta Doldurunuz. Örneğin 9123 Değerini 9123.0 şeklinde giriniz.");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Ayarlar frm = new Ayarlar();
            frm.Show();
        }

        private void S_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult x = MessageBox.Show(dataGridView1.CurrentRow.Cells[2].Value.ToString() + "Seçili kayıtı Silmek istiyormusnuz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    baglan();
                    System.Data.DataTable dt1 = new System.Data.DataTable();
                    OleDbCommand Cmd1 = new OleDbCommand("Delete From Sayac where Kimlik=" + dataGridView1.CurrentRow.Cells[5].Value + "", baglanti);
                    OleDbDataAdapter da1 = new OleDbDataAdapter(Cmd1);
                    da1.Fill(dt1);
                    da1.Dispose();
                    dt1.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Seçili Kayıt Silindi");
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dtst.Clear();
                    sqlcek();
                    grafikciz();
                    grafikciz2();

                }
                else
                {
                    MessageBox.Show("Silme İşlem, İptal edildi...");
                }
            }
            catch (Exception hata)
            {
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string komut = "select * from Sayac Where AylikDeger ='0' AND Sayac_Tarih = #" + dateTimePicker1.Value.ToString("MM/dd/yyyy").Replace(".", "/") + "# Order By Kimlik DESC";


            OleDbCommand Cmd1 = new OleDbCommand(komut, baglanti);
            OleDbDataAdapter da1 = new OleDbDataAdapter(Cmd1);
            System.Data.DataTable _table = new System.Data.DataTable();

            da1.Fill(_table);
            int i = 0;
            foreach (DataRow _row in _table.Rows)
            {
             


                    dataGridView1.Rows.Add();
                    int sayi = dataGridView1.Rows.Count;


                    dataGridView1[0, sayi - 1].Value = Convert.ToDateTime(_row[5].ToString()).ToShortDateString(); //id
                    dataGridView1[1, sayi - 1].Value = _row[4].ToString(); //id
                    dataGridView1[2, sayi - 1].Value = _row[6].ToString(); //yapılacakis
                    dataGridView1[3, sayi - 1].Value = "% " + _row[9].ToString();//yapılan
                    dataGridView1[4, sayi - 1].Value = "% " + _row[10].ToString(); //hol
                    dataGridView1[5, sayi - 1].Value = _row[0].ToString(); //hol
                    dataGridView1[5, sayi - 1].Value = _row[0].ToString(); //hol
                    dataGridView1[6, sayi - 1].Value = _row[1].ToString(); //hol
                    dataGridView1[7, sayi - 1].Value = _row[2].ToString(); //hol       
                    dataGridView1[8, sayi - 1].Value = _row[3].ToString(); //hol
               
              

            }

            dataGridView1.Columns[5].Visible = false;
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            Ayarlar frm = new Ayarlar();
            frm.Show();
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult x = MessageBox.Show(dataGridView1.CurrentRow.Cells[2].Value.ToString() + "Seçili kayıtı Silmek istiyormusnuz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    baglan();
                    System.Data.DataTable dt1 = new System.Data.DataTable();
                    OleDbCommand Cmd1 = new OleDbCommand("Delete From Sayac where Kimlik=" + dataGridView1.CurrentRow.Cells[5].Value + "", baglanti);
                    OleDbDataAdapter da1 = new OleDbDataAdapter(Cmd1);
                    da1.Fill(dt1);
                    da1.Dispose();
                    dt1.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Seçili Kayıt Silindi");
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dtst.Clear();
                    sqlcek();
                    grafikciz();
                    grafikciz2();

                }
                else
                {
                    MessageBox.Show("Silme İşlem, İptal edildi...");
                }
            }
            catch (Exception hata)
            {
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/selimerkan/");

        
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://yadi.sk/d/i5mYu2LwxTZbrQ");

        }
    }
}
