namespace gestion_hotelier.UC
{
    partial class service_consomation
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
            this.prix = new System.Windows.Forms.Label();
            this.reser = new System.Windows.Forms.Label();
            this.cons = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.valider = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prix
            // 
            this.prix.BackColor = System.Drawing.Color.AliceBlue;
            this.prix.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix.Location = new System.Drawing.Point(38, 354);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(288, 40);
            this.prix.TabIndex = 0;
            this.prix.Text = "Prix";
            // 
            // reser
            // 
            this.reser.BackColor = System.Drawing.Color.AliceBlue;
            this.reser.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reser.Location = new System.Drawing.Point(38, 202);
            this.reser.Name = "reser";
            this.reser.Size = new System.Drawing.Size(288, 46);
            this.reser.TabIndex = 1;
            this.reser.Text = "Numero de reservation";
            this.reser.Click += new System.EventHandler(this.reser_Click);
            // 
            // cons
            // 
            this.cons.BackColor = System.Drawing.Color.AliceBlue;
            this.cons.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cons.Location = new System.Drawing.Point(38, 276);
            this.cons.Name = "cons";
            this.cons.Size = new System.Drawing.Size(288, 46);
            this.cons.TabIndex = 2;
            this.cons.Text = "Type de consommation";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(425, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "pettit dejeuer",
            "dejeuner",
            "dinne"});
            this.comboBox3.Location = new System.Drawing.Point(425, 280);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(192, 24);
            this.comboBox3.TabIndex = 5;
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.Color.LightCyan;
            this.valider.Location = new System.Drawing.Point(308, 505);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(114, 35);
            this.valider.TabIndex = 6;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(425, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ajouter une consommation : ";
            // 
            // service_consomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::gestion_hotelier.Properties.Resources.fl;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cons);
            this.Controls.Add(this.reser);
            this.Controls.Add(this.prix);
            this.Name = "service_consomation";
            this.Size = new System.Drawing.Size(689, 575);
            this.Load += new System.EventHandler(this.service_consomation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prix;
        private System.Windows.Forms.Label reser;
        private System.Windows.Forms.Label cons;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
