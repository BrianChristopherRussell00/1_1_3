using System.Diagnostics.CodeAnalysis;

namespace Assignment_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1_2_1
            Console.WriteLine("Give me a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Give me another number: ");

            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine(firstNumber + " and " + secondNumber + " are equal ");

            }
            else Console.WriteLine("They are not equal" + firstNumber + " is different from " + secondNumber);

            //1_2_2

            int sum = 0;


            Console.WriteLine("The first ten natural numbers are: ");

            for (int i = 0; i < 11; i++)
            {
                sum = sum + i;
                Console.Write("{0} ", i);
            }
            Console.Write("\nThe Sum is : {0}\n", sum);

        }
    }
}// Go to program cs for the last part of 1_2