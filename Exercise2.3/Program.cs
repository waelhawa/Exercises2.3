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
                text = TextInput();
                var array = LetterSifter(text);
                Console.WriteLine($"The number of vowels is\t\t\t\t{array.Item1}\nThe number of consonants is\t\t\t{array.Item2}\nThe phrase without the vowels is\t\t{array.Item3}");
                checker = ContinueEntry();

                }
            Console.WriteLine("Thank you, Goodbye!");
            }

        public static string TextInput ()
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
                if (Char.IsLetter(letter) || letter == ' ')
                    {
                    newText += letter;
                    }
                else
                    {
                    invalidText += letter;
                    }
                }
            if (!string.IsNullOrEmpty(invalidText))
            {
                Console.WriteLine($"Invalid text is\t\t\t\t\t{invalidText}");
            }
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
                        

                    case "n":
                    case "no":
                        return false;
                        

                    default:
                        Console.WriteLine("Invalid Entry.");
                        break;
                    }
                }
            }

            public static (int, int, string) LetterSifter (string text)
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
