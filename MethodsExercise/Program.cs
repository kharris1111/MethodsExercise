namespace MethodsExercise
{
    public class Program
    {
       
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
        static void Main(string[] args)
        {
            //MadLib();
            //Console.WriteLine(Add(4, 4));
            // Console.WriteLine(Subtract(4, 4));
            //Console.WriteLine(Multiply(3, 3));
            //Console.WriteLine(Divide(3, 3));
            Console.WriteLine(Sum(6, 6, 6));
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public static int Subtract( int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        public static int Multiply(int numOne, int numTwo)
        {
            return  numOne * numTwo;
        }
        public static int Divide(int numOne, int numTwo)
        { 
            return (numOne / numTwo);
        }
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }

}

