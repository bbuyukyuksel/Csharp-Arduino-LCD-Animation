using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Animation_Led
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] myPort = SerialPort.GetPortNames();
            comboBox1.DataSource = myPort;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(String.Format("You selected port '{0}'", comboBox1.SelectedItem));
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            label1.ForeColor = System.Drawing.Color.FromArgb(0, 255, 0); // R G B
            label1.Text = "Connected";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "0" + textBox1.Text;
            
            byte[] MyMessage = System.Text.Encoding.UTF8.GetBytes(str);

            serialPort1.Write(MyMessage, 0, MyMessage.Length);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "1" + textBox2.Text;

            byte[] MyMessage = System.Text.Encoding.UTF8.GetBytes(str);

            serialPort1.Write(MyMessage, 0, MyMessage.Length);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "2" + textBox3.Text;
            byte[] MyMessage = System.Text.Encoding.UTF8.GetBytes(str);
            serialPort1.Write(MyMessage, 0, MyMessage.Length);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("q");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("w");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("s");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("h");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            serialPort1.Write("H");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            serialPort1.Write("j");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            serialPort1.Write("J");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            serialPort1.Write("c");
        }

        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void button14_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
