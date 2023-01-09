using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5_2
{
    internal class Chapitre
    {
        private LinkedList<Agent> agents;
        private Dictionary<string, string> safeHouses;
        private Dictionary<string, HashSet<Agent>> missions;

        public Chapitre(string ville)
        {
            Ville = ville;
            agents = new LinkedList<Agent>();
            safeHouses= new Dictionary<string, string>();
            missions = new Dictionary<string, HashSet<Agent>>();
        }

        public string Ville
        {
            get; 
            set;
        }

        public void AjouteAgent(Agent agent)
        {
            if (!agents.Contains(agent))
                agents.AddLast(agent);
        }

        public void SupprimeAgent(Agent agent)
        {
            agents.Remove(agent);
        }

        public HashSet<Agent> AgentsSelonID(Identite identite)
        {
            HashSet<Agent> liste = new HashSet<Agent>();
            foreach(Agent agent in agents)
            {
                if (agent.getIdentite().Nom == identite.Nom || agent.getIdentite().Prenom == identite.Prenom) // Verifier que 2x même noms mais pas même prénoms
                    liste.Add(agent);
            }
            return liste;
        }

        public string AfficheSelonID(Identite identite)
        {
            StringBuilder output = new StringBuilder();
            HashSet<Agent> liste = AgentsSelonID(identite);
            foreach (Agent agent in liste)
                output.AppendLine(agent.ToString());
            return output.ToString();
        }

        public void AjouteSafehouse(string code, string adresse)
        {
            safeHouses.Add(code, adresse);
        }

        public string AdresseSafeHouse(string code)
        {
            if (safeHouses.ContainsKey(code))
            {
                return $"{safeHouses[code]}";
            }
            return "Code inconnu";
        }

        public string AfficheCodesSafehouses()
        {
            StringBuilder output = new StringBuilder();
            foreach(var safehouse in safeHouses)
            {
                output.AppendLine(safehouse.Key);
            }
            return output.ToString();
        }

        public void AjouteMission(string code)
        {
            if (!missions.ContainsKey(code))
            {
                HashSet<Agent> listeAgents = new HashSet<Agent>();
                missions.Add(code, listeAgents);
            }
        }

        public void AjouteAgentMission(string code, Agent agent)
        {
            if (!missions.ContainsKey(code))
                AjouteMission(code);
            missions[code].Add(agent);

        }

        public void AjouteMission(string code, params Agent[] newAgents)
        {
            foreach (Agent newAgent in newAgents)
            {
                AjouteAgentMission(code, newAgent);
            }
        }

        public string AfficheMissions(Agent agent)
        {
            StringBuilder output = new StringBuilder();
            foreach(string code in missions.Keys)
            {
                if (missions[code].Contains(agent))
                {
                    output.AppendLine(code);
                }
            }
            return output.ToString();
        }



        public Agent DernierAgentEnDate
        {
            get
            {
                return agents.Last();
            }
            set 
            {
                AjouteAgent(value);
            }
        }
    }
}
