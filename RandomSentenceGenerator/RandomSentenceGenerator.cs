using System;

namespace RandomSentenceGenerator
{
    internal class RandomSentenceGenerator
    {
        static void Main(string[] args)
        {
            /*
             To create our sentences we are going to need: names, places, verbs, nouns, adverbs and details.
             The sentence that we will create is based on the following model:
               •	One sentence needs [Who from where] [Action] [Detail] to be created.
               o	"Who from where" example: [Name + from + Place] ("David from London").
               o	"Action" example: [Adverb] + [Verb] + [Noun] ("calmly watched the sunset").
               o	"Detail" example: "near the river", "at home", "in the park".
                         */
            string[] names = { "Peter", "Michell", "Jane", "Steve" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings"};
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park" };
            Console.WriteLine("Hello, this is your first random-generated sentence!");
            while (true)
            {
                string name = GetRandomWord(names);
                string place = GetRandomWord(places);
                string verb = GetRandomWord(verbs);
                string noun = GetRandomWord(nouns);
                string adverb = GetRandomWord(adverbs);
                string detail = GetRandomWord(details);
                List<string> sentence = new(){ name, "form", place, adverb, verb, noun, detail};
                string output = string.Join(' ', sentence);
                Console.WriteLine(output+".");
                Console.WriteLine("Click [Enter] to generate a new one.");
                string control;
                if ((control = Console.ReadLine()) != "")
                {
                    break;
                }
            }
        }
        
        // random word finder method
        static string GetRandomWord(string[] words)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(words.Length);
            string randomWord = words[randomIndex];
            return randomWord;
        }
    }
}