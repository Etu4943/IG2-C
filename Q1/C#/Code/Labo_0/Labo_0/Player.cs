using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace Labo_0
{
    internal class Player
    {
        #region attributes
        public const int NB_MAX_MAPS = 5;
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private int skillRating;
        private bool sponsored;
        Map[] maps;
        #endregion

        public Player(string firstName, string lastName, DateTime birthday,bool isRanked)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.skillRating = isRanked ? 1 : 0;
            this.sponsored = false;
            maps = new Map[NB_MAX_MAPS];
        }
        public Player(string firstName, string lastName, DateTime birthday) : this(firstName, lastName, birthday, false) { }

        public string GetName()
        {   
            return this.lastName + " " + this.firstName;
        }

        public string GetBirthday()
        {
            return "(" + this.birthday.Day + "/" + this.birthday.Month + "/" + this.birthday.Year+ ")"; 
        }

        public void setRanked()
        {
            if(!IsRanked())
                skillRating = 1;
        }

        private bool IsRanked()
        {
            return skillRating > 0;
        }

        private void setSkillRating(int nbPoints)
        {
            this.skillRating += nbPoints;
            if (this.skillRating > 5000)
                this.skillRating = 5000;
            if (this.skillRating < 1)
                this.skillRating = 1;
        }

        public void ModifySkillRating(int nbPoints)
        {
            if(IsRanked())
                setSkillRating(nbPoints);
        }

        public void AddMap(Map newMap)
        {
            for(int i = NB_MAX_MAPS-1; i > 0; i--)
            {
                if (maps[i-1] != null)
                {
                    if (maps[i - 1].GetName() != newMap.GetName())
                    {
                        maps[i] = maps[i - 1];
                    }
                    else
                    {
                        int j;
                        for (j = i; j < NB_MAX_MAPS - 1; j++)
                        {
                            maps[j] = maps[j + 1];
                        }
                    }
                }
                
                
            }
            maps[0] = newMap;
        }

        public string ListingMaps()
        {
            string output = "";
            int nbMap = 1;
            foreach (Map map in maps)
            {
                
                output += nbMap + " - " + (map != null ? map.GetName() : "") + "\n";
                nbMap++;
            }
               
            return output;
        }

        public override string ToString()
        {
            string output = "";
            output += "Nom et prénom : " + GetName() + "\n";
            output += "Date de naissance " + GetBirthday() + "\n";
            output += (IsRanked() ? "Compétiteur" : "Non compétiteur") + "\n";
            output += ListingMaps();
            return output;
        }

    }
}
