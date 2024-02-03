namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true);
            bool isAdult = false;
            Console.WriteLine(isAdult);
            if (isAdult)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
                bool hasLicense = true;
                if (isAdult && hasLicense)
                {
                    Console.WriteLine("You are an adult and have a license.");
                    
                }
                else
                {
                    Console.WriteLine("Conditions not met.");
                }
            }


        }
    }
}
