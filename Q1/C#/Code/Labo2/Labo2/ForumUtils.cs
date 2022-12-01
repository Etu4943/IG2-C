using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    internal static class ForumUtils
    {
        public static string[] FORBIDDEN_LOGINS = new[] {"fake","fart","test",""};
        public static bool ValidLogin(string login)
        {
            return !(Array.Exists(FORBIDDEN_LOGINS, element => login.ToLower() == element.ToLower()));
        }

        public static int Encode(string password)
        {
            int somme = 0;
            foreach(char element in password)
            {
                somme += element;
            }
            return (somme % 997);
        }

        public static int SpaceCount(string txt)
        {
            int nbSpaces = 0;
            foreach(char elem in txt)
            {
                if(elem == ' ') nbSpaces++;
            }
            return nbSpaces;
        }

        public static int DigitCount(string txt)
        {
            int nbDigit = 0;
            foreach (char elem in txt)
            {
                if (Char.IsDigit(elem)) nbDigit++;
            }
            return nbDigit;
        }

        public static void Count(string txt, out int spaceCount, out int digitCount)
        {
            spaceCount = SpaceCount(txt);
            digitCount = DigitCount(txt);
        }

        public static void CountAndUpdate(string txt, ref int spaceCount, ref int digitCount)
        {
            spaceCount += SpaceCount(txt);
            digitCount += DigitCount(txt);
        }



    }
}
