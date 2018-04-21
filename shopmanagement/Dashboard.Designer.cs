namespace shopmanagement
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Btnpanel = new System.Windows.Forms.Panel();
            this.categorybtn = new System.Windows.Forms.Button();
            this.productbtn = new System.Windows.Forms.Button();
            this.graphpanel = new System.Windows.Forms.Panel();
            this.masalachat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Btnpanel.SuspendLayout();
            this.graphpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masalachat)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnpanel
            // 
            this.Btnpanel.Controls.Add(this.categorybtn);
            this.Btnpanel.Controls.Add(this.productbtn);
            this.Btnpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btnpanel.Location = new System.Drawing.Point(0, 0);
            this.Btnpanel.Name = "Btnpanel";
            this.Btnpanel.Size = new System.Drawing.Size(164, 418);
            this.Btnpanel.TabIndex = 0;
            // 
            // categorybtn
            // 
            this.categorybtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.categorybtn.FlatAppearance.BorderSize = 0;
            this.categorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorybtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybtn.ForeColor = System.Drawing.SystemColors.Control;
            this.categorybtn.Location = new System.Drawing.Point(13, 189);
            this.categorybtn.Name = "categorybtn";
            this.categorybtn.Size = new System.Drawing.Size(140, 40);
            this.categorybtn.TabIndex = 4;
            this.categorybtn.Text = "Category Wise";
            this.categorybtn.UseVisualStyleBackColor = false;
            this.categorybtn.Click += new System.EventHandler(this.categorybtn_Click);
            // 
            // productbtn
            // 
            this.productbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.productbtn.FlatAppearance.BorderSize = 0;
            this.productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.productbtn.Location = new System.Drawing.Point(13, 107);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(140, 40);
            this.productbtn.TabIndex = 3;
            this.productbtn.Text = "Product Wise";
            this.productbtn.UseVisualStyleBackColor = false;
            this.productbtn.Click += new System.EventHandler(this.productbtn_Click);
            // 
            // graphpanel
            // 
            this.graphpanel.Controls.Add(this.masalachat);
            this.graphpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphpanel.Location = new System.Drawing.Point(164, 0);
            this.graphpanel.Name = "graphpanel";
            this.graphpanel.Size = new System.Drawing.Size(706, 418);
            this.graphpanel.TabIndex = 1;
            // 
            // masalachat
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarksNextToAxis = false;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep90)));
            chartArea1.Name = "ChartArea1";
            this.masalachat.ChartAreas.Add(chartArea1);
            this.masalachat.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.masalachat.Legends.Add(legend1);
            this.masalachat.Location = new System.Drawing.Point(0, 0);
            this.masalachat.Name = "masalachat";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Profit";
            this.masalachat.Series.Add(series1);
            this.masalachat.Size = new System.Drawing.Size(706, 418);
            this.masalachat.TabIndex = 0;
            this.masalachat.Text = "chart1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.graphpanel);
            this.Controls.Add(this.Btnpanel);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(870, 418);
            this.Btnpanel.ResumeLayout(false);
            this.graphpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masalachat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Btnpanel;
        private System.Windows.Forms.Panel graphpanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart masalachat;
        private System.Windows.Forms.Button categorybtn;
        private System.Windows.Forms.Button productbtn;
    }
}
