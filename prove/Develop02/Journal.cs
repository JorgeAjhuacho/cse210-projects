using System;
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Journal{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        foreach (Entry entry in _entries){
            entry.Display();
        }
    }

    public void SaveToFile(string filename){
        using (StreamWriter outputfile = new StreamWriter(filename)){
            foreach (Entry entry in _entries){
                outputfile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved!");
    }

    public void ReadFile(string filename){
        _entries.Clear();

        try {
            using (StreamReader reader = new StreamReader(filename)){
                string line;
                while ((line = reader.ReadLine()) != null){
                    string [] components = line.Split("~");
                    Entry newEntryAdd = new Entry();
                    newEntryAdd._date = components[0];
                    newEntryAdd._promptText = components[1];
                    newEntryAdd._entryText = components[2];
                    _entries.Add(newEntryAdd);
                }
            }

            Console.WriteLine("File readed Successfully!");
        }
        catch (Exception ex){
            Console.WriteLine($"Error loading hournal: {ex.Message}");
        }

    }
}