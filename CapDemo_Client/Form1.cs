using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using myStruct;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CapDemo_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Socket client;
        IPEndPoint ipe;
        Thread ketnoi;

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            ketnoi = new Thread(new ThreadStart(KetNoiDenServer));
            ketnoi.IsBackground=true;
            ketnoi.Start();
        }

        public void KetNoiDenServer()
        {
            ipe = new IPEndPoint(IPAddress.Parse(txt_ip.Text),2001);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            client.Connect(ipe);
            Thread Langnghe = new Thread(LangNgheDuLieu);
            Langnghe.IsBackground = true;
            Langnghe.Start();
        }
        public void LangNgheDuLieu(object obj)
        {
            Socket sk = (Socket)obj;
            while (true)
            {
                byte[] buff = new byte[1024];
                int recv = client.Receive(buff);
                HamMaHoa(buff);
            }
        }

        private void HamMaHoa(byte[] buff)
        {
            myStruct.Structure str = new Structure();
            MemoryStream stream = new MemoryStream(buff);
            BinaryFormatter bformat = new BinaryFormatter();
            str = (Structure)bformat.Deserialize(stream);

            richTextBox1.AppendText(str.TextChat);
            richTextBox1.ScrollToCaret();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Structure str = new Structure();
            str.TextChat = richTextBox2.Text;
            MemoryStream stream = new MemoryStream();
            BinaryFormatter bformat = new BinaryFormatter();
            bformat.Serialize(stream,str);
            byte[] buff = new byte[1024];
            buff = stream.ToArray();
            client.Send(buff);
            richTextBox2.Text = "";

        }
    }
}
