using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDCharacterCalculator.Models
{
    //public class Class
    //{
    //    public string Name { get; set; }
    //    public int Hitdie { get; set; }
    //}

    //or
    public class Class
    {
        private string name;
        private int hitdie;

        //public string Name
        //{
        //    get { return name;}
        //    set { name = value;}
        //}

        //public int Hitdie
        //{
        //    get { return hitdie;}
        //    set { hitdie = value;}
        //}

        //or

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Hitdie
        {
            get => hitdie;
            set => hitdie = value;
        }
    }


}
