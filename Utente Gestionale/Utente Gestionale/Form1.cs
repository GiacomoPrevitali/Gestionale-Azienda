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
        Thread t;
        string n_Ordine;
        bool login = false;
        bool first = true;

        private void btn_remove_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.ASCII.GetBytes("e;" +n_Ordine+ ";<EOF>");
            int bytesSent = Sender.Send(msg);
        }

        private void btn_Chiudi_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes("Quit$<EOF>");
                //Send
                int bytesSent = Sender.Send(msg);
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }
        private void btn_ChiudiL_Click(object sender, EventArgs e)
        {
            try
            {
                if (!login)
                {
                    ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                    remoteEP = new IPEndPoint(ipAddress, 5000);
                    Sender = new Socket(ipAddress.AddressFamily,
                      SocketType.Stream, ProtocolType.Tcp);
                    Sender.Connect(remoteEP);
                }


                byte[] msg = Encoding.ASCII.GetBytes("Quit$<EOF>");
                //Send
                int bytesSent = Sender.Send(msg);
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }
        private void aggiorna()
        {
            while (true)
            {
                //fare first
                    Thread.Sleep(10000);

                
                byte[] msg = Encoding.ASCII.GetBytes("a;<EOF>");
                int bytesSent = Sender.Send(msg);
                // Scrivi();


                string r;
                Ordini o = new Ordini();
                int bytesRec = Sender.Receive(bytes);
                int Nlines = Convert.ToInt32(Encoding.ASCII.GetString(bytes, 0, bytesRec));

                this.Invoke((MethodInvoker)(() => lsb_Ordini.Items.Clear()));
                this.Invoke((MethodInvoker)(() => lsb_Ordini.Items.Add("Ordine     Pezzi        Codice        Data consegna")));

                for (int i = 0; i < Nlines; i++)
                {
                    bytesRec = Sender.Receive(bytes);
                    r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    string[] v = r.Split(';');
                    o.setOrdine(Convert.ToInt32(v[0]), Convert.ToInt32(v[1]), v[2], v[3]);
                    this.Invoke((MethodInvoker)(() => lsb_Ordini.Items.Add(o.Nordine + "             " + o.Npezzi + "             " + o.Cod + "        " + o.DataConsegna)));
                }
            }
        }
        private void rjB_AggOrdine_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text != "<EOF>" && txt_Pezzi.Text != "<EOF>" && txt_scadenza.Text != "<EOF>")
            {
                if (txt_cod.Text != "" && txt_Pezzi.Text != "" && txt_scadenza.Text != "")
                {
                    byte[] msg = Encoding.ASCII.GetBytes("d;" + txt_Pezzi.Text + ";" + txt_cod.Text + ";" + txt_scadenza.Text + ";<EOF>");
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
                else
                {
                    MessageBox.Show("Valori non inseriti!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Valori non validi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bottoni1_Click(object sender, EventArgs e)
        {
            if (txt_Gestore.Text != "<EOF>" && txt_PassGestore.Text != "<EOF>")
            {
                if (txt_Gestore.Text != "" && txt_PassGestore.Text != "")
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


                            byte[] msg = Encoding.ASCII.GetBytes("c;" + txt_Gestore.Text + ";" + txt_PassGestore.Text + ";<EOF>");
                            //Send
                            int bytesSent = Sender.Send(msg);


                            int bytesRec = Sender.Receive(bytes);
                            r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                            if (Convert.ToInt32(r) == 0)
                            {
                                Form1 f = new Form1();
                                MessageBox.Show("ggggg", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                panel1.Visible = false;
                                login = true;
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
                    t = new Thread(aggiorna);
                    t.IsBackground = true;
                    t.Start();
                }
                else
                {
                    MessageBox.Show("Valori non inseriti!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Valori non validi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lsb_Ordini_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Ordine = lsb_Ordini.Text;
                if (Ordine != null)
                {
                    n_Ordine = Ordine.Substring(0, 1);
                }
            }
            catch
            {
                MessageBox.Show("Ordine non Valido");
            }
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
