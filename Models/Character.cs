using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDCharacterCalculator.Models
{
    // this is my practice class 
    // public means this thing can be access anywhere in the solution
    // private means this thing can only be access within  in the current class
    // protected means this thing can only be access within  in the current class or anyclass derived from the same class 
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int StrMod { get; set; }
        public int Dexterity { get; set; }
        public int DexMod { get; set; }
        public int Constitution { get; set; }
        public int ConMod { get; set; }
        public int Intelligence { get; set; }
        public int IntMod { get; set; }
        public int Wisdom { get; set; }
        public int WisMod { get; set; }
        public int Charisma { get; set; }
        public int ChaMod{ get; set; }
        public int MaxHealth { get; set; }
        public int HitDie { get; set; }

        private static int Modifier(int stat)
        {
            int mod = ((stat - 10) / 2); 
            return mod;
        }

        private static int Health()
        {
            //Sources:
            //https://www.omnicalculator.com/other/hit-points

            return 10;
        }

        //This is a contructor of player if it received name parameter
        public Character(string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Name = name;
            Strength = strength;
            StrMod = Modifier(strength);
            Dexterity = dexterity;
            DexMod = Modifier(dexterity);
            Constitution = constitution;
            ConMod = Modifier(constitution);
            Intelligence = intelligence;
            IntMod = Modifier(intelligence);
            Wisdom = wisdom;
            WisMod = Modifier(wisdom);
            Charisma = charisma;
            ChaMod = Modifier(charisma);
        }
    }
}
