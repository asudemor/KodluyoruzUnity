namespace csharp_interface_example
{
    public class NewCorolla:Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}
