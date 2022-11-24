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

        private void lbl_Stato_Click(object sender, EventArgs e)
        {

        }
    }
}

public class ClientManager
{

    Socket clientSocket;
    byte[] bytes = new Byte[1024];
    String data = "";
    Ordini[] o = new Ordini[100];
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
        while (data != "Quit$")
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
            else if (info[0] =="b")
            {
                o[(Convert.ToInt32(info[1])-1)].ModificaOrdine(info);
                aggiorna();

            }
            else
            {

                login();
              
            } 

            Console.WriteLine("Messaggio ricevuto : {0}", data);
        }
        MessageBox.Show("cc");
        clientSocket.Shutdown(SocketShutdown.Both);
        clientSocket.Close();
        data = "";

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
    public void login()
    {
        int c = -2;
        bool check = false;
        
        string[] info = data.Split(';');
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
        byte[] msg = Encoding.ASCII.GetBytes(Convert.ToString(c));
        clientSocket.Send(msg);
    }
    public void Send()
    {
        byte[] msg = Encoding.ASCII.GetBytes(Convert.ToString(" "));
        var reader = new StreamReader(@"../../../File/Database.csv");
        int lines = 0;
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
            msg = Encoding.ASCII.GetBytes(Convert.ToString(l));
            i++;
            clientSocket.Send(msg);
        }
        reader1.Close();
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
        var writer = new StreamWriter(@"../../../File/"+Cod+".csv");
        writer.Write(Nordine+";"+Pr+";"+Npezzi+";"+Macchina+";"+Operatore+"");
        writer.Close();
    }

}
