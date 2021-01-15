using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MuPlusLambdaAlgorithm
{
    public partial class MuPlusLambdaForm : Form
    {
        private List<Individual> _parentalPopulation = new List<Individual>();
        private List<Individual> _offspringPopulation = new List<Individual>();
        private List<Individual> _wholePopulation;
        private int _mu;
        private int _lambda;
        private int _iterationsCount;
        private int _tournamentSize;
        public int _mutationLevel;

        public MuPlusLambdaForm(int mu, int lambda, int iterationsCount, int tournamentSize, int mutationLevel)
        {
            InitializeComponent();
            _mu = mu;
            _lambda = lambda;
            _iterationsCount = iterationsCount;
            _tournamentSize = tournamentSize;
            _mutationLevel = mutationLevel;
        }

        public async Task MuPlusLambdaAlghoritm()
        {
            _parentalPopulation = PopulationHelper.DrawPopulation(_mu);
            ClearChart();
            CreateChart();
            DrawParentsOnChart();

            await Task.Delay(2000);

            for (int iteration = 0; iteration < _iterationsCount; iteration++)
            {
                this.iterationValueLabel.Text = (iteration + 1).ToString();

                _wholePopulation = _parentalPopulation.ToList();

                while(_offspringPopulation.Count() < _lambda)
                {
                    Individual offspring = Tournament.GetOffspring(_parentalPopulation, _tournamentSize, _mutationLevel);
                    if(!CheckIfNewOffspringIsNotUnique(offspring))
                    {
                        _wholePopulation.Add(offspring);
                        _offspringPopulation.Add(offspring);
                    }
                }

                _parentalPopulation.Clear();
                _parentalPopulation = PopulationHelper.GetNewParentalPopulation(_wholePopulation, _mu);
                this.theBestResultValueLabel.Text = (PopulationHelper.GetIndividualWithTheHighestF(_parentalPopulation).F).ToString();

                ClearChart();
                CreateChart();
                DrawParentsOnChart();
                DrawOffspringPopulationOnChart();

                await Task.Delay(2000);

                _offspringPopulation.Clear();
                _wholePopulation.Clear();

            }
        }

        public void CreateChart()
        {
            muPlusLambdaChart.ChartAreas.Add(new ChartArea(Name = "muPlusLambda"));

            var area = muPlusLambdaChart.ChartAreas[0];
            area.Position.X = 0;
            area.Position.Y = 0;
            area.Position.Height = 100;
            area.Position.Width = 80;
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = 100;
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 100;

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
                MarkerSize = 10,
            };

            for (int i = 0; i < _mu; i++)
            {
                serieOfParents.Points.AddXY(_parentalPopulation[i].X1, _parentalPopulation[i].X2); 
            }

            muPlusLambdaChart.Series.Add(serieOfParents);
        }


        public void DrawOffspringPopulationOnChart()
        {
            Series serieOfOffspringPopulation = new Series
            {
                Name = $"Offspring",
                ChartType = SeriesChartType.Point,
                MarkerStyle = MarkerStyle.Star6,
                MarkerSize = 10,
            };

            for (int i = 0; i < _mu; i++)
            {
                serieOfOffspringPopulation.Points.AddXY(_offspringPopulation[i].X1, _offspringPopulation[i].X2);
            }

            muPlusLambdaChart.Series.Add(serieOfOffspringPopulation);
        }

        public void ClearChart()
        {
            muPlusLambdaChart.Series.Clear();
            muPlusLambdaChart.Legends.Clear();
            muPlusLambdaChart.ChartAreas.Clear();
        }

        private bool CheckIfNewOffspringIsNotUnique(Individual individual)
        {
            return PopulationHelper.CheckIfPopulationContainsIndividual(_parentalPopulation, individual)
                || PopulationHelper.CheckIfPopulationContainsIndividual(_offspringPopulation, individual);
        }



    }
}
