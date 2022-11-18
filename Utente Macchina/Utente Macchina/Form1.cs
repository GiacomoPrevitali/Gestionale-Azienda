using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
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
            //gestire data di scadenza
            lsB_Ordini.Items.Add("N° Ordine                 Pezzi da produrre              Data di Scasenza ");
            lsB_Ordini.Items.Add("1                             500                            28/11/2022 ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show();
            
            try
            {

               /* ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                remoteEP = new IPEndPoint(ipAddress, 5000);
                Sender = new Socket(ipAddress.AddressFamily,
                  SocketType.Stream, ProtocolType.Tcp);*/

                try
                {
                    int bytesRec = Sender.Receive(bytes);
                    r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    MessageBox.Show(r);



                    byte[] msg = Encoding.ASCII.GetBytes(n_Ordine+";"+txt_PezziProdotti.Text + ";" + Txt_Macchina.Text + ";" + Txt_Operatore.Text + DateTime.Now.ToString("dddd, dd MMMM yyyy")+";<EOF>");

                    int bytesSent = Sender.Send(msg);


                   
                    

                    Sender.Shutdown(SocketShutdown.Both);
                    Sender.Close();

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

        private void lsB_Ordini_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Ordine=lsB_Ordini.Text;
            if(Ordine!= null)
            {
                n_Ordine = Ordine.Substring(0, 1);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                remoteEP = new IPEndPoint(ipAddress, 5000);
                Sender = new Socket(ipAddress.AddressFamily,
                  SocketType.Stream, ProtocolType.Tcp);

                Sender.Connect(remoteEP);
                byte[] msg = Encoding.ASCII.GetBytes(Txt_Utente.Text+";<EOF>");

                int bytesSent = Sender.Send(msg);

                int bytesRec = Sender.Receive(bytes);
                r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Chiudi_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.ASCII.GetBytes("-1;<EOF>");

            int bytesSent = Sender.Send(msg);

            int bytesRec = Sender.Receive(bytes);
            r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
        }
    }
}
