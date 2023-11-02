using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.Classes
{
    internal class Animal
    {
        private string _model;
        public string Model
        {
            get => _model;
            set { _model = value; }
        }
        private string _name;
        public string Name
        {
            get => _name;
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get => _age;
            set { _age = value; }
        }
        public Animal(string model, string name, int age)
        {
            Model = model;
            Name = name;
            Age = age;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Животное издает звук");
        }
    }
}
