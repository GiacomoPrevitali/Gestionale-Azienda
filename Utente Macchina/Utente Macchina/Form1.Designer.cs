namespace Utente_Macchina
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
            this.txt_PezziProdotti = new System.Windows.Forms.TextBox();
            this.Txt_Operatore = new System.Windows.Forms.TextBox();
            this.Txt_Macchina = new System.Windows.Forms.TextBox();
            this.lsB_Ordini = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.Txt_Utente = new System.Windows.Forms.TextBox();
            this.btn_Chiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_PezziProdotti
            // 
            this.txt_PezziProdotti.Location = new System.Drawing.Point(43, 25);
            this.txt_PezziProdotti.Name = "txt_PezziProdotti";
            this.txt_PezziProdotti.Size = new System.Drawing.Size(100, 20);
            this.txt_PezziProdotti.TabIndex = 0;
            // 
            // Txt_Operatore
            // 
            this.Txt_Operatore.Location = new System.Drawing.Point(351, 25);
            this.Txt_Operatore.Name = "Txt_Operatore";
            this.Txt_Operatore.Size = new System.Drawing.Size(100, 20);
            this.Txt_Operatore.TabIndex = 1;
            // 
            // Txt_Macchina
            // 
            this.Txt_Macchina.Location = new System.Drawing.Point(204, 25);
            this.Txt_Macchina.Name = "Txt_Macchina";
            this.Txt_Macchina.Size = new System.Drawing.Size(100, 20);
            this.Txt_Macchina.TabIndex = 2;
            // 
            // lsB_Ordini
            // 
            this.lsB_Ordini.FormattingEnabled = true;
            this.lsB_Ordini.Location = new System.Drawing.Point(22, 77);
            this.lsB_Ordini.Name = "lsB_Ordini";
            this.lsB_Ordini.Size = new System.Drawing.Size(750, 355);
            this.lsB_Ordini.TabIndex = 3;
            this.lsB_Ordini.SelectedIndexChanged += new System.EventHandler(this.lsB_Ordini_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(531, 25);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.button2_Click);
            // 
            // Txt_Utente
            // 
            this.Txt_Utente.Location = new System.Drawing.Point(889, 37);
            this.Txt_Utente.Name = "Txt_Utente";
            this.Txt_Utente.Size = new System.Drawing.Size(100, 20);
            this.Txt_Utente.TabIndex = 6;
            // 
            // btn_Chiudi
            // 
            this.btn_Chiudi.Location = new System.Drawing.Point(980, 190);
            this.btn_Chiudi.Name = "btn_Chiudi";
            this.btn_Chiudi.Size = new System.Drawing.Size(75, 23);
            this.btn_Chiudi.TabIndex = 7;
            this.btn_Chiudi.Text = "Chiudi";
            this.btn_Chiudi.UseVisualStyleBackColor = true;
            this.btn_Chiudi.Click += new System.EventHandler(this.btn_Chiudi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 450);
            this.Controls.Add(this.btn_Chiudi);
            this.Controls.Add(this.Txt_Utente);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsB_Ordini);
            this.Controls.Add(this.Txt_Macchina);
            this.Controls.Add(this.Txt_Operatore);
            this.Controls.Add(this.txt_PezziProdotti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PezziProdotti;
        private System.Windows.Forms.TextBox Txt_Operatore;
        private System.Windows.Forms.TextBox Txt_Macchina;
        private System.Windows.Forms.ListBox lsB_Ordini;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox Txt_Utente;
        private System.Windows.Forms.Button btn_Chiudi;
    }
}

