using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_hotelier.classes
{
    internal class gestion_reservation
    {
        db db1;


        public Reservation reservation(int id)
        {
            try
            {
                using (db1 = new db())
                {
                    //MessageBox.Show("hello" + db.Commandes.ToList());
                    return db1.reservations.Where(p => p.id == id).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
                return null;
            }
        }

      
    }
}
