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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Gestore = new System.Windows.Forms.TextBox();
            this.txt_PassGestore = new System.Windows.Forms.TextBox();
            this.txt_Pezzi = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_scadenza = new System.Windows.Forms.TextBox();
            this.btn_Aggiungi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Gestore
            // 
            this.txt_Gestore.Location = new System.Drawing.Point(10, 38);
            this.txt_Gestore.Name = "txt_Gestore";
            this.txt_Gestore.Size = new System.Drawing.Size(100, 20);
            this.txt_Gestore.TabIndex = 1;
            // 
            // txt_PassGestore
            // 
            this.txt_PassGestore.Location = new System.Drawing.Point(10, 92);
            this.txt_PassGestore.Name = "txt_PassGestore";
            this.txt_PassGestore.Size = new System.Drawing.Size(100, 20);
            this.txt_PassGestore.TabIndex = 2;
            // 
            // txt_Pezzi
            // 
            this.txt_Pezzi.Location = new System.Drawing.Point(464, 122);
            this.txt_Pezzi.Name = "txt_Pezzi";
            this.txt_Pezzi.Size = new System.Drawing.Size(100, 20);
            this.txt_Pezzi.TabIndex = 3;
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(464, 177);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 4;
            // 
            // txt_scadenza
            // 
            this.txt_scadenza.Location = new System.Drawing.Point(464, 241);
            this.txt_scadenza.Name = "txt_scadenza";
            this.txt_scadenza.Size = new System.Drawing.Size(100, 20);
            this.txt_scadenza.TabIndex = 5;
            // 
            // btn_Aggiungi
            // 
            this.btn_Aggiungi.Location = new System.Drawing.Point(629, 189);
            this.btn_Aggiungi.Name = "btn_Aggiungi";
            this.btn_Aggiungi.Size = new System.Drawing.Size(75, 49);
            this.btn_Aggiungi.TabIndex = 6;
            this.btn_Aggiungi.Text = "Aggiungi Ordine";
            this.btn_Aggiungi.UseVisualStyleBackColor = true;
            this.btn_Aggiungi.Click += new System.EventHandler(this.btn_Aggiungi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_PassGestore);
            this.panel1.Controls.Add(this.txt_Gestore);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(49, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 154);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantità pezzi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data di Scadenza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codice ordine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Aggiungi);
            this.Controls.Add(this.txt_scadenza);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.txt_Pezzi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Gestore;
        private System.Windows.Forms.TextBox txt_PassGestore;
        private System.Windows.Forms.TextBox txt_Pezzi;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_scadenza;
        private System.Windows.Forms.Button btn_Aggiungi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

