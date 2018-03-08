using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gamepadtest;
using System.IO.Ports;


namespace BigPapaDs
{
    public partial class iRoboticsCommandCenter : Form
    {
        const int baudrate = 57600;                     // xbee serial port baudrate (bits per second)
        const int delay = 10;                           // delay for updating the controller values and sending the packet (milliseconds)

        GamepadState[] controller = new GamepadState[2];
        TextBox[] controller_textBox = new TextBox[2];
        System.Windows.Threading.DispatcherTimer controllerUpdateTimer;
        private StringBuilder recievedData1 = new StringBuilder();
        private StringBuilder recievedDataMain = new StringBuilder();
        private byte[] controller_packet = new byte[18];

        public iRoboticsCommandCenter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string portname in SerialPort.GetPortNames())
            {
                controllerComboBox.Items.Add(portname);
                controllerComboBox.Text = portname;
            }

            controller_textBox[0] = controller1_textBox;
            controller_textBox[1] = controller2_textBox;

            for (int i = 0; i < 2; i++)
            {
                controller_initialize(i);
            }

            Array.Clear(controller_packet, 0, controller_packet.Length);

            controllerUpdateTimer = new System.Windows.Threading.DispatcherTimer();
            controllerUpdateTimer.Interval = new TimeSpan(0, 0, 0, 0, delay);
            controllerUpdateTimer.Tick += new EventHandler(updateControllerState);
            controllerUpdateTimer.Start();

            timer1.Start();
        }

        private bool controller_check(int num)
        {
            if (controller[num] != null && controller[num].Connected)
            {
                return true;
            }
            return false;
        }

        private void controller_initialize(int num)
        {
            if (num == 0)
            {
                controller[num] = new GamepadState(SlimDX.XInput.UserIndex.One);
            }
            else if (num == 1)
            {
                controller[num] = new GamepadState(SlimDX.XInput.UserIndex.Two);
            }

            if (controller_check(num))
            {
                controller_textBox[num].Text = "Connected";
            }
            else
            {
                controller_textBox[num].Text = "Disconnected";
            }
        }

        private void controller1_button_Click(object sender, EventArgs e)
        {
            controller_initialize(0);
        }

        private void controller2_button_Click(object sender, EventArgs e)
        {
            controller_initialize(1);
        }

        private void updateControllerState(object o, EventArgs e)
        {
            if (controller_check(0))
            {
                controller_textBox[0].Text = "Connected";

                controller[0].Update();

                leftStickX1_textBox.Text = " " + Convert.ToByte(controller[0].LeftStick.Position.X * 100 + 100).ToString();
                leftStickY1_textBox.Text = " " + Convert.ToByte(controller[0].LeftStick.Position.Y * 100 + 100).ToString();

                rightStickX1_textBox.Text = " " + Convert.ToByte(controller[0].RightStick.Position.X * 100 + 100).ToString();
                rightStickY1_textBox.Text = " " + Convert.ToByte(controller[0].RightStick.Position.Y * 100 + 100).ToString();

                rightBumper1_textBox.Text = " " + controller[0].RightShoulder.ToString();
                leftBumper1_textBox.Text = " " + controller[0].LeftShoulder.ToString();

                leftTrigger1_textBox.Text = " " + Convert.ToByte(controller[0].LeftTrigger * 100).ToString();
                rightTrigger1_textBox.Text = " " + Convert.ToByte(controller[0].RightTrigger * 100).ToString();

                upDpad1_textBox.Text = " " + controller[0].DPad.Up.ToString();
                downDpad1_textBox.Text = " " + controller[0].DPad.Down.ToString();
                rightDpad1_textBox.Text = " " + controller[0].DPad.Right.ToString();
                leftDpad1_textBox.Text = " " + controller[0].DPad.Left.ToString();

                backButton1_textBox.Text = " " + controller[0].Back.ToString();
                startButton1_textBox.Text = " " + controller[0].Start.ToString();

                leftStickClick1_textBox.Text = " " + controller[0].LeftStick.Clicked.ToString();
                rightStickClick1_textBox.Text = " " + controller[0].RightStick.Clicked.ToString();

                aButton1_textBox.Text = " " + controller[0].A.ToString();
                bButton1_textBox.Text = " " + controller[0].B.ToString();
                xButton1_textBox.Text = " " + controller[0].X.ToString();
                yButton1_textBox.Text = " " + controller[0].Y.ToString();
            }
            else
            {
                controller_textBox[0].Text = "Disconnected";
            }
            if (controller_check(1))
            {
                controller_textBox[1].Text = "Connected";

                controller[1].Update();

                leftStickX2_textBox.Text = " " + Convert.ToByte(controller[1].LeftStick.Position.X * 100 + 100).ToString();
                leftStickY2_textBox.Text = " " + Convert.ToByte(controller[1].LeftStick.Position.Y * 100 + 100).ToString();

                rightStickX2_textBox.Text = " " + Convert.ToByte(controller[1].RightStick.Position.X * 100 + 100).ToString();
                rightStickY2_textBox.Text = " " + Convert.ToByte(controller[1].RightStick.Position.Y * 100 + 100).ToString();

                rightBumper2_textBox.Text = " " + controller[1].RightShoulder.ToString();
                leftBumper2_textBox.Text = " " + controller[1].LeftShoulder.ToString();

                leftTrigger2_textBox.Text = " " + Convert.ToByte(controller[1].LeftTrigger * 100).ToString();
                rightTrigger2_textBox.Text = " " + Convert.ToByte(controller[1].RightTrigger * 100).ToString();

                upDpad2_textBox.Text = " " + controller[1].DPad.Up.ToString();
                downDpad2_textBox.Text = " " + controller[1].DPad.Down.ToString();
                rightDpad2_textBox.Text = " " + controller[1].DPad.Right.ToString();
                leftDpad2_textBox.Text = " " + controller[1].DPad.Left.ToString();

                backButton2_textBox.Text = " " + controller[1].Back.ToString();
                startButton2_textBox.Text = " " + controller[1].Start.ToString();

                leftStickClick2_textBox.Text = " " + controller[1].LeftStick.Clicked.ToString();
                rightStickClick2_textBox.Text = " " + controller[1].RightStick.Clicked.ToString();

                aButton2_textBox.Text = " " + controller[1].A.ToString();
                bButton2_textBox.Text = " " + controller[1].B.ToString();
                xButton2_textBox.Text = " " + controller[1].X.ToString();
                yButton2_textBox.Text = " " + controller[1].Y.ToString();
            }
            else
            {
                controller_textBox[1].Text = "Disconnected";
            }

            Task updatecontrollerStateTask = new Task(() => updateControllerBuffers());
            updatecontrollerStateTask.Start();

        }

        private void updateControllerBuffers()
        {
            if (controller_check(0) && controller_check(1))
            {
                int x = 0;

                controller_packet[0] = Convert.ToByte(255);

                ///////////////////////////////////////////////////////////////////////////

                x = (Convert.ToInt32(controller[0].A) << 6) |
                    (Convert.ToInt32(controller[0].B) << 5) |
                    (Convert.ToInt32(controller[0].X) << 4) |
                    (Convert.ToInt32(controller[0].Y) << 3) |
                    (Convert.ToInt32(controller[0].LeftShoulder) << 2) |
                    (Convert.ToInt32(controller[0].RightShoulder) << 1) |
                    Convert.ToInt32(controller[0].Start);

                controller_packet[1] = Convert.ToByte(x);

                x = (Convert.ToInt32(controller[0].DPad.Up) << 6) |
                    (Convert.ToInt32(controller[0].DPad.Down) << 5) |
                    (Convert.ToInt32(controller[0].DPad.Left) << 4) |
                    (Convert.ToInt32(controller[0].DPad.Right) << 3) |
                    (Convert.ToInt32(controller[0].LeftStick.Clicked) << 2) |
                    (Convert.ToInt32(controller[0].RightStick.Clicked) << 1) |
                    Convert.ToInt32(controller[0].Back);

                controller_packet[2] = Convert.ToByte(x);

                controller_packet[3] = Convert.ToByte(controller[0].LeftStick.Position.X * 100 + 100);

                controller_packet[4] = Convert.ToByte(controller[0].LeftStick.Position.Y * 100 + 100);

                controller_packet[5] = Convert.ToByte(controller[0].RightStick.Position.X * 100 + 100);

                controller_packet[6] = Convert.ToByte(controller[0].RightStick.Position.Y * 100 + 100);

                controller_packet[7] = Convert.ToByte(controller[0].LeftTrigger * 100);

                controller_packet[8] = Convert.ToByte(controller[0].RightTrigger * 100);

                ////////////////////////////////////////////////////////////////////////////////

                x = (Convert.ToInt32(controller[1].A) << 6) |
                    (Convert.ToInt32(controller[1].B) << 5) |
                    (Convert.ToInt32(controller[1].X) << 4) |
                    (Convert.ToInt32(controller[1].Y) << 3) |
                    (Convert.ToInt32(controller[1].LeftShoulder) << 2) |
                    (Convert.ToInt32(controller[1].RightShoulder) << 1) |
                    Convert.ToInt32(controller[1].Start);

                controller_packet[9] = Convert.ToByte(x);

                x = (Convert.ToInt32(controller[1].DPad.Up) << 6) |
                    (Convert.ToInt32(controller[1].DPad.Down) << 5) |
                    (Convert.ToInt32(controller[1].DPad.Left) << 4) |
                    (Convert.ToInt32(controller[1].DPad.Right) << 3) |
                    (Convert.ToInt32(controller[1].LeftStick.Clicked) << 2) |
                    (Convert.ToInt32(controller[1].RightStick.Clicked) << 1) |
                    Convert.ToInt32(controller[1].Back);

                controller_packet[10] = Convert.ToByte(x);

                controller_packet[11] = Convert.ToByte(controller[1].LeftStick.Position.X * 100 + 100);

                controller_packet[12] = Convert.ToByte(controller[1].LeftStick.Position.Y * 100 + 100);

                controller_packet[13] = Convert.ToByte(controller[1].RightStick.Position.X * 100 + 100);

                controller_packet[14] = Convert.ToByte(controller[1].RightStick.Position.Y * 100 + 100);

                controller_packet[15] = Convert.ToByte(controller[1].LeftTrigger * 100);

                controller_packet[16] = Convert.ToByte(controller[1].RightTrigger * 100);

                //////////////////////////////////////////////////////////////////////////////////

                controller_packet[17] = Convert.ToByte(254);
            }
        }

        private void openButton1_Click(object sender, EventArgs e)
        {
            if (dropDownComboBox1.Text == "")
            {
                return;
            }
            if (!serialPort1.IsOpen)
            {
                if (serialPort3.PortName == dropDownComboBox1.Text && (serialPort3.IsOpen))
                {
                    dropDownComboBox1.Text = "";
                    return;
                }
                serialPort1.PortName = dropDownComboBox1.Text;
                serialPort1.Open();
            }
        }

        private void closeButton1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                dropDownComboBox1.Text = "";
            }
        }

        private void iRoboticsCommandCenter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            
        }

        private void sendXbeeButton1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(sendMessageTextBox1.Text + "\n\r");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            recievedData1.Append(serialPort1.ReadExisting());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            consoleTextBox1.Text = recievedData1.ToString();
            
            dataRecievedTextBox.Text = recievedDataMain.ToString();

        }

        private void controllerOpenButton_Click(object sender, EventArgs e)
        {
            if (controllerComboBox.Text == "")
            {
                return;
            }

            if (!serialPort3.IsOpen)
            {
                if (serialPort1.PortName == controllerComboBox.Text && (serialPort1.IsOpen))
                {
                    controllerComboBox.Text = "";
                    return;
                }
                serialPort3.PortName = controllerComboBox.Text;
                serialPort3.BaudRate = baudrate;
                serialPort3.Open();
            }
            Task SendControllerValuesTask = new Task(() => sendControllerValues());
            SendControllerValuesTask.Start();
        }

        private void controllerCloseButton_Click(object sender, EventArgs e)
        {
            if (serialPort3.IsOpen)
            {
                serialPort3.Close();
                controllerComboBox.Text = "";
            }
        }

        private void serialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            recievedDataMain.Append(serialPort3.ReadExisting());
        }

        private void sendControllerValues()
        {
            while (serialPort3.IsOpen)
            {
                try
                {
                    serialPort3.Write(controller_packet, 0, controller_packet.Length);
                    System.Threading.Thread.Sleep(delay);
                    serialPort3.DiscardOutBuffer();
                }
                catch
                {
                    return;
                }
            }
        }

        private void refreshPortsButton_Click(object sender, EventArgs e)
        {

            if (serialPort3.IsOpen)
            {
                serialPort3.Close();
            }

            if (controllerComboBox.Text == "")
            {
                return;
            }

            if (!serialPort3.IsOpen)
            {
                serialPort3.PortName = controllerComboBox.Text;
                serialPort3.BaudRate = baudrate;
                serialPort3.Open();
            }
            Task SendControllerValuesTask = new Task(() => sendControllerValues());
            SendControllerValuesTask.Start();
        }

        private void dataRecievedTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}