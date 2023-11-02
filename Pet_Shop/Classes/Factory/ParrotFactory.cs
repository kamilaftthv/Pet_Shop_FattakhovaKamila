using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.Classes.Factory
{
    internal class ParrotFactory
    {
        public static Parrot Create(string type, string model, string name, int age)
        {
            return new Parrot(model, name, age);
        }
    }
}
