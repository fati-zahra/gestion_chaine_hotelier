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

namespace gestion_hotelier
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        public static int num;

        gestion_reservation gestion_reservation = new gestion_reservation();
        gestion_consommation gestion_consommation  = new gestion_consommation();

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable reservation = new DataTable();
            reservation.Columns.Add("id", typeof(int));
            reservation.Columns.Add("debut", typeof(DateTime));
            reservation.Columns.Add("fin", typeof(DateTime));
            reservation.Columns.Add("montant", typeof(int));
            reservation.Columns.Add("chambre", typeof(string));
            reservation.Columns.Add("hotel", typeof(string));
            reservation.Columns.Add("consommation", typeof(string));
            reservation.Columns.Add("prix", typeof(int));
            reservation.Columns.Add("total", typeof(int));


            try
            { 
            DataRow row;
                var s = 0;


               

                Reservation res = gestion_reservation.reservation(num);
                 //var ser = gestion_consommation.consommation(num);
              //  var lst = tableCrud.Tables();
                row = reservation.NewRow();

             row["id"] = res.id;
             row["debut"] = res.debut;
             row["fin"] = res.fin;
             row["montant"] = res.montant;
             row["chambre"] = res.chambre;
             row["hotel"] = res.hotel;


                // row["consommation"] = ser[1];
                //row["prix"] = ser[2];


                reservation.Rows.Add(row);


                List<Service> listdata = gestion_consommation.consommation(num);

                foreach (var re in listdata)
                {
                    if (re.num_reservation == num)
                    {
                        row = reservation.NewRow();

                        row["consommation"] = re.consommation;
                        row["prix"] = re.prix;
                        s = s + re.prix;
                        reservation.Rows.Add(row);
                    }


                }
                row = reservation.NewRow();
                row["total"] = res.montant + s;
                reservation.Rows.Add(row);


                CrystalReport5 cr = new CrystalReport5();
                cr.SetDataSource(reservation);
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ex)
         {
               // Service ser = gestion_consommation.consommation(1);

                MessageBox.Show("error table rows");
         }


         /* CrystalReport1 cr = new CrystalReport1();


           cr.Database.Tables["reservation"].SetDataSource(reservation);

            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cr;*/

        }

        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport51 = new gestion_hotelier.CrystalReport5();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport51;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1078, 652);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1078, 652);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form2";
            this.Text = "facture";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }
    }
}
