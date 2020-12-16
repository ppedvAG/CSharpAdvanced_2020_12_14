using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Verwenden von Genric Klassen aus  .NET 
            IList<string> strList = new List<string>();
            strList.Add("eins");
            strList.Add("zwei");

            IDictionary<Guid, string> dict = new Dictionary<Guid, string>();
            dict.Add(Guid.NewGuid(), "Das ist ein Text");
            #endregion

            #region DataStore

            DataStore<string> store = new DataStore<string>();
            store.AddOrUpdate(0, "Mumbai");
            store.AddOrUpdate(1, "London");
            store.AddOrUpdate(2, "Madrid");

            string currentCity = store.GetData(2); //Madrid wird ausgelesen

            if (!string.IsNullOrEmpty(currentCity))
            {
                //Mach was mit dem String
            }



            DataStore<int?> intStore = new DataStore<int?>();
            intStore.AddOrUpdate(1, 12);
            intStore.AddOrUpdate(2, 32);
            intStore.AddOrUpdate(3, 54);
            intStore.AddOrUpdate(4, 33);
            intStore.AddOrUpdate(5, 63);

            int? value = intStore.GetData(1);

            if(value.HasValue)
            {
                //MAch etwas mit dem integer
            }

            store.DisplayDefaultOf<int>();
            store.DisplayDefaultOf2<int?>();

            #endregion

        }
    }

    public class DataStore<T>
    {
        public T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }

        public void DisplayDefaultOf2<TT>() //Generische Methode
        {
            TT item = default(TT);
            Console.WriteLine($"Default value of {typeof(TT)} is {(item == null ? "null" : item.ToString())}.");
        }

        public void DisplayDefaultOf<TT>()
        {
            var val = default(TT);
            Console.WriteLine($"Default value of {typeof(TT)} is {(val == null ? "null" : val.ToString())}.");
        }
    }
}
