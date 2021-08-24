using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V> //K -> keys, V -> values
    {
        K[] Keys;
        K[] tempKeys; //temp diziler, asıl dizileri yeniden boyutlandırdığımızda verileri saklıyor.

        V[] Values;
        V[] tempValues;

        private bool kontrol;

        public int Count { get { return Keys.Length; } } //Anahtar ve değer sayıları aynı olduğu için bu yeterli.

        public MyDictionary()
        {
            Keys = new K[0];
            Values = new V[0];
        }

        public void Add(K key, V value) //Ekleme metodu
        {
            tempKeys = Keys;
            tempValues = Values;

            foreach (var item in Keys)
            {
                if (item.Equals(key)) //Anahtarlar aynı olamaz. Bu yüzden kontrolünü yaptım.
                {
                    kontrol = true;
                    break;
                }
                else
                {
                    kontrol = false;
                }
            }

            if (kontrol == false)
            {
                Keys = new K[Keys.Length + 1];
                Values = new V[Keys.Length + 1];

                for (int i = 0; i < tempKeys.Length; i++)
                {
                    Keys[i] = tempKeys[i];
                    Values[i] = tempValues[i];
                }

                Keys[Keys.Length - 1] = key;
                Values[Keys.Length - 1] = value;
            }

        }
    }
}
