using System;
using System.Data.SqlTypes;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.XPath;

class currencyConverter
{
    static void Main(string[] args)
    {
        Count start = new Count();
        start.TakeInput();
        start.CountWords();
        start.CountChar();
    }
}


class Count
{
    int? charCount;
    string? input = "";
    int? wordsCount = 0;
    public void TakeInput()
    {
        System.Console.Write("ketik apapun : ");
        input = Console.ReadLine(); 
    }
    public void CountWords()
    {
        string? [] words = input.Split(" ");
        wordsCount = words.Length;
        System.Console.WriteLine($"jumlah kata = {wordsCount}");
    }
    public void CountChar()
    {
        input = input.Replace(" ", "");
        charCount =  input.Length;
        System.Console.WriteLine($"jumlah huruf = {charCount}");
    }
}

