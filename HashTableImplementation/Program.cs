using System;

namespace HashTableImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program!");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            string result5 = hash.Get("5");
            Console.WriteLine("Value at 5th index : " + result5);
        }
    }
}
