namespace ConsoleApp1
{
    public class TweenInfo
    {
        public double Time = 1;
        public EasingStyle EasingStyle = EasingStyle.Quad;
        public EasingDirection EasingDirection = EasingDirection.Out;
        public bool Reverses = false;
        public double DelayTime = 0;

        public TweenInfo(double time, EasingStyle easingStyle, EasingDirection easingDirection, bool reverses, double delayTime)
        {
            Time = time;
            EasingStyle = easingStyle;
            EasingDirection = easingDirection;
            Reverses = reverses;
            DelayTime = delayTime;
        }
    }
}
