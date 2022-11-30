using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Utente_Macchina
{
    public partial class Form1 : Form
    {
        byte[] bytes = new byte[1024];
        IPAddress ipAddress;
        IPEndPoint remoteEP;
        Socket Sender;
        string n_Ordine;
        string r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //gestire data di scadenza
            lsB_Ordini.Items.Add("N° Ordine                 Pezzi da produrre              Data di Scasenza ");
            lsB_Ordini.Items.Add("1                             500                            28/11/2022 ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.ASCII.GetBytes("cc ;<EOF>");
            MessageBox.Show("aa");
            int bytesSent = Sender.Send(msg);


            /* try
             {

                 ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                 remoteEP = new IPEndPoint(ipAddress, 5000);
                 Sender = new Socket(ipAddress.AddressFamily,
                   SocketType.Stream, ProtocolType.Tcp);

                 try
                 {
                     Sender.Connect(remoteEP);

                     Console.WriteLine("Socket connected to {0}",
                         Sender.RemoteEndPoint.ToString());


                     byte[] msg = Encoding.ASCII.GetBytes("cc"+";<EOF>");
                     //Send
                     int bytesSent = Sender.Send(msg);


                     int bytesRec = Sender.Receive(bytes);
                     r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                     if (Convert.ToInt32(r) == 0)
                     {
                         Form1 f = new Form1();
                         f.Show();
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
             }*/
        }

        private void lsB_Ordini_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Ordine = lsB_Ordini.Text;
            if (Ordine != null)
            {
                n_Ordine = Ordine.Substring(0, 1);
            }

        }

    }
}



