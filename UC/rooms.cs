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
    public partial class rooms : UserControl

    {
        db context = new db();

        public rooms()
        {
            InitializeComponent();
        }
        private NpgsqlConnection con;
        string constring = string.Format("server=localhost; port=5432; database=fstt; user id=postgres; password=root");
        //<add name = "cnx1" connectionString="server=localhost; port=5432; database=fstt; user id=postgres; password=root" providerName="Npgsql"/>

        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void rooms_Load(object sender, EventArgs e)
        {
            db db2 = new db();

            comboBox1.DataSource = db2.Categories.ToList();
            comboBox1.DisplayMember = "description";
            comboBox1.ValueMember = "id";

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



        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.DataSource = null;
                con.Open();
                sql = "INSERT INTO chambre(numero, telephone, status, id_categorie) VALUES(" + textBox2.Text + ", " + textBox4.Text + ", " + " '" +textBox3.Text + "', " + comboBox1.SelectedValue +")";
                cmd = new NpgsqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("nm", textBox1.Text);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                MessageBox.Show("inserted" +comboBox1.SelectedValue);

                con.Close();
                //add.PerformClick();
                db db4 = new db();
                dataGridView1.DataSource = db4.chambres.ToList();


            }
            catch(Exception ex)
            {
                MessageBox.Show("error");

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var room = (Chambre)row.DataBoundItem;
                textBox2.Text = room.numero.ToString();
                textBox3.Text = room.status;
                textBox4.Text = room.telephone.ToString();
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.DataSource = null;
                con.Open();
                sql = "INSERT INTO chambre(numero, telephone, status, id_categorie) VALUES(" + textBox2.Text + ", " + textBox4.Text + ", " + " '" + textBox3.Text + "', " + comboBox1.SelectedValue + ")";
                cmd = new NpgsqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("nm", textBox1.Text);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                MessageBox.Show("inserted");

                con.Close();
                //add.PerformClick();
                db db4 = new db();
                dataGridView1.DataSource = db4.chambres.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + comboBox1.ValueMember);

            }
        }
    }
}
