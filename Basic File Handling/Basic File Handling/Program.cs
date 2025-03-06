using System;
using System.IO;

class FileExample
{
    static void Main()
    {
        string path = "testfile.txt";
        File.WriteAllText(path, "Hello, this is a test file!");
        Console.WriteLine("File written successfully!");

        string content = File.ReadAllText(path);
        Console.WriteLine("File content: " + content);
    }
}
