using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using DR.ExposeSimulator20.Com;


namespace Cabletest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] str = SerialPort.GetPortNames();
            foreach (string s in str)
            {
                comboBox1.Items.Add(s);
                
            }
            comboBox1.SelectedIndex = 0;
        }
        DR.ExposeSimulator20.Com.AutoExp _emulator;
        private void button1_Click(object sender, EventArgs e)
        {
            _emulator.Connect();
            _emulator.Pre(3000);
            _emulator.Expose();
            _emulator.Res();
            _emulator.DisConnect();

        }
    }
}
