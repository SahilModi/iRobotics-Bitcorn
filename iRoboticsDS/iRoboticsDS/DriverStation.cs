using System;
using System.Windows.Forms;
using Gamepadtest;
using System.IO.Ports;


namespace iRoboticsDS
{
    public partial class DriverStation : Form
    {
        GamepadState controller = new GamepadState(SlimDX.XInput.UserIndex.One);
        System.Windows.Threading.DispatcherTimer packetTransferTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer findDevicesTimer = new System.Windows.Threading.DispatcherTimer();
        private byte[] controller_packet = new byte[8];
        private byte[] gui_packet = new byte[10];
        private byte[] data = new byte[10];
        int packet_time = 0;
        int i = 0;
        int period = 40;
        bool comms = false;
        int signal_integrity;
        int packet_index = 0;
        byte checkSumRX = 0;
        bool[] packet_state = new bool[25];
        private byte[] startByte = new byte[1];
        private byte[] checkSumTX = new byte[1];
        private byte[] endByte = new byte[1];


        public DriverStation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startByte[0] = 255;
            endByte[0] = 240;

            packetTransferTimer.Interval = new TimeSpan(0, 0, 0, 0, period);
            packetTransferTimer.Tick += new EventHandler(packetTransfer);

            findDevicesTimer.Interval = new TimeSpan(0, 0, 0, 0, period);
            findDevicesTimer.Tick += new EventHandler(findDevices);
            findDevicesTimer.Start();
        }

        private void findDevices(object sender, EventArgs e)
        {
            if (controllerComboBox.Text == "")
            {
                foreach (string portname in SerialPort.GetPortNames())
                {
                    controllerComboBox.Items.Add(portname);
                    controllerComboBox.Text = portname;
                }
            }

            if (controller != null && controller.Connected)
            {
                controller1_textBox.Text = "Connected";
                controller1_textBox.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                controller1_textBox.Text = "Disconnected";
                controller1_textBox.ForeColor = System.Drawing.Color.DarkRed;
            }
        }

        private void packetTransfer(object sender, EventArgs e)
        {
            packet_state[packet_time] = false;

            while (packet_index == 0 && serialPort.BytesToRead >= 26)
            {
                serialPort.ReadByte();
            }

            while (serialPort.BytesToRead > 0)
            {
                if (packet_index == 0)
                {
                    if (serialPort.ReadByte() == 255)
                    {
                        packet_index++;
                    }
                }else if (packet_index < 11)
                {
                    data[packet_index - 1] = Convert.ToByte(serialPort.ReadByte());
                    checkSumRX += data[packet_index - 1];
                    packet_index++;
                }else if (packet_index == 11)
                {
                    if(serialPort.ReadByte() == checkSumRX)
                    {
                        packet_index++;
                    }else
                    {
                        packet_index = 0;
                    }
                    checkSumRX = 0;
                }else if(packet_index == 12)
                {
                    if (serialPort.ReadByte() == 240)
                    {
                        for (i = 0; i < 8; i++)
                        {
                            gui_packet[i] += data[i];
                        }
                        packet_state[packet_time] = true;
                    }
                    packet_index = 0;
                }
            }

            signal_integrity = 0;
            for (i=0; i<25; i++)
            {
                if (packet_state[packet_time])
                {
                    signal_integrity++;
                }
            }
            signal_integrity = signal_integrity * 100 / 25;

            packet_time = (packet_time + 1) % 25;

            updateGUIState();

            serialPort.DiscardOutBuffer();

            updateControllerState();

            serialPort.Write(startByte, 0, 1);
            serialPort.Write(controller_packet, 0, 8);
            serialPort.Write(checkSumTX, 0, 1);
            serialPort.Write(endByte, 0, 1);

        }
        
        private void updateControllerState()
        {
            if (controller != null && controller.Connected)
            {
                controller.Update();

                controller1_textBox.Text = "Connected";
                controller1_textBox.ForeColor = System.Drawing.Color.Green;

                i = 0;

                i = (Convert.ToInt32(controller.A)) |
                    (Convert.ToInt32(controller.B) << 1) |
                    (Convert.ToInt32(controller.X) << 2) |
                    (Convert.ToInt32(controller.Y) << 3) |
                    (Convert.ToInt32(controller.LeftShoulder) << 4) |
                    (Convert.ToInt32(controller.RightShoulder) << 5) |
                    (Convert.ToInt32(controller.Start) << 6);

                controller_packet[0] = Convert.ToByte(i);

                i = (Convert.ToInt32(controller.DPad.Up)) |
                    (Convert.ToInt32(controller.DPad.Down) << 1) |
                    (Convert.ToInt32(controller.DPad.Left) << 2) |
                    (Convert.ToInt32(controller.DPad.Right) << 3) |
                    (Convert.ToInt32(controller.LeftStick.Clicked) << 4) |
                    (Convert.ToInt32(controller.RightStick.Clicked) << 5) |
                    (Convert.ToInt32(controller.Back) << 6);

                controller_packet[1] = Convert.ToByte(i);

                controller_packet[2] = Convert.ToByte(controller.LeftStick.Position.X * 100 + 100);

                controller_packet[3] = Convert.ToByte(controller.LeftStick.Position.Y * 100 + 100);

                controller_packet[4] = Convert.ToByte(controller.RightStick.Position.X * 100 + 100);

                controller_packet[5] = Convert.ToByte(controller.RightStick.Position.Y * 100 + 100);

                controller_packet[6] = Convert.ToByte(controller.LeftTrigger * 100);

                controller_packet[7] = Convert.ToByte(controller.RightTrigger * 100);

            }
            else
            {
                controller1_textBox.Text = "Disconnected";
                controller1_textBox.ForeColor = System.Drawing.Color.DarkRed;

                controller_packet[0] = Convert.ToByte(0);
                controller_packet[1] = Convert.ToByte(0);
                controller_packet[2] = Convert.ToByte(100);
                controller_packet[3] = Convert.ToByte(100);
                controller_packet[4] = Convert.ToByte(100);
                controller_packet[5] = Convert.ToByte(100);
                controller_packet[6] = Convert.ToByte(0);
                controller_packet[7] = Convert.ToByte(0);
            }

            checkSumTX[0] = 0;
            for (i = 0; i < 8; i++)
            {
                checkSumTX[0] += controller_packet[i];
            }

        }
        
        private void updateGUIState()
        {

            connection_textBox.Text = "     " + Convert.ToString(signal_integrity) + "%";

            if (Convert.ToInt32(gui_packet[0] & 3) == 0)
            {
                sortingStatus_textBox.Text = "Reset";
                sortingStatus_textBox.ForeColor = System.Drawing.Color.White;
            }
            else if (Convert.ToInt32(gui_packet[0] & 3) == 1)
            {
                sortingStatus_textBox.Text = "Working";
                sortingStatus_textBox.ForeColor = System.Drawing.Color.DodgerBlue;
            }
            else if (Convert.ToInt32(gui_packet[0] & 3) == 2)
            {
                sortingStatus_textBox.Text = "Good";
                sortingStatus_textBox.ForeColor = System.Drawing.Color.Green;
            }
            else if (Convert.ToInt32(gui_packet[0] & 3) == 3)
            {
                sortingStatus_textBox.Text = "Bad";
                sortingStatus_textBox.ForeColor = System.Drawing.Color.DarkRed;
            }

            /////////////////////////////////////////////////////////////

            if (Convert.ToBoolean(gui_packet[0] & 4))
            {
                computerVision_textBox.Text = "ON";
                computerVision_textBox.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                computerVision_textBox.Text = "OFF";
                computerVision_textBox.ForeColor = System.Drawing.Color.DarkRed;
            }

            if (Convert.ToBoolean(gui_packet[0] & 8))
            {
                autoCompress_textBox.Text = "Auto";
                autoCompress_textBox.ForeColor = System.Drawing.Color.DodgerBlue;
            }
            else
            {
                autoCompress_textBox.Text = "Manual";
                autoCompress_textBox.ForeColor = System.Drawing.Color.DarkOrange;
            }
            if (Convert.ToBoolean(gui_packet[0] & 16))
            {
                compressorStatus_textBox.Text = "ON";
                compressorStatus_textBox.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                compressorStatus_textBox.Text = "OFF";
                compressorStatus_textBox.ForeColor = System.Drawing.Color.DarkRed;
            }
            if (Convert.ToBoolean(gui_packet[0] & 64))
            {
                shooter_textBox.Text = "ON";
                shooter_textBox.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                shooter_textBox.Text = "OFF";
                shooter_textBox.ForeColor = System.Drawing.Color.DarkRed;
            }

            if (Convert.ToBoolean(gui_packet[0] & 32))
            {
                intake_textBox.Text = "ON";
                intake_textBox.ForeColor = System.Drawing.Color.DodgerBlue;
            }
            else
            {
                intake_textBox.Text = "OFF";
                intake_textBox.ForeColor = System.Drawing.Color.DarkOrange;
            }

            /////////////////////////////////////////////////////////////

            if (Convert.ToInt32(gui_packet[2] & 96) == 0)
            {
                wheelType_textBox.Text = "Mecanum";
                wheelType_textBox.ForeColor = System.Drawing.Color.DodgerBlue;
            }
            else if (Convert.ToInt32(gui_packet[2] & 96) == 32)
            {
                wheelType_textBox.Text = "Traction";
                wheelType_textBox.ForeColor = System.Drawing.Color.DarkOrange;
            }
            else if (Convert.ToInt32(gui_packet[2] & 96) >= 64)
            {
                wheelType_textBox.Text = "Quick Turn";
                wheelType_textBox.ForeColor = System.Drawing.Color.Green;
            }

            /////////////////////////////////////////////////////////////

            if (Convert.ToInt32(gui_packet[1] & 96) == 0)
            {
                drivingSpeed_textBox.Text = "Precision";
                drivingSpeed_textBox.ForeColor = System.Drawing.Color.DarkOrange;
            }
            else if (Convert.ToInt32(gui_packet[1] & 96) == 32)
            {
                drivingSpeed_textBox.Text = "Normal";
                drivingSpeed_textBox.ForeColor = System.Drawing.Color.White;
            }
            else if (Convert.ToInt32(gui_packet[1] & 96) == 64)
            {
                drivingSpeed_textBox.Text = "Turbo";
                drivingSpeed_textBox.ForeColor = System.Drawing.Color.DodgerBlue;
            }

            ///////////////////////////////////////////////////////////////////

            if (Convert.ToInt32(gui_packet[1] & 31) <= 16)
            {
                ballsScored_progressBar.Value = Convert.ToInt32(gui_packet[1] & 31);
                ballsScored_textBox.Text = Convert.ToString(gui_packet[1] & 31) + " / 16";
            }
            if (Convert.ToInt32(gui_packet[2] & 31) <= 16)
            {
                ballsGood_progressBar.Value = Convert.ToInt32(gui_packet[2] & 31);
                ballsGood_textBox.Text = Convert.ToString(gui_packet[2] & 31) + " / 16";
            }
            if (Convert.ToInt32(gui_packet[3] & 63) <= 48)
            {
                ballsBad_progressBar.Value = Convert.ToInt32(gui_packet[3] & 63);
                ballsBad_textBox.Text = Convert.ToString(gui_packet[3] & 63) + " / 48";
            }

            ///////////////////////////////////////////////////////////////////

            manipulatorAngle_textBox.Text = Convert.ToString(gui_packet[4]);

            pressure_textBox.Text = Convert.ToString(gui_packet[5]);
            if (Convert.ToInt32(gui_packet[5]) >= 40 && Convert.ToInt32(gui_packet[5]) <= 110)
            {
                pressure_textBox.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                pressure_textBox.ForeColor = System.Drawing.Color.DarkRed;
            }

            //////////////////////////////////////////////////////////////

            if (Convert.ToInt32(gui_packet[6]) <= 200)
            {
                fl_trackBar.Value = Convert.ToInt32(gui_packet[6]);
            }
            if (Convert.ToInt32(gui_packet[7]) <= 200)
            {
                fr_trackBar.Value = Convert.ToInt32(gui_packet[7]);
            }
            if (Convert.ToInt32(gui_packet[8]) <= 200)
            {
                bl_trackBar.Value = Convert.ToInt32(gui_packet[8]);
            }
            if (Convert.ToInt32(gui_packet[9]) <= 200)
            {
                br_trackBar.Value = Convert.ToInt32(gui_packet[9]);
            }

        }

        private void open_button_Click(object sender, EventArgs e)
        {
            if (controllerComboBox.Text == "")
            {
                return;
            }

            if (!serialPort.IsOpen)
            {
                serialPort.PortName = controllerComboBox.Text;
                serialPort.Open();
            }
            else
            {
                return;
            }

            findDevicesTimer.Stop();
            System.Threading.Thread.Sleep(period);
            packetTransferTimer.Start();

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            if (packetTransferTimer.IsEnabled)
            {
                packetTransferTimer.Stop();
            }
            System.Threading.Thread.Sleep(period);
            serialPort.Close();
            while (serialPort.IsOpen)
            {
                System.Threading.Thread.Sleep(10);
            }
            connection_textBox.Text = "   Closed";
            findDevicesTimer.Start();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            if (packetTransferTimer.IsEnabled)
            {
                packetTransferTimer.Stop();
            }
            System.Threading.Thread.Sleep(period);
            serialPort.Close();
            while (serialPort.IsOpen)
            {
                System.Threading.Thread.Sleep(10);
            }

            if (controllerComboBox.Text == "")
            {
                return;
            }

            if (!serialPort.IsOpen)
            {
                serialPort.PortName = controllerComboBox.Text;
                serialPort.Open();
            }
            else
            {
                return;
            }

            packetTransferTimer.Start();
        }

        private void iRoboticsCommandCenter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (packetTransferTimer.IsEnabled)
            {
                packetTransferTimer.Stop();
            }
            System.Threading.Thread.Sleep(30);
            serialPort.Close();
            while (serialPort.IsOpen)
            {
                System.Threading.Thread.Sleep(30);
            }
        }
    }
}
