using System;

namespace RandomSentenceGenerator
{
    internal class RandomSentenceGenerator
    {
        static void Main(string[] args)
        {
            //lists of data for sentences; names is read-only!
            Console.WriteLine("Hello, welcome to random sentence generator!");
            Console.WriteLine();
            Console.WriteLine("Please, enter places, verbs, nouns, adverbs and details. Names are already entered!");
            string[] names = { "Peter", "Michell", "Jane", "Steve", "Mary", "Clayton", "Justin", "Rebecca" };
            string[] places = Console.ReadLine().Split(", ").ToArray();
            string[] verbs = Console.ReadLine().Split(", ").ToArray();
            string[] nouns = Console.ReadLine().Split(", ").ToArray();
            string[] adverbs = Console.ReadLine().Split(", ").ToArray();
            string[] details = Console.ReadLine().Split(", ").ToArray();
            Separator();
            
            Console.WriteLine("Please, enter a name or type \"Exit\" to stop the generator!:");
            string inputName;
            while ((inputName = Console.ReadLine()) != "Exit")
            {
                if (!names.Contains(inputName))
                {
                    Console.WriteLine($"{inputName} is missing!");
                    Separator();
                    continue;
                }
                string place = GetRandomWord(places);
                string personLocation = $"{inputName} from {place}";
                Console.WriteLine($"Let's see what {personLocation} is the doing.");
                Console.WriteLine("Press any key to continue...");
                string command;
                while ((command = Console.ReadLine()) != "Enough!")
                {
                    //random sentence logic
                    string verb = GetRandomWord(verbs);
                    string noun = GetRandomWord(nouns);
                    string adverb = GetRandomWord(adverbs);
                    string detail = GetRandomWord(details);
                    List<string> sentence = new(){ inputName, "form", place, adverb, verb, noun, detail};
                    string output = string.Join(' ', sentence);
                    Console.WriteLine(output+".");
                    
                    //controls
                    Console.WriteLine();
                    Console.WriteLine($"Press any key to see what {inputName} is doing next.");
                    Console.WriteLine("Type \"Enough!\" to move on to another person.");
                }
                Separator();
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
        
        //separator method
        static void Separator()
        {
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}