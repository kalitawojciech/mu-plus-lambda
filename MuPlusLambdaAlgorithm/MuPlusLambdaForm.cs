using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MuPlusLambdaAlgorithm
{
    public partial class MuPlusLambdaForm : Form
    {
        private List<Individual> _parentalPopulation = new List<Individual>();
        private List<Individual> _offspringPopulation; // populacja potomna
        private int _mu;
        private int _lambda;
        private int _iterationsCount;
        private int _tournamentSize;
        public double _mutationLevel;

        public MuPlusLambdaForm(int mu, int lambda, int iterationsCount, int tournamentSize, double mutationLevel)
        {
            InitializeComponent();
            _mu = mu;
            _lambda = lambda;
            _iterationsCount = iterationsCount;
            _tournamentSize = tournamentSize;
            _mutationLevel = mutationLevel;
        }

        public void MuPlusLambdaAlghoritm()
        {
            _parentalPopulation = PopulationHelper.DrawPopulation(_mu);
            ClearChart();
            CreateChart();
            DrawParentsOnChart();

            for (int iteration = 0; iteration < _iterationsCount; iteration++)
            {
                _offspringPopulation = new List<Individual>();
            }
        }

        public void CreateChart()
        {
            muPlusLambdaChart.ChartAreas.Add(new ChartArea(Name = "muPlusLambda"));

            Legend legend = new Legend();
            legend.Name = "Legend";
            muPlusLambdaChart.Legends.Add(legend);
        }

        public void DrawParentsOnChart()
        {
            Series serieOfParents = new Series
            {
                Name = $"Parents",
                ChartType = SeriesChartType.Point,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10
            };

            for (int i = 0; i < _mu; i++)
            {
                serieOfParents.Points.AddXY(_parentalPopulation[i].X1, _parentalPopulation[i].X2); 
            }

            muPlusLambdaChart.Series.Add(serieOfParents);
        }

        public void ClearChart()
        {
            muPlusLambdaChart.Series.Clear();
            muPlusLambdaChart.Legends.Clear();
        }



    }
}
