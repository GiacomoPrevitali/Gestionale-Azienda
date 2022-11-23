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
            this.button1 = new System.Windows.Forms.Button();
            this.lsb_Ordini = new System.Windows.Forms.ListBox();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 814);
            this.Controls.Add(this.lsb_Ordini);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_NomeUtente);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomeUtente;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsb_Ordini;
    }
}