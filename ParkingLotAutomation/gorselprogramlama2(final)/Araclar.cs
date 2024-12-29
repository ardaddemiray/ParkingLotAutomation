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
    class Araclar
    {
        private int AracID;
        private string Model;
        private string Plaka;
        private string Renk;
        private string Yil;

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

        public string aracModel
        {
            get
            {
                return Model;
            }
            set
            {
                Model = value;
            }
        }

        public string aracPlaka
        {
            get
            {
                return Plaka;
            }
            set 
            { 
                Plaka = value; 
            }
        }

        public string aracRenk
        {
            get
            {
                return Renk;
            }
            set 
            { 
                Renk = value; 
            }
        }

        public string aracYil
        {
            get 
            {
                return Yil;
            }
            set
            {
                Yil = value;
            }
        }

        SqlConnection baglantiDizesi = new SqlConnection("Data Source=DESKTOP-DFG4UT2\\SQLEXPRESS;Initial Catalog=Otopark;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da;
        string query;

        public void aracEkle()
        {
            query = "INSERT INTO Araclar (Plaka, Renk, Model, Yil) VALUES (@Plaka, @Renk, @Model, @Yil)";
            cmd = new SqlCommand(query,baglantiDizesi);
            cmd.Parameters.AddWithValue("@Plaka", this.Plaka);
            cmd.Parameters.AddWithValue("@Renk", this.Renk);
            cmd.Parameters.AddWithValue("@Model", this.Model);
            cmd.Parameters.AddWithValue("@Yil", this.Yil);

            if(baglantiDizesi.State == System.Data.ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }

            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();
        }

        public void aracGuncelle()
        {
            query = "UPDATE Araclar SET Plaka = @Plaka, Renk = @Renk, Model = @Model, Yil = @Yil WHERE AracID = @AracID";
            cmd = new SqlCommand(query, baglantiDizesi);
            cmd.Parameters.AddWithValue("@Plaka", this.Plaka);
            cmd.Parameters.AddWithValue("@Renk", this.Renk);
            cmd.Parameters.AddWithValue("@Model", this.Model);
            cmd.Parameters.AddWithValue("@Yil",this.Yil);
            cmd.Parameters.AddWithValue("@AracID", this.AracID);

            if(baglantiDizesi.State == System.Data.ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }

            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();
        }

        public void aracSil()
        {
            query = "DELETE FROM Araclar WHERE AracID = @AracID";
            cmd = new SqlCommand(query, baglantiDizesi);
            cmd.Parameters.AddWithValue("@AracID", this.AracID);

            if (baglantiDizesi.State == System.Data.ConnectionState.Closed)
            {
                baglantiDizesi.Open();
            }

            cmd.ExecuteNonQuery();
            baglantiDizesi.Close();
        }

        public void araclariListele(DataGridView dataGridView)
        {
            query = "SELECT * FROM Araclar";
            da = new SqlDataAdapter(query, baglantiDizesi);
            DataTable dt = new DataTable();

            baglantiDizesi.Open();
            da.Fill(dt);
            baglantiDizesi.Close();

            dataGridView.DataSource = dt;
        }
    }
}
