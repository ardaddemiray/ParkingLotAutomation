namespace gorselprogramlama2_final_
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.aracDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.btnAracGuncelle = new System.Windows.Forms.Button();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.txtAracYil = new System.Windows.Forms.TextBox();
            this.txtAracRenk = new System.Windows.Forms.TextBox();
            this.txtAracPlaka = new System.Windows.Forms.TextBox();
            this.txtAracModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.musteriDataGridView = new System.Windows.Forms.DataGridView();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.txtMusteriTelefon = new System.Windows.Forms.TextBox();
            this.txtMusteriAdres = new System.Windows.Forms.TextBox();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboAbonelikTipi = new System.Windows.Forms.ComboBox();
            this.btnAbonelikSil = new System.Windows.Forms.Button();
            this.btnAbonelikGuncelle = new System.Windows.Forms.Button();
            this.btnAbonelikEkle = new System.Windows.Forms.Button();
            this.abonelikDataGridView = new System.Windows.Forms.DataGridView();
            this.txtAbonelikUcret = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AbonelikBitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AbonelikBasDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAbonelikSuresi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnHizmetSil = new System.Windows.Forms.Button();
            this.btnHizmetGuncelle = new System.Windows.Forms.Button();
            this.btnHizmetEkle = new System.Windows.Forms.Button();
            this.hizmetDataGridView = new System.Windows.Forms.DataGridView();
            this.txtHizmetUcret = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cikisDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.girisDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.comboAbonelik = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboPlaka = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboMusteri = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hizmetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 453);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.aracDataGridView);
            this.tabPage1.Controls.Add(this.btnAracSil);
            this.tabPage1.Controls.Add(this.btnAracGuncelle);
            this.tabPage1.Controls.Add(this.btnAracEkle);
            this.tabPage1.Controls.Add(this.txtAracYil);
            this.tabPage1.Controls.Add(this.txtAracRenk);
            this.tabPage1.Controls.Add(this.txtAracPlaka);
            this.tabPage1.Controls.Add(this.txtAracModel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Araçlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // aracDataGridView
            // 
            this.aracDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aracDataGridView.Location = new System.Drawing.Point(0, 222);
            this.aracDataGridView.Name = "aracDataGridView";
            this.aracDataGridView.Size = new System.Drawing.Size(794, 205);
            this.aracDataGridView.TabIndex = 11;
            this.aracDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aracDataGridView_CellClick);
            // 
            // btnAracSil
            // 
            this.btnAracSil.Location = new System.Drawing.Point(468, 158);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(86, 39);
            this.btnAracSil.TabIndex = 10;
            this.btnAracSil.Text = "Sil";
            this.btnAracSil.UseVisualStyleBackColor = true;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnAracGuncelle
            // 
            this.btnAracGuncelle.Location = new System.Drawing.Point(468, 102);
            this.btnAracGuncelle.Name = "btnAracGuncelle";
            this.btnAracGuncelle.Size = new System.Drawing.Size(86, 39);
            this.btnAracGuncelle.TabIndex = 9;
            this.btnAracGuncelle.Text = "Güncelle";
            this.btnAracGuncelle.UseVisualStyleBackColor = true;
            this.btnAracGuncelle.Click += new System.EventHandler(this.btnAracGuncelle_Click);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(468, 42);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(86, 39);
            this.btnAracEkle.TabIndex = 8;
            this.btnAracEkle.Text = "Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // txtAracYil
            // 
            this.txtAracYil.Location = new System.Drawing.Point(300, 166);
            this.txtAracYil.Multiline = true;
            this.txtAracYil.Name = "txtAracYil";
            this.txtAracYil.Size = new System.Drawing.Size(132, 24);
            this.txtAracYil.TabIndex = 7;
            // 
            // txtAracRenk
            // 
            this.txtAracRenk.Location = new System.Drawing.Point(300, 127);
            this.txtAracRenk.Multiline = true;
            this.txtAracRenk.Name = "txtAracRenk";
            this.txtAracRenk.Size = new System.Drawing.Size(132, 24);
            this.txtAracRenk.TabIndex = 6;
            // 
            // txtAracPlaka
            // 
            this.txtAracPlaka.Location = new System.Drawing.Point(300, 87);
            this.txtAracPlaka.Multiline = true;
            this.txtAracPlaka.Name = "txtAracPlaka";
            this.txtAracPlaka.Size = new System.Drawing.Size(132, 24);
            this.txtAracPlaka.TabIndex = 5;
            // 
            // txtAracModel
            // 
            this.txtAracModel.Location = new System.Drawing.Point(300, 48);
            this.txtAracModel.Multiline = true;
            this.txtAracModel.Name = "txtAracModel";
            this.txtAracModel.Size = new System.Drawing.Size(132, 24);
            this.txtAracModel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yıl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Renk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plaka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.musteriDataGridView);
            this.tabPage2.Controls.Add(this.btnMusteriSil);
            this.tabPage2.Controls.Add(this.btnMusteriGuncelle);
            this.tabPage2.Controls.Add(this.btnMusteriEkle);
            this.tabPage2.Controls.Add(this.txtMusteriTelefon);
            this.tabPage2.Controls.Add(this.txtMusteriAdres);
            this.tabPage2.Controls.Add(this.txtMusteriAdSoyad);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteriler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // musteriDataGridView
            // 
            this.musteriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriDataGridView.Location = new System.Drawing.Point(0, 224);
            this.musteriDataGridView.Name = "musteriDataGridView";
            this.musteriDataGridView.Size = new System.Drawing.Size(794, 203);
            this.musteriDataGridView.TabIndex = 22;
            this.musteriDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriDataGridView_CellClick);
            this.musteriDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriDataGridView_CellContentClick);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(464, 173);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(86, 39);
            this.btnMusteriSil.TabIndex = 21;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(359, 173);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(86, 39);
            this.btnMusteriGuncelle.TabIndex = 20;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(254, 173);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(86, 39);
            this.btnMusteriEkle.TabIndex = 19;
            this.btnMusteriEkle.Text = "Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.Location = new System.Drawing.Point(346, 126);
            this.txtMusteriTelefon.Multiline = true;
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Size = new System.Drawing.Size(132, 24);
            this.txtMusteriTelefon.TabIndex = 17;
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.Location = new System.Drawing.Point(346, 86);
            this.txtMusteriAdres.Multiline = true;
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.Size = new System.Drawing.Size(132, 24);
            this.txtMusteriAdres.TabIndex = 16;
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(346, 47);
            this.txtMusteriAdSoyad.Multiline = true;
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(132, 24);
            this.txtMusteriAdSoyad.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ad Soyad:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboAbonelikTipi);
            this.tabPage3.Controls.Add(this.btnAbonelikSil);
            this.tabPage3.Controls.Add(this.btnAbonelikGuncelle);
            this.tabPage3.Controls.Add(this.btnAbonelikEkle);
            this.tabPage3.Controls.Add(this.abonelikDataGridView);
            this.tabPage3.Controls.Add(this.txtAbonelikUcret);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.AbonelikBitDateTimePicker);
            this.tabPage3.Controls.Add(this.AbonelikBasDateTimePicker);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtAbonelikSuresi);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(794, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Abonelik";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboAbonelikTipi
            // 
            this.comboAbonelikTipi.FormattingEnabled = true;
            this.comboAbonelikTipi.Location = new System.Drawing.Point(310, 39);
            this.comboAbonelikTipi.Name = "comboAbonelikTipi";
            this.comboAbonelikTipi.Size = new System.Drawing.Size(132, 21);
            this.comboAbonelikTipi.TabIndex = 29;
            this.comboAbonelikTipi.SelectedIndexChanged += new System.EventHandler(this.comboAbonelikTipi_SelectedIndexChanged);
            // 
            // btnAbonelikSil
            // 
            this.btnAbonelikSil.Location = new System.Drawing.Point(546, 164);
            this.btnAbonelikSil.Name = "btnAbonelikSil";
            this.btnAbonelikSil.Size = new System.Drawing.Size(86, 39);
            this.btnAbonelikSil.TabIndex = 28;
            this.btnAbonelikSil.Text = "Sil";
            this.btnAbonelikSil.UseVisualStyleBackColor = true;
            this.btnAbonelikSil.Click += new System.EventHandler(this.btnAbonelikSil_Click);
            // 
            // btnAbonelikGuncelle
            // 
            this.btnAbonelikGuncelle.Location = new System.Drawing.Point(546, 108);
            this.btnAbonelikGuncelle.Name = "btnAbonelikGuncelle";
            this.btnAbonelikGuncelle.Size = new System.Drawing.Size(86, 39);
            this.btnAbonelikGuncelle.TabIndex = 27;
            this.btnAbonelikGuncelle.Text = "Güncelle";
            this.btnAbonelikGuncelle.UseVisualStyleBackColor = true;
            this.btnAbonelikGuncelle.Click += new System.EventHandler(this.btnAbonelikGuncelle_Click);
            // 
            // btnAbonelikEkle
            // 
            this.btnAbonelikEkle.Location = new System.Drawing.Point(546, 48);
            this.btnAbonelikEkle.Name = "btnAbonelikEkle";
            this.btnAbonelikEkle.Size = new System.Drawing.Size(86, 39);
            this.btnAbonelikEkle.TabIndex = 26;
            this.btnAbonelikEkle.Text = "Ekle";
            this.btnAbonelikEkle.UseVisualStyleBackColor = true;
            this.btnAbonelikEkle.Click += new System.EventHandler(this.btnAbonelikEkle_Click);
            // 
            // abonelikDataGridView
            // 
            this.abonelikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonelikDataGridView.Location = new System.Drawing.Point(-4, 235);
            this.abonelikDataGridView.Name = "abonelikDataGridView";
            this.abonelikDataGridView.Size = new System.Drawing.Size(798, 192);
            this.abonelikDataGridView.TabIndex = 25;
            this.abonelikDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.abonelikDataGridView_CellClick);
            // 
            // txtAbonelikUcret
            // 
            this.txtAbonelikUcret.Location = new System.Drawing.Point(310, 194);
            this.txtAbonelikUcret.Multiline = true;
            this.txtAbonelikUcret.Name = "txtAbonelikUcret";
            this.txtAbonelikUcret.Size = new System.Drawing.Size(132, 24);
            this.txtAbonelikUcret.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ücret:";
            // 
            // AbonelikBitDateTimePicker
            // 
            this.AbonelikBitDateTimePicker.Location = new System.Drawing.Point(310, 157);
            this.AbonelikBitDateTimePicker.Name = "AbonelikBitDateTimePicker";
            this.AbonelikBitDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AbonelikBitDateTimePicker.TabIndex = 22;
            // 
            // AbonelikBasDateTimePicker
            // 
            this.AbonelikBasDateTimePicker.Location = new System.Drawing.Point(310, 118);
            this.AbonelikBasDateTimePicker.Name = "AbonelikBasDateTimePicker";
            this.AbonelikBasDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AbonelikBasDateTimePicker.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Bitiş Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Başlangıç Tarihi:";
            // 
            // txtAbonelikSuresi
            // 
            this.txtAbonelikSuresi.Location = new System.Drawing.Point(310, 74);
            this.txtAbonelikSuresi.Multiline = true;
            this.txtAbonelikSuresi.Name = "txtAbonelikSuresi";
            this.txtAbonelikSuresi.Size = new System.Drawing.Size(132, 24);
            this.txtAbonelikSuresi.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Süre (Aylık-Yıllık):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Abonelik Tipi:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnHizmetSil);
            this.tabPage4.Controls.Add(this.btnHizmetGuncelle);
            this.tabPage4.Controls.Add(this.btnHizmetEkle);
            this.tabPage4.Controls.Add(this.hizmetDataGridView);
            this.tabPage4.Controls.Add(this.txtHizmetUcret);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.cikisDateTimePicker);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.girisDateTimePicker);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.comboAbonelik);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.comboPlaka);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.comboMusteri);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(794, 427);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hizmetler";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnHizmetSil
            // 
            this.btnHizmetSil.Location = new System.Drawing.Point(537, 162);
            this.btnHizmetSil.Name = "btnHizmetSil";
            this.btnHizmetSil.Size = new System.Drawing.Size(86, 39);
            this.btnHizmetSil.TabIndex = 31;
            this.btnHizmetSil.Text = "Sil";
            this.btnHizmetSil.UseVisualStyleBackColor = true;
            this.btnHizmetSil.Click += new System.EventHandler(this.btnHizmetSil_Click);
            // 
            // btnHizmetGuncelle
            // 
            this.btnHizmetGuncelle.Location = new System.Drawing.Point(537, 106);
            this.btnHizmetGuncelle.Name = "btnHizmetGuncelle";
            this.btnHizmetGuncelle.Size = new System.Drawing.Size(86, 39);
            this.btnHizmetGuncelle.TabIndex = 30;
            this.btnHizmetGuncelle.Text = "Güncelle";
            this.btnHizmetGuncelle.UseVisualStyleBackColor = true;
            this.btnHizmetGuncelle.Click += new System.EventHandler(this.btnHizmetGuncelle_Click);
            // 
            // btnHizmetEkle
            // 
            this.btnHizmetEkle.Location = new System.Drawing.Point(537, 46);
            this.btnHizmetEkle.Name = "btnHizmetEkle";
            this.btnHizmetEkle.Size = new System.Drawing.Size(86, 39);
            this.btnHizmetEkle.TabIndex = 29;
            this.btnHizmetEkle.Text = "Ekle";
            this.btnHizmetEkle.UseVisualStyleBackColor = true;
            this.btnHizmetEkle.Click += new System.EventHandler(this.btnHizmetEkle_Click);
            // 
            // hizmetDataGridView
            // 
            this.hizmetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hizmetDataGridView.Location = new System.Drawing.Point(-4, 235);
            this.hizmetDataGridView.Name = "hizmetDataGridView";
            this.hizmetDataGridView.Size = new System.Drawing.Size(798, 192);
            this.hizmetDataGridView.TabIndex = 12;
            this.hizmetDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hizmetDataGridView_CellClick);
            // 
            // txtHizmetUcret
            // 
            this.txtHizmetUcret.Location = new System.Drawing.Point(281, 193);
            this.txtHizmetUcret.Multiline = true;
            this.txtHizmetUcret.Name = "txtHizmetUcret";
            this.txtHizmetUcret.Size = new System.Drawing.Size(127, 26);
            this.txtHizmetUcret.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(231, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Ücret:";
            // 
            // cikisDateTimePicker
            // 
            this.cikisDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.cikisDateTimePicker.Location = new System.Drawing.Point(281, 157);
            this.cikisDateTimePicker.Name = "cikisDateTimePicker";
            this.cikisDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.cikisDateTimePicker.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(231, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Çıkış:";
            // 
            // girisDateTimePicker
            // 
            this.girisDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.girisDateTimePicker.Location = new System.Drawing.Point(281, 124);
            this.girisDateTimePicker.Name = "girisDateTimePicker";
            this.girisDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.girisDateTimePicker.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(231, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Giriş:";
            // 
            // comboAbonelik
            // 
            this.comboAbonelik.FormattingEnabled = true;
            this.comboAbonelik.Location = new System.Drawing.Point(281, 93);
            this.comboAbonelik.Name = "comboAbonelik";
            this.comboAbonelik.Size = new System.Drawing.Size(127, 21);
            this.comboAbonelik.TabIndex = 5;
            this.comboAbonelik.SelectedIndexChanged += new System.EventHandler(this.comboAbonelik_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(231, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Abonelik:";
            // 
            // comboPlaka
            // 
            this.comboPlaka.FormattingEnabled = true;
            this.comboPlaka.Location = new System.Drawing.Point(281, 56);
            this.comboPlaka.Name = "comboPlaka";
            this.comboPlaka.Size = new System.Drawing.Size(127, 21);
            this.comboPlaka.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(231, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Plaka:";
            // 
            // comboMusteri
            // 
            this.comboMusteri.FormattingEnabled = true;
            this.comboMusteri.Location = new System.Drawing.Point(281, 20);
            this.comboMusteri.Name = "comboMusteri";
            this.comboMusteri.Size = new System.Drawing.Size(127, 21);
            this.comboMusteri.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Müşteri:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "o";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hizmetDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView aracDataGridView;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.Button btnAracGuncelle;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.TextBox txtAracYil;
        private System.Windows.Forms.TextBox txtAracRenk;
        private System.Windows.Forms.TextBox txtAracPlaka;
        private System.Windows.Forms.TextBox txtAracModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView musteriDataGridView;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtMusteriTelefon;
        private System.Windows.Forms.TextBox txtMusteriAdres;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboAbonelikTipi;
        private System.Windows.Forms.Button btnAbonelikSil;
        private System.Windows.Forms.Button btnAbonelikGuncelle;
        private System.Windows.Forms.Button btnAbonelikEkle;
        private System.Windows.Forms.DataGridView abonelikDataGridView;
        private System.Windows.Forms.TextBox txtAbonelikUcret;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker AbonelikBitDateTimePicker;
        private System.Windows.Forms.DateTimePicker AbonelikBasDateTimePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAbonelikSuresi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnHizmetSil;
        private System.Windows.Forms.Button btnHizmetGuncelle;
        private System.Windows.Forms.Button btnHizmetEkle;
        private System.Windows.Forms.DataGridView hizmetDataGridView;
        private System.Windows.Forms.TextBox txtHizmetUcret;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker cikisDateTimePicker;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker girisDateTimePicker;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboAbonelik;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboPlaka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboMusteri;
        private System.Windows.Forms.Label label13;
    }
}

