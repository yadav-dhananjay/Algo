using System;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Sorting t = new Sorting();

            int[] a = { 5, 7, 3, 2, 4, 0, 9, 6, 35 ,1};
            t.mergeSort(a);



            //LinkedList list = new LinkedList();
            //list.stringtoFloat();
            //list.ReverseAdd("12");
            //list.ReverseAdd("2");
            //list.ReverseAdd("33");
            //list.ReverseAdd("4");
            //list.ReverseAdd("56");
            //list.ReverseAdd("6");
            //list.ReverseAdd("76");
            //list.ReverseAdd("8");
            //list.ReverseAdd("9");

            //list.SortList2();
            //list.print();

            //list.DeleteNode("6");

            //list.print();

            //list.removeNode("6");

            //list.print();

            Console.ReadLine();
        }
    }
}