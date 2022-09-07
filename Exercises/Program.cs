namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 4

            string messageLimit = "Enter the speed limit!";
            Console.WriteLine(messageLimit);
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            string messageSpeed = "Enter the car speed!";
            Console.WriteLine(messageSpeed);
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            int failurePoints = 0;

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok, You are driving safe!");
            }  
            else if (carSpeed > speedLimit) {

                int speedDifference = carSpeed - speedLimit;

                for (int i = 5; i <= speedDifference;  i+= 1)
                {
                    if (i % 5 == 0)
                    {
                        failurePoints++;
                    }
                }
            }
            
            Console.WriteLine("You have " + failurePoints + " failure points added");

            if (failurePoints >= 12)
            {
                Console.WriteLine("Your License is suspended!");
            }

        }
    }
}


/*  Exercise 1

Console.WriteLine("Enter a number between 1 and 10");

int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 10)
{
    Console.WriteLine("Valid");

} else
{
    Console.WriteLine("Invalid");
}

-------------------------------------------  
*/


// Exercise 2

//Console.WriteLine("Please enter a number between 1 and 10");

//int number = Convert.ToInt32(Console.ReadLine());

//if (number >= 1 && number <= 10)
//{
//    Console.Write("Your number is valid");
//}
//else if (number !>= 1 && number !<= 10)
//{
//    Console.Write("Enter a number that's valid");
//}

//----------------------------------------------------------

// Exercise 3

//Console.WriteLine("Enter the width and height of your image");

//int width = Convert.ToInt32(Console.ReadLine());
//int height = Convert.ToInt32(Console.ReadLine());

//if (width > height)
//{
//    Console.WriteLine("It's an landscape");
//} else
//{
//    Console.WriteLine("It's an portrait");
//}
//--------------------------------------------------------