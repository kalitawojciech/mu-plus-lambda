
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
            this.iterationsCountLabel = new System.Windows.Forms.Label();
            this.iterationsCountNumericInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tournamentSizeNumericInput = new System.Windows.Forms.NumericUpDown();
            this.mutationLevelNumericInput = new System.Windows.Forms.NumericUpDown();
            this.mutationLevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.muNumericInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaNumericInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsCountNumericInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentSizeNumericInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationLevelNumericInput)).BeginInit();
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
            this.lambdaLabel.Location = new System.Drawing.Point(7, 56);
            this.lambdaLabel.Name = "lambdaLabel";
            this.lambdaLabel.Size = new System.Drawing.Size(54, 17);
            this.lambdaLabel.TabIndex = 1;
            this.lambdaLabel.Text = "lambda";
            // 
            // muNumericInput
            // 
            this.muNumericInput.Location = new System.Drawing.Point(129, 16);
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
            this.lambdaNumericInput.Location = new System.Drawing.Point(129, 54);
            this.lambdaNumericInput.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lambdaNumericInput.Name = "lambdaNumericInput";
            this.lambdaNumericInput.Size = new System.Drawing.Size(120, 22);
            this.lambdaNumericInput.TabIndex = 3;
            this.lambdaNumericInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // startAlghoritmButton
            // 
            this.startAlghoritmButton.Location = new System.Drawing.Point(10, 210);
            this.startAlghoritmButton.Name = "startAlghoritmButton";
            this.startAlghoritmButton.Size = new System.Drawing.Size(239, 78);
            this.startAlghoritmButton.TabIndex = 4;
            this.startAlghoritmButton.Text = "Start";
            this.startAlghoritmButton.UseVisualStyleBackColor = true;
            this.startAlghoritmButton.Click += new System.EventHandler(this.startAlghoritmButton_Click);
            // 
            // iterationsCountLabel
            // 
            this.iterationsCountLabel.AutoSize = true;
            this.iterationsCountLabel.Location = new System.Drawing.Point(7, 172);
            this.iterationsCountLabel.Name = "iterationsCountLabel";
            this.iterationsCountLabel.Size = new System.Drawing.Size(105, 17);
            this.iterationsCountLabel.TabIndex = 5;
            this.iterationsCountLabel.Text = "iterations count";
            // 
            // iterationsCountNumericInput
            // 
            this.iterationsCountNumericInput.Location = new System.Drawing.Point(129, 170);
            this.iterationsCountNumericInput.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.iterationsCountNumericInput.Name = "iterationsCountNumericInput";
            this.iterationsCountNumericInput.Size = new System.Drawing.Size(120, 22);
            this.iterationsCountNumericInput.TabIndex = 6;
            this.iterationsCountNumericInput.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "tournament size";
            // 
            // tournamentSizeNumericInput
            // 
            this.tournamentSizeNumericInput.Location = new System.Drawing.Point(129, 129);
            this.tournamentSizeNumericInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tournamentSizeNumericInput.Name = "tournamentSizeNumericInput";
            this.tournamentSizeNumericInput.Size = new System.Drawing.Size(120, 22);
            this.tournamentSizeNumericInput.TabIndex = 8;
            this.tournamentSizeNumericInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // mutationLevelNumericInput
            // 
            this.mutationLevelNumericInput.Location = new System.Drawing.Point(129, 91);
            this.mutationLevelNumericInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mutationLevelNumericInput.Name = "mutationLevelNumericInput";
            this.mutationLevelNumericInput.Size = new System.Drawing.Size(120, 22);
            this.mutationLevelNumericInput.TabIndex = 9;
            this.mutationLevelNumericInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // mutationLevelLabel
            // 
            this.mutationLevelLabel.AutoSize = true;
            this.mutationLevelLabel.Location = new System.Drawing.Point(7, 96);
            this.mutationLevelLabel.Name = "mutationLevelLabel";
            this.mutationLevelLabel.Size = new System.Drawing.Size(95, 17);
            this.mutationLevelLabel.TabIndex = 10;
            this.mutationLevelLabel.Text = "mutation level";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 297);
            this.Controls.Add(this.mutationLevelLabel);
            this.Controls.Add(this.mutationLevelNumericInput);
            this.Controls.Add(this.tournamentSizeNumericInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iterationsCountNumericInput);
            this.Controls.Add(this.iterationsCountLabel);
            this.Controls.Add(this.startAlghoritmButton);
            this.Controls.Add(this.lambdaNumericInput);
            this.Controls.Add(this.muNumericInput);
            this.Controls.Add(this.lambdaLabel);
            this.Controls.Add(this.muLabel);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.muNumericInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaNumericInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsCountNumericInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentSizeNumericInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationLevelNumericInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label muLabel;
        private System.Windows.Forms.Label lambdaLabel;
        private System.Windows.Forms.NumericUpDown muNumericInput;
        private System.Windows.Forms.NumericUpDown lambdaNumericInput;
        private System.Windows.Forms.Button startAlghoritmButton;
        private System.Windows.Forms.Label iterationsCountLabel;
        private System.Windows.Forms.NumericUpDown iterationsCountNumericInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tournamentSizeNumericInput;
        private System.Windows.Forms.NumericUpDown mutationLevelNumericInput;
        private System.Windows.Forms.Label mutationLevelLabel;
    }
}

