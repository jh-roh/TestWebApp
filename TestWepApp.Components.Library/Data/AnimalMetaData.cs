﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWepApp.Components.Library.Components.Advanced.Pages;

namespace TestWepApp.Components.Library.Data
{
    public static class AnimalMetaData
    {
        private static Dictionary<string, object> ToParameters(this object instance)
             => new Dictionary<string, object> { { "Instance",instance} };

        public static ComponentMetaData? ToMetaData(this AnimalKind animal)
            => animal switch
            {
                AnimalKind.Dog => new ComponentMetaData(typeof(DogComponent), new Dog().ToParameters()),
                AnimalKind.Cat => new ComponentMetaData(typeof(CatComponent), new CatComponent().ToParameters()),
                _ => null
            };
       
    }
}
