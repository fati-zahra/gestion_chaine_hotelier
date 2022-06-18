using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_hotelier.classes
{
    internal class gestion_consommation
    {

        db db1;


        public List<Service> consommation(int id)
        {
            using (db1 = new db())

                try
                {
                using (db1 = new db())

                {
                        //List<Service> r = db1.services.Where(p => p.num_reservation == 17).ToList();
                        //MessageBox.Show(" ll  " + r[1]);

                        return db1.services.ToList();
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("error to get ....");
                return null;
                }
        }
    }
}
