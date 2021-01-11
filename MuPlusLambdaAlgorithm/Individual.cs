using System;

namespace MuPlusLambdaAlgorithm
{
    public class Individual : IComparable
    {
        public double X1 { get; set; }

        public double X2 { get; set; }

        public Individual(double X1, double X2)
        {
            this.X1 = X1;
            this.X2 = X2;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Individual otherIndividual = obj as Individual;

            if (otherIndividual.X1 == this.X1)
            {
                return this.X2.CompareTo(otherIndividual.X2);
            }

            return this.X1.CompareTo(otherIndividual.X1);
        }
    }
}
