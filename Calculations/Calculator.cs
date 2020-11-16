using System;

namespace Calculations
{
    public static class Calculator
    {
        public static double GetSumOne(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1d / i;
            }

            return sum;
        }

        public static double GetSumTwo(int n)
        {
            double sum = 0d;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1d, i + 1) / (i * (i + 1d));
            }

            return sum;
        }

        public static double GetSumThree(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1d / Math.Pow(i, 5);
            }

            return sum;
        }

        public static double GetSumFour(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1d / (((2d * i) + 1d) * ((2d * i) + 1d));
            }

            return sum;
        }

        public static double GetProductOne(int n)
        {
            double sum = 1d;

            for (double i = 1d; i <= n; i++)
            {
                sum *= 1d + (1d / (i * i));
            }

            return sum;
        }

        public static double GetSumFive(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1d, i) / ((2d * i) + 1d);
            }

            return sum;
        }

        public static double GetSumSix(int n)
        {
            double sum = 0;
            var f = 1d;
            var s = 0d;

            for (int i = 1; i <= n; i++)
            {
                f *= i;
                s += 1d / i;
                sum += f / s;
            }

            return sum;
        }

        public static double GetSumSeven(int n)
        {
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = Math.Sqrt(2 + sum);
            }

            return sum;
        }

        public static double GetSumEight(int n)
        {
            double sum = 0;
            double sin = 0;

            for (var i = 1d; i <= n; i++)
            {
                sin += Math.Sin(Math.PI * i / 180);
                sum += 1d / sin;
            }

            return sum;
        }
    }
}
