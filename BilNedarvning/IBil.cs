namespace BilNedarvning
{
    public interface IBil
    {
        int BilPrisExAfgift { get; }
        int KøbsÅr { get; }

        int HalvÅrligEjerafgift();
        string HvilkenBilErJeg();
        double RegistreringsAfgift();
        double RækkeVidde();
        double Totalpris();
    }
}