namespace _08_PetShop
{
    internal class PetShop
    {
        static void Main(string[] args)
        {
            var dogFood = int.Parse(Console.ReadLine()) * 2.5;
            var catFood = int.Parse(Console.ReadLine()) * 4.0;

            Console.WriteLine($"{dogFood + catFood} lv.");
        }
    }
}
