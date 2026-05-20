using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class EasingFunctions{
        static double clamp(double input, double min_val, double max_val){
            if (input < min_val) {
                input = min_val; }
            else if (input > max_val) {
                input = max_val;
            }
            return input;
        }        
        // Sine
        public double easeInSine(double x){
            return 1 - Math.Cos((clamp(x,0,1) * Math.PI) / 2);
        }
        public double easeOutSine(double x)
        {
            return (1 - Math.Cos(Math.PI * clamp(x,0,1))) / 2;
        }
        public double easeInOutSine(double x)
        {
            return Math.Sin((clamp(x,0,1) * Math.PI) / 2);
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
            return 1-x*x*x;
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
        public 
    }
}
