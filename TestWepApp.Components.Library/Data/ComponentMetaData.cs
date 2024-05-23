using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWepApp.Components.Library.Data
{
    public class ComponentMetaData
    {
        public ComponentMetaData(Type type, Dictionary<string, object> parameters) 
        {
            Type = type;
            Parameters = parameters;
        }

        public Type Type { get; set; }  
        public Dictionary<string, object> Parameters { get;}
    }
}
