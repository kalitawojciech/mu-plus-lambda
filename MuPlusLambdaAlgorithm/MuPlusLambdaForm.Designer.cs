
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
            this.theBestResultLabel = new System.Windows.Forms.Label();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.theBestResultValueLabel = new System.Windows.Forms.Label();
            this.iterationValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.muPlusLambdaChart)).BeginInit();
            this.SuspendLayout();
            // 
            // muPlusLambdaChart
            // 
            chartArea1.Name = "ChartArea1";
            this.muPlusLambdaChart.ChartAreas.Add(chartArea1);
            this.muPlusLambdaChart.Location = new System.Drawing.Point(0, 0);
            this.muPlusLambdaChart.Name = "muPlusLambdaChart";
            this.muPlusLambdaChart.Size = new System.Drawing.Size(875, 700);
            this.muPlusLambdaChart.TabIndex = 0;
            this.muPlusLambdaChart.Text = "Chart";
            // 
            // theBestResultLabel
            // 
            this.theBestResultLabel.AutoSize = true;
            this.theBestResultLabel.Location = new System.Drawing.Point(881, 18);
            this.theBestResultLabel.Name = "theBestResultLabel";
            this.theBestResultLabel.Size = new System.Drawing.Size(103, 17);
            this.theBestResultLabel.TabIndex = 1;
            this.theBestResultLabel.Text = "The best result";
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Location = new System.Drawing.Point(881, 51);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(59, 17);
            this.iterationLabel.TabIndex = 2;
            this.iterationLabel.Text = "Iteration";
            // 
            // theBestResultValueLabel
            // 
            this.theBestResultValueLabel.AutoSize = true;
            this.theBestResultValueLabel.Location = new System.Drawing.Point(1000, 18);
            this.theBestResultValueLabel.Name = "theBestResultValueLabel";
            this.theBestResultValueLabel.Size = new System.Drawing.Size(0, 17);
            this.theBestResultValueLabel.TabIndex = 3;
            // 
            // iterationValueLabel
            // 
            this.iterationValueLabel.AutoSize = true;
            this.iterationValueLabel.Location = new System.Drawing.Point(1000, 51);
            this.iterationValueLabel.Name = "iterationValueLabel";
            this.iterationValueLabel.Size = new System.Drawing.Size(0, 17);
            this.iterationValueLabel.TabIndex = 4;
            // 
            // MuPlusLambdaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 753);
            this.Controls.Add(this.iterationValueLabel);
            this.Controls.Add(this.theBestResultValueLabel);
            this.Controls.Add(this.iterationLabel);
            this.Controls.Add(this.theBestResultLabel);
            this.Controls.Add(this.muPlusLambdaChart);
            this.Name = "MuPlusLambdaForm";
            this.Text = "MuPlusLambda";
            ((System.ComponentModel.ISupportInitialize)(this.muPlusLambdaChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart muPlusLambdaChart;
        private System.Windows.Forms.Label theBestResultLabel;
        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.Label theBestResultValueLabel;
        private System.Windows.Forms.Label iterationValueLabel;
    }
}