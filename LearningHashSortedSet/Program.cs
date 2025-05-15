using System;
using System.IO;
using System.Collections.Generic;
using LearningHashSortedSet.Entities;

namespace LearningHashSortedSet{
    
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\in.txt";
            HashSet<Log> logSet = new HashSet<Log>();
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        logSet.Add(new Log(line));
                    }
                    Console.WriteLine("Total users: {0}", logSet.Count);
                }
            }
            catch (Exception e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }

        static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach (T item in collection) {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}