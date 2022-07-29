namespace PC_Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RAM_txt = new System.Windows.Forms.Label();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.ComputerName_txt = new System.Windows.Forms.Label();
            this.UserName_txt = new System.Windows.Forms.Label();
            this.systemip_txt = new System.Windows.Forms.Label();
            this.TimeZone_txt = new System.Windows.Forms.Label();
            this.Osname_txt = new System.Windows.Forms.Label();
            this.GPU_txt = new System.Windows.Forms.Label();
            this.cpu_txt = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label17);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer2.Panel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chart1);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.Refresh_btn);
            this.splitContainer2.Panel2.Controls.Add(this.ComputerName_txt);
            this.splitContainer2.Panel2.Controls.Add(this.UserName_txt);
            this.splitContainer2.Panel2.Controls.Add(this.systemip_txt);
            this.splitContainer2.Panel2.Controls.Add(this.TimeZone_txt);
            this.splitContainer2.Panel2.Controls.Add(this.Osname_txt);
            this.splitContainer2.Panel2.Controls.Add(this.GPU_txt);
            this.splitContainer2.Panel2.Controls.Add(this.cpu_txt);
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip2);
            this.splitContainer2.Size = new System.Drawing.Size(962, 474);
            this.splitContainer2.SplitterDistance = 271;
            this.splitContainer2.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 288);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 25);
            this.label17.TabIndex = 10;
            this.label17.Text = "Computer Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "User Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "System IP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Time Zone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "OS Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "RAM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "GPU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "CPU";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(271, 28);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 23);
            this.toolStripStatusLabel1.Text = "Item";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RAM_txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 104);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RAM Properties";
            // 
            // RAM_txt
            // 
            this.RAM_txt.AutoSize = true;
            this.RAM_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAM_txt.Location = new System.Drawing.Point(6, 20);
            this.RAM_txt.Name = "RAM_txt";
            this.RAM_txt.Size = new System.Drawing.Size(52, 24);
            this.RAM_txt.TabIndex = 10;
            this.RAM_txt.Text = "RAM";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Location = new System.Drawing.Point(549, 424);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(106, 38);
            this.Refresh_btn.TabIndex = 12;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // ComputerName_txt
            // 
            this.ComputerName_txt.AutoSize = true;
            this.ComputerName_txt.Location = new System.Drawing.Point(3, 288);
            this.ComputerName_txt.Name = "ComputerName_txt";
            this.ComputerName_txt.Size = new System.Drawing.Size(155, 25);
            this.ComputerName_txt.TabIndex = 11;
            this.ComputerName_txt.Text = "Computer Name";
            // 
            // UserName_txt
            // 
            this.UserName_txt.AutoSize = true;
            this.UserName_txt.Location = new System.Drawing.Point(3, 263);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(110, 25);
            this.UserName_txt.TabIndex = 10;
            this.UserName_txt.Text = "User Name";
            // 
            // systemip_txt
            // 
            this.systemip_txt.AutoSize = true;
            this.systemip_txt.Location = new System.Drawing.Point(3, 238);
            this.systemip_txt.Name = "systemip_txt";
            this.systemip_txt.Size = new System.Drawing.Size(101, 25);
            this.systemip_txt.TabIndex = 10;
            this.systemip_txt.Text = "System IP";
            // 
            // TimeZone_txt
            // 
            this.TimeZone_txt.AutoSize = true;
            this.TimeZone_txt.Location = new System.Drawing.Point(3, 213);
            this.TimeZone_txt.Name = "TimeZone_txt";
            this.TimeZone_txt.Size = new System.Drawing.Size(106, 25);
            this.TimeZone_txt.TabIndex = 10;
            this.TimeZone_txt.Text = "Time Zone";
            // 
            // Osname_txt
            // 
            this.Osname_txt.AutoSize = true;
            this.Osname_txt.Location = new System.Drawing.Point(3, 188);
            this.Osname_txt.Name = "Osname_txt";
            this.Osname_txt.Size = new System.Drawing.Size(99, 25);
            this.Osname_txt.TabIndex = 10;
            this.Osname_txt.Text = "OS Name";
            // 
            // GPU_txt
            // 
            this.GPU_txt.AutoSize = true;
            this.GPU_txt.Location = new System.Drawing.Point(3, 53);
            this.GPU_txt.Name = "GPU_txt";
            this.GPU_txt.Size = new System.Drawing.Size(54, 25);
            this.GPU_txt.TabIndex = 10;
            this.GPU_txt.Text = "GPU";
            // 
            // cpu_txt
            // 
            this.cpu_txt.AutoSize = true;
            this.cpu_txt.Location = new System.Drawing.Point(3, 28);
            this.cpu_txt.Name = "cpu_txt";
            this.cpu_txt.Size = new System.Drawing.Size(54, 25);
            this.cpu_txt.TabIndex = 10;
            this.cpu_txt.Text = "CPU";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 0);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(687, 28);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(52, 23);
            this.toolStripStatusLabel2.Text = "Value";
            // 
            // chart1
            // 
            this.chart1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(364, 78);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "RAM";
            dataPoint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            dataPoint1.Label = "Free Physical Memory";
            dataPoint2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            dataPoint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            dataPoint2.IsValueShownAsLabel = false;
            dataPoint2.Label = "Total Visible Memory";
            dataPoint3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            dataPoint3.Label = "Total Virtual Memory";
            dataPoint4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            dataPoint4.Label = "Free Virtual Memory";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(311, 210);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(962, 474);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "My PC Statistics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label UserName_txt;
        private System.Windows.Forms.Label systemip_txt;
        private System.Windows.Forms.Label TimeZone_txt;
        private System.Windows.Forms.Label Osname_txt;
        private System.Windows.Forms.Label RAM_txt;
        private System.Windows.Forms.Label GPU_txt;
        private System.Windows.Forms.Label cpu_txt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label ComputerName_txt;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

