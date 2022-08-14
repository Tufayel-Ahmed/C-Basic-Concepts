using System;
using System.Collections;
using System.Collections.Generic;

namespace ListArrayArrayList
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] array = new int[5];       

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            Console.WriteLine("Print array: ");
            foreach (var i in array)
            {
                Console.Write($"    {i}");
            }
            Console.WriteLine();
            Console.WriteLine();


            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);

            Console.WriteLine("Print array list: ");
            foreach (var i in arrayList)
            {
                Console.Write($"    {i}");
            }
            Console.WriteLine();
            Console.WriteLine();

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            Console.WriteLine("Print list: ");
            foreach (var i in list)
            {
                Console.Write($"    {i}");
            }

        }
    }
}

