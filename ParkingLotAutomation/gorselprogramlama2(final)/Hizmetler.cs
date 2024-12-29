using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlama2_final_
{
    class Hizmetler
    {
        private int HizmetID;
        private int MusteriID;
        private int AracID;
        private DateTime GirisTarihi;
        private DateTime CikisTarihi;
        private string AbonelikTipi;
        private decimal Ucret;

        public int hizmetID
        {
            get
            {
                return HizmetID;
            }
            set
            {
                HizmetID = value;
            }
        }

        public int musteriID
        {
            get
            {
                return MusteriID;
            }
            set
            {
                MusteriID = value;
            }
        }

        public int aracID
        {
            get
            {
                return AracID;
            }
            set
            {
                AracID = value;
            }
        }

        public DateTime girisTarihi
        {
            get
            {
                return GirisTarihi;
            }
            set
            {
                GirisTarihi = value;
            }
        }

        public DateTime cikisTarihi
        {
            get
            {
                return CikisTarihi;
            }
            set
            {
                CikisTarihi = value;
            }
        }

        public string abonelikTipi
        {
            get
            {
                return AbonelikTipi;
            }
            set
            {
                AbonelikTipi = value;
            }

        }

        public decimal ucret
        {
            get
            {
                return Ucret;
            }
            set
            {
                Ucret = value;
            }
        }

        SqlConnection baglantiDizesi = new SqlConnection("Data Source=DESKTOP-DFG4UT2\\SQLEXPRESS;Initial Catalog=Otopark;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da;
        string query;

        public void hizmetEkle()
        {
            query = "INSERT INTO Hizmetler (MusteriID, AracID, GirisSaati, CikisSaati, AbonelikTipi, Ucret)" +
                "VALUES (@MusteriID, @AracID, @GirisSaati, @CikisSaati, @AbonelikTipi, @Ucret)";

            cmd = new SqlCommand(query, baglantiDizesi);
            cmd.Parameters.AddWithValue("@MusteriID", this.musteriID);
            cmd.Parameters.AddWithValue("@AracID", this.aracID);
            cmd.Parameters.AddWithValue("@GirisSaati", this.GirisTarihi);
            cmd.Parameters.AddWithValue("@CikisSaati", this.cikisTarihi);
            cmd.Parameters.AddWithValue("@AbonelikTipi", this.AbonelikTipi);
            cmd.Parameters.AddWithValue("@Ucret", this.ucret);

            if (baglantiDizesi.State == System.Data.ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }

            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();

        }

        public void hizmetGuncelle()
        {
            query = "UPDATE Hizmetler SET MusteriID = @MusteriID, AracID = @AracID, GirisSaati = @GirisTarihi, CikisSaati = @CikisTarihi, " +
                    "AbonelikTipi = @AbonelikTipi, Ucret = @Ucret WHERE HizmetID = @HizmetID";

            cmd = new SqlCommand(query, baglantiDizesi);
            cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);
            cmd.Parameters.AddWithValue("@AracID", this.AracID);
            cmd.Parameters.AddWithValue("@GirisTarihi", this.GirisTarihi);
            cmd.Parameters.AddWithValue("@CikisTarihi", this.CikisTarihi);
            cmd.Parameters.AddWithValue("@AbonelikTipi", this.AbonelikTipi);
            cmd.Parameters.AddWithValue("@Ucret", this.Ucret);
            cmd.Parameters.AddWithValue("@HizmetID", this.HizmetID);

            if (baglantiDizesi.State == ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }

            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();

        }

        public void hizmetSil()
        {
            query = "DELETE FROM Hizmetler WHERE HizmetID = @HizmetID";
            cmd = new SqlCommand(query, baglantiDizesi);
            cmd.Parameters.AddWithValue("@HizmetID", this.HizmetID);

            if (baglantiDizesi.State == System.Data.ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }

            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();
        }

        public void hizmetleriListele(DataGridView dataGridView)
        {
            query = "SELECT * FROM Hizmetler";
            da = new SqlDataAdapter(query, baglantiDizesi);
            DataTable dt = new DataTable();

            baglantiDizesi.Open();
            da.Fill(dt);
            baglantiDizesi.Close();

            dataGridView.DataSource = dt;
        }

        public void AraclariDoldur(ComboBox comboBox)
        {
            query = "SELECT AracID, Plaka FROM Araclar";
            da = new SqlDataAdapter(query, baglantiDizesi);
            DataTable dt = new DataTable();

            baglantiDizesi.Open();
            da.Fill(dt);
            baglantiDizesi.Close();

            comboBox.DisplayMember = "Plaka";
            comboBox.ValueMember = "AracID";
            comboBox.DataSource = dt;
        }

        public void MusterileriDoldur(ComboBox comboBox)
        {
            string query = "SELECT MusteriID, AdSoyad FROM Musteriler";
            da = new SqlDataAdapter(query, baglantiDizesi);
            DataTable dt = new DataTable();

            baglantiDizesi.Open();
            da.Fill(dt);
            baglantiDizesi.Close();

            comboBox.DisplayMember = "AdSoyad";
            comboBox.ValueMember = "MusteriID";
            comboBox.DataSource = dt;
        }

        public void AbonelikleriDoldur(ComboBox comboBox)
        {
            query = "SELECT AbonelikID, AbonelikTipi FROM Abonelikler";
            da = new SqlDataAdapter(query, baglantiDizesi);
            DataTable dt = new DataTable();

            baglantiDizesi.Open();
            da.Fill(dt);
            baglantiDizesi.Close();

            DataRow row = dt.NewRow();
            row["AbonelikTipi"] = "Abone Değil";
            dt.Rows.InsertAt(row, 0);

            comboBox.DisplayMember = "AbonelikTipi";
            comboBox.ValueMember = "AbonelikID";
            comboBox.DataSource = dt;
        }

    }
}
