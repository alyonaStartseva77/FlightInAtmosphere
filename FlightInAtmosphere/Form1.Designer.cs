
namespace FlightInAtmosphere
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericSquare = new System.Windows.Forms.NumericUpDown();
            this.numericWeight = new System.Windows.Forms.NumericUpDown();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericAngle = new System.Windows.Forms.NumericUpDown();
            this.labelSquare = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelAngle = new System.Windows.Forms.Label();
            this.titleData = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer.Panel1.Controls.Add(this.buttonStart);
            this.splitContainer.Panel1.Controls.Add(this.numericSquare);
            this.splitContainer.Panel1.Controls.Add(this.numericWeight);
            this.splitContainer.Panel1.Controls.Add(this.numericHeight);
            this.splitContainer.Panel1.Controls.Add(this.numericSpeed);
            this.splitContainer.Panel1.Controls.Add(this.numericAngle);
            this.splitContainer.Panel1.Controls.Add(this.labelSquare);
            this.splitContainer.Panel1.Controls.Add(this.labelWeight);
            this.splitContainer.Panel1.Controls.Add(this.labelHeight);
            this.splitContainer.Panel1.Controls.Add(this.labelSpeed);
            this.splitContainer.Panel1.Controls.Add(this.labelAngle);
            this.splitContainer.Panel1.Controls.Add(this.titleData);
            this.splitContainer.Panel1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackgroundImage = global::FlightInAtmosphere.Properties.Resources.bg;
            this.splitContainer.Panel2.Controls.Add(this.chart);
            this.splitContainer.Size = new System.Drawing.Size(1420, 747);
            this.splitContainer.SplitterDistance = 267;
            this.splitContainer.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonStart.Location = new System.Drawing.Point(19, 384);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(231, 53);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "START!";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericSquare
            // 
            this.numericSquare.BackColor = System.Drawing.Color.AliceBlue;
            this.numericSquare.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSquare.ForeColor = System.Drawing.Color.Navy;
            this.numericSquare.Location = new System.Drawing.Point(102, 273);
            this.numericSquare.Name = "numericSquare";
            this.numericSquare.Size = new System.Drawing.Size(149, 28);
            this.numericSquare.TabIndex = 10;
            this.numericSquare.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericWeight
            // 
            this.numericWeight.BackColor = System.Drawing.Color.AliceBlue;
            this.numericWeight.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericWeight.ForeColor = System.Drawing.Color.Navy;
            this.numericWeight.Location = new System.Drawing.Point(102, 232);
            this.numericWeight.Name = "numericWeight";
            this.numericWeight.Size = new System.Drawing.Size(149, 28);
            this.numericWeight.TabIndex = 9;
            this.numericWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericHeight
            // 
            this.numericHeight.BackColor = System.Drawing.Color.AliceBlue;
            this.numericHeight.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHeight.ForeColor = System.Drawing.Color.Navy;
            this.numericHeight.Location = new System.Drawing.Point(102, 192);
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(149, 28);
            this.numericHeight.TabIndex = 8;
            // 
            // numericSpeed
            // 
            this.numericSpeed.BackColor = System.Drawing.Color.AliceBlue;
            this.numericSpeed.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSpeed.ForeColor = System.Drawing.Color.Navy;
            this.numericSpeed.Location = new System.Drawing.Point(102, 151);
            this.numericSpeed.Name = "numericSpeed";
            this.numericSpeed.Size = new System.Drawing.Size(149, 28);
            this.numericSpeed.TabIndex = 7;
            this.numericSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericAngle
            // 
            this.numericAngle.BackColor = System.Drawing.Color.AliceBlue;
            this.numericAngle.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAngle.ForeColor = System.Drawing.Color.Navy;
            this.numericAngle.Location = new System.Drawing.Point(102, 111);
            this.numericAngle.Name = "numericAngle";
            this.numericAngle.Size = new System.Drawing.Size(149, 28);
            this.numericAngle.TabIndex = 6;
            this.numericAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // labelSquare
            // 
            this.labelSquare.AutoSize = true;
            this.labelSquare.BackColor = System.Drawing.Color.Transparent;
            this.labelSquare.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSquare.ForeColor = System.Drawing.Color.Navy;
            this.labelSquare.Location = new System.Drawing.Point(16, 271);
            this.labelSquare.Name = "labelSquare";
            this.labelSquare.Size = new System.Drawing.Size(78, 25);
            this.labelSquare.TabIndex = 5;
            this.labelSquare.Text = "Square:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.BackColor = System.Drawing.Color.Transparent;
            this.labelWeight.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.ForeColor = System.Drawing.Color.Navy;
            this.labelWeight.Location = new System.Drawing.Point(16, 230);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(80, 25);
            this.labelWeight.TabIndex = 4;
            this.labelWeight.Text = "Weight:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.BackColor = System.Drawing.Color.Transparent;
            this.labelHeight.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.ForeColor = System.Drawing.Color.Navy;
            this.labelHeight.Location = new System.Drawing.Point(16, 190);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(76, 25);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Height:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeed.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.Navy;
            this.labelSpeed.Location = new System.Drawing.Point(15, 150);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(70, 25);
            this.labelSpeed.TabIndex = 2;
            this.labelSpeed.Text = "Speed:";
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.BackColor = System.Drawing.Color.Transparent;
            this.labelAngle.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAngle.ForeColor = System.Drawing.Color.Navy;
            this.labelAngle.Location = new System.Drawing.Point(21, 109);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(66, 25);
            this.labelAngle.TabIndex = 1;
            this.labelAngle.Text = "Angle:";
            // 
            // titleData
            // 
            this.titleData.AutoSize = true;
            this.titleData.BackColor = System.Drawing.Color.Transparent;
            this.titleData.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleData.ForeColor = System.Drawing.Color.Navy;
            this.titleData.Location = new System.Drawing.Point(96, 47);
            this.titleData.Name = "titleData";
            this.titleData.Size = new System.Drawing.Size(73, 34);
            this.titleData.TabIndex = 0;
            this.titleData.Text = "DATA:";
            // 
            // chart
            // 
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1149, 747);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 747);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "FlightInAtmosphere";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label titleData;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown numericSquare;
        private System.Windows.Forms.NumericUpDown numericWeight;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericSpeed;
        private System.Windows.Forms.NumericUpDown numericAngle;
        private System.Windows.Forms.Label labelSquare;
        private System.Windows.Forms.Button buttonStart;
    }
}

