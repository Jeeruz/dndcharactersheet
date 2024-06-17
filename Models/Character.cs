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
        public string CharClass { get; set; }
        public int Level2 { get; set; }
        public string CharClass2 { get; set; }
        public int Level3 { get; set; }
        public int Class3 { get; set; }
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

        private static int CalculatedClassHealth(int level,string charclass)
        {
            //Hit Points at 1st Levei: 8 + your Constitution modifier
            //Hit Points at Higher Leveis: 1d8(or 5) + your Constitution 
            //    modifier per clerie levei after 1st
            int calculatedHealth = 0;

            if (level == 1)
            {
                //calculatedHealth = 5 + Character.ChaMod;
            }
       
            return 10;
        }

        private static int CalculatedMaxHealth(int level, string character)
        {
            //This will be used to calculate max health if player has multiclasses
       
            return 10;
        }

        //This is a contructor of player if it received name parameter
        public Character(string name, int level, string charclass, int level2, string charclass2, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Name = name;
            Level = level;
            CharClass = charclass;
            Level2 = level2;
            CharClass2 = charclass2;
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
