using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string asciiArt = 
          @" 
             __       __                     _____                                                    __ 
            /  \     /  |                   /     |                                                  /  |
            $$  \   /$$ | __    __          $$$$$ |  ______   __    __   ______   _______    ______  $$ |
            $$$  \ /$$$ |/  |  /  |            $$ | /      \ /  |  /  | /      \ /       \  /      \ $$ |
            $$$$  /$$$$ |$$ |  $$ |       __   $$ |/$$$$$$  |$$ |  $$ |/$$$$$$  |$$$$$$$  | $$$$$$  |$$ |
            $$ $$ $$/$$ |$$ |  $$ |      /  |  $$ |$$ |  $$ |$$ |  $$ |$$ |  $$/ $$ |  $$ | /    $$ |$$ |
            $$ |$$$/ $$ |$$ \__$$ |      $$ \__$$ |$$ \__$$ |$$ \__$$ |$$ |      $$ |  $$ |/$$$$$$$ |$$ |
            $$ | $/  $$ |$$    $$ |      $$    $$/ $$    $$/ $$    $$/ $$ |      $$ |  $$ |$$    $$ |$$ |
            $$/      $$/  $$$$$$$ |       $$$$$$/   $$$$$$/   $$$$$$/  $$/       $$/   $$/  $$$$$$$/ $$/ 
                         /  \__$$ |                                                                      
                         $$    $$/                           by Jorge Ajhuacho Arevalo | CSE 210         
                          $$$$$$/                                                                        ";
        Console.WriteLine(asciiArt);
        Thread.Sleep(4000);
        Console.Clear();

        Journal journal = new Journal();
        string choice = "";
        while (choice != "5"){
            Console.WriteLine(@"Please select one of the following choices:
                            1. Write
                            2. Display
                            3. Save file
                            4. Load file
                            5. Quit");
            Console.WriteLine("Write the number of choice (i.e. 1)");
            choice = Console.ReadLine();

            switch (choice){
                case "1":
                    PromptGenerator newprompt = new PromptGenerator();
                    string dateToday = DateTime.Now.ToString("MM/dd/yyyy");
                    Entry newEntry = new Entry();
                    newEntry._date = dateToday;
                    newEntry._promptText = newprompt.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);
                    Console.Write(">");
                    newEntry._entryText = Console.ReadLine();
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.WriteLine("What is the file name?: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;

                case "4":
                    Console.WriteLine("What is the filename?:");
                    string ReadfileName = Console.ReadLine();
                    journal.ReadFile(ReadfileName);
                    break;
        }
        }

        
    }
}