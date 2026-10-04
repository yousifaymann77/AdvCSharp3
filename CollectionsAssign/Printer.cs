using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsAssign
{
    internal class Printer
    {
        public static void PrintCollection<T>(String name , IEnumerable<T> collection)
        {
            Console.WriteLine($"{name}: {string.Join(", ", collection)}");
        }
    }
}
