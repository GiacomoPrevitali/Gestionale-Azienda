using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Utente_Macchina
{
    public partial class Macchina : Form
    {
        public Macchina()
        {
            InitializeComponent();
        }
        byte[] bytes = new byte[1024];
        IPAddress ipAddress;
        IPEndPoint remoteEP;
        Socket Sender;
        string n_Ordine;
        Thread t;
        bool login = false;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                remoteEP = new IPEndPoint(ipAddress, 5000);
                Sender = new Socket(ipAddress.AddressFamily,
                  SocketType.Stream, ProtocolType.Tcp);
                Sender.Connect(remoteEP);



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

        private void Form2_Load(object sender, EventArgs e)
        {
            lsb_Ordini.Items.Add("Ordine     Pezzi        Codice        Data consegna");

        }

        private void aggiorna()
        {
            try
            {
                while (true)
                {
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
                        // MessageBox.Show(r);
                        o.setOrdine(Convert.ToInt32(v[0]), Convert.ToInt32(v[1]), v[2], v[3]);
                        this.Invoke((MethodInvoker)(() => lsb_Ordini.Items.Add(o.Nordine + "             " + o.Npezzi + "             " + o.Cod + "        " + o.DataConsegna)));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Server non raggiungibile", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        bool first=true;
        private void rjB_login_Click(object sender, EventArgs e)
        {
            if (txt_NomeUtente.Text != "<EOF>" && txt_Password.Text != "<EOF>")
            {
                if (txt_NomeUtente.Text != "" && txt_Password.Text != "")
                {
                    string r;
                    if (first)
                    {
                        lsb_Ordini.Items.Clear();
                        lsb_Ordini.Items.Add("Ordine     Pezzi        Codice        Data consegna");
                        first = false;
                    }
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


                            byte[] msg = Encoding.ASCII.GetBytes(txt_NomeUtente.Text + ";" + txt_Password.Text + ";<EOF>");
                            //Send
                            int bytesSent = Sender.Send(msg);


                            int bytesRec = Sender.Receive(bytes);
                            r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                            if (Convert.ToInt32(r) == 0)
                            {
                                Form1 f = new Form1();
                                login = true;
                                panel1.Visible = false;
                                // f.Show();
                            }
                            else
                            {
                                MessageBox.Show("Utente o Password errati!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            if (login)
                            {
                                msg = Encoding.ASCII.GetBytes("a;<EOF>");
                                bytesSent = Sender.Send(msg);
                                Console.WriteLine(r);
                                Scrivi();
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
        private void Scrivi()
        {
            string r;
            Ordini o = new Ordini();
            int bytesRec = Sender.Receive(bytes);
            int Nlines = Convert.ToInt32(Encoding.ASCII.GetString(bytes, 0, bytesRec));

            for (int i = 0; i < Nlines; i++)
            {
                bytesRec = Sender.Receive(bytes);
                r = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                Console.WriteLine(r);
                string[] v = r.Split(';');
                o.setOrdine(Convert.ToInt32(v[0]), Convert.ToInt32(v[1]), v[2], v[3]);
                lsb_Ordini.Items.Add(o.Nordine + "             " + o.Npezzi + "             " + o.Cod + "        " + o.DataConsegna);
            }
        }
        private void rjB_Carica_Click(object sender, EventArgs e)
        {
            if (n_Ordine != null)
            {
                if (txt_Macchina.Text != "<EOF>" && txt_qntPezzi.Text != "<EOF>" && txt_Operatore.Text != "<EOF>")
                {
                    if (txt_Macchina.Text != "" && txt_qntPezzi.Text != "" && txt_Operatore.Text != "")
                    {
                        byte[] msg = Encoding.ASCII.GetBytes("b;" + n_Ordine + ";" + txt_Macchina.Text + ";" + txt_Operatore.Text + ";" + txt_qntPezzi.Text + ";<EOF>");
                        int bytesSent = Sender.Send(msg);
                        txt_Macchina.Text = "";
                        txt_qntPezzi.Text = "";
                        txt_Operatore.Text = "";
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
            else
            {
                MessageBox.Show("Ordine non selezionato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void rjB_Chiudi_Click(object sender, EventArgs e)
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
                int bytesSent = Sender.Send(msg);
                this.Close();
            }
            catch
            {
                this.Close();
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
