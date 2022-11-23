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


namespace Server
{
    public partial class Form1 : Form
    {
        Thread t;
        bool acceso = false;
        public static string data = null;
        int User = 0;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!acceso)
            {
                lbl_Stato.Text = "Acceso";
                lbl_Stato.ForeColor = System.Drawing.Color.Green;
                acceso = true;
                t = new Thread(server);
                t.IsBackground = true;
                t.Start();
            }
            else
            {
                lbl_Stato.Text = "Spento";
                lbl_Stato.ForeColor = System.Drawing.Color.Red;
                acceso = false;

            }

        }
        private void server()
        {
            IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);
            Socket listener = new Socket(ipAddress.AddressFamily,SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("Timeout : {0}", listener.ReceiveTimeout);
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    //FARE CONTO USER
                    //CHIUDERE TUTTO QUANDO PREMI x
                    Console.WriteLine("Waiting for a connection...");

                    Socket handler = listener.Accept();

                    ClientManager clientThread = new ClientManager(handler);
                    Thread t = new Thread(new ThreadStart(clientThread.doClient));
                    User++;
                    lbl_User.Text = "Utenti Connessi: "+Convert.ToString(User);
                    t.IsBackground = true;
                    t.Start();
                    User--;
                    lbl_User.Text = "Utenti Connessi: "+Convert.ToString(User);


                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }
        
        private void Add()
        {
            string Codice = "tps11";
            using (StreamWriter writetext = new StreamWriter(@"../../../File/Ordini/" + Codice +".csv"))
            {
                writetext.WriteLine(data);
                //codice+pezzi+data di scadenza


            }
        }

        private void Modifica() { }
        private void button2_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}

public class ClientManager
{

    Socket clientSocket;
    byte[] bytes = new Byte[1024];
    String data = "";

    public ClientManager(Socket clientSocket)
    {
        this.clientSocket = clientSocket;
    }

    public void doClient()
    {
        bool check = false;
        int c = -2;

        while (data != "Quit$")
        {

            // An incoming connection needs to be processed.  
            data = "";
            while (data.IndexOf("<EOF>") == -1)
            {
                int bytesRec = clientSocket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
            }
            byte[] msg = Encoding.ASCII.GetBytes(Convert.ToString(c));
            string[] info = data.Split(';');
            if (info[0] == "a")
            {

                var reader = new StreamReader(@"../../../File/Database.csv");
                int lines = 0;
                while (reader.ReadLine() != null)
                {
                    lines++;
                }
                reader.Close();
                msg = Encoding.ASCII.GetBytes(Convert.ToString(lines));
                //MessageBox.Show("NT"+lines);
                clientSocket.Send(msg);
                var reader1 = new StreamReader(@"../../../File/Database.csv");
                while (!reader1.EndOfStream)
                {
                    var l = reader1.ReadLine();
                    msg = Encoding.ASCII.GetBytes(Convert.ToString(l));
                    //MessageBox.Show(l);
                    clientSocket.Send(msg);
                }
                reader1.Close();

            }
            else
            {


                var reader = new StreamReader(@"../../../File/Utenti.csv");
                while (!reader.EndOfStream)
                {
                    var l = reader.ReadLine();
                    string[] v = l.Split(';');
                    if (v[0] == info[0] && v[1] == info[1])
                    {
                        check = true;
                    }
                }
                reader.Close();

                if (check)
                {
                    c = 0;
                }
                else
                {
                    c = -1;
                }
            }
            msg = Encoding.ASCII.GetBytes(Convert.ToString(c));
            // Show the data on the console.  
            Console.WriteLine("Messaggio ricevuto : {0}", data);

            // Echo the data back to the client.  
           // byte[] msg = Encoding.ASCII.GetBytes(data);

            clientSocket.Send(msg);
        }
        MessageBox.Show("cc");
        clientSocket.Shutdown(SocketShutdown.Both);
        clientSocket.Close();
        data = "";

    }
}

//SI CONNETTE TRAMITE UN LOGIN
//LO ACCETTA E GLI MANDA GLI ORDINI
//SELEZIONA, E RITORNA LE MODIFICHE
//IL SERVER ACCETTA E MODIFICA I DATI
//LA CONNESSIONE SI CHIUDE