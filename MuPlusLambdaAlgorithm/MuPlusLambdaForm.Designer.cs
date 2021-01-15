
namespace MuPlusLambdaAlgorithm
{
    partial class MuPlusLambdaForm
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
            this.muPlusLambdaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.muPlusLambdaChart)).BeginInit();
            this.SuspendLayout();
            // 
            // muPlusLambdaChart
            // 
            chartArea1.Name = "ChartArea1";
            this.muPlusLambdaChart.ChartAreas.Add(chartArea1);
            this.muPlusLambdaChart.Location = new System.Drawing.Point(0, 0);
            this.muPlusLambdaChart.Name = "muPlusLambdaChart";
            this.muPlusLambdaChart.Size = new System.Drawing.Size(778, 700);
            this.muPlusLambdaChart.TabIndex = 0;
            this.muPlusLambdaChart.Text = "Chart";
            // 
            // MuPlusLambdaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 753);
            this.Controls.Add(this.muPlusLambdaChart);
            this.Name = "MuPlusLambdaForm";
            this.Text = "MuPlusLambda";
            ((System.ComponentModel.ISupportInitialize)(this.muPlusLambdaChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart muPlusLambdaChart;
    }
}