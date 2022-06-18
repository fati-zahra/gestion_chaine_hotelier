namespace gestion_hotelier.UC
{
    partial class etape2
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.debut = new System.Windows.Forms.Label();
            this.classe = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fin = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.hotel = new System.Windows.Forms.Label();
            this.hotel1 = new System.Windows.Forms.ComboBox();
            this.nbr = new System.Windows.Forms.ComboBox();
            this.numero = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.categorie = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // debut
            // 
            this.debut.BackColor = System.Drawing.Color.MintCream;
            this.debut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debut.Location = new System.Drawing.Point(15, 313);
            this.debut.Name = "debut";
            this.debut.Size = new System.Drawing.Size(226, 36);
            this.debut.TabIndex = 1;
            this.debut.Text = "date debut";
            // 
            // classe
            // 
            this.classe.BackColor = System.Drawing.Color.MintCream;
            this.classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classe.Location = new System.Drawing.Point(15, 108);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(226, 36);
            this.classe.TabIndex = 3;
            this.classe.Text = "classe d\'hotel";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(342, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "select";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // fin
            // 
            this.fin.BackColor = System.Drawing.Color.MintCream;
            this.fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fin.Location = new System.Drawing.Point(15, 371);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(226, 36);
            this.fin.TabIndex = 8;
            this.fin.Text = "date fin";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(342, 373);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // hotel
            // 
            this.hotel.BackColor = System.Drawing.Color.MintCream;
            this.hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotel.Location = new System.Drawing.Point(15, 159);
            this.hotel.Name = "hotel";
            this.hotel.Size = new System.Drawing.Size(226, 36);
            this.hotel.TabIndex = 10;
            this.hotel.Text = "hotel";
            // 
            // hotel1
            // 
            this.hotel1.FormattingEnabled = true;
            this.hotel1.Location = new System.Drawing.Point(342, 159);
            this.hotel1.Name = "hotel1";
            this.hotel1.Size = new System.Drawing.Size(200, 24);
            this.hotel1.TabIndex = 13;
            this.hotel1.Text = "select";
            this.hotel1.SelectedIndexChanged += new System.EventHandler(this.hotel1_SelectedIndexChanged);
            // 
            // nbr
            // 
            this.nbr.FormattingEnabled = true;
            this.nbr.Location = new System.Drawing.Point(342, 261);
            this.nbr.Name = "nbr";
            this.nbr.Size = new System.Drawing.Size(200, 24);
            this.nbr.TabIndex = 21;
            this.nbr.Text = "select";
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.Color.MintCream;
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(15, 257);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(226, 36);
            this.numero.TabIndex = 20;
            this.numero.Text = "numero chambre";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(342, 214);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 24);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.Text = "select";
            // 
            // categorie
            // 
            this.categorie.BackColor = System.Drawing.Color.MintCream;
            this.categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorie.Location = new System.Drawing.Point(15, 210);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(226, 36);
            this.categorie.TabIndex = 18;
            this.categorie.Text = "categorie de chambre";
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(590, 496);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 22;
            this.valider.Text = "valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.MintCream;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(15, 418);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(226, 36);
            this.price.TabIndex = 23;
            this.price.Text = "prix";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "Etape 2 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // etape2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::gestion_hotelier.Properties.Resources.fl;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.nbr);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.categorie);
            this.Controls.Add(this.hotel1);
            this.Controls.Add(this.hotel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.fin);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.classe);
            this.Controls.Add(this.debut);
            this.Name = "etape2";
            this.Size = new System.Drawing.Size(685, 540);
            this.Load += new System.EventHandler(this.etape2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label debut;
        private System.Windows.Forms.Label classe;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label fin;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label hotel;
        private System.Windows.Forms.ComboBox hotel1;
        private System.Windows.Forms.ComboBox nbr;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label categorie;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
