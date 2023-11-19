namespace _05_SuppliesForSchool
{
    internal class SuppliesForSchool
    {
        static void Main(string[] args)
        {
            var pens = int.Parse(Console.ReadLine()) * 5.8;
            var markers = int.Parse(Console.ReadLine()) * 7.2;
            var cleaningChem = int.Parse(Console.ReadLine()) * 1.2;
            var discount = double.Parse(Console.ReadLine());

            var totalSum = pens + markers + cleaningChem ;

            Console.WriteLine(totalSum * (1 - discount / 100));



        }
    }
}
