using System;

namespace hazirMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string degisken = "Dersimiz CSharp, hosgeldiniz.";
            string degisken2 = "CSharp";
            
            //length
            Console.WriteLine(degisken.Length);

            //toupper, tolower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            
            //concat
            Console.WriteLine(String.Concat(degisken," Merhaba"));
            
            //compare, compareTo
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));
            
            //contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("hosgeldiniz."));
            Console.WriteLine(degisken.StartsWith("Merhaba"));
            
            //ındexof
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("asude"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //ınsert
            Console.WriteLine(degisken.Insert(0,"merhaba"));

            //padleft, padright
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //split
            Console.WriteLine(degisken.Split(' ')[1]);

            //substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));








        }
    }
}
