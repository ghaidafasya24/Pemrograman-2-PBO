using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220031
{
    public class Buah
    {
        // Field
        private string name;

        // Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Constructor
        public Buah(string name)
        {
            this.name = name;
        }

        // Method
        public virtual void Display()
        {
            Console.WriteLine($"ini adalah macam-macam {name}.");
        }
    }

}
