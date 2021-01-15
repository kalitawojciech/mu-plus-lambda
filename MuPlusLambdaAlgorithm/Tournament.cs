using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Individual offspringParent = tournamentWinners.OrderByDescending(x => x.F).FirstOrDefault();

            int mutationChange = random.Next(-mutationLevel, mutationLevel);
            float x1, x2;

            if(offspringParent.X1 + mutationChange < 0 )  // mutationChange value is less than 0
            {
                x1 = offspringParent.X1 - mutationChange;
            }
            else if(offspringParent.X1 + mutationChange > 100) // mutationChange value is greater than 0
            {
                x1 = offspringParent.X1 - mutationChange;
            }
            else
            {
                x1 = offspringParent.X1 + mutationChange;
            }

            if (offspringParent.X2 + mutationChange < 0)  // mutationChange value is less than 0
            {
                x2 = offspringParent.X2 - mutationChange;
            }
            else if (offspringParent.X2 + mutationChange > 100) // mutationChange value is greater than 0
            {
                x2 = offspringParent.X2 - mutationChange;
            }
            else
            {
                x2 = offspringParent.X2 + mutationChange;
            }

            return new Individual(x1, x2);
        }
    }
}
