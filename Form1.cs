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

namespace ArduinoVoiceControl
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;


        public Form1()
        {
            InitializeComponent();
            disableControls();
            getAvailableComPorts();

            foreach (string port in ports)
            {
                usb_ports.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    usb_ports.SelectedItem = ports[0];
                }
            }
        }

        //Get ports by (initializing it in form1)
        private void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        //Disable controls (initializing it in form1)
        private void disableControls()
        {
            LED1.Enabled = false;
            LED2.Enabled = false;
            LED3.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LED1_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (LED1.Checked)
                {
                    port.Write("#LED1ON\n");
                }
                else
                {
                    port.Write("#LED1OF\n");
                }

            }
        }

        private void LED2_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (LED2.Checked)
                {
                    port.Write("#LED2ON\n");
                }
                else
                {
                    port.Write("#LED2OF\n");
                }

            }
        }

        private void LED3_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (LED3.Checked)
                {
                    port.Write("#LED3ON\n");
                }
                else
                {
                    port.Write("#LED3OF\n");
                }

            }
        }

        private void usb_ports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = usb_ports.GetItemText(usb_ports.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            button1.Text = "Disconnect";
            enableControls();
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            button1.Text = "Connect";
            disableControls();
            resetDefaults();
        }

        private void enableControls()
        {
            LED1.Enabled = true;
            LED2.Enabled = true;
            LED3.Enabled = true;
        
        }

        private void resetDefaults()
        {
            LED1.Checked = false;
            LED2.Checked = false;
            LED3.Checked = false;

        }
    }
}
