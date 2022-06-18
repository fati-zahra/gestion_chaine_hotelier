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
    public partial class review : UserControl
    {
        public review()
        {
            InitializeComponent();
        }
        archive ar = new archive();


        private NpgsqlConnection con;
        public static int num_cmd;

        string constring = string.Format("server=localhost; port=5432; database=fstt; user id=postgres; password=root");
        //<add name = "cnx1" connectionString="server=localhost; port=5432; database=fstt; user id=postgres; password=root" providerName="Npgsql"/>

        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;
        

        private void review_Load(object sender, EventArgs e)
        {
            List<Reservation> listdata = ar.reservats();
            //archive r = new archive();
            Archive r = new Archive();
            con = new NpgsqlConnection(constring);

            try
            {
                foreach (var re in listdata)
                {

                    r.debut = re.debut;
                    r.fin = re.fin;
                    r.montant = re.montant;
                    r.chambre = re.chambre;
                    r.hotel = re.hotel;
                   
                        //dataGridView1.DataSource = null;
                        con.Open();
                        sql = "INSERT INTO archive.archive(debut, fin, montant, chambre, hotel) VALUES('" + re.debut + "', '" + re.fin + "', " + re.montant + ", " + re.chambre + ", '" + re.hotel + "')";
                        cmd = new NpgsqlCommand(sql, con);
                        //cmd.Parameters.AddWithValue("nm", textBox1.Text);
                        dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        MessageBox.Show("inserted");
                    sql = "delete from reservation where debut = '" + re.debut + "' and fin = '" + re.fin + "' and montant = " + re.montant + " and chambre = " + re.chambre + " and hotel = '" + re.hotel + "'";
                    cmd = new NpgsqlCommand(sql, con);
                    //cmd.Parameters.AddWithValue("nm", textBox1.Text);
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    MessageBox.Show("deleted");

                    con.Close();
                                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("error");
            }

            //dataGridView2.DataSource = listdata;




            con = new NpgsqlConnection(constring);

            try
            {
                dataGridView1.DataSource = null;
                con.Open();
                //where(date_part('month', now()) - date_part('month', debut) < 6) or (date_part('year', now()) - date_part('year', debut) <= -1)
                sql = "select * from archive.archive   ";
                cmd = new NpgsqlCommand(sql, con);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
               // MessageBox.Show("ok");
                dataGridView1.DataSource = dt;
                con.Close();
                //add.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show("errorselect date_part('year', debut) from reservation r  where (date_part('month', now()) - date_part('month', debut) = 2)");

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(constring);

            try
            {
                dataGridView1.DataSource = null;
                con.Open();

                sql = "select * from reservation r  where (date_part('month', now()) - date_part('month', debut) <= 6) and(date_part('year', now()) - date_part('year', debut) <= 1)";
                cmd = new NpgsqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("nm", textBox1.Text);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
               // MessageBox.Show("ok");
                dataGridView1.DataSource = dt;
                con.Close();
                //add.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show("errorselect date_part('year', debut) from reservation r  where (date_part('month', now()) - date_part('month', debut) = 2)");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            num_cmd = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
            Form2 f3 = new Form2();
               Form2.num = num_cmd;
                f3.Show();

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
