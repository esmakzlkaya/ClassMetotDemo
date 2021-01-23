using System;
using System.Collections.Generic;

namespace MyDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Bir");
            myDictionary.Add( 2, "İki");
        }
    }
}
