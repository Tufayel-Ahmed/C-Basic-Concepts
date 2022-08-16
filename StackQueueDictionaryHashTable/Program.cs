using System;
using System.Collections;

namespace StackQueueDictionaryHashTable
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("-----Stack-----");
            Stack stack = new Stack();
            Console.WriteLine("Push Data:");    
            stack.Push(121);
            stack.Push("Hello");
            stack.Push(121.23);
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine("After pop:");
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            
            
            Console.WriteLine("-----Queue-----");
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("Enqueue Data: ");
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Dequeue: {queue.Dequeue()}");
            Console.WriteLine("After dequeue:");
            foreach(var i in queue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            
            Console.WriteLine("-----Dictionary-----");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Console.WriteLine("Add data:");
            dictionary.Add(1, "Tufayel Ahmed");
            dictionary.Add(2, "Abul Kalam Azad");
            dictionary.Add(3, "Selim Reza");
            foreach (var i in dictionary)
            {
                Console.Write($"{i.Key}:\t");
                Console.Write(i.Value);
                Console.WriteLine();
            }
            if (dictionary.TryGetValue(1, out string value)){
                Console.WriteLine("Found data");
            }
            Console.WriteLine();
            
            
            Console.WriteLine("-----Hash table-----");
            Hashtable hashtable = new Hashtable();
            Console.WriteLine("Add data:");
            hashtable.Add(1, "One");
            hashtable.Add("2", 2);
            hashtable.Add(3, 33.3);
            hashtable["2"] = "Two";
            foreach (var i in hashtable.Values)
            {
                Console.WriteLine(i);
            }
            if (hashtable.Contains("2"))
            {
                Console.WriteLine("Found data");
            }
        }
    }
}
