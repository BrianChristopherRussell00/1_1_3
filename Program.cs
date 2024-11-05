namespace _1_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decision;
            do
            {
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Apply four operations");
                Console.WriteLine("6. Average");
                Console.WriteLine("7. Exit Application");
                Console.WriteLine("Enter your choice");
                decision = Convert.ToInt32(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                        Console.WriteLine("Enter two numbers");
                        int numberEntered = Convert.ToInt32(Console.ReadLine());
                        int secondNumberEntered = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Addition of two numbers is " + Addition(numberEntered, secondNumberEntered));
                        break;
                    case 2:
                        Console.WriteLine("Enter two numbers");
                        int randomNumber = Convert.ToInt32(Console.ReadLine());
                        int secondRandNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Subtraction of two numbers is " + Subtraction(randomNumber, secondRandNumber));
                        break;
                    case 3:
                        Console.WriteLine("Enter two numbers");
                        int firstEntered = Convert.ToInt32(Console.ReadLine());
                        int secondEntered = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Multiplication of two numbers is " + Multiplication(firstEntered, secondEntered));
                        break;
                    case 4:
                        Console.WriteLine("Enter two numbers");
                        int dividedNum = Convert.ToInt32(Console.ReadLine());
                        int secondDividedNum = Convert.ToInt32(Console.ReadLine());
                        if (dividedNum == 0)
                        {
                            Console.WriteLine("Division: Cannot divide by zero.");
                            break;
                        }

                        Console.WriteLine("Division of two numbers is " + Division(dividedNum, secondDividedNum));

                        break;
                    case 5:
                        Console.WriteLine("Enter two numbers");
                        int exampleNumOne = Convert.ToInt32(Console.ReadLine());
                        int exampleNumTwo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Addition of two numbers is " + Addition(exampleNumOne, exampleNumTwo));
                        Console.WriteLine("Subtraction of two numbers is " + Subtraction(exampleNumOne, exampleNumTwo));
                        Console.WriteLine("Multiplication of two numbers is " + Multiplication(exampleNumOne, exampleNumTwo));
                        if (exampleNumOne == 0)
                        {
                            Console.WriteLine("Division: Cannot divide by zero.");
                            break;
                        }
                        Console.WriteLine("Division of two numbers is " + Division(exampleNumOne, exampleNumTwo));
                        break;
                    case 6:
                        Console.WriteLine("Enter three numbers");
                        int numberOne = Convert.ToInt32(Console.ReadLine());
                        int numberTwo = Convert.ToInt32(Console.ReadLine());
                        int numberThree = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Average of three numbers is " + Average(numberOne, numberTwo, numberThree));
                        break;
                    case 7:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (decision != 7);
        }
        static int Addition(int numberEntered, int secondNumberEntered)
        {
            return numberEntered + secondNumberEntered;
        }
        static int Subtraction(int randomNumber, int secondRandNumber)
        {
            return randomNumber - secondRandNumber;
        }
        static int Multiplication(int firstEntered, int secondEntered)
        {
            return firstEntered * secondEntered;
        }
        static int Division(int exampleNumOne, int exampleNumTwo)
        {
            return exampleNumOne / exampleNumTwo;
        }
        static int Average(int numberOne, int numberTwo, int numberThree)
        {
            return (numberOne + numberTwo + numberThree) / 3;
        }
    }
    }

