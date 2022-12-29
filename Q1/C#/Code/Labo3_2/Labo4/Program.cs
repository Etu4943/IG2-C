// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

namespace Labo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            Marchand cunégonde = new Marchand("Cunégonde");
            //cunégonde.AjouterCompagnon(abu);
            Mercenaire m1 = new Mercenaire("homme de main", 5);
            Mercenaire m2 = new Mercenaire("garde du corps", 12);
            Mercenaire m3 = new Mercenaire("vétéran", 20);
            cunégonde.AjouterCompagnon(m1, m2, m3);
            cunégonde.AfficherOffre();
        }

        static string Verifs(Creature creature, int ePv, int ePVMAX)
        {
            int pv = creature.Pv;
            int pvMax = creature.PvMax;
            float ratio = (float)(pv) / pvMax;
            float expectedRatio = creature.PourcentsPV;
            if (pv == ePv && pvMax == ePVMAX && ratio == expectedRatio)
                return " OK !!";
            else
            {
                return "A problem has occured";
            }

        }

    }
}
