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
        Socket listener;
        Thread t;
        bool acceso = false;
        public static string data = null;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }
        private void server()
        {
            byte[] bytes = new Byte[1024];
            IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);
            listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            byte[] msg = new Byte[1024];

            try
            {

                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    Socket handler = listener.Accept();
                    data = null;

                    var reader = new StreamReader(@"../../../File/Database.csv");
                    while (!reader.EndOfStream)
                    {
                        var l = reader.ReadLine();
                        string[] v = l.Split(';');

                        msg = Encoding.ASCII.GetBytes(Convert.ToString(l));
                        handler.Send(msg);
                        handler.Shutdown(SocketShutdown.Both);



                    }



                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    string[] info = data.Split(';');
                    MessageBox.Show("ww " + data);


              
                    //byte[] msg = Encoding.ASCII.GetBytes(Convert.ToString("Return"));
                   // handler.Send(msg);
                    //handler.Shutdown(SocketShutdown.Both);
                    //if (-1== Convert.ToInt32(info[0]))
                   // {
                        
                        handler.Close();
                  //  }
                    

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
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
        private void Add()
        {
            string Codice = "tps11";
            using (StreamWriter writetext = new StreamWriter(@"../../../File/Ordini/" + Codice +".csv"))
            {
                writetext.WriteLine(data);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}
