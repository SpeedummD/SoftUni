namespace _01_USDtoBGN
{
    internal class USDtoBGN
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;
            Console.WriteLine(bgn);
        }
    }
}
