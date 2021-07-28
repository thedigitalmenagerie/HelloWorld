using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            var greetings = new string[] { "Howdy", "How ya been", "How's your mama" };
            Console.WriteLine("Please enter numbers 1, 2, or 3 to get a greeting");
            string number = Console.ReadLine();
            if (number == "1")
              {
                Console.WriteLine($"{greetings[0]}, {name}");
              }
            if (number == "2")
              {
                Console.WriteLine($"{greetings[1]}, {name}");
              }
            if (number == "3")
              {
                Console.WriteLine($"{greetings[2]}, {name}");
              }
            
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                if (animal.Length <= 5 )
                Console.WriteLine($"This animal has five or fewer characters: {animal}");
            }
            Console.WriteLine("Please enter your favorite color");
            string favoriteColor = Console.ReadLine();
            Random pickRandom = new Random();
            int index = pickRandom.Next(animals.Length);
            Console.WriteLine($"Would you like a {favoriteColor} {animals[index]}?");
        }
    }
}
