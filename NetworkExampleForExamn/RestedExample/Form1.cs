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
using System.IO;
namespace RestedExample
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient(URLTextBox.Text);

            OutPutTextBox.Text = client.Request();

        }
    }
}
