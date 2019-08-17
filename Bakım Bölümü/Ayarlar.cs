using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakım_Bölümü
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=plan.mdb");
        public void ayarlaricek()
        {
            string komut = "select * from Ayarlar Where Kimlik = 1";

            OleDbCommand Cmd1 = new OleDbCommand(komut, baglanti);
            OleDbDataAdapter da1 = new OleDbDataAdapter(Cmd1);
            System.Data.DataTable _table = new System.Data.DataTable();

            da1.Fill(_table);

            foreach (DataRow _row in _table.Rows)
            {
                t_smtpadres.Text = _row[1].ToString();
                t_smtpport.Text = _row[2].ToString();
                t_mailadresi.Text = _row[3].ToString();
                t_gonderen.Text = _row[4].ToString();
                t_mailkonusu.Text = _row[5].ToString();
                t_sifre.Text = _row[6].ToString();
                t_mailadresleri.Text = _row[7].ToString();
                n_enduktif.Value = Convert.ToInt32(_row[8].ToString());
                n_kapasitif.Value = Convert.ToInt32(_row[9].ToString());

            }
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            kisilerigetir();
            ayarlaricek();
        }
        public void kisilerigetir()
        {
            listBox1.Items.Clear();
            string komut = "select * from Kisiler Order By Kimlik ASC";

            OleDbCommand Cmd1 = new OleDbCommand(komut, baglanti);
            OleDbDataAdapter da1 = new OleDbDataAdapter(Cmd1);
            System.Data.DataTable _table = new System.Data.DataTable();

            da1.Fill(_table);
        
            foreach (DataRow _row in _table.Rows)
            {
               
                   listBox1.Items.Add(_row[1].ToString().Trim());
             
            }
        }
        OleDbCommand cmd;
        private void Button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;

            cmd.CommandText = "insert into Kisiler (Isim) values ('"
            + textBox1.Text.Trim()+ "')";

            cmd.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("Ekleme Başarılı");
            kisilerigetir();
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
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult x = MessageBox.Show(listBox1.Items[listBox1.SelectedIndex].ToString() + " Adlı Seçili kayıtı Silmek istiyormusnuz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    baglan();
                    System.Data.DataTable dt1 = new System.Data.DataTable();
                    OleDbCommand Cmd1 = new OleDbCommand("Delete From Kisiler where Isim=" + listBox1.Items[listBox1.SelectedIndex].ToString() + "", baglanti);
                    OleDbDataAdapter da1 = new OleDbDataAdapter(Cmd1);
                    da1.Fill(dt1);
                    da1.Dispose();
                    dt1.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Seçili Kayıt Silindi");
              

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
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            string komut = "";

            komut = "UPDATE Ayarlar SET SMTP_Adres ='" + t_smtpadres.Text.Trim() + "', " + "SMTP_Port" + " ='" + t_smtpport.Text.Trim() + "', " + "SMTP_Mail" + " ='" + t_mailadresi.Text.Trim() + "', " + "SMTP_Gonderen" + " ='" + t_gonderen.Text.Trim()
                + "', " + "SMTP_Konu" + " ='" + t_mailkonusu.Text.Trim() + "', " + "SMTP_Sifre" + " ='" + t_sifre.Text.Trim()+ "', " 
                + "MailAdresleri" + " ='" + t_mailadresleri.Text.Trim()+ "', " + "EnduktifUyari" + " ='" + n_enduktif.Value.ToString()
                + "', " + "KapasitifUyari" + " ='" + n_kapasitif.Value.ToString() +"' WHERE Kimlik =1";

            cmd.CommandText = komut;

            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ayarlar Başarıyla Kaydedildi...");

            ayarlaricek();
        }
    }
}
