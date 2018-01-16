namespace BlackJack
{
    partial class FrmData
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
            this.pChart = new LiveCharts.WinForms.PieChart();
            this.caChart = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // pChart
            // 
            this.pChart.Location = new System.Drawing.Point(13, 13);
            this.pChart.Name = "pChart";
            this.pChart.Size = new System.Drawing.Size(227, 194);
            this.pChart.TabIndex = 0;
            this.pChart.Text = "pieChart1";
            // 
            // caChart
            // 
            this.caChart.Location = new System.Drawing.Point(246, 13);
            this.caChart.Name = "caChart";
            this.caChart.Size = new System.Drawing.Size(498, 194);
            this.caChart.TabIndex = 1;
            this.caChart.Text = "cartesianChart1";
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 219);
            this.Controls.Add(this.caChart);
            this.Controls.Add(this.pChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmData";
            this.Text = "Données";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmData_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pChart;
        private LiveCharts.WinForms.CartesianChart caChart;
    }
}