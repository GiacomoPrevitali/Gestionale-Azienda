﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace Utente_Macchina
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        byte[] bytes = new byte[1024];
        IPAddress ipAddress;
        IPEndPoint remoteEP;
        Socket Sender;
        string n_Ordine;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Ordini o = new Ordini();
            string r;
            bool login = false;
            try
            {
                //Creare classe ordini e fare separatore
                ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                remoteEP = new IPEndPoint(ipAddress, 5000);
                Sender = new Socket(ipAddress.AddressFamily,
                  SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    Sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        Sender.RemoteEndPoint.ToString());


                    byte[] msg = Encoding.ASCII.GetBytes(txt_NomeUtente.Text+";"+txt_Password.Text+ ";<EOF>");
                    //Send
                    int bytesSent = Sender.Send(msg);


                    int bytesRec = Sender.Receive(bytes);
                    r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (Convert.ToInt32(r) == 0)
                    {
                        Form1 f = new Form1();
                        login = true;
                       // f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Utente o Password errati!","Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (login)
                    {
                        msg = Encoding.ASCII.GetBytes("a;<EOF>");
                        bytesSent = Sender.Send(msg);
                        Console.WriteLine(r);
                        bytesRec = Sender.Receive(bytes);
                        int Nlines = Convert.ToInt32(Encoding.ASCII.GetString(bytes, 0, bytesRec));
                        for (int i = 0; i < Nlines; i++)
                        {
                            bytesRec = Sender.Receive(bytes);
                            r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                            string[] v = r.Split(';');
                            o.setOrdine(Convert.ToInt32(v[0]), Convert.ToInt32(v[1]), v[2], v[3]);
                            lsb_Ordini.Items.Add(o.Nordine + "             " + o.Npezzi + "             " + o.Cod + "        " + o.DataConsegna);
                        }
                        MessageBox.Show(Convert.ToString("gg"));
                    }

                    //Sender.Shutdown(SocketShutdown.Both);
                    // Sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show(ane.ToString());
                }
                catch (SocketException se)
                {
                    MessageBox.Show("IMPOSSIBILE RAGGIUNGERE IL SERVER");
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n_Ordine != null)
            {
                byte[] msg = Encoding.ASCII.GetBytes("b;"+n_Ordine+";"+txt_Macchina.Text + ";" + txt_Operatore.Text + ";" + txt_qntPezzi.Text + ";<EOF>");
                int bytesSent = Sender.Send(msg);
                MessageBox.Show("sendato");
            }

        }

        private void lsb_Ordini_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Ordine = lsb_Ordini.Text;
            if (Ordine != null)
            {
                n_Ordine = Ordine.Substring(0, 1);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lsb_Ordini.Items.Add("Ordine     Pezzi        Codice        Data consegna");
        }
    }
}


class Ordini
{
    public int Nordine { get; set; }
    public int Npezzi { get; set; }
    public string Cod { get; set; }
    public string DataConsegna { get; set; }

    public Ordini()
    {
        Nordine = 0;
        Npezzi = 0;
        Cod = "";
        DataConsegna = "";
    }

    public void setOrdine(int No, int Np, string C, string Dc)
    {
        Nordine = No;
        Npezzi = Np;
        Cod = C;
        DataConsegna = Dc;
    }

}