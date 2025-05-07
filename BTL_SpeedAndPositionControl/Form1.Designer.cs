namespace BTL_SpeedAndPositionControl
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDisconnectUART = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SetPointSpeed = new System.Windows.Forms.Button();
            this.btnSetPIDSpeed = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelStUart = new System.Windows.Forms.Label();
            this.comboBaudrate = new System.Windows.Forms.ComboBox();
            this.comboCom = new System.Windows.Forms.ComboBox();
            this.buttonConnectUART = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SetPointPosistion = new System.Windows.Forms.Button();
            this.BtnSetPIDPosistion = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDisconnectUART
            // 
            this.buttonDisconnectUART.Location = new System.Drawing.Point(140, 240);
            this.buttonDisconnectUART.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDisconnectUART.Name = "buttonDisconnectUART";
            this.buttonDisconnectUART.Size = new System.Drawing.Size(106, 28);
            this.buttonDisconnectUART.TabIndex = 4;
            this.buttonDisconnectUART.Text = "Disconnect";
            this.buttonDisconnectUART.UseVisualStyleBackColor = true;
            this.buttonDisconnectUART.Click += new System.EventHandler(this.buttonDisconnectUART_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SetPointSpeed);
            this.groupBox5.Controls.Add(this.btnSetPIDSpeed);
            this.groupBox5.Controls.Add(this.textBox13);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.textBox14);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.textBox15);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.textBox16);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(44, 430);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(351, 227);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PID Control Speed";
            // 
            // SetPointSpeed
            // 
            this.SetPointSpeed.Location = new System.Drawing.Point(220, 35);
            this.SetPointSpeed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SetPointSpeed.Name = "SetPointSpeed";
            this.SetPointSpeed.Size = new System.Drawing.Size(106, 28);
            this.SetPointSpeed.TabIndex = 12;
            this.SetPointSpeed.Text = "Set";
            this.SetPointSpeed.UseVisualStyleBackColor = true;
            this.SetPointSpeed.Click += new System.EventHandler(this.SetPointSpeed_Click);
            // 
            // btnSetPIDSpeed
            // 
            this.btnSetPIDSpeed.Location = new System.Drawing.Point(220, 113);
            this.btnSetPIDSpeed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSetPIDSpeed.Name = "btnSetPIDSpeed";
            this.btnSetPIDSpeed.Size = new System.Drawing.Size(106, 28);
            this.btnSetPIDSpeed.TabIndex = 11;
            this.btnSetPIDSpeed.Text = "Set PID";
            this.btnSetPIDSpeed.UseVisualStyleBackColor = true;
            this.btnSetPIDSpeed.Click += new System.EventHandler(this.btnSetPIDSpeed_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(69, 35);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(143, 20);
            this.textBox13.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Setpoint";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(69, 152);
            this.textBox14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(143, 20);
            this.textBox14.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 157);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Kd";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(69, 113);
            this.textBox15.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(143, 20);
            this.textBox15.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 113);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Ki";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(69, 71);
            this.textBox16.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(143, 20);
            this.textBox16.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 75);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Kp";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(100, 109);
            this.textBox20.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(130, 20);
            this.textBox20.TabIndex = 16;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(100, 146);
            this.textBox19.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(130, 20);
            this.textBox19.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 149);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Current Speed";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 111);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Current possition";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelStUart);
            this.groupBox4.Controls.Add(this.comboBaudrate);
            this.groupBox4.Controls.Add(this.comboCom);
            this.groupBox4.Controls.Add(this.buttonConnectUART);
            this.groupBox4.Controls.Add(this.textBox19);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.textBox20);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.buttonDisconnectUART);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(44, 115);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(250, 308);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UART Device Connection";
            // 
            // labelStUart
            // 
            this.labelStUart.AutoSize = true;
            this.labelStUart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStUart.ForeColor = System.Drawing.Color.Red;
            this.labelStUart.Location = new System.Drawing.Point(65, 198);
            this.labelStUart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStUart.Name = "labelStUart";
            this.labelStUart.Size = new System.Drawing.Size(136, 20);
            this.labelStUart.TabIndex = 22;
            this.labelStUart.Text = "DISCONNECTED";
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBaudrate.Location = new System.Drawing.Point(100, 69);
            this.comboBaudrate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(116, 21);
            this.comboBaudrate.TabIndex = 21;
            // 
            // comboCom
            // 
            this.comboCom.FormattingEnabled = true;
            this.comboCom.Location = new System.Drawing.Point(93, 33);
            this.comboCom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboCom.Name = "comboCom";
            this.comboCom.Size = new System.Drawing.Size(116, 21);
            this.comboCom.TabIndex = 20;
            this.comboCom.SelectedIndexChanged += new System.EventHandler(this.comboCom_SelectedIndexChanged);
            // 
            // buttonConnectUART
            // 
            this.buttonConnectUART.Location = new System.Drawing.Point(4, 240);
            this.buttonConnectUART.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonConnectUART.Name = "buttonConnectUART";
            this.buttonConnectUART.Size = new System.Drawing.Size(106, 28);
            this.buttonConnectUART.TabIndex = 19;
            this.buttonConnectUART.Text = "Connect";
            this.buttonConnectUART.UseVisualStyleBackColor = true;
            this.buttonConnectUART.Click += new System.EventHandler(this.buttonConnectUART_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Baud Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "COM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SetPointPosistion);
            this.groupBox2.Controls.Add(this.BtnSetPIDPosistion);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(44, 663);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(351, 227);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PID Control Position";
            // 
            // SetPointPosistion
            // 
            this.SetPointPosistion.Location = new System.Drawing.Point(215, 30);
            this.SetPointPosistion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SetPointPosistion.Name = "SetPointPosistion";
            this.SetPointPosistion.Size = new System.Drawing.Size(106, 28);
            this.SetPointPosistion.TabIndex = 12;
            this.SetPointPosistion.Text = "Set";
            this.SetPointPosistion.UseVisualStyleBackColor = true;
            this.SetPointPosistion.Click += new System.EventHandler(this.SetPointPosistion_Click);
            // 
            // BtnSetPIDPosistion
            // 
            this.BtnSetPIDPosistion.Location = new System.Drawing.Point(215, 108);
            this.BtnSetPIDPosistion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSetPIDPosistion.Name = "BtnSetPIDPosistion";
            this.BtnSetPIDPosistion.Size = new System.Drawing.Size(106, 28);
            this.BtnSetPIDPosistion.TabIndex = 11;
            this.BtnSetPIDPosistion.Text = "Set PID";
            this.BtnSetPIDPosistion.UseVisualStyleBackColor = true;
            this.BtnSetPIDPosistion.Click += new System.EventHandler(this.BtnSetPIDPosistion_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(69, 35);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(143, 20);
            this.textBox6.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Setpoint";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(69, 152);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 20);
            this.textBox5.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kd";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 113);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ki";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(69, 71);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kp";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(106, 30);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(668, 26);
            this.label21.TabIndex = 12;
            this.label21.Text = "Major assignment for the subject of Introduction to Intelligent Control";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(387, 115);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Speed";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.LabelBorderWidth = 2;
            series4.Legend = "Legend1";
            series4.Name = "Setpoint";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(998, 300);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 920);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDisconnectUART;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSetPIDSpeed;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSetPIDPosistion;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonConnectUART;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBaudrate;
        private System.Windows.Forms.ComboBox comboCom;
        private System.Windows.Forms.Label labelStUart;
        private System.Windows.Forms.Button SetPointSpeed;
        private System.Windows.Forms.Button SetPointPosistion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

