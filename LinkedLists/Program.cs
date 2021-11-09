using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    /// <summary>
    /// Tests the linked lists
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests the linked lists
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            //TestUnsortedLinkedList.RunTestCases();
            //TestSortedLinkedList.RunTestCases();

            UnsortedLinkedList<int> lista = new UnsortedLinkedList<int>();
            lista.Add(100);
            lista.Add(200);
            lista.Add(300);
            // lista.Remove(200);
            // Console.WriteLine(lista);
            lista.LinkedListPrint();

            Console.ReadKey();
        }
    }
}
