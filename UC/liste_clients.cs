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
    public partial class liste_clients : UserControl
    {
        public liste_clients()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void liste_clients_Load(object sender, EventArgs e)
        {
            db db2 = new db();
           dataGridView1.DataSource = db2.clients.ToList();

        }

        private void actualiser_Click(object sender, EventArgs e)
        {
           db db2 = new db();
           dataGridView1.DataSource = db2.clients.ToList();
        }
    }
}
