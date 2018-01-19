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
            this.pChartPro = new LiveCharts.WinForms.PieChart();
            this.caChart = new LiveCharts.WinForms.CartesianChart();
            this.pChartPlayerLambda = new LiveCharts.WinForms.PieChart();
            this.lblPlayerPro = new System.Windows.Forms.Label();
            this.lblPlayerLambda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pChartPro
            // 
            this.pChartPro.Location = new System.Drawing.Point(14, 28);
            this.pChartPro.Name = "pChartPro";
            this.pChartPro.Size = new System.Drawing.Size(227, 194);
            this.pChartPro.TabIndex = 0;
            this.pChartPro.Text = "pieChart1";
            // 
            // caChart
            // 
            this.caChart.Location = new System.Drawing.Point(247, 28);
            this.caChart.Name = "caChart";
            this.caChart.Size = new System.Drawing.Size(498, 194);
            this.caChart.TabIndex = 1;
            this.caChart.Text = "cartesianChart1";
            // 
            // pChartPlayerLambda
            // 
            this.pChartPlayerLambda.Location = new System.Drawing.Point(760, 28);
            this.pChartPlayerLambda.Name = "pChartPlayerLambda";
            this.pChartPlayerLambda.Size = new System.Drawing.Size(227, 194);
            this.pChartPlayerLambda.TabIndex = 2;
            this.pChartPlayerLambda.Text = "pieChart1";
            // 
            // lblPlayerPro
            // 
            this.lblPlayerPro.AutoSize = true;
            this.lblPlayerPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPro.Location = new System.Drawing.Point(86, 12);
            this.lblPlayerPro.Name = "lblPlayerPro";
            this.lblPlayerPro.Size = new System.Drawing.Size(83, 16);
            this.lblPlayerPro.TabIndex = 3;
            this.lblPlayerPro.Text = "Joueur Pro";
            // 
            // lblPlayerLambda
            // 
            this.lblPlayerLambda.AutoSize = true;
            this.lblPlayerLambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLambda.Location = new System.Drawing.Point(778, 12);
            this.lblPlayerLambda.Name = "lblPlayerLambda";
            this.lblPlayerLambda.Size = new System.Drawing.Size(190, 16);
            this.lblPlayerLambda.TabIndex = 4;
            this.lblPlayerLambda.Text = "Moyenne Joueurs Lambda";
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 234);
            this.Controls.Add(this.lblPlayerLambda);
            this.Controls.Add(this.lblPlayerPro);
            this.Controls.Add(this.pChartPlayerLambda);
            this.Controls.Add(this.caChart);
            this.Controls.Add(this.pChartPro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmData";
            this.Text = "Données";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmData_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.PieChart pChartPro;
        private LiveCharts.WinForms.CartesianChart caChart;
        private LiveCharts.WinForms.PieChart pChartPlayerLambda;
        private System.Windows.Forms.Label lblPlayerPro;
        private System.Windows.Forms.Label lblPlayerLambda;
    }
}