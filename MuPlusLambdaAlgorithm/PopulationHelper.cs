using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuPlusLambdaAlgorithm
{
    public static class PopulationHelper
    {
        public static List<Individual> DrawPopulation(int populationSize)
        {
            Random rnd = new Random();
            double X1, X2;
            HashSet<Individual> population = new HashSet<Individual>();

            while (population.Count() <= populationSize)
            {
                X1 = rnd.NextDouble() * 100;
                X2 = rnd.NextDouble() * 100;

                population.Add(new Individual(X1, X2));
            }

            return population.ToList();
        }
    }
}
