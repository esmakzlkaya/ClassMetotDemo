using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryProject
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] _keys;
        TValue[] _values;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = _keys;
            TValue[] tempValues = _values;

            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];


            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];
            }

            for (int j = 0; j < tempKeys.Length; j++)
            {
                if (key==null)
                {
                    throw new ArgumentNullException();
                }
                else if (tempKeys[j].Equals(key))
                {
                    throw new ArgumentException("The key element already exists in keys");
                }
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

            Console.WriteLine(_keys[_keys.Length - 1] + " " + _values[_values.Length - 1]);
        }
    }
}
