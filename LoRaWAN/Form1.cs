using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.IO.Ports;
//using System.Threading; //confuses timer so don't use

namespace LoRaWAN
{
    public partial class Form1 : Form
    {

        //Intialize Timer
        Timer t = new Timer();


        // Use StringBuilder variable to capture any data received 
        // through receivedData object
        private StringBuilder receivedData = new StringBuilder();      
        
        public Form1()
        {
            InitializeComponent();
        }

        //Stop Watch Variables 
        int hour, min, sec, ms = 0;

        
        private void Form1_Load(object sender, EventArgs e)
        {

            // timer interval
            t.Interval = 1000; // in milliseconds
            t.Tick += new EventHandler(this.t_Tick);

            // Start timer when form loads
            t.Start(); // this will start t_Tick() meathod

            // Setup Serial Port attibutes and route them to the combo box for Serial Port Selection
            string[] ports = SerialPort.GetPortNames();
            LoRaCOMPort.Items.AddRange(ports);
            LoRaCOMPort.SelectedIndex = 0;
            ClosePort.Enabled = false;

        }
        // Setup Open Port button for the serial port intialization 
        private void OpenPort_Click(object sender, EventArgs e)
        {
            timer1.Start();
            OpenPort.Enabled = false;
            ClosePort.Enabled = true;
            try
            {
                serialPort1.PortName = LoRaCOMPort.Text;
                if (!serialPort1.IsOpen) serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Start timer to show elapse time for LoRa data
            timer2.Start();
        }

        // Setup Output Window to display serial port data 
        private void ReadLoRaData_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {

                    serialPort1.BaudRate = 9600;
                    serialPort1.ReadTimeout = 5000;
                    serialPort1.RtsEnable = true;
                    //serialPort1.Open();

                      LoRaOutputWindow.Text = serialPort1.ReadExisting();
                    //LoRaOutputWindow.Text = receivedData.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void LoRaOutputWindow_TextChanged(object sender, EventArgs e)
        {
            LoRaOutputWindow.SelectionStart = LoRaOutputWindow.Text.Length;
            LoRaOutputWindow.ScrollToCaret();
            LoRaOutputWindow.Refresh();


            receivedData.Append(serialPort1.ReadExisting());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoRaOutputWindow.Text = receivedData.ToString();
            // This Section outputs "OutputWindow.Text string to a file located C:\IoTData
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\TestFolder\LoRaData.txt", false))
            {
                file.WriteLine(LoRaOutputWindow.Text);

            }
        }
    
    //timer eventhandler for digital clock
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time routine
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            //update digital clock label
            CurrentTime.Text = time;
        }

        private void StartTimer_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void StopTimer_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void ResetTimer_Click(object sender, EventArgs e)
        {
            ms = 0;
            sec = 0;
            min = 0;
            hour = 0;
            StopWatch.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            StopWatch.Text = hour + ":" + min + ":" + sec + ":" + ms.ToString();
            ms++;
            if (ms > 10)
            {
                sec++;
                ms = 0;
            }
            else
            {
                ms++;
            }

            if (sec > 59)
            {
                min++;
                sec = 0;
            }
            if (min > 60)
            {
                hour++;
                min = 0;
            }
        }
    
    
    }
}
