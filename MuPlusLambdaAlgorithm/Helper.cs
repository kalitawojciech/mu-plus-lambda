using System;

namespace MuPlusLambdaAlgorithm
{
    public static class Helper
    {
        public static double F(Individual individual)
        {
            var result = Math.Sin(individual.X1 * 0.05d)
                + Math.Sin(individual.X2 * 0.05d)
                + 0.4d * Math.Sin(individual.X1 * 0.15d) * Math.Sin(individual.X2 * 0.15d);

            return result;
        }

        public static double F(double x1, double x2)
        {
            var result = Math.Sin(x1 * 0.05d)
                + Math.Sin(x2 * 0.05d)
                + 0.4d * Math.Sin(x1 * 0.15d) * Math.Sin(x2 * 0.15d);

            return result;
        }
    }
}
