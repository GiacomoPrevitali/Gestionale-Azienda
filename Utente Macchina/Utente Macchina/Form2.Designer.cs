﻿namespace Utente_Macchina
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rjB_Carica = new Utente_Macchina.Bottoni();
            this.rjB_login = new Utente_Macchina.Bottoni();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NomeUtente
            // 
            this.txt_NomeUtente.Location = new System.Drawing.Point(28, 38);
            this.txt_NomeUtente.Name = "txt_NomeUtente";
            this.txt_NomeUtente.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeUtente.TabIndex = 0;
            this.txt_NomeUtente.Text = "admin";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(227, 14);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "ACCEDI";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(28, 86);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.Text = "admin";
            // 
            // btn_Carica
            // 
            this.btn_Carica.Location = new System.Drawing.Point(61, 185);
            this.btn_Carica.Name = "btn_Carica";
            this.btn_Carica.Size = new System.Drawing.Size(75, 23);
            this.btn_Carica.TabIndex = 3;
            this.btn_Carica.Text = "Carica";
            this.btn_Carica.UseVisualStyleBackColor = true;
            this.btn_Carica.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsb_Ordini
            // 
            this.lsb_Ordini.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsb_Ordini.FormattingEnabled = true;
            this.lsb_Ordini.Location = new System.Drawing.Point(201, 23);
            this.lsb_Ordini.Name = "lsb_Ordini";
            this.lsb_Ordini.Size = new System.Drawing.Size(665, 251);
            this.lsb_Ordini.TabIndex = 4;
            this.lsb_Ordini.SelectedIndexChanged += new System.EventHandler(this.lsb_Ordini_SelectedIndexChanged);
            // 
            // txt_qntPezzi
            // 
            this.txt_qntPezzi.Location = new System.Drawing.Point(58, 51);
            this.txt_qntPezzi.Name = "txt_qntPezzi";
            this.txt_qntPezzi.Size = new System.Drawing.Size(100, 20);
            this.txt_qntPezzi.TabIndex = 5;
            // 
            // txt_Operatore
            // 
            this.txt_Operatore.Location = new System.Drawing.Point(58, 99);
            this.txt_Operatore.Name = "txt_Operatore";
            this.txt_Operatore.Size = new System.Drawing.Size(100, 20);
            this.txt_Operatore.TabIndex = 6;
            // 
            // txt_Macchina
            // 
            this.txt_Macchina.Location = new System.Drawing.Point(58, 154);
            this.txt_Macchina.Name = "txt_Macchina";
            this.txt_Macchina.Size = new System.Drawing.Size(100, 20);
            this.txt_Macchina.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.rjB_login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_NomeUtente);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Location = new System.Drawing.Point(96, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 155);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pezzi prodotti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Operatore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Macchina utilizzata";
            // 
            // rjB_Carica
            // 
            this.rjB_Carica.BackColor = System.Drawing.Color.Teal;
            this.rjB_Carica.FlatAppearance.BorderSize = 0;
            this.rjB_Carica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjB_Carica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjB_Carica.ForeColor = System.Drawing.Color.White;
            this.rjB_Carica.Location = new System.Drawing.Point(29, 214);
            this.rjB_Carica.Name = "rjB_Carica";
            this.rjB_Carica.Size = new System.Drawing.Size(150, 40);
            this.rjB_Carica.TabIndex = 9;
            this.rjB_Carica.Text = "CARICA";
            this.rjB_Carica.UseVisualStyleBackColor = false;
            this.rjB_Carica.Click += new System.EventHandler(this.rjB_Carica_Click);
            // 
            // rjB_login
            // 
            this.rjB_login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rjB_login.FlatAppearance.BorderSize = 0;
            this.rjB_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjB_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjB_login.ForeColor = System.Drawing.Color.White;
            this.rjB_login.Location = new System.Drawing.Point(189, 54);
            this.rjB_login.Name = "rjB_login";
            this.rjB_login.Size = new System.Drawing.Size(150, 42);
            this.rjB_login.TabIndex = 5;
            this.rjB_login.Text = "ACCEDI";
            this.rjB_login.UseVisualStyleBackColor = false;
            this.rjB_login.Click += new System.EventHandler(this.rjB_login_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 812);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjB_Carica);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Macchina);
            this.Controls.Add(this.txt_Operatore);
            this.Controls.Add(this.txt_qntPezzi);
            this.Controls.Add(this.lsb_Ordini);
            this.Controls.Add(this.btn_Carica);
            this.MinimumSize = new System.Drawing.Size(926, 359);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bottoni rjB_login;
        private Bottoni rjB_Carica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}