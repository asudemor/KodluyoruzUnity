using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.tohumlaCogalma();

            Kuslar marti = new Kuslar();
            marti.ucmak();
        }
    }
}
