using System;
using System.Collections;

namespace BasicPart09_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable product = new Hashtable();
            product.Add("P001","IPHONE");
            product.Add("P002","SAMSUNG");
            product.Add("P003","OPPO");

            foreach (string id in product.Keys)
            {
                Console.WriteLine(id);
            }

            /*foreach (string name in product.Values)
            {
                Console.WriteLine(name);
            }*/


            Console.ReadKey();
        }
    }
}
