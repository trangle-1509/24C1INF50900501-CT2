﻿internal class Program
{
    private static void Main(string[] args)
    {
        //baitap_1(); 
        //baitap_2(); 
        //baitap_3(); 
        //baitap_4(); 
        //baitap_5(); 
        baitap_6();
    }
    static void baitap_1()
    {
        Console.Write("Input the string: ");
        string inputTheString = Console.ReadLine();
        Console.WriteLine("The string you entered is: " + inputTheString);
        Console.ReadLine();
    }
    static void baitap_2()
    {
        Console.Write("Input the string: ");
        string inputTheString = Console.ReadLine();
        //int length = inputTheString.Length;
        int length = 0;
        foreach (char c in inputTheString)
        {
            length++;
        }
        Console.WriteLine("Length of the string is: " + length);
        Console.ReadLine();
    }
    static void baitap_3()
    {
        Console.Write("Input the string: ");
        string inputTheString = Console.ReadLine();
        Console.Write("The characters of the string are: ");
        foreach (char c in inputTheString)
        {
            Console.Write(c + " ");
        }
        Console.ReadLine();
    }
    static void baitap_4()
    {
        Console.Write("Input the string: ");
        string inputTheString = Console.ReadLine();
        Console.Write("The characters of the string in reverse are: ");
        char[] charArray = inputTheString.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        foreach (char c in reversedString)
        {
            Console.Write(c + " ");
        }
        Console.ReadLine();
    }
    static void baitap_5()
    {
        Console.Write("Input the string: ");
        string inputTheString = Console.ReadLine();
        string[] words = inputTheString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int wordscount = 0;
        foreach (string word in words)
        {
            wordscount++;
        }
        Console.Write("Total number of words in string: " + wordscount);
        Console.ReadLine();
    }
    static void baitap_6()
    {
        Console.Write("Input the 1st string: ");
        string firstString = Console.ReadLine();
        Console.Write("Input the 2nd string: ");
        string secondString = Console.ReadLine();
        int length1 = 0;
        int length2 = 0;
        foreach (char c in firstString)
        {
            length1++;
        }
        foreach (char c in secondString)
        {
            length2++;
        }
        if (length1 == length2)
        {
            Console.WriteLine("The length of both strings are equal"
    
            bool Equal = true;

        }
    }
}
