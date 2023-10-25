using System;
using System.Collections.Generic;
//using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P4_2_714220031
{
    public class Pisang : Buah
    {
        // Field
        private string variety;

        // Property
        public string Variety
        {
            get { return variety; }
            set { variety = value; }
        }

        // Constructor
        public Pisang(string name, string variety) : base(name)
        {
            this.variety = variety;
        }

        // Method
        public override void Display()
        {
            Console.WriteLine($"ini adalah {Name} rasanya {variety}");
        }
    }
}
