﻿using System.Windows.Forms;

namespace MuPlusLambdaAlgorithm
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private async void startAlghoritmButton_Click(object sender, System.EventArgs e)
        {
            MuPlusLambdaForm muPlusLambdaForm 
                = new MuPlusLambdaForm(
                    (int)this.muNumericInput.Value,
                    (int)this.lambdaNumericInput.Value,
                    (int)this.iterationsCountNumericInput.Value,
                    (int)this.tournamentSizeNumericInput.Value,
                    (int)this.mutationLevelNumericInput.Value
                    );
            muPlusLambdaForm.Show();
            await muPlusLambdaForm.MuPlusLambdaAlghoritm();
        }
    }
}
