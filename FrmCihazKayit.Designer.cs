
namespace TeknikServisOtomasyonu
{
    partial class FrmCihazKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCihazKayit));
            this.txt_dis_gorunum = new System.Windows.Forms.TextBox();
            this.cbox_model = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbox_marka = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbox_cihaz_turu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_serino = new System.Windows.Forms.TextBox();
            this.date_gelis_tarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.txt_aksesuar = new System.Windows.Forms.TextBox();
            this.txt_sikayet = new System.Windows.Forms.TextBox();
            this.btn_cihaz_kayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_dis_gorunum
            // 
            this.txt_dis_gorunum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_dis_gorunum.Location = new System.Drawing.Point(675, 713);
            this.txt_dis_gorunum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_dis_gorunum.Multiline = true;
            this.txt_dis_gorunum.Name = "txt_dis_gorunum";
            this.txt_dis_gorunum.Size = new System.Drawing.Size(242, 126);
            this.txt_dis_gorunum.TabIndex = 45;
            // 
            // cbox_model
            // 
            this.cbox_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_model.FormattingEnabled = true;
            this.cbox_model.Items.AddRange(new object[] {
            "Galaxy A21s",
            "Iphone 11"});
            this.cbox_model.Location = new System.Drawing.Point(549, 510);
            this.cbox_model.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox_model.Name = "cbox_model";
            this.cbox_model.Size = new System.Drawing.Size(125, 24);
            this.cbox_model.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(486, 514);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Model : ";
            // 
            // cbox_marka
            // 
            this.cbox_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_marka.FormattingEnabled = true;
            this.cbox_marka.Items.AddRange(new object[] {
            "Apple",
            "Samsung"});
            this.cbox_marka.Location = new System.Drawing.Point(327, 510);
            this.cbox_marka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox_marka.Name = "cbox_marka";
            this.cbox_marka.Size = new System.Drawing.Size(125, 24);
            this.cbox_marka.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(264, 514);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Marka :";
            // 
            // cbox_cihaz_turu
            // 
            this.cbox_cihaz_turu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_cihaz_turu.FormattingEnabled = true;
            this.cbox_cihaz_turu.Items.AddRange(new object[] {
            "Telefon",
            "Bilgisayar",
            "Tablet"});
            this.cbox_cihaz_turu.Location = new System.Drawing.Point(102, 510);
            this.cbox_cihaz_turu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox_cihaz_turu.Name = "cbox_cihaz_turu";
            this.cbox_cihaz_turu.Size = new System.Drawing.Size(125, 24);
            this.cbox_cihaz_turu.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 514);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Cihaz Türü :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(264, 559);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Geliş Tarihi : ";
            // 
            // txt_serino
            // 
            this.txt_serino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_serino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_serino.Location = new System.Drawing.Point(81, 556);
            this.txt_serino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_serino.Name = "txt_serino";
            this.txt_serino.Size = new System.Drawing.Size(146, 22);
            this.txt_serino.TabIndex = 15;
            this.txt_serino.TextChanged += new System.EventHandler(this.txt_serino_TextChanged);
            // 
            // date_gelis_tarih
            // 
            this.date_gelis_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_gelis_tarih.Location = new System.Drawing.Point(369, 556);
            this.date_gelis_tarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date_gelis_tarih.Name = "date_gelis_tarih";
            this.date_gelis_tarih.Size = new System.Drawing.Size(210, 22);
            this.date_gelis_tarih.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 558);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Seri No :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_adres
            // 
            this.txt_adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adres.Location = new System.Drawing.Point(607, 295);
            this.txt_adres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(269, 81);
            this.txt_adres.TabIndex = 4;
            // 
            // txt_soyad
            // 
            this.txt_soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(341, 295);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(148, 22);
            this.txt_soyad.TabIndex = 5;
            this.txt_soyad.TextChanged += new System.EventHandler(this.txt_soyad_TextChanged);
            // 
            // txt_ad
            // 
            this.txt_ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(341, 354);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(148, 22);
            this.txt_ad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Müş. Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adresi :";
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.Location = new System.Drawing.Point(95, 353);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(148, 22);
            this.txt_email.TabIndex = 11;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.Color.White;
            this.txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tel.Location = new System.Drawing.Point(95, 296);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(148, 22);
            this.txt_tel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefon No :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.White;
            this.email.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(279, 356);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(55, 17);
            this.email.TabIndex = 14;
            this.email.Text = "E-mail :";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // txt_aksesuar
            // 
            this.txt_aksesuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aksesuar.Location = new System.Drawing.Point(369, 713);
            this.txt_aksesuar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_aksesuar.Multiline = true;
            this.txt_aksesuar.Name = "txt_aksesuar";
            this.txt_aksesuar.Size = new System.Drawing.Size(243, 126);
            this.txt_aksesuar.TabIndex = 40;
            // 
            // txt_sikayet
            // 
            this.txt_sikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sikayet.Location = new System.Drawing.Point(65, 713);
            this.txt_sikayet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sikayet.Multiline = true;
            this.txt_sikayet.Name = "txt_sikayet";
            this.txt_sikayet.Size = new System.Drawing.Size(242, 126);
            this.txt_sikayet.TabIndex = 41;
            // 
            // btn_cihaz_kayit
            // 
            this.btn_cihaz_kayit.BackColor = System.Drawing.Color.White;
            this.btn_cihaz_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cihaz_kayit.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cihaz_kayit.Location = new System.Drawing.Point(773, 213);
            this.btn_cihaz_kayit.Name = "btn_cihaz_kayit";
            this.btn_cihaz_kayit.Size = new System.Drawing.Size(144, 45);
            this.btn_cihaz_kayit.TabIndex = 47;
            this.btn_cihaz_kayit.Text = "Ekle";
            this.btn_cihaz_kayit.UseVisualStyleBackColor = false;
            this.btn_cihaz_kayit.Click += new System.EventHandler(this.btn_cihaz_kayit_Click);
            // 
            // FrmCihazKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(999, 852);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_serino);
            this.Controls.Add(this.cbox_model);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_cihaz_kayit);
            this.Controls.Add(this.cbox_marka);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_dis_gorunum);
            this.Controls.Add(this.cbox_cihaz_turu);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_gelis_tarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_aksesuar);
            this.Controls.Add(this.txt_sikayet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCihazKayit";
            this.Text = "FrmCihazKayit";
            this.Load += new System.EventHandler(this.FrmCihazKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dis_gorunum;
        private System.Windows.Forms.ComboBox cbox_model;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbox_marka;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbox_cihaz_turu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_serino;
        private System.Windows.Forms.DateTimePicker date_gelis_tarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txt_aksesuar;
        private System.Windows.Forms.TextBox txt_sikayet;
        private System.Windows.Forms.Button btn_cihaz_kayit;
    }
}