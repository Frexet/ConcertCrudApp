namespace Concert_CRUD_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcertManager.LoadFromFile();
            while (true)
            {
                Console.WriteLine("\nConcert Management System");
                Console.WriteLine("1. Add a new Concert.");
                Console.WriteLine("2 View all Concerts");
                Console.WriteLine("3. Edit a Concert.");
                Console.WriteLine("4. Delete a Concert.");
                Console.WriteLine("5. Save a Concert.");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ConcertManager.AddConcert();
                        break;
                    case "2":
                        ConcertManager.ListConcerts();
                        break;
                    case "3":
                        ConcertManager.EditConcert();
                        break;
                    case "4":
                        ConcertManager.DeleteConcert();
                        break;
                    case "5":
                        ConcertManager.SaveToFile();
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}