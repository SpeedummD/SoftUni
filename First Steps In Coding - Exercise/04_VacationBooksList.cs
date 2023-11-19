namespace _04_VacationBooksList
{
    internal class VacationBooksList
    {
        static void Main(string[] args)
        {
            int totalPages = int.Parse(Console.ReadLine());
            int hourPages = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            var neededHours = (totalPages / hourPages) / days;

            Console.WriteLine(neededHours);
        }

    }
}
