
using System;                // Console
using System.IO;             // FileStream, FileReader

class FileDetails
{
    static void Main(string[] args)
    {
        Console.WriteLine("The length of array args is " + args.Length);

        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }

        string fileName = args[0];


        FileStream stream = new FileStream(fileName, FileMode.Open);
        StreamReader reader = new StreamReader(stream);

        int size = (int)stream.Length; // Length of file
        char[] contents = new char[size];

        for (int i = 0; i < size; i++)
        {
            contents[i] = (char)reader.Read();
        }

        foreach (char ch in contents)
        {
            Console.Write(ch);
        }

        reader.Close();

        Summarize(contents);
    }

    
    static void Summarize(char[] fileContents) 
    {   // Counters
        int consonant = 0, vowel = 0, lines = 0;
        
        foreach (char currentChar in fileContents)
        {
            if (Char.IsLetter(currentChar))
            {
                if ("AEIOUaeiou".IndexOf(currentChar) != -1)
                {
                    vowel++;
                }
                else
                {
                    consonant++;
                }
            }
            else if (currentChar == '\n')
            {
                lines++;
            }

        }

        Console.WriteLine("Total number of characters is: " + fileContents.Length);
        Console.WriteLine("Total number of vowels is: " + vowel);
        Console.WriteLine("Total number of consonants is: " + consonant);
        Console.WriteLine("Total number of lines is: " + lines);
    }
            
}
