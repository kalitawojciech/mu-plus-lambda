using System;
using System.Collections.Generic;
using System.Linq;

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
                X1 = rnd.Next(0, 100);
                X2 = rnd.Next(0, 100);

                population.Add(new Individual((double)X1,(double) X2));
            }

            return population.ToList();
        }

        public static List<Individual> GetNewParentalPopulation(List<Individual> population, int mu)
        {
            return population.OrderBy(x => x.F).Take(mu).ToList();
        }

        public static bool CheckIfPopulationContainsIndividual(List<Individual> population, Individual individual)
        {
            foreach(Individual populationMember in population)
            {
                if(populationMember.X1 == individual.X1 && populationMember.X2 == individual.X2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
