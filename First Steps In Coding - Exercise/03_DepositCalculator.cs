namespace _03_DepositCalculator
{
    internal class DepositCalculator
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            var totalSum = deposit + months * ((deposit * interest / 100) / 12);

            Console.WriteLine(totalSum);
        }
    }
}
