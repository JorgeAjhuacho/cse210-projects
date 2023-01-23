using System;

class Program
{
    static void Main(string[] args)
    {   //Initialize the progam
        Console.Write("Welcome to Scripture Memorizer!\n\nPlease enter the book: ");
        string inputbook = Console.ReadLine();
        Console.Write("Enter the chapter: ");
        string inputchapter = Console.ReadLine();
        Console.Write("Please enter the number of the first verse: ");
        string firstNumVerse = Console.ReadLine();
        Console.Write("Please enter the number of the last verse: (If there is no more than 1 verse, write 'no'");
        string lastNumVerse = Console.ReadLine();
        Console.Write("Almost done!. \nPlease enter the scripture: ");
        string scripture = Console.ReadLine();

        //New Objects:
        Scripture BaseScripture = new(scripture);
        string baseScrip = BaseScripture.GetCompleteSentence();
        Reference reference = new(inputbook,inputchapter,firstNumVerse,lastNumVerse);
        string baseReference = reference.GetCompleteReference();

        Console.WriteLine(baseScrip);
        Console.WriteLine(baseReference);

    }


}