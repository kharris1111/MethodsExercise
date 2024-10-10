namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib();
        }
        public static void MadLib()
        {
           Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello,{userName}! What is your favorite animal");
            string favAnimal  = Console.ReadLine();
            Console.WriteLine(" What is your favorite color");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite band"); 
                string favBand = Console.ReadLine();

            Console.WriteLine($"On {userName} birthday, she decided to wear a {favColor} dress to see {favBand}. After the concert {userName} boyfriend gifted her a {favAnimal}. Best birthday ever!");
        }
    }

}
