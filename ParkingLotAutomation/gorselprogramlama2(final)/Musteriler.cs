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
    class Musteriler
    {
        private int MusteriID;
        private string AdSoyad;
        private string Adres;
        private string Telefon;

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

        public string adsoyad
        {
            get
            {
                return AdSoyad;
            }
            set
            {
                AdSoyad = value;
            }
        }

        public string adres
        {
            get
            {
                return Adres;
            }
            set
            {
                Adres = value;
            }
        }

        public string telefon
        {
            get
            {
                return Telefon;
            }
            set
            {
                Telefon = value;
            }
        }

        SqlConnection baglantiDizesi = new SqlConnection("Data Source=DESKTOP-DFG4UT2\\SQLEXPRESS;Initial Catalog=Otopark;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da;
        string query;

        public void musteriEkle()
        {
            query = "INSERT INTO Musteriler (AdSoyad, Adres, Telefon) VALUES (@AdSoyad, @Adres, @Telefon)";
            cmd = new SqlCommand(query, baglantiDizesi);
            cmd.Parameters.AddWithValue("@AdSoyad", this.AdSoyad);
            cmd.Parameters.AddWithValue("@Adres", this.Adres);
            cmd.Parameters.AddWithValue("@Telefon", this.Telefon);

            if (baglantiDizesi.State == System.Data.ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }

            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();
        }

        public void musteriGuncelle()
        {
            query = "UPDATE Musteriler SET AdSoyad = @AdSoyad, Adres = @Adres, Telefon = @Telefon WHERE MusteriID = @MusteriID";
            cmd = new SqlCommand(query, baglantiDizesi);
            cmd.Parameters.AddWithValue("@AdSoyad", this.AdSoyad);
            cmd.Parameters.AddWithValue("@Adres", this.Adres);
            cmd.Parameters.AddWithValue("@Telefon", this.Telefon);
            cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);

            if (baglantiDizesi.State == ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }

            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();
        }

        public void musteriSil()
        {
            query = "DELETE FROM Musteriler WHERE MusteriID = @MusteriID";
            cmd = new SqlCommand(query, baglantiDizesi);
            cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);

            if (baglantiDizesi.State == System.Data.ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }

            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();
        }

        public void musterileriListele(DataGridView dataGridView)
        {
            query = "SELECT * FROM Musteriler";
            da = new SqlDataAdapter(query, baglantiDizesi);
            DataTable dt = new DataTable();

            baglantiDizesi.Open();
            da.Fill(dt);
            baglantiDizesi.Close();

            dataGridView.DataSource = dt;
        }
    }
}
