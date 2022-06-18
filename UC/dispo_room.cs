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
    public partial class dispo_room : UserControl
    {
        public dispo_room()
        {
            InitializeComponent();
        }

        private NpgsqlConnection con;
        string constring = string.Format("server=localhost; port=5432; database=fstt; user id=postgres; password=root");
        //<add name = "cnx1" connectionString="server=localhost; port=5432; database=fstt; user id=postgres; password=root" providerName="Npgsql"/>

        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void ok_Click(object sender, EventArgs e)
        {

            try
            {
                //dataGridView1.DataSource = null;
                con.Open();
                sql = "select  * from  chambre where status  = '" + comboBox1.Text + "'";
                cmd = new NpgsqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("nm", textBox1.Text);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;

                con.Close();
                //add.PerformClick();
               // db db4 = new db();
                //dataGridView1.DataSource = db4.chambres.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + comboBox1.Text);

            }

        }

        private void dispo_room_Load(object sender, EventArgs e)
        {

            con = new NpgsqlConnection(constring);


            try
            {
                dataGridView1.DataSource = null;
                con.Open();
                sql = "select * from chambre";
                cmd = new NpgsqlCommand(sql, con);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                con.Close();



            }
            catch
            {
                MessageBox.Show("error");

            }
        }
    }
}
