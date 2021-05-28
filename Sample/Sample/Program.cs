using System;

namespace Sample
{
    class Program
    {
        static void Prompt(ref string nameField, ref string ageField,
            ref string locationField)
        {
            // Get user name 
            Console.Write("What is your first name? -> ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? -> ");
            string lastName = Console.ReadLine();

            // Concatinate full name
            nameField = string.Concat(firstName, lastName);

            // Get user age
            Console.Write("How old are you? -> ");
            // Convert string to int of 16 bits
            ageField = Console.ReadLine();

            // Get location of origin
            Console.Write("What state are you from? -> ");
            locationField = Console.ReadLine();
            Console.WriteLine();
        }

        static void survey1(string[] responsesField, string nameField,
            string ageField, string locationField)
        {
            // Survey Output
            Console.WriteLine(responsesField[0] + nameField);
            Console.WriteLine(responsesField[1] + ageField);
            Console.WriteLine(responsesField[2] + locationField);
            return;
        }

        static void survey2(string[] responsesField, string nameField,
            string ageField, string locationField)
        {
            // Survey Output 2
            Console.WriteLine("{0}{1}", responsesField[0], nameField);
            Console.WriteLine("{0}{1}", responsesField[1], ageField);
            Console.WriteLine("{0}{1}", responsesField[2], locationField);
        }


        static void survey3(string[] responsesField, string nameField,
            string ageField, string locationField)
        {
            // Survey Output 3
            Console.WriteLine("{0}{1}\n{2}{3}\n{4}{5}", responsesField[0], nameField,
                responsesField[1], ageField, responsesField[2], locationField);
        }

        static void survey4(string[] result)
        {
            // Survey Output 4
            Console.WriteLine();
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);
        }

        static void Main(string[] args)
        {
            // Full name
            string name = string.Empty;

            // Get user age
            string age = string.Empty;

            // Get location of origin
            string location = string.Empty;

            Prompt(nameField: ref name, ageField: ref age,
                locationField: ref location);

            string[] responses = { "Name: ", "Age: ", "Location: " };
            ///survey1(responses, name, age, location);
            //survey2(responses, name, age, location);
            //survey3(responses, name, age, location);

            string[] result = new string[3];
            result[0] = $"{responses[0]}{name}";
            result[1] = $"{responses[1]}{age}";
            result[2] = $"{responses[2]}{location}";
            survey4(result: result);

            if (location.ToLower() == "texas" || location.ToLower() == "tx")
            {
                Console.WriteLine("*Computer points gun at head*");
                Console.Write("Dallas Cowboys or Houston Texans?: ");
                string lifeDecicion = Console.ReadLine();
                if (lifeDecicion.ToLower() == "dallas cowboys" ||
                    lifeDecicion.ToLower() == "cowboys")
                {
                    Console.WriteLine("*Computer Shoots Gun*\nBang!!\n" +
                        "Don't blame me for my programming.");
                }
                else
                {
                    Console.WriteLine("*Computer puts gun away*\n" +
                        "I'll be watching you!");
                }
            }
        }
    }
}
