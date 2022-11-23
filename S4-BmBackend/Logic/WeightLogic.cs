namespace S4_BmBackend.Logic
{
    public class WeightLogic
    {
        public double CalculatePercentage(double mass, double var)
        {
            double percentage = Math.Round(var / mass * 100, 1);
            return percentage;
        }
    }
}
