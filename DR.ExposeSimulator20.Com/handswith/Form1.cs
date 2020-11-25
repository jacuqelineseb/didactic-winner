using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using DR.ExposeSimulator.Com;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;



namespace Cabletest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_Click_1(object sender, System.EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] str = SerialPort.GetPortNames();
            foreach (string s in str)
            {
                comboBox1.Items.Add(s);

            }
            comboBox1.SelectedIndex = 0;

        }


        DR.ExposeSimulator.Com.AutoExp _emulator;

        int count;
        private void button1_Click(object sender, System.EventArgs e)
        {
            {
                button2.BackColor = Color.Yellow;
                _emulator = new AutoExp();
                
                _emulator.Connect();
               
                if (button1.Text == "btnCom17")
                //  for (int i = 0; i < 100000; i++)
                {





                    _emulator.Pre(2);
                    _emulator.ddf();
                  
                    _emulator.Expose();


                    //  Thread.Sleep(3000);
                    //   _emulator.Res();




                    button2.BackColor = Color.DarkBlue;
                    count = Convert.ToInt32(label1.Text) + 1;
                    label1.Text = Convert.ToString(count);
                    button1.Text = "0btnCom17";
                }
                else
                {
                    _emulator.Res();

                    button1.Text = "btnCom17";


                }
                _emulator.DisConnect();
            }
        }
private void button2_Click(object sender, EventArgs e)
        { if (button2.Text == "OPEN")
           { button1.BackColor = Color.DarkRed;
                _emulator = new AutoExp();
                
                
                    _emulator.PortName = comboBox1.SelectedItem.ToString();

                    _emulator.TestFunc();


                
                button1.BackColor = Color.White;
                button2.Text = "CLOSE";
            }
            else
            {

                _emulator.DisConnect();
                
                button2.Text = "OPEN"; }}

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text ="0";
            string time = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
