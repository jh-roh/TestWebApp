using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWepApp.Components.Library.Data
{
    public enum AnimalKind
    {
        UnKnown,
        Dog,
        Cat
    }

    public class Animal
    {
        public string Name { get; set; } = string.Empty;
    }

    public class Dog :Animal 
    {
        public bool IsAGoodDog { get; set; }
    }

    public class Cat :Animal
    {
        public bool Scratches { get; set; }
    }

}
