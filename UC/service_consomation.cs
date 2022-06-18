using gestion_hotelier.classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_hotelier.UC
{
    public partial class service_consomation : UserControl
    {
        public service_consomation()
        {
            InitializeComponent();
        }
        private NpgsqlConnection con;
        string constring = string.Format("server=localhost; port=5432; database=fstt; user id=postgres; password=root");
        //<add name = "cnx1" connectionString="server=localhost; port=5432; database=fstt; user id=postgres; password=root" providerName="Npgsql"/>

        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;


        private void reser_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void service_consomation_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(constring);

            db db2 = new db();

            //comboBox1.DataSource = db2.reservations.ToList();
            comboBox1.DisplayMember = "id";
            comboBox1.ValueMember = "id";



        }


        private void valider_Click(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.DataSource = null;
                con.Open();

                sql = "INSERT INTO service(num_reservation, consommation, prix) VALUES(" + comboBox1.Text + ", '" + comboBox3.Text + "', "+ textBox1.Text+ ")";
                cmd = new NpgsqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("nm", textBox1.Text);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("inserted");

                con.Close();
                //add.PerformClick();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" );

            }
        }
    }
}
