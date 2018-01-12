using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Service1/mex

            ServiceReference1.Service1Client client = new
                ServiceReference1.Service1Client();
            string returnString;

            returnString = client.GetData(textBox1.Text);
            label1.Text = returnString;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
