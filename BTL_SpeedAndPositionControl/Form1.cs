using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml.Serialization;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_SpeedAndPositionControl
{
    public partial class Form1 : Form
    {

        
        int Rev_Speed;
        int Rev_Position;
        int SP_Posistion;
        int SP_Speed;
        int Rev_response;
        byte dummy = 0x00;
        byte version = 0x01;
        byte command = 0x07;
        byte flag = 0x00;
        byte len = 0x06;
        byte len1 = 14;
        byte CRC = 0x00;
        byte[] payload = new byte[] {0x00,0x01,0x00,0x00,0x07,0x00};
        byte[] Get_position_SP = new byte[] { 0x00, 0x00, 0x00, 0x00 };
        byte[] Get_Speed_SP = new byte[] { 0x00, 0x00, 0x00, 0x00 };
        byte[] Get_Kp = new byte[] { 0x00, 0x00, 0x00, 0x00 };
        byte[] Get_Ki = new byte[] { 0x00, 0x00, 0x00, 0x00 };
        byte[] Get_Kd = new byte[] { 0x00, 0x00, 0x00, 0x00 };
        float convert_speed;
        float convert_SetSpeed;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
      

        }


        private int _countSecond = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //enable C# to send and receive data via serial port, com 1
            comboCom.DataSource= SerialPort.GetPortNames();
            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort1.PortName = comboCom.Text;
            //serialPort1.BaudRate = Int32.Parse(comboBaudrate.Text);

           

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 250;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            chart1.Series[0].XValueType = ChartValueType.DateTime;

            chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.Interval = 5;
        }  
        

        private void InitializeTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 1000; // 1 giây
            timer1.Tick += Timer1_Tick;
            
        }
        private void buttonConnectUART_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    labelStUart.Text = "CONNECTED";
                    labelStUart.ForeColor = Color.Green;
                    buttonConnectUART.Visible = false;
                }
                if (timer1 != null && !timer1.Enabled)
                {
                    timer1.Start();

                }


            }
            catch (Exception ex)
            {

            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            byte[] frame = new byte[6];
            frame[0] = dummy;
            frame[1] = version;
            frame[2] = command;
            frame[3] = flag;
            frame[4] = len;
            frame[5] = CRC;

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(frame, 0, frame.Length);
                
            }

            chart1.Series[1].Points.AddXY(timeNow, convert_SetSpeed);
            chart1.Series[0].Points.AddXY(timeNow, convert_speed);
            _countSecond++;
            if (_countSecond == 60)
            {
                
                _countSecond = 0;

                chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart1.ChartAreas[0].AxisX.Interval = 5;
            }
        }

        private void buttonDisconnectUART_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!serialPort1.IsOpen) {
                labelStUart.Text = "DISCONNECTED";
                labelStUart.ForeColor = Color.Red;
                buttonConnectUART.Visible = true;
            }
        }

        byte[] buffer = new byte[100];

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
                // receive data from PIC0 
                int counter = 0;

                for (int i = 0; i < 14; i++)
                {
                    counter = serialPort1.Read(buffer, Rev_response, 14);
                    Rev_response += counter;
                    if (counter == 0 || Rev_response == 14)
                    {
                        //  no more data to read or read enough data
                        break;
                    }
                }

                if (Rev_response != 14)
                {
                    // lack of data
                    return;
                }

                Rev_response = 0;

                // check header here
                // if wrong, return

                if (buffer[1] != version || buffer[2] != command || buffer[4] == 0)
            {
                return;
            }

                byte[] speed = new byte[4];
                Array.Copy(buffer, 6, speed, 0, 4);

                 convert_speed = BitConverter.ToSingle(speed, 0);

                string speed_string = convert_speed.ToString();
                textBox19.Text = convert_speed.ToString();
                Array.Clear(speed, 0, speed.Length);

                byte[] position = new byte[4];
                Array.Copy(buffer, 10, position, 0, 4);


                float convert_pos = BitConverter.ToSingle(position, 0);

                textBox20.Text = convert_pos.ToString();
                Array.Clear(position, 0, position.Length);
                Array.Clear(buffer, 0, buffer.Length);
            

        }

        // set SP posistion
        private void SetPointPosistion_Click(object sender, EventArgs e)
        {
            String SP_Position_string = textBox6.Text;

            // convert posistion from string to float 
            if (float.TryParse(SP_Position_string, out float convert_pos)) {
                 Get_position_SP = BitConverter.GetBytes(convert_pos);
            }

            byte command1 = 3;
            byte[] Set_position = new byte[10];
            Set_position[0] = dummy;
            Set_position[1] = version;
            Set_position[2] = command1;
            Set_position[3] = flag;
            Set_position[4] = 10;
            Set_position[5] = CRC;
            Set_position[6] = Get_position_SP[0]; ;
            Set_position[7] = Get_position_SP[1]; ;
            Set_position[8] = Get_position_SP[2]; ;
            Set_position[9] = Get_position_SP[3]; ;
            
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(Set_position, 0, Set_position.Length);
            }
            

        }

        // set SP speed
        private void SetPointSpeed_Click(object sender, EventArgs e)
        {
            String SP_Speed_string = textBox13.Text;

            // convert posistion from string to float 
            if (float.TryParse(SP_Speed_string, out  convert_SetSpeed))
            {
                Get_Speed_SP = BitConverter.GetBytes(convert_SetSpeed);
            }

            byte command2 = 1;
            byte len2 = 10;
            byte[] Set_Speed = new byte[10];
            Set_Speed[0] = dummy;
            Set_Speed[1] = version;
            Set_Speed[2] = command2;
            Set_Speed[3] = flag;
            Set_Speed[4] = len2;
            Set_Speed[5] = CRC;
            Set_Speed[6] = Get_Speed_SP[0];
            Set_Speed[7] = Get_Speed_SP[1];
            Set_Speed[8] = Get_Speed_SP[2];
            Set_Speed[9] = Get_Speed_SP[3];
           
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(Set_Speed, 0, Set_Speed.Length);
            }
        }

        // Set Kp, Ki, Kd for Speed
        private void btnSetPIDSpeed_Click(object sender, EventArgs e)
        {
            String Set_Kp_String = textBox16.Text;
            if (float.TryParse(Set_Kp_String, out float convert_Kp))
            {
                Get_Kp = BitConverter.GetBytes(convert_Kp);
            }
            
            String Set_Ki_String = textBox15.Text;
            if (float.TryParse(Set_Ki_String, out float convert_Ki))
            {
                Get_Ki = BitConverter.GetBytes(convert_Ki);
            }
            Byte command_Set_Kp_Ki = 8;
            Byte[] Set_Kp_Ki = new byte[14];
            Set_Kp_Ki[0] = dummy;
            Set_Kp_Ki[1] = version;
            Set_Kp_Ki[2] = command_Set_Kp_Ki;
            Set_Kp_Ki[3] = flag;
            Set_Kp_Ki[4] = len1;
            Set_Kp_Ki[5] = CRC;
            Set_Kp_Ki[6] = Get_Kp[0];
            Set_Kp_Ki[7] = Get_Kp[1];
            Set_Kp_Ki[8] = Get_Kp[2];
            Set_Kp_Ki[9] = Get_Kp[3];
            Set_Kp_Ki[10] = Get_Ki[0];
            Set_Kp_Ki[11] = Get_Ki[1];
            Set_Kp_Ki[12] = Get_Ki[2];
            Set_Kp_Ki[13] = Get_Ki[3];


            if (serialPort1.IsOpen)
            {
                serialPort1.Write(Set_Kp_Ki, 0, Set_Kp_Ki.Length);
            }
            Array.Clear(Get_Kd, 0, Get_Kd.Length);
            Array.Clear(Get_Ki, 0, Get_Ki.Length);
        }

        private void BtnSetPIDPosistion_Click(object sender, EventArgs e)
        {
            String Set_Kp_String = textBox4.Text;
            if (float.TryParse(Set_Kp_String, out float convert_Kp))
            {
                Get_Kp = BitConverter.GetBytes(convert_Kp);
            }

            String Set_Ki_String = textBox3.Text;
            if (float.TryParse(Set_Ki_String, out float convert_Ki))
            {
                Get_Ki = BitConverter.GetBytes(convert_Ki);
            }
            Byte command_Set_Kp_Ki = 8;
            Byte[] Set_Kp_Ki = new byte[14];
            Set_Kp_Ki[0] = dummy;
            Set_Kp_Ki[1] = version;
            Set_Kp_Ki[2] = command_Set_Kp_Ki;
            Set_Kp_Ki[3] = flag;
            Set_Kp_Ki[4] = len1;
            Set_Kp_Ki[5] = CRC;
            Set_Kp_Ki[6] = Get_Kp[0];
            Set_Kp_Ki[7] = Get_Kp[1];
            Set_Kp_Ki[8] = Get_Kp[2];
            Set_Kp_Ki[9] = Get_Kp[3];
            Set_Kp_Ki[10] = Get_Ki[0];
            Set_Kp_Ki[11] = Get_Ki[1];
            Set_Kp_Ki[12] = Get_Ki[2];
            Set_Kp_Ki[13] = Get_Ki[3];
         

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(Set_Kp_Ki, 0, Set_Kp_Ki.Length);
            }
            Array.Clear(Get_Kp, 0, Get_Kp.Length);
            Array.Clear(Get_Ki, 0, Get_Ki.Length);

        }

        private void comboCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
