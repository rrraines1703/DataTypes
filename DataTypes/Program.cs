using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("What term would you like to search for in the following sentence? " + sentence);

            string term = Console.ReadLine();

            if (sentence.ToLower().Contains(term.ToLower()) == true)
            {
                Console.WriteLine($"{term} found! It starts at index {sentence.IndexOf(term)} and is {term.Length} characters long.");
                string edit = sentence.Remove(sentence.IndexOf(term), term.Length);
                Console.WriteLine($"Edited sentence with selected term removed: {edit}");
            }
            else
            {
                Console.WriteLine($"{term} not found!");
            }
        }
    }
}
