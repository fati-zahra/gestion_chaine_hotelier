using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_hotelier.classes
{
    internal class gestion_client { 


         public Client cl(string num_cmd)
    {
        db db1;

        try
        {
            using (db1 = new db())
            {
                //MessageBox.Show("hello" + db.Commandes.ToList());
                return db1.clients.Where(p => p.email == num_cmd).FirstOrDefault();

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("hello in list cmd" + ex.Message);
            return null;
        }
    }

}
}
