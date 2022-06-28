using System;
using System.IO;

class program
{
    public static void EncryptAFile(string x)
    {
        File.Encrypt(x);

    }
    public static void DecryptAFile(string x)
    {
        File.Decrypt(x);

    }


    public static void ReadFile()
    {
        int counter = 0;
        string line;

        // read the file and display it line by line.
        System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Train 08\Desktop\C#.txt");
        while ((line = file.ReadLine()) != null)
            Console.WriteLine(line);
        counter++;

        file.Close();
    }
    static void Main()
    {
        ReadFile(); 
        Console.WriteLine("Press Enter the Encrypt the file ..");
        Console.ReadLine();

        EncryptAFile(@"C:\Users\Train 08\Desktop\C#.txt");

        Console.WriteLine("Press Enter the Decrypt the file ..");
        Console.ReadLine();
        DecryptAFile(@"C:\Users\Train 08\Desktop\C#.txt");


    }
}