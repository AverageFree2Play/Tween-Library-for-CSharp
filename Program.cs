using ConsoleApp1;

namespace FirstConsoleApp{
    class Program
    {
        static void Main(string[] args)
        {
            TweenInfo tweenInfo = new TweenInfo(1, EasingStyle.Linear, EasingDirection.Out, false, 0);
            Console.WriteLine($"Time: {tweenInfo.Time}");
        }
    }
}