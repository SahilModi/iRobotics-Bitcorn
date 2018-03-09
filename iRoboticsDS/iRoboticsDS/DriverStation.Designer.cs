namespace iRoboticsDS
{
    partial class DriverStation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverStation));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.controllerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.controllerspLabel = new System.Windows.Forms.Label();
            this.open_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fl_trackBar = new System.Windows.Forms.TrackBar();
            this.bl_trackBar = new System.Windows.Forms.TrackBar();
            this.fr_trackBar = new System.Windows.Forms.TrackBar();
            this.br_trackBar = new System.Windows.Forms.TrackBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.controller1_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connection_textBox = new System.Windows.Forms.TextBox();
            this.connection_label = new System.Windows.Forms.Label();
            this.wheelType_textBox = new System.Windows.Forms.TextBox();
            this.wheelType_label = new System.Windows.Forms.Label();
            this.drivingSpeed_textBox = new System.Windows.Forms.TextBox();
            this.drivingSpeed_label = new System.Windows.Forms.Label();
            this.computerVision_textBox = new System.Windows.Forms.TextBox();
            this.computerVision_label = new System.Windows.Forms.Label();
            this.ballsBad_progressBar = new System.Windows.Forms.ProgressBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ballsScored_textBox = new System.Windows.Forms.TextBox();
            this.ballsScored_label = new System.Windows.Forms.Label();
            this.ballsScored_progressBar = new System.Windows.Forms.ProgressBar();
            this.ballsBad_textBox = new System.Windows.Forms.TextBox();
            this.ballsGood_textBox = new System.Windows.Forms.TextBox();
            this.ballsBad_label = new System.Windows.Forms.Label();
            this.ballsGood_label = new System.Windows.Forms.Label();
            this.ballsGood_progressBar = new System.Windows.Forms.ProgressBar();
            this.sortingStatus_textBox = new System.Windows.Forms.TextBox();
            this.sortingStatus_label = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.intake_textBox = new System.Windows.Forms.TextBox();
            this.intake_label = new System.Windows.Forms.Label();
            this.shooter_textBox = new System.Windows.Forms.TextBox();
            this.shooter_label = new System.Windows.Forms.Label();
            this.manipulatorAngle_textBox = new System.Windows.Forms.TextBox();
            this.manipulatorAngle_label = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.autoCompress_textBox = new System.Windows.Forms.TextBox();
            this.autoCompress_label = new System.Windows.Forms.Label();
            this.compressorStatus_textBox = new System.Windows.Forms.TextBox();
            this.compressorStatus_label = new System.Windows.Forms.Label();
            this.pressure_textBox = new System.Windows.Forms.TextBox();
            this.pressure_label = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fl_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bl_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fr_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.br_trackBar)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.controllerComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.refresh_button);
            this.panel2.Controls.Add(this.controllerspLabel);
            this.panel2.Controls.Add(this.open_button);
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 89);
            this.panel2.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(735, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "MuTan(Clan) Edition";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(57, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "XBee Controller Communication";
            // 
            // controllerComboBox
            // 
            this.controllerComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.controllerComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controllerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controllerComboBox.ForeColor = System.Drawing.Color.White;
            this.controllerComboBox.FormattingEnabled = true;
            this.controllerComboBox.Location = new System.Drawing.Point(336, 44);
            this.controllerComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.controllerComboBox.Name = "controllerComboBox";
            this.controllerComboBox.Size = new System.Drawing.Size(169, 28);
            this.controllerComboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(715, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Big Papa Driver Station";
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.refresh_button.FlatAppearance.BorderSize = 0;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.ForeColor = System.Drawing.Color.White;
            this.refresh_button.Location = new System.Drawing.Point(243, 44);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(0);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(85, 30);
            this.refresh_button.TabIndex = 12;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = false;
            // 
            // controllerspLabel
            // 
            this.controllerspLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controllerspLabel.ForeColor = System.Drawing.Color.White;
            this.controllerspLabel.Location = new System.Drawing.Point(385, 26);
            this.controllerspLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.controllerspLabel.Name = "controllerspLabel";
            this.controllerspLabel.Size = new System.Drawing.Size(75, 15);
            this.controllerspLabel.TabIndex = 12;
            this.controllerspLabel.Text = "Serial Port";
            this.controllerspLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // open_button
            // 
            this.open_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.open_button.FlatAppearance.BorderSize = 0;
            this.open_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_button.ForeColor = System.Drawing.Color.White;
            this.open_button.Location = new System.Drawing.Point(56, 44);
            this.open_button.Margin = new System.Windows.Forms.Padding(0);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(85, 30);
            this.open_button.TabIndex = 14;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = false;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.White;
            this.close_button.Location = new System.Drawing.Point(149, 44);
            this.close_button.Margin = new System.Windows.Forms.Padding(0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(85, 30);
            this.close_button.TabIndex = 13;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 38400;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 297);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // fl_trackBar
            // 
            this.fl_trackBar.Location = new System.Drawing.Point(12, 297);
            this.fl_trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.fl_trackBar.Maximum = 200;
            this.fl_trackBar.Name = "fl_trackBar";
            this.fl_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fl_trackBar.Size = new System.Drawing.Size(56, 128);
            this.fl_trackBar.TabIndex = 11;
            this.fl_trackBar.TickFrequency = 10;
            this.fl_trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.fl_trackBar.Value = 100;
            // 
            // bl_trackBar
            // 
            this.bl_trackBar.Location = new System.Drawing.Point(12, 618);
            this.bl_trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.bl_trackBar.Maximum = 200;
            this.bl_trackBar.Name = "bl_trackBar";
            this.bl_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bl_trackBar.Size = new System.Drawing.Size(56, 128);
            this.bl_trackBar.TabIndex = 12;
            this.bl_trackBar.TickFrequency = 10;
            this.bl_trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.bl_trackBar.Value = 100;
            // 
            // fr_trackBar
            // 
            this.fr_trackBar.Location = new System.Drawing.Point(380, 297);
            this.fr_trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.fr_trackBar.Maximum = 200;
            this.fr_trackBar.Name = "fr_trackBar";
            this.fr_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fr_trackBar.Size = new System.Drawing.Size(56, 128);
            this.fr_trackBar.TabIndex = 13;
            this.fr_trackBar.TickFrequency = 10;
            this.fr_trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.fr_trackBar.Value = 100;
            // 
            // br_trackBar
            // 
            this.br_trackBar.Location = new System.Drawing.Point(379, 618);
            this.br_trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.br_trackBar.Maximum = 200;
            this.br_trackBar.Name = "br_trackBar";
            this.br_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.br_trackBar.Size = new System.Drawing.Size(56, 128);
            this.br_trackBar.TabIndex = 14;
            this.br_trackBar.TickFrequency = 10;
            this.br_trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.br_trackBar.Value = 100;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.panel5.Controls.Add(this.controller1_textBox);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.connection_textBox);
            this.panel5.Controls.Add(this.connection_label);
            this.panel5.Location = new System.Drawing.Point(17, 107);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(423, 169);
            this.panel5.TabIndex = 51;
            // 
            // controller1_textBox
            // 
            this.controller1_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.controller1_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controller1_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.controller1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controller1_textBox.ForeColor = System.Drawing.Color.DarkRed;
            this.controller1_textBox.Location = new System.Drawing.Point(173, 111);
            this.controller1_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.controller1_textBox.Multiline = true;
            this.controller1_textBox.Name = "controller1_textBox";
            this.controller1_textBox.ReadOnly = true;
            this.controller1_textBox.Size = new System.Drawing.Size(230, 41);
            this.controller1_textBox.TabIndex = 71;
            this.controller1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 70;
            this.label1.Text = "Controller:";
            // 
            // connection_textBox
            // 
            this.connection_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.connection_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connection_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.connection_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_textBox.ForeColor = System.Drawing.Color.White;
            this.connection_textBox.Location = new System.Drawing.Point(203, 21);
            this.connection_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.connection_textBox.Multiline = true;
            this.connection_textBox.Name = "connection_textBox";
            this.connection_textBox.ReadOnly = true;
            this.connection_textBox.Size = new System.Drawing.Size(201, 41);
            this.connection_textBox.TabIndex = 69;
            // 
            // connection_label
            // 
            this.connection_label.AutoSize = true;
            this.connection_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_label.ForeColor = System.Drawing.Color.White;
            this.connection_label.Location = new System.Drawing.Point(19, 28);
            this.connection_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connection_label.Name = "connection_label";
            this.connection_label.Size = new System.Drawing.Size(162, 26);
            this.connection_label.TabIndex = 68;
            this.connection_label.Text = "Signal Integrity:";
            // 
            // wheelType_textBox
            // 
            this.wheelType_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.wheelType_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wheelType_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.wheelType_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheelType_textBox.ForeColor = System.Drawing.Color.White;
            this.wheelType_textBox.Location = new System.Drawing.Point(196, 288);
            this.wheelType_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.wheelType_textBox.Multiline = true;
            this.wheelType_textBox.Name = "wheelType_textBox";
            this.wheelType_textBox.ReadOnly = true;
            this.wheelType_textBox.Size = new System.Drawing.Size(181, 41);
            this.wheelType_textBox.TabIndex = 42;
            this.wheelType_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wheelType_label
            // 
            this.wheelType_label.AutoSize = true;
            this.wheelType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheelType_label.ForeColor = System.Drawing.Color.White;
            this.wheelType_label.Location = new System.Drawing.Point(23, 295);
            this.wheelType_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wheelType_label.Name = "wheelType_label";
            this.wheelType_label.Size = new System.Drawing.Size(133, 26);
            this.wheelType_label.TabIndex = 41;
            this.wheelType_label.Text = "Wheel Type:";
            // 
            // drivingSpeed_textBox
            // 
            this.drivingSpeed_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.drivingSpeed_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drivingSpeed_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.drivingSpeed_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingSpeed_textBox.ForeColor = System.Drawing.Color.White;
            this.drivingSpeed_textBox.Location = new System.Drawing.Point(196, 223);
            this.drivingSpeed_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.drivingSpeed_textBox.Multiline = true;
            this.drivingSpeed_textBox.Name = "drivingSpeed_textBox";
            this.drivingSpeed_textBox.ReadOnly = true;
            this.drivingSpeed_textBox.Size = new System.Drawing.Size(181, 41);
            this.drivingSpeed_textBox.TabIndex = 40;
            this.drivingSpeed_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drivingSpeed_label
            // 
            this.drivingSpeed_label.AutoSize = true;
            this.drivingSpeed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingSpeed_label.ForeColor = System.Drawing.Color.White;
            this.drivingSpeed_label.Location = new System.Drawing.Point(23, 230);
            this.drivingSpeed_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drivingSpeed_label.Name = "drivingSpeed_label";
            this.drivingSpeed_label.Size = new System.Drawing.Size(155, 26);
            this.drivingSpeed_label.TabIndex = 0;
            this.drivingSpeed_label.Text = "Driving Speed:";
            // 
            // computerVision_textBox
            // 
            this.computerVision_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.computerVision_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computerVision_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.computerVision_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerVision_textBox.ForeColor = System.Drawing.Color.DarkRed;
            this.computerVision_textBox.Location = new System.Drawing.Point(273, 222);
            this.computerVision_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.computerVision_textBox.Multiline = true;
            this.computerVision_textBox.Name = "computerVision_textBox";
            this.computerVision_textBox.ReadOnly = true;
            this.computerVision_textBox.Size = new System.Drawing.Size(99, 41);
            this.computerVision_textBox.TabIndex = 61;
            this.computerVision_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // computerVision_label
            // 
            this.computerVision_label.AutoSize = true;
            this.computerVision_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerVision_label.ForeColor = System.Drawing.Color.White;
            this.computerVision_label.Location = new System.Drawing.Point(21, 229);
            this.computerVision_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.computerVision_label.Name = "computerVision_label";
            this.computerVision_label.Size = new System.Drawing.Size(180, 26);
            this.computerVision_label.TabIndex = 60;
            this.computerVision_label.Text = "Computer Vision:";
            // 
            // ballsBad_progressBar
            // 
            this.ballsBad_progressBar.Location = new System.Drawing.Point(21, 225);
            this.ballsBad_progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ballsBad_progressBar.Maximum = 48;
            this.ballsBad_progressBar.Name = "ballsBad_progressBar";
            this.ballsBad_progressBar.Size = new System.Drawing.Size(591, 28);
            this.ballsBad_progressBar.TabIndex = 52;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.panel6.Controls.Add(this.ballsScored_textBox);
            this.panel6.Controls.Add(this.ballsScored_label);
            this.panel6.Controls.Add(this.ballsScored_progressBar);
            this.panel6.Controls.Add(this.ballsBad_textBox);
            this.panel6.Controls.Add(this.ballsGood_textBox);
            this.panel6.Controls.Add(this.ballsBad_label);
            this.panel6.Controls.Add(this.ballsGood_label);
            this.panel6.Controls.Add(this.ballsGood_progressBar);
            this.panel6.Controls.Add(this.ballsBad_progressBar);
            this.panel6.Location = new System.Drawing.Point(453, 463);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(796, 283);
            this.panel6.TabIndex = 53;
            // 
            // ballsScored_textBox
            // 
            this.ballsScored_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ballsScored_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ballsScored_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ballsScored_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ballsScored_textBox.ForeColor = System.Drawing.Color.White;
            this.ballsScored_textBox.Location = new System.Drawing.Point(629, 41);
            this.ballsScored_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.ballsScored_textBox.Multiline = true;
            this.ballsScored_textBox.Name = "ballsScored_textBox";
            this.ballsScored_textBox.ReadOnly = true;
            this.ballsScored_textBox.Size = new System.Drawing.Size(149, 50);
            this.ballsScored_textBox.TabIndex = 62;
            this.ballsScored_textBox.Text = "0 / 16";
            this.ballsScored_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ballsScored_label
            // 
            this.ballsScored_label.AutoSize = true;
            this.ballsScored_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ballsScored_label.ForeColor = System.Drawing.Color.White;
            this.ballsScored_label.Location = new System.Drawing.Point(21, 17);
            this.ballsScored_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ballsScored_label.Name = "ballsScored_label";
            this.ballsScored_label.Size = new System.Drawing.Size(135, 26);
            this.ballsScored_label.TabIndex = 61;
            this.ballsScored_label.Text = "Scored Balls";
            // 
            // ballsScored_progressBar
            // 
            this.ballsScored_progressBar.Location = new System.Drawing.Point(21, 50);
            this.ballsScored_progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ballsScored_progressBar.MarqueeAnimationSpeed = 0;
            this.ballsScored_progressBar.Maximum = 16;
            this.ballsScored_progressBar.Name = "ballsScored_progressBar";
            this.ballsScored_progressBar.Size = new System.Drawing.Size(591, 28);
            this.ballsScored_progressBar.TabIndex = 60;
            // 
            // ballsBad_textBox
            // 
            this.ballsBad_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ballsBad_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ballsBad_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ballsBad_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ballsBad_textBox.ForeColor = System.Drawing.Color.White;
            this.ballsBad_textBox.Location = new System.Drawing.Point(629, 213);
            this.ballsBad_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.ballsBad_textBox.Multiline = true;
            this.ballsBad_textBox.Name = "ballsBad_textBox";
            this.ballsBad_textBox.ReadOnly = true;
            this.ballsBad_textBox.Size = new System.Drawing.Size(149, 50);
            this.ballsBad_textBox.TabIndex = 57;
            this.ballsBad_textBox.Text = "0 / 48";
            this.ballsBad_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ballsGood_textBox
            // 
            this.ballsGood_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ballsGood_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ballsGood_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ballsGood_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ballsGood_textBox.ForeColor = System.Drawing.Color.White;
            this.ballsGood_textBox.Location = new System.Drawing.Point(629, 128);
            this.ballsGood_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.ballsGood_textBox.Multiline = true;
            this.ballsGood_textBox.Name = "ballsGood_textBox";
            this.ballsGood_textBox.ReadOnly = true;
            this.ballsGood_textBox.Size = new System.Drawing.Size(149, 50);
            this.ballsGood_textBox.TabIndex = 56;
            this.ballsGood_textBox.Text = "0 / 16";
            this.ballsGood_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ballsBad_label
            // 
            this.ballsBad_label.AutoSize = true;
            this.ballsBad_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ballsBad_label.ForeColor = System.Drawing.Color.White;
            this.ballsBad_label.Location = new System.Drawing.Point(21, 192);
            this.ballsBad_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ballsBad_label.Name = "ballsBad_label";
            this.ballsBad_label.Size = new System.Drawing.Size(105, 26);
            this.ballsBad_label.TabIndex = 55;
            this.ballsBad_label.Text = "Bad Balls";
            // 
            // ballsGood_label
            // 
            this.ballsGood_label.AutoSize = true;
            this.ballsGood_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ballsGood_label.ForeColor = System.Drawing.Color.White;
            this.ballsGood_label.Location = new System.Drawing.Point(21, 105);
            this.ballsGood_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ballsGood_label.Name = "ballsGood_label";
            this.ballsGood_label.Size = new System.Drawing.Size(197, 26);
            this.ballsGood_label.TabIndex = 54;
            this.ballsGood_label.Text = "Current Good Balls";
            // 
            // ballsGood_progressBar
            // 
            this.ballsGood_progressBar.Location = new System.Drawing.Point(21, 138);
            this.ballsGood_progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ballsGood_progressBar.MarqueeAnimationSpeed = 0;
            this.ballsGood_progressBar.Maximum = 16;
            this.ballsGood_progressBar.Name = "ballsGood_progressBar";
            this.ballsGood_progressBar.Size = new System.Drawing.Size(591, 28);
            this.ballsGood_progressBar.TabIndex = 53;
            // 
            // sortingStatus_textBox
            // 
            this.sortingStatus_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.sortingStatus_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortingStatus_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.sortingStatus_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortingStatus_textBox.ForeColor = System.Drawing.Color.DarkRed;
            this.sortingStatus_textBox.Location = new System.Drawing.Point(224, 85);
            this.sortingStatus_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.sortingStatus_textBox.Multiline = true;
            this.sortingStatus_textBox.Name = "sortingStatus_textBox";
            this.sortingStatus_textBox.ReadOnly = true;
            this.sortingStatus_textBox.Size = new System.Drawing.Size(149, 41);
            this.sortingStatus_textBox.TabIndex = 59;
            this.sortingStatus_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sortingStatus_label
            // 
            this.sortingStatus_label.AutoSize = true;
            this.sortingStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortingStatus_label.ForeColor = System.Drawing.Color.White;
            this.sortingStatus_label.Location = new System.Drawing.Point(21, 92);
            this.sortingStatus_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortingStatus_label.Name = "sortingStatus_label";
            this.sortingStatus_label.Size = new System.Drawing.Size(155, 26);
            this.sortingStatus_label.TabIndex = 58;
            this.sortingStatus_label.Text = "Sorting Status:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.panel7.Controls.Add(this.intake_textBox);
            this.panel7.Controls.Add(this.intake_label);
            this.panel7.Controls.Add(this.shooter_textBox);
            this.panel7.Controls.Add(this.sortingStatus_textBox);
            this.panel7.Controls.Add(this.sortingStatus_label);
            this.panel7.Controls.Add(this.shooter_label);
            this.panel7.Controls.Add(this.manipulatorAngle_textBox);
            this.panel7.Controls.Add(this.manipulatorAngle_label);
            this.panel7.Controls.Add(this.computerVision_label);
            this.panel7.Controls.Add(this.computerVision_textBox);
            this.panel7.Location = new System.Drawing.Point(859, 107);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(391, 342);
            this.panel7.TabIndex = 54;
            // 
            // intake_textBox
            // 
            this.intake_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.intake_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intake_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.intake_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intake_textBox.ForeColor = System.Drawing.Color.DarkRed;
            this.intake_textBox.Location = new System.Drawing.Point(273, 154);
            this.intake_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.intake_textBox.Multiline = true;
            this.intake_textBox.Name = "intake_textBox";
            this.intake_textBox.ReadOnly = true;
            this.intake_textBox.Size = new System.Drawing.Size(99, 41);
            this.intake_textBox.TabIndex = 69;
            this.intake_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // intake_label
            // 
            this.intake_label.AutoSize = true;
            this.intake_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intake_label.ForeColor = System.Drawing.Color.White;
            this.intake_label.Location = new System.Drawing.Point(21, 161);
            this.intake_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intake_label.Name = "intake_label";
            this.intake_label.Size = new System.Drawing.Size(77, 26);
            this.intake_label.TabIndex = 68;
            this.intake_label.Text = "Intake:";
            // 
            // shooter_textBox
            // 
            this.shooter_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.shooter_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shooter_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.shooter_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shooter_textBox.ForeColor = System.Drawing.Color.DarkRed;
            this.shooter_textBox.Location = new System.Drawing.Point(273, 14);
            this.shooter_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.shooter_textBox.Multiline = true;
            this.shooter_textBox.Name = "shooter_textBox";
            this.shooter_textBox.ReadOnly = true;
            this.shooter_textBox.Size = new System.Drawing.Size(99, 41);
            this.shooter_textBox.TabIndex = 67;
            this.shooter_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shooter_label
            // 
            this.shooter_label.AutoSize = true;
            this.shooter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shooter_label.ForeColor = System.Drawing.Color.White;
            this.shooter_label.Location = new System.Drawing.Point(21, 21);
            this.shooter_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shooter_label.Name = "shooter_label";
            this.shooter_label.Size = new System.Drawing.Size(94, 26);
            this.shooter_label.TabIndex = 66;
            this.shooter_label.Text = "Shooter:";
            // 
            // manipulatorAngle_textBox
            // 
            this.manipulatorAngle_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.manipulatorAngle_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manipulatorAngle_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.manipulatorAngle_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manipulatorAngle_textBox.ForeColor = System.Drawing.Color.White;
            this.manipulatorAngle_textBox.Location = new System.Drawing.Point(273, 281);
            this.manipulatorAngle_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.manipulatorAngle_textBox.Multiline = true;
            this.manipulatorAngle_textBox.Name = "manipulatorAngle_textBox";
            this.manipulatorAngle_textBox.ReadOnly = true;
            this.manipulatorAngle_textBox.Size = new System.Drawing.Size(99, 41);
            this.manipulatorAngle_textBox.TabIndex = 63;
            this.manipulatorAngle_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // manipulatorAngle_label
            // 
            this.manipulatorAngle_label.AutoSize = true;
            this.manipulatorAngle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manipulatorAngle_label.ForeColor = System.Drawing.Color.White;
            this.manipulatorAngle_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.manipulatorAngle_label.Location = new System.Drawing.Point(21, 288);
            this.manipulatorAngle_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manipulatorAngle_label.Name = "manipulatorAngle_label";
            this.manipulatorAngle_label.Size = new System.Drawing.Size(193, 26);
            this.manipulatorAngle_label.TabIndex = 62;
            this.manipulatorAngle_label.Text = "Manipulator Angle:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.panel8.Controls.Add(this.autoCompress_textBox);
            this.panel8.Controls.Add(this.autoCompress_label);
            this.panel8.Controls.Add(this.wheelType_textBox);
            this.panel8.Controls.Add(this.wheelType_label);
            this.panel8.Controls.Add(this.compressorStatus_textBox);
            this.panel8.Controls.Add(this.drivingSpeed_textBox);
            this.panel8.Controls.Add(this.compressorStatus_label);
            this.panel8.Controls.Add(this.drivingSpeed_label);
            this.panel8.Controls.Add(this.pressure_textBox);
            this.panel8.Controls.Add(this.pressure_label);
            this.panel8.Location = new System.Drawing.Point(453, 107);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(393, 342);
            this.panel8.TabIndex = 55;
            // 
            // autoCompress_textBox
            // 
            this.autoCompress_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.autoCompress_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoCompress_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.autoCompress_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompress_textBox.ForeColor = System.Drawing.Color.DarkRed;
            this.autoCompress_textBox.Location = new System.Drawing.Point(239, 158);
            this.autoCompress_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.autoCompress_textBox.Multiline = true;
            this.autoCompress_textBox.Name = "autoCompress_textBox";
            this.autoCompress_textBox.ReadOnly = true;
            this.autoCompress_textBox.Size = new System.Drawing.Size(138, 41);
            this.autoCompress_textBox.TabIndex = 67;
            this.autoCompress_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autoCompress_label
            // 
            this.autoCompress_label.AutoSize = true;
            this.autoCompress_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoCompress_label.ForeColor = System.Drawing.Color.White;
            this.autoCompress_label.Location = new System.Drawing.Point(23, 165);
            this.autoCompress_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autoCompress_label.Name = "autoCompress_label";
            this.autoCompress_label.Size = new System.Drawing.Size(181, 26);
            this.autoCompress_label.TabIndex = 66;
            this.autoCompress_label.Text = "Pressure Control:";
            // 
            // compressorStatus_textBox
            // 
            this.compressorStatus_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.compressorStatus_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compressorStatus_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.compressorStatus_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressorStatus_textBox.ForeColor = System.Drawing.Color.DarkRed;
            this.compressorStatus_textBox.Location = new System.Drawing.Point(277, 89);
            this.compressorStatus_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.compressorStatus_textBox.Multiline = true;
            this.compressorStatus_textBox.Name = "compressorStatus_textBox";
            this.compressorStatus_textBox.ReadOnly = true;
            this.compressorStatus_textBox.Size = new System.Drawing.Size(99, 41);
            this.compressorStatus_textBox.TabIndex = 65;
            this.compressorStatus_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // compressorStatus_label
            // 
            this.compressorStatus_label.AutoSize = true;
            this.compressorStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressorStatus_label.ForeColor = System.Drawing.Color.White;
            this.compressorStatus_label.Location = new System.Drawing.Point(23, 96);
            this.compressorStatus_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.compressorStatus_label.Name = "compressorStatus_label";
            this.compressorStatus_label.Size = new System.Drawing.Size(205, 26);
            this.compressorStatus_label.TabIndex = 64;
            this.compressorStatus_label.Text = "Compressor Status:";
            // 
            // pressure_textBox
            // 
            this.pressure_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pressure_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pressure_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.pressure_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure_textBox.ForeColor = System.Drawing.Color.White;
            this.pressure_textBox.Location = new System.Drawing.Point(277, 21);
            this.pressure_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.pressure_textBox.Multiline = true;
            this.pressure_textBox.Name = "pressure_textBox";
            this.pressure_textBox.ReadOnly = true;
            this.pressure_textBox.Size = new System.Drawing.Size(99, 41);
            this.pressure_textBox.TabIndex = 63;
            this.pressure_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pressure_label
            // 
            this.pressure_label.AutoSize = true;
            this.pressure_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure_label.ForeColor = System.Drawing.Color.White;
            this.pressure_label.Location = new System.Drawing.Point(23, 28);
            this.pressure_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressure_label.Name = "pressure_label";
            this.pressure_label.Size = new System.Drawing.Size(105, 26);
            this.pressure_label.TabIndex = 62;
            this.pressure_label.Text = "Pressure:";
            // 
            // DriverStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1272, 764);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.br_trackBar);
            this.Controls.Add(this.fr_trackBar);
            this.Controls.Add(this.bl_trackBar);
            this.Controls.Add(this.fl_trackBar);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DriverStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iRobotics Command Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.iRoboticsCommandCenter_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fl_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bl_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fr_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.br_trackBar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label controllerspLabel;
        private System.Windows.Forms.ComboBox controllerComboBox;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar fl_trackBar;
        private System.Windows.Forms.TrackBar bl_trackBar;
        private System.Windows.Forms.TrackBar fr_trackBar;
        private System.Windows.Forms.TrackBar br_trackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox wheelType_textBox;
        private System.Windows.Forms.Label wheelType_label;
        private System.Windows.Forms.TextBox drivingSpeed_textBox;
        private System.Windows.Forms.Label drivingSpeed_label;
        private System.Windows.Forms.ProgressBar ballsBad_progressBar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label ballsGood_label;
        private System.Windows.Forms.ProgressBar ballsGood_progressBar;
        private System.Windows.Forms.Label ballsBad_label;
        private System.Windows.Forms.TextBox ballsBad_textBox;
        private System.Windows.Forms.TextBox ballsGood_textBox;
        private System.Windows.Forms.TextBox sortingStatus_textBox;
        private System.Windows.Forms.Label sortingStatus_label;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox manipulatorAngle_textBox;
        private System.Windows.Forms.Label manipulatorAngle_label;
        private System.Windows.Forms.TextBox computerVision_textBox;
        private System.Windows.Forms.Label computerVision_label;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox compressorStatus_textBox;
        private System.Windows.Forms.Label compressorStatus_label;
        private System.Windows.Forms.TextBox pressure_textBox;
        private System.Windows.Forms.Label pressure_label;
        private System.Windows.Forms.TextBox autoCompress_textBox;
        private System.Windows.Forms.Label autoCompress_label;
        private System.Windows.Forms.TextBox ballsScored_textBox;
        private System.Windows.Forms.Label ballsScored_label;
        private System.Windows.Forms.ProgressBar ballsScored_progressBar;
        private System.Windows.Forms.TextBox connection_textBox;
        private System.Windows.Forms.Label connection_label;
        private System.Windows.Forms.TextBox shooter_textBox;
        private System.Windows.Forms.Label shooter_label;
        private System.Windows.Forms.TextBox intake_textBox;
        private System.Windows.Forms.Label intake_label;
        private System.Windows.Forms.TextBox controller1_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

