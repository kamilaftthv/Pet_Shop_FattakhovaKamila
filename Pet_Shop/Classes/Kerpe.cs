using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.Classes
{
    internal class Kerpe : Animal
    {
        public Kerpe(string model, string name, int age) : base(model, name, age)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Шуршит");
        }
    }
}
