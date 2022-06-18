using gestion_hotelier.classes;
using gestion_hotelier.UC;
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

   

        private void button1_Click(object sender, EventArgs e)
        { 
            next1.Hide();
            button2.Show();
            button2.BringToFront();
            reservation2.Show();
            reservation2.BringToFront();
            button1.Hide();
            //premieRe_interface2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            next1.Show();
            next1.BringToFront();
            prev.Show();
            prev.BringToFront();
            etape22.Show();
            etape22.BringToFront();
            reservation2.Hide();
            //premieRe_interface2.Hide();
             

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            liste_client.Show();
            liste_client.BringToFront();
            liste_reservations1.Hide();
            liste_services1.Hide();
            panel3.Hide();
            service_consomation1.Hide();
            panel2.Hide();
            liste_client.Hide();
            room.Hide();
            review2.Hide();
            next1.Hide();
            button2.Hide();
            prev.Hide();
            reservation2.Hide();
            //premieRe_interface2.Hide();
            etape22.Hide();
            dispo_room2.Hide();
           liste_clients1.Hide();
            review2.Hide();
            rooms2.Hide();  
        }

        private void home_Click(object sender, EventArgs e)
        {
            liste_reservations1.Hide();
            liste_services1.Hide();
            service_consomation1.Hide();
            liste_client.Show();
            liste_client.BringToFront();

            room.Hide();
            review2.Hide();
            next1.Hide();
            button2.Hide();
            prev.Hide();
            reservation2.Hide();
            //premieRe_interface2.Hide();
            etape22.Hide();
            dispo_room2.Hide();
            liste_clients1.Hide();
            review2.Hide();
            rooms2.Hide();

        }

        private void etape21_Load(object sender, EventArgs e)
        {
            
        }

        private void prev_Click(object sender, EventArgs e)
        {
            button2.Show();
            button2.BringToFront();
            next1.Hide();
            reservation2.Show();
            reservation2.BringToFront();
            prev.Hide();
            etape22.Hide();
            //premieRe_interface2.Hide();
            
        }

        private void next1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            home.Show();
            home.BringToFront();
            next1.Hide();
            button2.Hide();
            prev.Hide();
            review2.Show();
            review2.BringToFront();
        }

        private void room_Click(object sender, EventArgs e)
        {
            rooms2.Show();
            button2.Hide();
            rooms2.BringToFront();
            next1.Hide();
            reservation2.Hide();
            //reservation1.BringToFront();
            prev.Hide();
            etape22.Hide();
            //premieRe_interface2.Hide();
        }

        private void rooms1_Load(object sender, EventArgs e)
        {

        }

        private void liste_client_Click(object sender, EventArgs e)
        {

            liste_reservations1.Show();
            liste_reservations1.BringToFront();
            liste_clients1.Hide();
            next1.Hide();
            button2.Hide();
            prev.Hide();
            review2.Hide();
            review2.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rooms_Click(object sender, EventArgs e)
        {
            reservation2.Show();
            reservation2.BringToFront();
            button2.Show();
            button3.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel2.BringToFront();
        }

        private void gestion_Click(object sender, EventArgs e)
        {
           

            rooms2.Show();
            rooms2.BringToFront();
            panel2.Hide();
            home.Show();
            home.BringToFront();

        }

        private void consult_Click(object sender, EventArgs e)
        {
            dispo_room2.Show();
            dispo_room2.BringToFront();
            panel2.Hide();
            home.Show();
            home.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            review2.Show();
            review2.BringToFront();
        }

        private void presta_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel3.BringToFront();

           


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            service_consomation1.Show();
            service_consomation1.BringToFront();
            panel3.Hide();
            home.Show();
            home.BringToFront();
        }

        private void liste_Click(object sender, EventArgs e)
        {
            liste_services1.Show();
            liste_services1.BringToFront();
            panel3.Hide();
            home.Show();
            home.BringToFront();
        }

       
    }
}
