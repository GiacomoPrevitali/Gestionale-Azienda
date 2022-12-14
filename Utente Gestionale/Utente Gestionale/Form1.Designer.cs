namespace Utente_Gestionale
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Gestore = new System.Windows.Forms.TextBox();
            this.txt_PassGestore = new System.Windows.Forms.TextBox();
            this.txt_Pezzi = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_scadenza = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ChiudiL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lsb_Ordini = new System.Windows.Forms.ListBox();
            this.bottoni1 = new Utente_Gestionale.Bottoni();
            this.bottoni2 = new Utente_Gestionale.Bottoni();
            this.rjB_Rimuovi = new Utente_Gestionale.Bottoni();
            this.rjB_AggOrdine = new Utente_Gestionale.Bottoni();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Gestore
            // 
            this.txt_Gestore.Location = new System.Drawing.Point(39, 35);
            this.txt_Gestore.Name = "txt_Gestore";
            this.txt_Gestore.Size = new System.Drawing.Size(100, 20);
            this.txt_Gestore.TabIndex = 1;
            // 
            // txt_PassGestore
            // 
            this.txt_PassGestore.Location = new System.Drawing.Point(39, 89);
            this.txt_PassGestore.Name = "txt_PassGestore";
            this.txt_PassGestore.Size = new System.Drawing.Size(100, 20);
            this.txt_PassGestore.TabIndex = 2;
            this.txt_PassGestore.UseSystemPasswordChar = true;
            // 
            // txt_Pezzi
            // 
            this.txt_Pezzi.Location = new System.Drawing.Point(32, 44);
            this.txt_Pezzi.Name = "txt_Pezzi";
            this.txt_Pezzi.Size = new System.Drawing.Size(100, 20);
            this.txt_Pezzi.TabIndex = 3;
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(32, 99);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 4;
            // 
            // txt_scadenza
            // 
            this.txt_scadenza.Location = new System.Drawing.Point(32, 163);
            this.txt_scadenza.Name = "txt_scadenza";
            this.txt_scadenza.Size = new System.Drawing.Size(100, 20);
            this.txt_scadenza.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bottoni1);
            this.panel1.Controls.Add(this.btn_ChiudiL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_PassGestore);
            this.panel1.Controls.Add(this.txt_Gestore);
            this.panel1.Location = new System.Drawing.Point(-7, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 360);
            this.panel1.TabIndex = 7;
            // 
            // btn_ChiudiL
            // 
            this.btn_ChiudiL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChiudiL.Location = new System.Drawing.Point(745, 323);
            this.btn_ChiudiL.Name = "btn_ChiudiL";
            this.btn_ChiudiL.Size = new System.Drawing.Size(75, 23);
            this.btn_ChiudiL.TabIndex = 12;
            this.btn_ChiudiL.Text = "Chiudi";
            this.btn_ChiudiL.UseVisualStyleBackColor = true;
            this.btn_ChiudiL.Click += new System.EventHandler(this.btn_ChiudiL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantità pezzi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data di Scadenza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codice ordine";
            // 
            // lsb_Ordini
            // 
            this.lsb_Ordini.FormattingEnabled = true;
            this.lsb_Ordini.Location = new System.Drawing.Point(254, 24);
            this.lsb_Ordini.Name = "lsb_Ordini";
            this.lsb_Ordini.Size = new System.Drawing.Size(572, 316);
            this.lsb_Ordini.TabIndex = 15;
            this.lsb_Ordini.SelectedIndexChanged += new System.EventHandler(this.lsb_Ordini_SelectedIndexChanged);
            // 
            // bottoni1
            // 
            this.bottoni1.BackColor = System.Drawing.Color.MidnightBlue;
            this.bottoni1.FlatAppearance.BorderSize = 0;
            this.bottoni1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottoni1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottoni1.ForeColor = System.Drawing.Color.White;
            this.bottoni1.Location = new System.Drawing.Point(39, 123);
            this.bottoni1.Name = "bottoni1";
            this.bottoni1.Size = new System.Drawing.Size(150, 40);
            this.bottoni1.TabIndex = 13;
            this.bottoni1.Text = "Login";
            this.bottoni1.UseVisualStyleBackColor = false;
            this.bottoni1.Click += new System.EventHandler(this.bottoni1_Click);
            // 
            // bottoni2
            // 
            this.bottoni2.BackColor = System.Drawing.Color.Navy;
            this.bottoni2.FlatAppearance.BorderSize = 0;
            this.bottoni2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottoni2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottoni2.ForeColor = System.Drawing.Color.White;
            this.bottoni2.Location = new System.Drawing.Point(21, 293);
            this.bottoni2.Name = "bottoni2";
            this.bottoni2.Size = new System.Drawing.Size(150, 40);
            this.bottoni2.TabIndex = 17;
            this.bottoni2.Text = "Chiudi";
            this.bottoni2.UseVisualStyleBackColor = false;
            this.bottoni2.Click += new System.EventHandler(this.bottoni2_Click);
            // 
            // rjB_Rimuovi
            // 
            this.rjB_Rimuovi.BackColor = System.Drawing.Color.DodgerBlue;
            this.rjB_Rimuovi.FlatAppearance.BorderSize = 0;
            this.rjB_Rimuovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjB_Rimuovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjB_Rimuovi.ForeColor = System.Drawing.Color.White;
            this.rjB_Rimuovi.Location = new System.Drawing.Point(21, 247);
            this.rjB_Rimuovi.Name = "rjB_Rimuovi";
            this.rjB_Rimuovi.Size = new System.Drawing.Size(150, 40);
            this.rjB_Rimuovi.TabIndex = 16;
            this.rjB_Rimuovi.Text = "Rimuovi";
            this.rjB_Rimuovi.UseVisualStyleBackColor = false;
            this.rjB_Rimuovi.Click += new System.EventHandler(this.rjB_Rimuovi_Click);
            // 
            // rjB_AggOrdine
            // 
            this.rjB_AggOrdine.BackColor = System.Drawing.Color.DarkTurquoise;
            this.rjB_AggOrdine.FlatAppearance.BorderSize = 0;
            this.rjB_AggOrdine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjB_AggOrdine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjB_AggOrdine.ForeColor = System.Drawing.Color.White;
            this.rjB_AggOrdine.Location = new System.Drawing.Point(21, 201);
            this.rjB_AggOrdine.Name = "rjB_AggOrdine";
            this.rjB_AggOrdine.Size = new System.Drawing.Size(150, 40);
            this.rjB_AggOrdine.TabIndex = 14;
            this.rjB_AggOrdine.Text = "Aggiungi Ordine";
            this.rjB_AggOrdine.UseVisualStyleBackColor = false;
            this.rjB_AggOrdine.Click += new System.EventHandler(this.rjB_AggOrdine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 350);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottoni2);
            this.Controls.Add(this.rjB_Rimuovi);
            this.Controls.Add(this.lsb_Ordini);
            this.Controls.Add(this.rjB_AggOrdine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_scadenza);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.txt_Pezzi);
            this.MinimumSize = new System.Drawing.Size(853, 389);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Gestore;
        private System.Windows.Forms.TextBox txt_PassGestore;
        private System.Windows.Forms.TextBox txt_Pezzi;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_scadenza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ChiudiL;
        private Bottoni rjB_AggOrdine;
        private Bottoni bottoni1;
        private System.Windows.Forms.ListBox lsb_Ordini;
        private Bottoni rjB_Rimuovi;
        private Bottoni bottoni2;
    }
}

