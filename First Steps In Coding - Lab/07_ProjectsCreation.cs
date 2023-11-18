namespace _07_ProjectsCreation
{
    internal class ProjectsCreation
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var projects = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {name} will need {projects * 3} hours to complete {projects} project/s.");
        }
    }
}
