using System;
using System.Collections.Generic;
using System.Linq;

namespace MuPlusLambdaAlgorithm
{
    public static class Tournament
    {
        public static Individual GetOffspring(List<Individual> parentalPopulation, int tournamentSize, int mutationLevel)
        {
            if(tournamentSize > parentalPopulation.Count())
            {
                throw new Exception();
            }

            HashSet<int> winnersIndexes = new HashSet<int>();
            Random random = new Random();
            while(winnersIndexes.Count() != tournamentSize)
            {
                winnersIndexes.Add(random.Next(parentalPopulation.Count()));
            }

            List<Individual> tournamentWinners = new List<Individual>();

            foreach(int index in winnersIndexes)
            {
                tournamentWinners.Add(parentalPopulation[index]);
            }

            Individual offspringParent;

            if (tournamentSize > 1 && Helper.Possibility() > 70)
            {
                offspringParent = tournamentWinners.OrderByDescending(x => x.F).Skip(1).FirstOrDefault();
            }
            else
            {
                offspringParent = tournamentWinners.OrderByDescending(x => x.F).FirstOrDefault();
            }

            int mutationChangeX1 = random.Next(-mutationLevel, mutationLevel);
            int mutationChangeX2 = random.Next(-mutationLevel, mutationLevel);
            float x1, x2;

            x1 = CalculateNewParameterValue(offspringParent.X1, mutationChangeX1);
            x2 = CalculateNewParameterValue(offspringParent.X2, mutationChangeX2);

            return new Individual(x1, x2);
        }

        private static float CalculateNewParameterValue(float oldParameterValue, int mutationChange)
        {
            if (oldParameterValue + mutationChange < 0)  // mutationChange value is less than 0
            {
                return oldParameterValue - mutationChange;
            }
            else if (oldParameterValue + mutationChange > 100) // mutationChange value is greater than 0
            {
                return oldParameterValue - mutationChange;
            }

            return oldParameterValue + mutationChange;
        }
    }
}
