using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheltene
{
    internal class Superhero
    {
        public string Identity = "";
        public string Abilities = "";
        public string Outfit = "";
        public string MoralCode = "";
        public string Enemies = "";
        public string Fear = "";

        public Superhero(string identity, string abilities, string outfit, string moralCode, string enemies, string fear)
        {
            Identity = identity;
            Abilities = abilities;
            Outfit = outfit;
            MoralCode = moralCode;
            Enemies = enemies;
            Fear = fear;
        }
    }
}
