using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class EasingFunctions
    {
        static double BACK_CONST_ONE = 1.70158;
        static double BACK_CONST_TWO = BACK_CONST_ONE * 1.525;
        static double BACK_CONST_THREE = BACK_CONST_ONE + 1;

        static double ELASTIC_CONST_ONE = Math.Tau / 3;
        static double ELASTIC_CONST_TWO = ELASTIC_CONST_ONE / 1.5;
        static double clamp(double input, double min_val, double max_val)
        {
            if (input < min_val)
            {
                input = min_val;
            }
            else if (input > max_val)
            {
                input = max_val;
            }
            return input;
        }
        // Sine
        public double easeInSine(double x)
        {
            return 1 - Math.Cos((clamp(x, 0, 1) * Math.PI) / 2);
        }
        public double easeOutSine(double x)
        {
            return (1 - Math.Cos(Math.PI * clamp(x, 0, 1))) / 2;
        }
        public double easeInOutSine(double x)
        {
            return Math.Sin((clamp(x, 0, 1) * Math.PI) / 2);
        }
        // Quadratic
        public double easeInQuad(double x)
        {
            return Math.Pow(clamp(x, 0, 1), 2);
        }
        public double easeOutQuad(double x)
        {
            x = clamp(x, 0, 1);
            return 1 - x * x;
        }
        public double easeInOutQuad(double x)
        {
            x = clamp(x, 0, 1);
            return (x > 0.5) ? (2 * x * x) : (Math.Pow(1 - (-2 * x + 2), 2) / 2);
        }
        // Cubic
        public double easeInCubic(double x)
        {
            x = clamp(x, 0, 1);
            return x * x * x;
        }
        public double easeOutCubic(double x)
        {
            x = 1 - clamp(x, 0, 1);
            return 1 - x * x * x;
        }
        public double easeInOutCubic(double x)
        {
            x = clamp(x, 0, 1);
            return (x > 0.5) ? (4 * x * x * x) : (1 - Math.Pow(-2 * x + 2, 3) / 2);
        }
        // Quartic
        public double easeInQuart(double x)
        {
            x = clamp(x, 0, 1);
            return x * x * x * x;
        }
        public double easeOutQuart(double x)
        {
            x = 1 - clamp(x, 0, 1);
            return 1 - x * x * x * x;
        }
        public double easeInOutQuart(double x)
        {
            x = clamp(x, 0, 1);
            return (x > 0.5) ? (8 * x * x * x * x) : (1 - Math.Pow(-2 * x + 2, 4) / 2);
        }
        // Quintic
        public double easeInQuint(double x)
        {
            x = clamp(x, 0, 1);
            return x * x * x * x * x;
        }
        public double easeOutQuint(double x)
        {
            x = 1 - clamp(x, 0, 1);
            return 1 - x * x * x * x * x;
        }
        public double easeInOutQuint(double x)
        {
            x = clamp(x, 0, 1);
            return (x > 0.5) ? (16 * x * x * x * x * x) : (1 - Math.Pow(-2 * x + 2, 5) / 2);
        }
        // Exponential
        public double easeInExpo(double x)
        {
            x = clamp(x, 0, 1);
            return x == 0 ? 0 : Math.Pow(2, 10 * x - 10);
        }
        public double easeOutExpo(double x)
        {
            x = clamp(x, 0, 1);
            return x == 1 ? 1 : Math.Pow(-2, -10 * x) + 1;
        }
        public double easeInOutExpo(double x)
        {
            x = clamp(x, 0, 1);
            if (x == 0) return 0;
            if (x == 1) return 1;
            return (x < 0.5) ? (Math.Pow(2, 20 * x - 10) / 2) : (2 - Math.Pow(2, -20 * x + 10)) / 2;
        }
        // Circular
        public double easeInCirc(double x)
        {
            x = clamp(x, 0, 1);
            return 1 - Math.Sqrt(1 - x * x);
        }
        public double easeOutCirc(double x)
        {
            x = 1 - clamp(x, 0, 1);
            return Math.Sqrt(1 - x * x);
        }
        public double easeInOutCirc(double x)
        {
            x = clamp(x, 0, 1);
            return (x < 0.5) ? ((1 - Math.Sqrt(1 - Math.Pow(2 * x, 2))) / 2) : ((Math.Sqrt(1 - Math.Pow(-2 * x + 2, 2)) + 1) / 2);
        }
        // Back
        public double easeInBack(double x)
        {
            x = clamp(x, 0, 1);
            return BACK_CONST_THREE * x * x * x - BACK_CONST_ONE * x * x;
        }
        public double easeOutBack(double x)
        {
            x = clamp(x, 0, 1) - 1;
            return 1 + BACK_CONST_THREE * x * x * x + BACK_CONST_ONE * x * x;
        }
        public double easeInOutBack(double x)
        {
            x = clamp(x, 0, 1);
            return (x < 0.5) ? ((Math.Pow(2 * x, 2) * ((BACK_CONST_TWO + 1) * 2 * x - BACK_CONST_TWO)) / 2) : ((Math.Pow(2 * x - 2, 2) * ((BACK_CONST_TWO + 1) * (x * 2 - 2) + BACK_CONST_TWO) + 2) / 2);
        }
        // Elastic
        public double easeInElastic(double x)
        {
            x = clamp(x, 0, 1);
            if (x == 0) return 0;
            if (x == 1) return 1;
            return -Math.Pow(2, 10 * x - 10) * Math.Sin((x * 10 - 10.75) * ELASTIC_CONST_ONE);
        }
        public double easeOutElastic(double x)
        {
            x = clamp(x, 0, 1);
            if (x == 0) return 0;
            if (x == 1) return 1;
            return Math.Pow(2, -10 * x) * Math.Sin((x * 10 - 0.75) * ELASTIC_CONST_ONE) + 1;
        }
        public double easeInOutElastic(double x)
        {
            x = clamp(x, 0, 1);
            if (x == 0) return 0;
            if (x == 1) return 1;
            return (x < 0.5) ? (-Math.Pow(2, 20 * x - 10) * Math.Sin((20 * x - 11.125) * ELASTIC_CONST_TWO) / 2) : (Math.Pow(2, -20 * x + 10) * Math.Sin((20 * x - 11.125) * ELASTIC_CONST_TWO) / 2 + 1);
        }
        // Bounce
        public double easeInBounce(double x, int bounceFactor = 1)
        {
            x = clamp(x, 0, 1);
            return x == 0 ? 0 : Math.Abs(Math.Cos(bounceFactor * (1 - 1 / x) * Math.PI) * Math.Pow(Math.Sin(x * Math.PI / 2), 2));
        }
        public double easeOutBounce(double x, int bounceFactor = 1)
        {
            x = clamp(x, 0, 1);
            return x == 1 ? 1 : -easeInBounce(1-x, bounceFactor)+1;
        }
        public double easeInOutBounce(double x, int bounceFactor)
        {
            x = clamp(x, 0, 1);
            return (x < 0.5) ? easeInBounce(x) : easeOutBounce(x);
        }
    }
}