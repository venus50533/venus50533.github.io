namespace TA_2
{
    internal static class MyTmpeConvert
    {
        public static double ConventToC(double temperature)
        {
            return (temperature - 32) * 5.0 / 9.0;
        }
        public static double ConventToF(double temperature)
        {
            return temperature * 9.0 / 5.0 + 32;
        }
    }
}