using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    
    class MyDictionary<K, T>
    {
        K[] keyArray;
        T[] valueArray;

        public MyDictionary()
        {
            keyArray = new K[0];
            valueArray = new T[0];
        }
        public void Add(K key, T value)
        {
            K[] tempKey = keyArray;
            T[] tempValue = valueArray;

            keyArray = new K[keyArray.Length + 1];
            valueArray = new T[valueArray.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keyArray[i] = tempKey[i];
                valueArray[i] = tempValue[i];
            }

            keyArray[keyArray.Length - 1] = key;
            valueArray[valueArray.Length - 1] = value;
            
        }

    }



}

