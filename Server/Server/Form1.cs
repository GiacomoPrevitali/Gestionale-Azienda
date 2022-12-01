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
        Ordini o = new Ordini();
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
                button1.Text = "Spegni";
                lbl_Stato.ForeColor = System.Drawing.Color.Green;
                acceso = true;
                t = new Thread(server);
                t.IsBackground = true;
                t.Start();
            }
            else
            {
                button1.Text = "AVVIA";
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

    }
}

public class ClientManager
{

    Socket clientSocket;
    byte[] bytes = new Byte[1024];
    String data = "";
    Ordini[] o = new Ordini[100];
    bool change = false;
    int lines = 0;
    public ClientManager(Socket clientSocket)
    {
        this.clientSocket = clientSocket;
    }

    public void doClient()
    {
        bool check = false;
        int c = -2;
        for(int i=0; i<o.Length; i++)
        {
            o[i] = new Ordini();
        }
        while (data != "Quit$<EOF>")
        {
            Console.WriteLine("Wait");
            data = "";
            while (data.IndexOf("<EOF>") == -1)
            {
                int bytesRec = clientSocket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
            }
            byte[] msg = Encoding.ASCII.GetBytes(Convert.ToString(c));
            string[] info = data.Split(';');
            //login();
            if (info[0] == "a")
            {

                Send();

            }
            else if (info[0] == "b")
            {
               // MessageBox.Show("1");
                o[(Convert.ToInt32(info[1]) - 1)].ModificaOrdine(info);
                WriteAllFile();
                change = true;

            }
            else if (info[0] == "c")
            {

                string file = @"../../../File/UtentiGestionali.csv";
                login(file, 0);
            }
            else if (info[0] == "d")
            {
                Add(info);
            }
            else if (info[0] == "e")
            {
                MessageBox.Show(Convert.ToString(info[1]));
                Remove(Convert.ToInt32(info[1]));
                
            }
            else
            {
                string file = @"../../../File/Utenti.csv";
                login(file, 1);

            }

            Console.WriteLine("Messaggio ricevuto : {0}", data);
        }
        MessageBox.Show("cc");
        clientSocket.Shutdown(SocketShutdown.Both);
        clientSocket.Close();
        data = "";

    }
    public void WriteAllFile()
    {
        //aggiorna();
        
        File.Delete(@"../../../File/Database.csv");
        //  var writer = new StreamWriter(@"../../../File/Database.csv");
        var writer = File.AppendText(@"../../../File/Database.csv");
        for (int i = 0; i < lines; i++)
        {
            if (o[i].Nordine > 0)
            {
                writer.WriteLine(o[i].Nordine + ";" + o[i].Npezzi + ";" + o[i].Cod + ";" + o[i].DataConsegna);
            }
        }
        writer.Close();
    }
    public int Nordine()
    {
        var l="";
        var reader1 = new StreamReader(@"../../../File/Database.csv");
        while (!reader1.EndOfStream)
        {
            l = reader1.ReadLine();
        }
        string[] v = l.Split(';');
        reader1.Close();
        MessageBox.Show(v[0]);
        if (v[0] == "")
        {
            v[0] = "0";
        }

        MessageBox.Show(v[0]);
        return Convert.ToInt32(v[0]);

    }
    public void Add(string[] info)
    {
        int c= Nordine();
        c++;
        var writer = File.AppendText(@"../../../File/Database.csv");
        writer.WriteLine(c+";"+info[1] + ";" + info[2] + ";" + info[3]);
        writer.Close();
        byte[] msg = Encoding.ASCII.GetBytes("0");
        clientSocket.Send(msg);
        change = true;
    }
    public void Remove(int r)
    {
        aggiorna();
        r = r - 1;
        MessageBox.Show(Convert.ToString(o[r].Nordine));
        o[r].Nordine = 0;
        MessageBox.Show(Convert.ToString(o[r].Nordine));
        WriteAllFile();
        change = true;
    }
    public void aggiorna()
    {
        var reader1 = new StreamReader(@"../../../File/Database.csv");
        int i = 0;
        while (!reader1.EndOfStream)
        {
            var l = reader1.ReadLine();
            string[] v = l.Split(';');
            o[i].setOrdine(Convert.ToInt32(v[0]), Convert.ToInt32(v[1]), v[2], v[3]);
            i++;

        }
        reader1.Close();
    }
    public void login(string file, int d)
    {
        int c = -2;
        bool check = false;
        int i = 0;
        if (d == 0)
        {
            i = 1;
        }
        string[] info = data.Split(';');
        var reader = new StreamReader(file);
        while (!reader.EndOfStream)
        {
            
            var l = reader.ReadLine();
            string[] v = l.Split(';');
            if (v[0] == info[i] && v[1] == info[i+1])
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
        byte[] msg = Encoding.ASCII.GetBytes(Convert.ToString(c));
        clientSocket.Send(msg);
    }
    bool first = true;
    public void Send()
    {
        byte[] msg = Encoding.ASCII.GetBytes(Convert.ToString(" "));

           // MessageBox.Show("ggg");
            var reader = new StreamReader(@"../../../File/Database.csv");
        lines = 0;
            while (reader.ReadLine() != null)
            {
                lines++;
            }
            reader.Close();

            msg = Encoding.ASCII.GetBytes(Convert.ToString(lines));
            clientSocket.Send(msg);

            var reader1 = new StreamReader(@"../../../File/Database.csv");
            int i = 0;
            while (!reader1.EndOfStream)
            {
                var l = reader1.ReadLine();
                string[] v = l.Split(';');
                o[i].setOrdine(Convert.ToInt32(v[0]), Convert.ToInt32(v[1]), v[2], v[3]);
                Thread.Sleep(10);
                msg = Encoding.ASCII.GetBytes(Convert.ToString(l));
                i++;
                clientSocket.Send(msg);
            }
            reader1.Close();
            change = false;
            first = false;
        

    }
}

//SI CONNETTE TRAMITE UN LOGIN
//LO ACCETTA E GLI MANDA GLI ORDINI
//SELEZIONA, E RITORNA LE MODIFICHE
//IL SERVER ACCETTA E MODIFICA I DATI
//LA CONNESSIONE SI CHIUDE

class Ordini
{
    public int Nordine { get; set; }
    public int Npezzi { get; set; }
    public string Cod { get; set; }
    public string DataConsegna { get; set; }
    public string Operatore { get; set; }
    public string Macchina { get; set; }

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
    public void ModificaOrdine(string[] info)
    {
        Nordine = Convert.ToInt32(info[1]);
        Macchina = info[2];
        Operatore = info[3];
        Npezzi = Npezzi - Convert.ToInt32(info[4]);
        Write(Convert.ToInt32(info[4]));
    }

    public void Write(int Pr)
    {
        //MessageBox.Show("£");
        var writer = File.AppendText(@"../../../File/" + Cod + ".csv");
        writer.WriteLine(Nordine + ";" + Pr + ";" + Npezzi + ";" + Macchina + ";" + Operatore + "");
        writer.Close();
    }

}
