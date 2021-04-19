using System;

namespace Exercise2._3
    {
    class Program
        {
        static void Main(string[] args)
            {
            bool checker = true;
            string text;
            while (checker)
                {
                text = textInput();
                var array = letterSifter(text);
                Console.WriteLine($"The number of vowels is {array.Item1}, The number of consonants is {array.Item2}, The phrase without the vowels is {array.Item3}");
                checker = ContinueEntry();

                }
            Console.WriteLine("Thank you, Goodbye!");
            }

        public static string textInput ()
            {
            string text;
            Console.Write("Enter some text: ");
            text = Console.ReadLine();
            text = textChecker(text);
            return text;
            }
        public static string textChecker (string text)
            {
            string newText = "";
            string invalidText = "";
            foreach (char letter in text.ToCharArray())
                {
                if (Char.IsLetter(letter))
                    {
                    newText += letter;
                    }
                else
                    {
                    invalidText += letter;
                    }
                }
            Console.WriteLine($"Invalid text is {invalidText}");
            return newText;
            }

        static bool ContinueEntry()
            {
            string text;
            while (true)
                {
                Console.Write("Would you like to continue? (Y/N)?: ");
                text = Console.ReadLine().Trim().ToLower();

                switch (text)
                    {
                    case "y":
                    case "yes":
                        return true;
                        break;

                    case "n":
                    case "no":
                        return false;
                        break;

                    default:
                        Console.WriteLine("Invalid Entry.");
                        break;
                    }
                }
            }

            public static (int, int, string) letterSifter (string text)
            {
            int vowelCount = 0;
            int consonantCount = 0;
            string consonantless = "";
            string vowels = "aeiou";
            foreach(char letter in text.ToLower().ToCharArray())
                {
                if (vowels.Contains(letter))
                    {
                    vowelCount++;               //exercise 26
                    }
                else
                    {
                    consonantCount++;           //exercise 27
                    consonantless += letter;    //exercise 28
                    }
                }

            return (vowelCount, consonantCount, consonantless);
            }
        }
    }
