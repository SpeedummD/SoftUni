namespace _04_InchesToCm
{
    internal class InchesToCm
    {
        static void Main(string[] args)
        {
            double cm = double.Parse(Console.ReadLine());
            var inch = cm * 2.54;
            Console.WriteLine(inch);
        }
    }
}
