namespace gestion_hotelier
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.next1 = new System.Windows.Forms.Button();
            this.room = new System.Windows.Forms.Button();
            this.liste_client = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.liste_services1 = new gestion_hotelier.UC.liste_services();
            this.panel3 = new System.Windows.Forms.Panel();
            this.liste = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.service_consomation1 = new gestion_hotelier.UC.service_consomation();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.consult = new System.Windows.Forms.Button();
            this.gestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reserver = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.consulter = new System.Windows.Forms.Button();
            this.presta = new System.Windows.Forms.Button();
            this.etape22 = new gestion_hotelier.UC.etape2();
            this.reservation2 = new gestion_hotelier.UC.reservation();
            this.dispo_room2 = new gestion_hotelier.UC.dispo_room();
            this.liste_clients1 = new gestion_hotelier.UC.liste_clients();
            this.rooms2 = new gestion_hotelier.UC.rooms();
            this.review2 = new gestion_hotelier.UC.review();
            this.liste_reservations1 = new gestion_hotelier.UC.liste_reservations();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reserver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(12, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 9;
            this.home.Text = "HOME";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(12, 133);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(76, 25);
            this.prev.TabIndex = 10;
            this.prev.Text = "prev";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next1
            // 
            this.next1.Location = new System.Drawing.Point(12, 174);
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(75, 23);
            this.next1.TabIndex = 12;
            this.next1.Text = "next";
            this.next1.UseVisualStyleBackColor = true;
            this.next1.Click += new System.EventHandler(this.next1_Click);
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(13, 217);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(75, 23);
            this.room.TabIndex = 14;
            this.room.Text = "rooms";
            this.room.UseVisualStyleBackColor = true;
            this.room.Click += new System.EventHandler(this.room_Click);
            // 
            // liste_client
            // 
            this.liste_client.Location = new System.Drawing.Point(13, 266);
            this.liste_client.Name = "liste_client";
            this.liste_client.Size = new System.Drawing.Size(75, 23);
            this.liste_client.TabIndex = 16;
            this.liste_client.Text = "liste";
            this.liste_client.UseVisualStyleBackColor = true;
            this.liste_client.Click += new System.EventHandler(this.liste_client_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.liste_services1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.service_consomation1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reserver);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.consulter);
            this.panel1.Controls.Add(this.presta);
            this.panel1.Location = new System.Drawing.Point(370, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 694);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // liste_services1
            // 
            this.liste_services1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("liste_services1.BackgroundImage")));
            this.liste_services1.Location = new System.Drawing.Point(3, 4);
            this.liste_services1.Name = "liste_services1";
            this.liste_services1.Size = new System.Drawing.Size(621, 639);
            this.liste_services1.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.liste);
            this.panel3.Controls.Add(this.add);
            this.panel3.Location = new System.Drawing.Point(190, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 100);
            this.panel3.TabIndex = 30;
            // 
            // liste
            // 
            this.liste.BackColor = System.Drawing.Color.WhiteSmoke;
            this.liste.Location = new System.Drawing.Point(3, 51);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(105, 36);
            this.liste.TabIndex = 1;
            this.liste.Text = "liste";
            this.liste.UseVisualStyleBackColor = false;
            this.liste.Click += new System.EventHandler(this.liste_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.add.Location = new System.Drawing.Point(3, 0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(105, 42);
            this.add.TabIndex = 0;
            this.add.Text = "ajouter";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // service_consomation1
            // 
            this.service_consomation1.BackColor = System.Drawing.Color.White;
            this.service_consomation1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("service_consomation1.BackgroundImage")));
            this.service_consomation1.Location = new System.Drawing.Point(169, -16);
            this.service_consomation1.Name = "service_consomation1";
            this.service_consomation1.Size = new System.Drawing.Size(677, 761);
            this.service_consomation1.TabIndex = 25;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = global::gestion_hotelier.Properties.Resources._20621874661637748136_128;
            this.pictureBox5.Location = new System.Drawing.Point(339, 181);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(124, 127);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::gestion_hotelier.Properties.Resources._8800325181578983337_128;
            this.pictureBox4.Location = new System.Drawing.Point(339, 353);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(124, 119);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::gestion_hotelier.Properties.Resources._18898947581580359467_128;
            this.pictureBox3.Location = new System.Drawing.Point(115, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::gestion_hotelier.Properties.Resources.icons8_hotel_16;
            this.pictureBox1.Location = new System.Drawing.Point(405, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::gestion_hotelier.Properties.Resources._7900804961639226373_128;
            this.pictureBox2.Location = new System.Drawing.Point(115, 353);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.consult);
            this.panel2.Controls.Add(this.gestion);
            this.panel2.Location = new System.Drawing.Point(438, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 100);
            this.panel2.TabIndex = 5;
            // 
            // consult
            // 
            this.consult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.consult.Location = new System.Drawing.Point(3, 51);
            this.consult.Name = "consult";
            this.consult.Size = new System.Drawing.Size(105, 36);
            this.consult.TabIndex = 1;
            this.consult.Text = "consulter";
            this.consult.UseVisualStyleBackColor = false;
            this.consult.Click += new System.EventHandler(this.consult_Click);
            // 
            // gestion
            // 
            this.gestion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gestion.Location = new System.Drawing.Point(3, 0);
            this.gestion.Name = "gestion";
            this.gestion.Size = new System.Drawing.Size(105, 42);
            this.gestion.TabIndex = 0;
            this.gestion.Text = "gestion";
            this.gestion.UseVisualStyleBackColor = false;
            this.gestion.Click += new System.EventHandler(this.gestion_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to RBBI       hotel";
            // 
            // reserver
            // 
            this.reserver.BackColor = System.Drawing.Color.Snow;
            this.reserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserver.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.reserver.Location = new System.Drawing.Point(115, 314);
            this.reserver.Name = "reserver";
            this.reserver.Size = new System.Drawing.Size(113, 31);
            this.reserver.TabIndex = 0;
            this.reserver.Text = "Reserver";
            this.reserver.UseVisualStyleBackColor = false;
            this.reserver.Click += new System.EventHandler(this.rooms_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(339, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 37);
            this.button3.TabIndex = 1;
            this.button3.Text = "Archive";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // consulter
            // 
            this.consulter.BackColor = System.Drawing.Color.AliceBlue;
            this.consulter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulter.ForeColor = System.Drawing.Color.Fuchsia;
            this.consulter.Location = new System.Drawing.Point(339, 314);
            this.consulter.Name = "consulter";
            this.consulter.Size = new System.Drawing.Size(119, 31);
            this.consulter.TabIndex = 2;
            this.consulter.Text = "Consulter chambre";
            this.consulter.UseVisualStyleBackColor = false;
            this.consulter.Click += new System.EventHandler(this.button4_Click);
            // 
            // presta
            // 
            this.presta.BackColor = System.Drawing.Color.Snow;
            this.presta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.presta.Location = new System.Drawing.Point(115, 478);
            this.presta.Name = "presta";
            this.presta.Size = new System.Drawing.Size(116, 37);
            this.presta.TabIndex = 3;
            this.presta.Text = "service ";
            this.presta.UseVisualStyleBackColor = false;
            this.presta.Click += new System.EventHandler(this.presta_Click);
            // 
            // etape22
            // 
            this.etape22.BackColor = System.Drawing.Color.LightCyan;
            this.etape22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("etape22.BackgroundImage")));
            this.etape22.Location = new System.Drawing.Point(328, 9);
            this.etape22.Name = "etape22";
            this.etape22.Size = new System.Drawing.Size(677, 805);
            this.etape22.TabIndex = 19;
            // 
            // reservation2
            // 
            this.reservation2.BackColor = System.Drawing.Color.Linen;
            this.reservation2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reservation2.BackgroundImage")));
            this.reservation2.Location = new System.Drawing.Point(328, 9);
            this.reservation2.Name = "reservation2";
            this.reservation2.Size = new System.Drawing.Size(671, 899);
            this.reservation2.TabIndex = 20;
            // 
            // dispo_room2
            // 
            this.dispo_room2.BackColor = System.Drawing.Color.White;
            this.dispo_room2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dispo_room2.BackgroundImage")));
            this.dispo_room2.Location = new System.Drawing.Point(328, 9);
            this.dispo_room2.Name = "dispo_room2";
            this.dispo_room2.Size = new System.Drawing.Size(677, 785);
            this.dispo_room2.TabIndex = 21;
            // 
            // liste_clients1
            // 
            this.liste_clients1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.liste_clients1.Location = new System.Drawing.Point(328, 9);
            this.liste_clients1.Name = "liste_clients1";
            this.liste_clients1.Size = new System.Drawing.Size(677, 896);
            this.liste_clients1.TabIndex = 22;
            // 
            // rooms2
            // 
            this.rooms2.BackColor = System.Drawing.Color.LightCyan;
            this.rooms2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rooms2.BackgroundImage")));
            this.rooms2.Location = new System.Drawing.Point(334, 5);
            this.rooms2.Name = "rooms2";
            this.rooms2.Size = new System.Drawing.Size(671, 772);
            this.rooms2.TabIndex = 23;
            // 
            // review2
            // 
            this.review2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.review2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("review2.BackgroundImage")));
            this.review2.Location = new System.Drawing.Point(195, 5);
            this.review2.Name = "review2";
            this.review2.Size = new System.Drawing.Size(824, 761);
            this.review2.TabIndex = 24;
            // 
            // liste_reservations1
            // 
            this.liste_reservations1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("liste_reservations1.BackgroundImage")));
            this.liste_reservations1.Location = new System.Drawing.Point(195, 33);
            this.liste_reservations1.Name = "liste_reservations1";
            this.liste_reservations1.Size = new System.Drawing.Size(824, 620);
            this.liste_reservations1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestion_hotelier.Properties.Resources.hotel;
            this.ClientSize = new System.Drawing.Size(1395, 660);
            this.Controls.Add(this.liste_reservations1);
            this.Controls.Add(this.review2);
            this.Controls.Add(this.rooms2);
            this.Controls.Add(this.liste_clients1);
            this.Controls.Add(this.dispo_room2);
            this.Controls.Add(this.reservation2);
            this.Controls.Add(this.etape22);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.liste_client);
            this.Controls.Add(this.room);
            this.Controls.Add(this.next1);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.home);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "welcome to RBBI Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UC.reservation reservation1;
       // private UC.PREMIERe_interface premieRe_interface2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UC.etape2 etape21;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button prev;
        private UC.review review1;
        private System.Windows.Forms.Button next1;
        private UC.rooms rooms1;
        private System.Windows.Forms.Button room;
        private System.Windows.Forms.Button liste_client;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reserver;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button consulter;
        private System.Windows.Forms.Button presta;
        private UC.dispo_room dispo_room1;
        private UC.etape2 etape22;
        private UC.reservation reservation2;
        private UC.dispo_room dispo_room2;
        private UC.liste_clients liste_clients1;
        private UC.rooms rooms2;
        private UC.review review2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button consult;
        private System.Windows.Forms.Button gestion;
        private UC.service_consomation service_consomation1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private UC.liste_services liste_services1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button liste;
        private System.Windows.Forms.Button add;
        private UC.liste_reservations liste_reservations1;
    }
}

