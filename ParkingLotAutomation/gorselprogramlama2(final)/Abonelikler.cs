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
    class Abonelikler
    {
        private int AbonelikID;
        private string AbonelikTipi;
        private string AbonelikSure;
        private DateTime AbonelikBasTarih;
        private DateTime AbonelikBitTarih;
        private string Ucret;

        public int abonelikID
        {
            get
            {
                return AbonelikID;
            }
            set
            {
                AbonelikID = value;
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

        public string abonelikSure
        {
            get 
            { 
                return AbonelikSure;
            }
            set
            {
                AbonelikSure = value;
            }
        }

        public DateTime abonelikBasTarih
        {
            get
            {
                return AbonelikBasTarih;
            }
            set
            {
                AbonelikBasTarih = value;
            }
        }

        public DateTime abonelikBitTarih
        {
            get
            {
                return AbonelikBitTarih;
            }
            set
            {
                AbonelikBitTarih = value;
            }
        }

        public string ucret
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

        public void abonelikEkle()
        {
            query = "INSERT INTO Abonelikler (AbonelikTipi, Sure, BaslangicTarihi, BitisTarihi, Ucret) VALUES (@AbonelikTipi, @Sure, @BaslangicTarihi, @BitisTarihi, @Ucret)";
            cmd = new SqlCommand(query, baglantiDizesi);
            cmd.Parameters.AddWithValue("@AbonelikTipi", this.AbonelikTipi);
            cmd.Parameters.AddWithValue("@Sure", this.AbonelikSure);
            cmd.Parameters.AddWithValue("@BaslangicTarihi", this.AbonelikBasTarih);
            cmd.Parameters.AddWithValue("@BitisTarihi", this.AbonelikBitTarih);
            cmd.Parameters.AddWithValue("@Ucret", this.Ucret);

            if (baglantiDizesi.State == System.Data.ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }

            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();
        }

        public void abonelikGuncelle()
        {
            query = "UPDATE Abonelikler SET AbonelikTipi = @AbonelikTipi, Sure = @Sure, BaslangicTarihi = @BaslangicTarihi, BitisTarihi = @BitisTarihi, Ucret = @Ucret WHERE AbonelikID = @AbonelikID";
            cmd = new SqlCommand(query, baglantiDizesi);
            cmd.Parameters.AddWithValue("@AbonelikTipi", this.AbonelikTipi);
            cmd.Parameters.AddWithValue("@Sure", Convert.ToInt32(this.AbonelikSure));
            cmd.Parameters.AddWithValue("@BaslangicTarihi", this.AbonelikBasTarih);
            cmd.Parameters.AddWithValue("@BitisTarihi", this.AbonelikBitTarih);
            cmd.Parameters.AddWithValue("@Ucret", Convert.ToDecimal(this.Ucret));
            cmd.Parameters.AddWithValue("@AbonelikID", this.AbonelikID);

            if (baglantiDizesi.State == ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }
            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();
        }

        public void abonelikSil()
        {
            query = "DELETE FROM Abonelikler WHERE AbonelikID = @AbonelikID";
            cmd = new SqlCommand(query, baglantiDizesi);
            cmd.Parameters.AddWithValue("@AbonelikID", this.AbonelikID);

            if (baglantiDizesi.State == System.Data.ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }

            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();
        }

        public void abonelikleriListele(DataGridView dataGridView)
        {
            query = "SELECT * FROM Abonelikler";
            da = new SqlDataAdapter(query, baglantiDizesi);
            DataTable dt = new DataTable();

            baglantiDizesi.Open();
            da.Fill(dt);
            baglantiDizesi.Close();

            dataGridView.DataSource = dt;
        }
    }
}
