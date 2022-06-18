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
    public partial class reservation : UserControl
    {
        public reservation()
        {
            InitializeComponent();
        }
        db db1;
        gestion_client client1 = new gestion_client();

        private NpgsqlConnection con;
        string constring = string.Format("server=localhost; port=5432; database=fstt; user id=postgres; password=root");
        //<add name = "cnx1" connectionString="server=localhost; port=5432; database=fstt; user id=postgres; password=root" providerName="Npgsql"/>

        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;
        private string sql1 = null;



        private void next_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            fr.BringToFront();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            //PREMIERe_interface pr = new PREMIERe_interface();
            //pr.Show();
           // pr.BringToFront();
            this.Hide();
            
           
        }
         db db2 = new db();

       


        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.DataSource = null;
                con.Open();
                sql = "INSERT INTO client(nom, prenom, adress, tel, pays, code_postal, email) VALUES('" + nom_.Text+ "', '" + prenom_.Text + "', '" + adress_.Text + "', "+ tel_.Text + ", '" + pays_.Text + "', "  +code_.Text +", '" + email_.Text+ "')";
                cmd = new NpgsqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("nm", textBox1.Text);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                MessageBox.Show("inserted");
               
                Client c = client1.cl(email_.Text);
                etape2 et = new etape2();
                etape2.id_client = c.id;
                con.Close();
                //add.PerformClick();


            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

            }




           
            //f3.Show();





        }

        private void reservation_Load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(constring);


            try
            {
                con.Open();
                sql = "select * from chambre";
                cmd = new NpgsqlCommand(sql, con);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                con.Close();



            }
            catch
            {
                MessageBox.Show("error");

            }
        }
    }
}
