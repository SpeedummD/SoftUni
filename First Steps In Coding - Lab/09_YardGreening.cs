namespace _09_YardGreening
{
    internal class YardGreening
    {
        static void Main(string[] args)
        {
            var sqrM = double.Parse(Console.ReadLine());
            var finalPrice = sqrM * 7.61;
            var discountedPrice = finalPrice * 0.82;
            var discount = finalPrice - discountedPrice;

            Console.WriteLine($"The final price is: {discountedPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
