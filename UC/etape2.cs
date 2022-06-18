using System;
using gestion_hotelier.classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace gestion_hotelier.UC
{
    public partial class etape2 : UserControl
    {
        public etape2()
        {
            InitializeComponent();
        }

        public static int id_client;

        private NpgsqlConnection con;
        string constring = string.Format("server=localhost; port=5432; database=fstt; user id=postgres; password=root");
        //<add name = "cnx1" connectionString="server=localhost; port=5432; database=fstt; user id=postgres; password=root" providerName="Npgsql"/>

        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;


      

        private void etape2_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(constring);

            db db2 = new db();
            comboBox1.DataSource = db2.chaines.ToList();
            comboBox1.DisplayMember = "hotel";
            comboBox1.ValueMember = "id";


            comboBox2.DataSource = db2.Categories.ToList();
            comboBox2.DisplayMember = "description";
            comboBox2.ValueMember = "id";

            hotel1.DataSource = db2.chaines.ToList();
            hotel1.DisplayMember = "nom";
            hotel1.ValueMember = "id";
            //dataGridView1.DataSource = db1.chaines.ToList();

            nbr.DataSource = db2.chambres.ToList();
            nbr.DisplayMember = "numero";
            nbr.ValueMember = "id";

        }



        private void pre_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservation res1 = new reservation();
            res1.BringToFront();
        }

       
        private void valider_Click(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.DataSource = null;
                con.Open();

                sql = "INSERT INTO reservation(debut, fin, montant, chambre, hotel, id_client) VALUES('" + dateTimePicker1.Value + "', '" + dateTimePicker2.Value + "', " + textBox1.Text + ", "+ nbr.SelectedValue + ", " + hotel1.SelectedValue +", " + id_client + ")";
                cmd = new NpgsqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("nm", textBox1.Text);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("votre reservation a été réservé  ");

                con.Close();
                //add.PerformClick();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + dateTimePicker1.Value + "', '" + dateTimePicker2.Value + "', " + textBox1.Text + ", " + nbr.SelectedValue + ", " + hotel1.SelectedValue + ", " + id_client );

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hotel1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

