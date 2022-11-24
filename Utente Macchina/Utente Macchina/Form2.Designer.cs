namespace Utente_Macchina
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_NomeUtente = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Carica = new System.Windows.Forms.Button();
            this.lsb_Ordini = new System.Windows.Forms.ListBox();
            this.txt_qntPezzi = new System.Windows.Forms.TextBox();
            this.txt_Operatore = new System.Windows.Forms.TextBox();
            this.txt_Macchina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_NomeUtente
            // 
            this.txt_NomeUtente.Location = new System.Drawing.Point(107, 98);
            this.txt_NomeUtente.Name = "txt_NomeUtente";
            this.txt_NomeUtente.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeUtente.TabIndex = 0;
            this.txt_NomeUtente.Text = "admin";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(283, 98);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "ACCEDI";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(107, 146);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.Text = "admin";
            // 
            // btn_Carica
            // 
            this.btn_Carica.Location = new System.Drawing.Point(752, 115);
            this.btn_Carica.Name = "btn_Carica";
            this.btn_Carica.Size = new System.Drawing.Size(75, 23);
            this.btn_Carica.TabIndex = 3;
            this.btn_Carica.Text = "Carica";
            this.btn_Carica.UseVisualStyleBackColor = true;
            this.btn_Carica.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsb_Ordini
            // 
            this.lsb_Ordini.FormattingEnabled = true;
            this.lsb_Ordini.Location = new System.Drawing.Point(86, 303);
            this.lsb_Ordini.Name = "lsb_Ordini";
            this.lsb_Ordini.Size = new System.Drawing.Size(665, 251);
            this.lsb_Ordini.TabIndex = 4;
            this.lsb_Ordini.SelectedIndexChanged += new System.EventHandler(this.lsb_Ordini_SelectedIndexChanged);
            // 
            // txt_qntPezzi
            // 
            this.txt_qntPezzi.Location = new System.Drawing.Point(1099, 214);
            this.txt_qntPezzi.Name = "txt_qntPezzi";
            this.txt_qntPezzi.Size = new System.Drawing.Size(100, 20);
            this.txt_qntPezzi.TabIndex = 5;
            // 
            // txt_Operatore
            // 
            this.txt_Operatore.Location = new System.Drawing.Point(1099, 262);
            this.txt_Operatore.Name = "txt_Operatore";
            this.txt_Operatore.Size = new System.Drawing.Size(100, 20);
            this.txt_Operatore.TabIndex = 6;
            // 
            // txt_Macchina
            // 
            this.txt_Macchina.Location = new System.Drawing.Point(1099, 303);
            this.txt_Macchina.Name = "txt_Macchina";
            this.txt_Macchina.Size = new System.Drawing.Size(100, 20);
            this.txt_Macchina.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 814);
            this.Controls.Add(this.txt_Macchina);
            this.Controls.Add(this.txt_Operatore);
            this.Controls.Add(this.txt_qntPezzi);
            this.Controls.Add(this.lsb_Ordini);
            this.Controls.Add(this.btn_Carica);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_NomeUtente);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomeUtente;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Carica;
        private System.Windows.Forms.ListBox lsb_Ordini;
        private System.Windows.Forms.TextBox txt_qntPezzi;
        private System.Windows.Forms.TextBox txt_Operatore;
        private System.Windows.Forms.TextBox txt_Macchina;
    }
}