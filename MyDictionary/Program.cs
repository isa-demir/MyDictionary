using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> deneme = new Dictionary<int, string>();
            deneme.Add(13, "ahmet");

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "İsa");
            myDictionary.Add(2, "Ahmet");
            myDictionary.Add(3, "Yaren");
            myDictionary.Add(4, "Sena");


            Console.WriteLine(myDictionary.Count);


        }
    }
 }


