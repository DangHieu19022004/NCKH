using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// gui tin di
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(txbText.Text);
        }

        IPEndPoint IP;
        Socket client;

        /// <summary>
        /// Ket noi toi sever
        /// </summary>
        void Connect()
        {
            //IP: dia chi sever
            IP = new IPEndPoint(IPAddress.Parse("192.168.247.51"), 9999);
            // client: lo cam de ket noi sever
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        /// <summary>
        /// dong ket noi
        /// </summary>
        void Close()
        {
            client.Close();
        }

        /// <summary>
        /// gui tin
        /// </summary>
        void Send()
        {
            if(txbText.Text != string.Empty)
            {
                client.Send(Serrialize(txbText.Text));
            }
        }

        /// <summary>
        /// Nhan thong tin
        /// </summary>
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = Deserialize(data).ToString();
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s});
            txbText.Clear();
        }

        //Phan manh
        byte[] Serrialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        
        //gom manh lai
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        //dong form thi dong ket noi
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
