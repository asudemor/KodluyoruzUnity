using System;

namespace csharp_interface_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            NewFocus Newfocus = new NewFocus();
            Console.WriteLine(Newfocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(Newfocus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(Newfocus.StandartRengiNe().ToString());

            NewCivic Newcivic = new NewCivic();
            Console.WriteLine(Newcivic.HangiMarkaninAraci().ToString());
            Console.WriteLine(Newcivic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(Newcivic.StandartRengiNe().ToString());
        }
    }
}
