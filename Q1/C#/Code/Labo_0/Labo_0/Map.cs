using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_0
{
    internal class Map
    {
        private string name;
        private int verticalSize;
        private int horizontalSize;
        private bool authorizedCompetition;

        public Map(string name, int verticalSize, int horizontalSize, bool authorizedCompetition)
        {
            this.name = name;
            this.verticalSize = verticalSize;
            this.horizontalSize = horizontalSize;
            this.authorizedCompetition = authorizedCompetition;
        }

        public Map(string name, int verticalSize, int horizontalSize) :this(name,verticalSize,horizontalSize,true){ }
        public Map(string name, int size, bool authorizedCompetition) : this(name, size, size, authorizedCompetition) { }

        public string GetName()
        {
            return this.name;
        }

        public int Surface()
        {
            return verticalSize * horizontalSize;
        }

        public string Description()
        {
            string output = "";
            output += name + " (taille " + verticalSize + "x" + horizontalSize + ", surface de " + Surface() + " cases)\n";
            output += (authorizedCompetition ? "Utilisable" : "Pas utilisable") + " en compétition";
            return output;
        }

        public override string ToString()
        {
            return this.name + " (" + this.verticalSize + " / " + this.horizontalSize +")";
        }

    }
}
