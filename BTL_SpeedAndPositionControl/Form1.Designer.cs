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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDisconnectUART = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SetPointSpeed = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.label21 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox5.Controls.Add(this.textBox13);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(44, 430);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(331, 91);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Set Speed";
            // 
            // SetPointSpeed
            // 
            this.SetPointSpeed.Location = new System.Drawing.Point(216, 30);
            this.SetPointSpeed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SetPointSpeed.Name = "SetPointSpeed";
            this.SetPointSpeed.Size = new System.Drawing.Size(106, 28);
            this.SetPointSpeed.TabIndex = 12;
            this.SetPointSpeed.Text = "Set";
            this.SetPointSpeed.UseVisualStyleBackColor = true;
            this.SetPointSpeed.Click += new System.EventHandler(this.SetPointSpeed_Click);
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
            this.comboCom.Location = new System.Drawing.Point(100, 33);
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
            this.label10.Location = new System.Drawing.Point(14, 72);
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
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(382, 38);
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
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(387, 115);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Speed";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.LabelBorderWidth = 2;
            series8.Legend = "Legend1";
            series8.Name = "Setpoint";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(998, 406);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 548);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDisconnectUART;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonConnectUART;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBaudrate;
        private System.Windows.Forms.ComboBox comboCom;
        private System.Windows.Forms.Label labelStUart;
        private System.Windows.Forms.Button SetPointSpeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

