using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;


namespace TCP_klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przyciskpolacz_Click(object sender, EventArgs e)
        {
            string host = adres.Text;
            int port = Convert.ToInt32(myport.Value);

            try
            {
                TcpClient klient = new TcpClient(host, port);
                infoopolaczeniu.Items.Add("nawiazano polaczenie z " + host + " na porcie: " + port);
                klient.Close();
            }
            catch(Exception ex)
            {
                infoopolaczeniu.Items.Add("blad: " + "nie udalo sie nawiazac polaczenia");
                MessageBox.Show(ex.ToString(), "blad");
            }
        }
    }
}
