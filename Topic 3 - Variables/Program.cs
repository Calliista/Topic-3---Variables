using System.Net.Http.Headers;

namespace Topic_3___Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, eyeColor, hairColor, courseName, myName;
            int age, height, weight, gradYear, roomNumber, radius;
            double price, pi;

            name = "John Smith";
            age = 35;     //not a lie
            height = 74;  //inches
            weight = 180; //lbs
            eyeColor = "Blue";
            hairColor = "Brown";

            myName = "Callista";
            courseName = "computer science";

            gradYear = 2028;
            radius = 5;
            roomNumber = 29;

            pi = 3.14159;
            price = 2.99;

            Console.WriteLine($"Let's talk about {name}.");
            Console.WriteLine($"He's {height} inches tall.");
            Console.WriteLine($"He's {weight} pounds heavy.");
            Console.WriteLine($"Actually, that's not too heavy.");
            Console.WriteLine($"His eyes are {eyeColor} and his hair is {hairColor}.");

            Console.WriteLine($"If I add {age}, {height}, and {weight} I get {age + height + weight}.");

            string name1 = "Jonathan";
            Console.WriteLine(name1);
            name1 = "Jon";
            Console.WriteLine(name1);

            int myNumber = 15;
            myNumber = 20;
            Console.WriteLine(myNumber);

            double height1 = 1.62;
            Console.WriteLine(height1);

            Console.WriteLine();

            //Assignment
            Console.WriteLine($"This is room {roomNumber}");
            Console.WriteLine($"The price is {price}");
            Console.WriteLine($"I am learning a bit about {courseName}");
            Console.WriteLine();
            Console.WriteLine($"My name is {myName} and I'll graduate in {gradYear}");
            Console.WriteLine();
        }
    }
}
