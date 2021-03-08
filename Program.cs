using System;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list = new LinkedList(10);
            list.InsertAt1(7, "seven");
            list.Insert("one");
            list.Insert("two");
            list.Insert("three");
            list.Insert("four");

            //Console.WriteLine($"{list.ReadAt(7)}");
            list.PrintReverse();
            
        }
    }
}
