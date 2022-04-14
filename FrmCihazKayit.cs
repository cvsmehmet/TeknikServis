using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisOtomasyonu.Models;

namespace TeknikServisOtomasyonu
{
    public partial class FrmCihazKayit : Form
    {
        TeknikServisContext db = new TeknikServisContext();
        public FrmCihazKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCihazKayit_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btn_cihaz_kayit_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text == "" || txt_soyad.Text == "" || txt_adres.Text == "" || txt_email.Text == "" || txt_tel.Text == "" || cbox_cihaz_turu.Text == "" || cbox_marka.Text == ""
                || cbox_model.Text == "" || txt_serino.Text == "" || txt_sikayet.Text == "" || txt_aksesuar.Text == "" || txt_dis_gorunum.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurunuz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi Gerçekleşti");
                CihazKayit c = new CihazKayit();
                c.Adi = txt_ad.Text;
                c.Soyadi = txt_soyad.Text;
                c.Adresi = txt_adres.Text;
                c.Email = txt_email.Text;
                c.Telefon = txt_tel.Text;
                c.CihazTuru = cbox_cihaz_turu.Text;
                c.Marka = cbox_marka.Text;
                c.Model = cbox_model.Text;
                c.GelisTarihi = date_gelis_tarih.Value;
                c.SeriNo = txt_serino.Text;
                c.SikayetBilgisi = txt_sikayet.Text;
                c.CihazlaGelenAksesuar = txt_aksesuar.Text;
                c.DisGorunum = txt_dis_gorunum.Text;
                c.MusteriID = Program.musteri.MusteriID;
                db.CihazKayit.Add(c);
                db.SaveChanges();
                this.Close();
            }
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void txt_soyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_serino_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

