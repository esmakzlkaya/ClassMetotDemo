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

            
        }
    }

    class MyDictionary<TKey,TValue>
    {
        (TKey, TValue)[] keyValuePairs;
        public MyDictionary()
        {
            keyValuePairs = new (TKey, TValue)[0];
        }

        public void Add(TKey key, TValue value)
        {
            (TKey, TValue)[] tempDict = keyValuePairs;
            keyValuePairs = new (TKey, TValue)[keyValuePairs.Length + 1];
            for (int i = 0; i < tempDict.Length; i++)
            {
                keyValuePairs[i] = tempDict[i];
            }
            keyValuePairs[keyValuePairs.Length - 1] = (key, value);

            Console.WriteLine(keyValuePairs[keyValuePairs.Length-1]+" eklendi.");
        }
    }
}
