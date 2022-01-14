using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Counter();
             CountByThree();
             Equal();
             EvenOrOdd();
             Negititve();
             Vote();
             Range();
             MultTable();
        
        }
        public static void Counter()
        {
            var num = -1000;
            for (int i = num; i < 1001; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void CountByThree()
        {
            for (int i = 0; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        public static void Equal()
        {
            var num1 = 4;
            var num2 = 2;
            if (num1 == num2)
            {
                Console.WriteLine("they are equal");
            }
            else { Console.WriteLine("they are not equal"); }
        }
        public static void EvenOrOdd()
        {
            var num1 = 4;
            var num2 = 2;
            if (num1 % num2 == 0)
            { Console.WriteLine("Number is even"); }
            else { Console.WriteLine("Number is odd"); }
        }
        public static void Negititve()
        {
            var num1 = 4;
            if (num1 > 0)
            {
                Console.WriteLine("Your number is positive");
            }
            else { Console.WriteLine("Your number is negitive"); }
        }
        public static void Vote()
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You can't vote.");
            }
        }
        public static void Range()
        {
            Console.WriteLine("Pick a number");
            var userNum1 = int.Parse(Console.ReadLine());
            if (userNum1 > -10 && userNum1 < 10) { Console.WriteLine("you are in range"); }
            else { Console.WriteLine("Your'e not in range"); }
        }
        public static void MultTable()
        {
            Console.WriteLine("pick a number");
            var usernum2 = int.Parse(Console.ReadLine());
            Console.WriteLine(usernum2 * 1);
            Console.WriteLine(usernum2 * 2);
            Console.WriteLine(usernum2 * 3);
            Console.WriteLine(usernum2 * 4);
            Console.WriteLine(usernum2 * 5);
            Console.WriteLine(usernum2 * 6);
            Console.WriteLine(usernum2 * 7);
            Console.WriteLine(usernum2 * 8);
            Console.WriteLine(usernum2 * 9);
            Console.WriteLine(usernum2 * 10);
            Console.WriteLine(usernum2 * 11);
            Console.WriteLine(usernum2 * 12);
        }
        public static void BetterMult()
        {
            Console.WriteLine("pick a number");
            var usernum2 = int.Parse(Console.ReadLine());
            var i = 0;
            for (i = 0; i < 12; i++) ;
                { Console.WriteLine($"{usernum2} x {i} = (usernum2 * i)"); }
        }


        
        
    }
}
