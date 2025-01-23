using System.IO;

public class Journal{
    public List<Entry> _entries;

    //METOD TO ADD THE VALUES FROM THE USER TO THE LIST
    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }

    //METOD TO DISPLAY THE ITENS FROM THE LIST TO THE TERMINAL
    //IT WORKS LIKE A 'SAVE' WHILE THE PROGRAM IS RUNNING, AND CAN BE USED TO SAVE THE INFORMATION IN A FILE
    public void DisplayAll(){
        foreach(Entry entry in _entries){
            entry.Display();
        }
    }

    //METOD TO SAVE THE INFORMATION FROM THE LIST IN A FILE
    public void SaveToFile(string file){
        using(StreamWriter savingFile = new StreamWriter(file)){
            foreach(Entry entry in _entries){
                savingFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

    //METOD TO LOAD INFORMATION FROM A FILE TO BE DISPLAYIED TO THE TERMINAR OR TO ADD NEW LINES
    public void LoadFromFile(string file){
        

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach(string line in lines){
            Entry textEntry = new Entry();

            //SEPARETE EACH LINE WHEN IT HAVE A COMMA
            //IT DO NOT HANDLE WITH TEXTS WITH COMMA YET
            string[] parts = line.Split(",");

            //SET THE VALUES TO ADD IN THE LIST FROM THE FILE CHOSEN BY THE USER
            textEntry._date = parts[0];
            textEntry._promptText = parts[1];
            textEntry._entryText = parts[2];

            //ADD THE VALUES TO THE LIST TO BE DISPLAYIED OR ADD NEW INFORMATION
            _entries.Add(textEntry);
        }
    }
}