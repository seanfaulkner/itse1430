using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        public string name { get; set; }
        public string profession { get; set; }
        public string race { get; set; }
        public string description { get; set; }
        public decimal strength { get; set; }
        public decimal intelligence { get; set; }
        public decimal agility { get; set; }
        public decimal constitution { get; set; }
        public decimal charisma { get; set; }

        public Character ( string name, string profession, string race, string description, decimal strength, decimal intelligence, decimal agility, decimal constitution, decimal charisma )
        {
            this.name = name;
            this.profession = profession;
            this.description = description;
            this.strength = strength;
            this.intelligence = intelligence;
            this.agility = agility;
            this.constitution = constitution;
            this.charisma = charisma;
        }

    }
}
   
