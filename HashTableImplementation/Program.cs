using System;

namespace HashTableImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program!");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "into");
            hash.Add("15", "paranoid");
            hash.Add("16", "avoidable");
            hash.Add("17", "situation");

            string result6 = hash.Get("6");
            Console.WriteLine("Value at 6th index : " + result6);

            string result2 = hash.Get("2");
            Console.WriteLine("Value at 2th index : " + result2);

            string result16 = hash.Get("16");
            Console.WriteLine("Value at 16th index : " + result16);

            hash.Remove("16");
        }
    }
}
