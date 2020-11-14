using System;

namespace Lesson2
{
    public class WeightCalculator
    {
        public const double NORMAL_BODY_MASS_INDEX_MIN = 18.5;
        public const double NORMAL_BODY_MASS_INDEX_MAX = 25;
        
        public double CalculateBodyMassIndex(int weight, int height)
        {
            return weight / (Math.Pow(height, 2) / 10000);;
        }

        public NormalWeight CalculateNormalWeight(int height)
        {
            double squaredHeight = Math.Pow(height, 2) / 10000;

            int minWeight = (int) Math.Round(squaredHeight * NORMAL_BODY_MASS_INDEX_MIN);
            int maxWeight = (int) Math.Round(squaredHeight * NORMAL_BODY_MASS_INDEX_MAX);
            return new NormalWeight(minWeight, maxWeight);
        }
    }
}