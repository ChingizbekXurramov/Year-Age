namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your Birth (year/month/day): ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());

                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - birthDate.Year;

                if (birthDate > currentDate.AddYears(-age))
                {
                    age--;
                }

                Console.WriteLine($"You are {age} years old");

                TimeSpan span = currentDate - birthDate;
                Console.WriteLine($"Your date of birth: {birthDate.Day:D2}/{birthDate.Month:D2}/{birthDate.Year} and" +
                    $" {span.TotalDays:N0} days have passed since that day");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please put dates between >> / <<");
                Main(args);
            }
        }
    }
}