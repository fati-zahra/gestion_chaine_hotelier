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
    public partial class liste_services : UserControl
    {
        public liste_services()
        {
            InitializeComponent();
        }

        private void liste_services_Load(object sender, EventArgs e)
        {
            db db2 = new db();
            dataGridView1.DataSource = db2.services.OrderBy(x => x.id).ToList();
        }

        private void update_Click(object sender, EventArgs e)
        {
            db db2 = new db();
            dataGridView1.DataSource = db2.services.ToList();
        }
    }
}
