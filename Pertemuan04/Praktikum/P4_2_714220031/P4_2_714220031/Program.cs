using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220031
{
    class Program
    {
        static void Main(string[] args)
        {
            Buah buah = new Buah("buah");
            buah.Display();

            Jeruk jeruk = new Jeruk("jeruk", "manis asam");
            jeruk.Display();

            Pisang pisang = new Pisang("pisang", "manis");
            pisang.Display();

            Console.ReadLine();

        }


    }
}
