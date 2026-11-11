using System.Security.Cryptography.X509Certificates;

public class Entry
(
    Public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date; {-date} - Prompt: {_promptText}");

        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
)