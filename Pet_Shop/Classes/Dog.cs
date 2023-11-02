using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.Classes
{
    internal class Dog : Animal
    {
        public Dog(string model, string name, int age) : base(model, name, age)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Гав");
        }
    }
}
