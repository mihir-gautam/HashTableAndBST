using System;

namespace HashTableProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hash Table Data structure practice problem.");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            hash.GetFrequency("be");

            //UC2 frequency of word in a paragraph
            MyMapNode<string, string> hash2 = new MyMapNode<string, string>(19);
            hash2.Add("0", "Paranoid");
            hash2.Add("1", "are");
            hash2.Add("2", "not");
            hash2.Add("3", "paranoid");
            hash2.Add("4", "beacuse");
            hash2.Add("5", "they");
            hash2.Add("6", "are");
            hash2.Add("7", "paranoid");
            hash2.Add("8", "but");
            hash2.Add("9", "because");
            hash2.Add("10", "they");
            hash2.Add("11", "keep");
            hash2.Add("12", "putting");
            hash2.Add("13", "themselves");
            hash2.Add("14", "deliberately");
            hash2.Add("15", "into");
            hash2.Add("16", "paranoid");
            hash2.Add("17", "avoidable");
            hash2.Add("18", "situations");
            hash2.GetFrequency("paranoid");
            Console.ReadKey();
        }
    }
}
