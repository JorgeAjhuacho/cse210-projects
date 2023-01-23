using System;
using System.IO;

class TextConverter
{
    
    public void GetAllPhrase(string reference, string sentence, bool conditional, List<string> list)
    {
        Console.Clear();
        string finalSentence = $"{reference} {sentence}";

        while (list.Any(a => !a.All(b => b =='-')) && conditional)
        {
            Random random = new Random();
            int index =random.Next(0, list.Count);
            string word = list[index];
            Console.Write("Please, press 'Enter' to continue or 'Exit' to quit: ");
            string answer = Console.ReadLine().ToLower();

            string WordChanged = "";

            for (int i=0; i < word.Length; i++)
            {
                WordChanged += "-";
            }

            list[index] = WordChanged;

            string FinalPhrase = "";
            for (int i=0; i<list.Count; i++){
                FinalPhrase += list[i].ToString() + " ";
            }
            string Print = $"{reference} {FinalPhrase}";

            if(answer != "exit")
            {
                Console.Clear();
                Console.WriteLine(FinalPhrase);
            }
            else{
                Console.WriteLine("");
            }
            if(answer == "exit"){
                conditional = false;
            }
        }
        
    }
}