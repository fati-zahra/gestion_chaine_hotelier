using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_hotelier.classes
{
    internal class archive
    {

        db db1;
        private NpgsqlConnection con;
        public static int num_cmd;

        string constring = string.Format("server=localhost; port=5432; database=fstt; user id=postgres; password=root");
        //<add name = "cnx1" connectionString="server=localhost; port=5432; database=fstt; user id=postgres; password=root" providerName="Npgsql"/>

        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;

        public List<Reservation> reservats()
        {
            using (db1 = new db())

                try
                {
                    using (db1 = new db())

                    {


                        return db1.reservations.Where(p => p.debut.Year - DateTime.Now.Year <= -1 ).ToList();
                    }//&& p.debut.Month - DateTime.Now.Month < -6)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error to get ....");
                    return null;
                }
        }

        public void CreerContient(Archive arch)
        {
            try
            {
                using (db1 = new db())
                {
                    db1.archives.Add(arch);
                    db1.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




    }
}
