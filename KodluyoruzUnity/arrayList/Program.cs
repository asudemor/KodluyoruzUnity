using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            //içerisinde verilere erişim
            //Console.WriteLine(liste[1]);

            //foreach (var item in liste)
                //Console.WriteLine(item);
            
            //addrange
            //string[] renkler = {"kırmızı","sarı","yesil"};
            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //sort
            liste.Sort();
     
            foreach (var item in liste)
                Console.WriteLine(item);

            //binary search
            Console.WriteLine(liste.BinarySearch(9));

            //reverse
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);
            
            //clear
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);
            
            



        }
    }
}
