using System;
public class Program
{
    public static void Main()
    {
        int mode;
        Console.WriteLine("Please select a mode:");
        Console.WriteLine("1. Encryption");
        Console.WriteLine("2. Decryption");
        string modeString = Console.ReadLine();
        mode = int.Parse(modeString);
        if (mode==1)
        {
            Encrypt();
            Decrypt();
        }
        else if (mode == 2)
        {
            Decrypt();
        }

    }
    public  static void Encrypt()
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string key = "qwertyuiopasdfghjklzxcvbnm3124960857QWERTYUIOPASDFGHJKLZXCVBNM";

        Console.WriteLine("Enter a text to encrypt:");
        string input = Console.ReadLine();
        string output = "";
        for (int i=0;i<input.Length;i++)
        {
            int index = alphabet.IndexOf(input[i]);
            if(index!=-1)
                output += key[index];
            
            else
                output += input[i];
        }
        Console.WriteLine("Your encrypted text is:");
        Console.WriteLine(output);
    }
    public static void Decrypt()
    {
        string alphabet = "qwertyuiopasdfghjklzxcvbnm3124960857QWERTYUIOPASDFGHJKLZXCVBNM";
        string key = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        Console.WriteLine("Enter a text to decrypt:");
        string input = Console.ReadLine();
        string output = "";
        for (int i = 0; i < input.Length; i++)
        {
            int index = alphabet.IndexOf(input[i]);
            if (index != -1)
                output += key[index];

            else
                output += input[i];
        }
        Console.WriteLine("Your encrypted text is:");
        Console.WriteLine(output);
    }
}