using System;

namespace MuPlusLambdaAlgorithm
{
    public static class Helper
    {
        public static float F(Individual individual)
        {
            var result = Math.Sin(individual.X1 * 0.05f)
                + Math.Sin(individual.X2 * 0.05f)
                + 0.4f * Math.Sin(individual.X1 * 0.15f) * Math.Sin(individual.X2 * 0.15f);

            return (float)result;
        }

        public static float F(float x1, float x2)
        {
            var result = Math.Sin(x1 * 0.05f)
                + Math.Sin(x2 * 0.05f)
                + 0.4f * Math.Sin(x1 * 0.15f) * Math.Sin(x2 * 0.15f);

            return (float)result;
        }
    }
}
