using System;

namespace MuPlusLambdaAlgorithm
{
    public class Individual : IComparable
    {
        public float X1 { get; set; }

        public float X2 { get; set; }

        public float F { get; set; }

        public Individual(float x1, float x2)
        {
            this.X1 = x1;
            this.X2 = x2;
            F = Helper.F(x1, x2);
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
