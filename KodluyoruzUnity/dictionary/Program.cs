using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10,"asude mor");
            kullanicilar.Add(11,"beyza mor");
            kullanicilar.Add(12,"furkan mor");
            kullanicilar.Add(13,"türkan mor");
            kullanicilar.Add(14,"hüseyin mor");

            //elemanlara erişim
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //count
            Console.WriteLine(kullanicilar.Count);

            //contains
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("asude mor"));

            //remove
            Console.WriteLine(kullanicilar.Remove(12));
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Value);

            //keys
            foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);

            //values
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);


        }
    }
}
