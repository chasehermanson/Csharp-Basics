using System;

namespace CsharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lost, expensive;
            expensive = true;
            lost = true;
            double deposits, distance;
            distance = 129.763001;
            deposits = 135002796;
            int heartRate, choice;
            choice = 2;
            heartRate = 85;
            string greetings, name;
            name = "Karen";
            greetings = "Hello";
            const byte sample1 = 0x3A;
            const float acceleration = 9.800f;
            const char integral = '\u222B';
            float mass = 14.6f;
            byte sample2 = 58;

            if (sample2 == sample1)
           
            {

                Console.WriteLine("The Samples Are Equal. ");

            }

            else

            {

                Console.WriteLine("The Samples are Not equal. ");

            }

            if (heartRate > 40 && heartRate < 80)

            {

                Console.WriteLine("Heart Rate Is Normal. ");

            }

            else

            {

                Console.WriteLine("Heart Rate Is Not Normal. ");

            }

            if (deposits >= 100000000)
            {
                Console.WriteLine("Your Are Exceedingly Wealthy. ");
            }
            else 
            {
                Console.WriteLine("Sorry You Are So Poor. ");
            }

            float force = mass * acceleration;
            Console.WriteLine("Force = {0}", force);

            Console.WriteLine("{0} is the distance", distance);

            if (lost == true && expensive == true)

            {
                Console.WriteLine("I Am Really Sorry! I will Get The Manager. ");
            }
            if (lost == true && expensive == false)
            {
                Console.WriteLine("Here Is Coupon For 10% Off. ");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You Chose 1. ");
                    break;

                case 2:
                    Console.WriteLine("You Chose 2. ");
                    break;

                case 3:
                    Console.WriteLine("You Chose 3. ");
                    break;

                default:
                    Console.WriteLine("You Made An Unknown Choice. ");
                    break;
            }

            Console.WriteLine("{0} is an integral.", integral);

            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine("i = {0}", i);
            }

            int age = 0;
            while (age <= 6)
            {
                Console.WriteLine("age = {0}", age);
                age++;
            }

            Console.WriteLine("{0} {1}", greetings, name);

            Console.ReadLine();
        }
    }
}
