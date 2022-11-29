using System;
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
using System.Threading;
using System.IO;


namespace Utente_Gestionale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] bytes = new byte[1024];
        IPAddress ipAddress;
        IPEndPoint remoteEP;
        Socket Sender;
        string n_Ordine;

        private void button1_Click(object sender, EventArgs e)
        {
            string r;
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


                    byte[] msg = Encoding.ASCII.GetBytes("c;"+txt_Gestore.Text+ ";" + txt_PassGestore.Text + ";<EOF>");
                    //Send
                    int bytesSent = Sender.Send(msg);


                    int bytesRec = Sender.Receive(bytes);
                    r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (Convert.ToInt32(r) == 0)
                    {
                        Form1 f = new Form1();
                        MessageBox.Show("ggggg", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        panel1.Visible = false;
                        // f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Utente o Password errati!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void btn_Aggiungi_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.ASCII.GetBytes("d;" + txt_Pezzi.Text + ";" + txt_cod.Text+";"+txt_scadenza.Text+ ";<EOF>");
            int bytesSent = Sender.Send(msg);

            int bytesRec = Sender.Receive(bytes);
            string r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            if (r == "0")
            {
                MessageBox.Show("Ordine Aggiunto");
            }
            txt_scadenza.Text = "";
            txt_Pezzi.Text = "";
            txt_cod.Text = "";
        }
    }
}
