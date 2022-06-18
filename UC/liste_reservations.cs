using gestion_hotelier.classes;
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
    public partial class liste_reservations : UserControl
    {
        public liste_reservations()
        {
            InitializeComponent();
        }

        private void liste_reservations_Load(object sender, EventArgs e)
        {
            db db1 = new db();
            dataGridView1.DataSource = db1.reservations.ToList();

        }
    }
}
