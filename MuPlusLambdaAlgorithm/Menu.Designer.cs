
namespace MuPlusLambdaAlgorithm
{
    partial class Menu
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
            this.muLabel = new System.Windows.Forms.Label();
            this.lambdaLabel = new System.Windows.Forms.Label();
            this.muNumericInput = new System.Windows.Forms.NumericUpDown();
            this.lambdaNumericInput = new System.Windows.Forms.NumericUpDown();
            this.startAlghoritmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.muNumericInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaNumericInput)).BeginInit();
            this.SuspendLayout();
            // 
            // muLabel
            // 
            this.muLabel.AutoSize = true;
            this.muLabel.Location = new System.Drawing.Point(7, 16);
            this.muLabel.Name = "muLabel";
            this.muLabel.Size = new System.Drawing.Size(27, 17);
            this.muLabel.TabIndex = 0;
            this.muLabel.Text = "mu";
            // 
            // lambdaLabel
            // 
            this.lambdaLabel.AutoSize = true;
            this.lambdaLabel.Location = new System.Drawing.Point(7, 54);
            this.lambdaLabel.Name = "lambdaLabel";
            this.lambdaLabel.Size = new System.Drawing.Size(54, 17);
            this.lambdaLabel.TabIndex = 1;
            this.lambdaLabel.Text = "lambda";
            // 
            // muNumericInput
            // 
            this.muNumericInput.Location = new System.Drawing.Point(91, 10);
            this.muNumericInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.muNumericInput.Name = "muNumericInput";
            this.muNumericInput.Size = new System.Drawing.Size(120, 22);
            this.muNumericInput.TabIndex = 2;
            this.muNumericInput.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lambdaNumericInput
            // 
            this.lambdaNumericInput.Location = new System.Drawing.Point(91, 54);
            this.lambdaNumericInput.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.lambdaNumericInput.Name = "lambdaNumericInput";
            this.lambdaNumericInput.Size = new System.Drawing.Size(120, 22);
            this.lambdaNumericInput.TabIndex = 3;
            this.lambdaNumericInput.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // startAlghoritmButton
            // 
            this.startAlghoritmButton.Location = new System.Drawing.Point(10, 101);
            this.startAlghoritmButton.Name = "startAlghoritmButton";
            this.startAlghoritmButton.Size = new System.Drawing.Size(201, 54);
            this.startAlghoritmButton.TabIndex = 4;
            this.startAlghoritmButton.Text = "Start";
            this.startAlghoritmButton.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 167);
            this.Controls.Add(this.startAlghoritmButton);
            this.Controls.Add(this.lambdaNumericInput);
            this.Controls.Add(this.muNumericInput);
            this.Controls.Add(this.lambdaLabel);
            this.Controls.Add(this.muLabel);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.muNumericInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaNumericInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label muLabel;
        private System.Windows.Forms.Label lambdaLabel;
        private System.Windows.Forms.NumericUpDown muNumericInput;
        private System.Windows.Forms.NumericUpDown lambdaNumericInput;
        private System.Windows.Forms.Button startAlghoritmButton;
    }
}

