﻿using System.Windows.Forms;

namespace MuPlusLambdaAlgorithm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void startAlghoritmButton_Click(object sender, System.EventArgs e)
        {
            MuPlusLambdaForm muPlusLambdaForm = new MuPlusLambdaForm((int)this.muNumericInput.Value, (int)this.lambdaNumericInput.Value);
            muPlusLambdaForm.Show();
            muPlusLambdaForm.MuPlusLambdaAlghoritm();
        }
    }
}
