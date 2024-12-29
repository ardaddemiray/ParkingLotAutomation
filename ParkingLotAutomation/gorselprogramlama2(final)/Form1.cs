using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlama2_final_
{
    public partial class Form1 : Form
    {
        Araclar arac = new Araclar();
        Musteriler musteri = new Musteriler();
        Abonelikler abone = new Abonelikler();
        Hizmetler hizmet = new Hizmetler();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arac.araclariListele(aracDataGridView);
            musteri.musterileriListele(musteriDataGridView);
            abone.abonelikleriListele(abonelikDataGridView);
            hizmet.hizmetleriListele(hizmetDataGridView);
            hizmet.AraclariDoldur(comboPlaka);
            hizmet.MusterileriDoldur(comboMusteri);
            hizmet.AbonelikleriDoldur(comboAbonelik);

            comboAbonelikTipi.Items.Add("Aylık");
            comboAbonelikTipi.Items.Add("Yıllık");
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            try
            {
                arac.aracModel = txtAracModel.Text;
                arac.aracPlaka = txtAracPlaka.Text;
                arac.aracRenk = txtAracRenk.Text;
                arac.aracYil = txtAracYil.Text;

                arac.aracEkle();
                Form1_Load(sender, e);
                MessageBox.Show("Araç başarıyla eklendi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Araç ekleme başarısız!");
            }
        }

        int secilenAracID;
        private void aracDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = aracDataGridView.Rows[e.RowIndex];
                txtAracModel.Text = row.Cells["Model"].Value.ToString();
                txtAracPlaka.Text = row.Cells["Plaka"].Value.ToString();
                txtAracRenk.Text = row.Cells["Renk"].Value.ToString();
                txtAracYil.Text = row.Cells["Yil"].Value.ToString();

                secilenAracID = Convert.ToInt32(row.Cells["AracID"].Value);
            }
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenAracID > 0)
                {
                    arac.aracID = secilenAracID;
                    arac.aracModel = txtAracModel.Text;
                    arac.aracPlaka = txtAracPlaka.Text;
                    arac.aracRenk = txtAracRenk.Text;
                    arac.aracYil = txtAracYil.Text;

                    arac.aracGuncelle();
                    Form1_Load(sender, e);
                    MessageBox.Show("Araç başarıyla güncellendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Araç güncelleme başarısız!");
            }
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            try
            {
                if(secilenAracID > 0)
                {
                    arac.aracID = secilenAracID;
                    arac.aracSil();
                    Form1_Load(sender, e);
                    MessageBox.Show("Araç başarıyla silindi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Araç silme başarısız!");
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                musteri.adsoyad = txtMusteriAdSoyad.Text;
                musteri.adres = txtMusteriAdres.Text;
                musteri.telefon = txtMusteriTelefon.Text;

                musteri.musteriEkle();
                Form1_Load(sender, e);
                MessageBox.Show("Müşteri başarıyla eklendi!");
            }catch(Exception)
            {
                MessageBox.Show("Müşteri ekleme başarısız!");
            }
        }

        int secilenMusteriID;
        private void musteriDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = musteriDataGridView.Rows[e.RowIndex];
                txtMusteriAdSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
                txtMusteriAdres.Text = row.Cells["Adres"].Value.ToString();
                txtMusteriTelefon.Text = row.Cells["Telefon"].Value.ToString();

                secilenMusteriID = Convert.ToInt32(row.Cells["MusteriID"].Value);
            }
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenMusteriID > 0)
                {
                    musteri.musteriID = secilenMusteriID;
                    musteri.adsoyad = txtMusteriAdSoyad.Text;
                    musteri.adres = txtMusteriAdres.Text;
                    musteri.telefon = txtMusteriTelefon.Text;

                    musteri.musteriGuncelle();
                    Form1_Load(sender, e);
                    MessageBox.Show("Müşteri başarıyla güncellendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri güncelleme başarısız!");
            }
        }
        private void musteriDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if(secilenMusteriID > 0)
                {
                    musteri.musteriID = secilenMusteriID;
                    musteri.musteriSil();
                    Form1_Load(sender, e);
                    MessageBox.Show("Müşteri başarıyla silindi!");
                }
            }catch (Exception)
            {
                MessageBox.Show("Müşteri silme başarısız!");
            }
        }

        private void btnAbonelikEkle_Click(object sender, EventArgs e)
        {
            try
            {
                abone.abonelikTipi = comboAbonelikTipi.Text;
                abone.abonelikSure = int.Parse(txtAbonelikSuresi.Text).ToString();
                abone.abonelikBasTarih = AbonelikBasDateTimePicker.Value;
                abone.abonelikBitTarih = AbonelikBitDateTimePicker.Value;
                abone.ucret = txtAbonelikUcret.Text;

                abone.abonelikEkle();
                Form1_Load(sender, e);
                MessageBox.Show("Abonelik başarıyla eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Abonelik ekleme başarısız");
            }
        }

        int secilenAbonelikID;
        private void abonelikDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = abonelikDataGridView.Rows[e.RowIndex];

                comboAbonelikTipi.Text = row.Cells["AbonelikTipi"].Value.ToString();
                txtAbonelikSuresi.Text = row.Cells["Sure"].Value.ToString();
                AbonelikBasDateTimePicker.Text = row.Cells["BaslangicTarihi"].Value.ToString();
                AbonelikBitDateTimePicker.Text = row.Cells["BitisTarihi"].Value.ToString();
                txtAbonelikUcret.Text = row.Cells["Ucret"].Value.ToString();

                secilenAbonelikID = Convert.ToInt32(row.Cells["AbonelikID"].Value);
            }
        }
        private void btnAbonelikGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenAbonelikID > 0)
                {
                    abone.abonelikID = secilenAbonelikID;
                    abone.abonelikTipi = comboAbonelikTipi.Text;
                    abone.abonelikSure = txtAbonelikSuresi.Text;
                    abone.abonelikBasTarih = AbonelikBasDateTimePicker.Value;
                    abone.abonelikBitTarih = AbonelikBitDateTimePicker.Value;
                    abone.ucret = txtAbonelikUcret.Text;


                    abone.abonelikGuncelle();
                    Form1_Load(sender, e);
                    MessageBox.Show("Abonelik başarıyla güncellendi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Abonelik güncelleme başarısız!" + ex.Message);
            }
        }

        private void btnAbonelikSil_Click(object sender, EventArgs e)
        {
            try
            {
                if(secilenAbonelikID > 0)
                {
                    abone.abonelikID = secilenAbonelikID;
                    abone.abonelikSil();
                    Form1_Load(sender, e);
                    MessageBox.Show("Abonelik başarıyla silindi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Abonelik silme başarısız!");
            }
        }

        private void comboAbonelikTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboAbonelik_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DFG4UT2\\SQLEXPRESS;Initial Catalog=Otopark;Integrated Security=True;");

            if (comboAbonelik.SelectedValue != null)
            {
                string abonelikID = comboAbonelik.SelectedValue.ToString();

                string query = "SELECT Ucret FROM Abonelikler WHERE AbonelikID = @AbonelikID";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@AbonelikID", abonelikID);

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null && (comboAbonelik.Text == "Aylık" || comboAbonelik.Text == "Yıllık"))
                        {
                            txtHizmetUcret.Text = result.ToString();
                            txtHizmetUcret.Enabled = false;
                        }
                        else
                        {
                            txtHizmetUcret.Text = "";
                            txtHizmetUcret.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ücret bilgisi alınırken bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }

        private void btnHizmetEkle_Click(object sender, EventArgs e)
        {
            try
            {
                hizmet.aracID = Convert.ToInt32(comboPlaka.SelectedValue);
                hizmet.musteriID = Convert.ToInt32(comboMusteri.SelectedValue);
                hizmet.girisTarihi = girisDateTimePicker.Value;
                hizmet.cikisTarihi = cikisDateTimePicker.Value;
                hizmet.abonelikTipi = comboAbonelik.Text;

                hizmet.ucret = decimal.Parse(txtHizmetUcret.Text);

                hizmet.hizmetEkle();
                Form1_Load(sender, e);
                MessageBox.Show("Hizmet başarıyla eklendi!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir ücret değeri girin!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hizmet ekleme başarısız! " + ex.Message);
            }
        }

        int secilenHizmetID;
        private void hizmetDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = hizmetDataGridView.Rows[e.RowIndex];

            secilenHizmetID = Convert.ToInt32(row.Cells[0].Value.ToString());
            comboPlaka.Text = hizmetDataGridView.CurrentRow.Cells[1].Value.ToString();
            comboMusteri.Text = hizmetDataGridView.CurrentRow.Cells[2].Value.ToString();
            girisDateTimePicker.Text = hizmetDataGridView.CurrentRow.Cells[3].Value.ToString();
            cikisDateTimePicker.Text = hizmetDataGridView.CurrentRow.Cells[4].Value.ToString();
            comboAbonelik.Text = hizmetDataGridView.CurrentRow.Cells[5].Value.ToString();
            txtHizmetUcret.Text = hizmetDataGridView.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnHizmetGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenHizmetID > 0)
                {
                    hizmet.hizmetID = secilenHizmetID;
                    hizmet.aracID = Convert.ToInt32(comboMusteri.SelectedValue);
                    hizmet.musteriID = Convert.ToInt32(comboMusteri.SelectedValue);
                    hizmet.girisTarihi = girisDateTimePicker.Value;
                    hizmet.cikisTarihi = cikisDateTimePicker.Value;
                    hizmet.abonelikTipi = comboAbonelik.Text;
                    hizmet.ucret = decimal.Parse(txtHizmetUcret.Text);

                    hizmet.hizmetGuncelle();
                    Form1_Load(sender, e);
                    MessageBox.Show("Hizmet başarıyla güncellendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hizmet güncelleme başarısız!");
            }
        }

        private void btnHizmetSil_Click(object sender, EventArgs e)
        {
            try
            {
                if(secilenHizmetID > 0)
                {
                    hizmet.hizmetID = secilenHizmetID;
                    hizmet.hizmetSil();
                    Form1_Load(sender, e);
                    MessageBox.Show("Hizmet başarıyla silindi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hizmet silme başarısız!");
            }
        }


    }
}
