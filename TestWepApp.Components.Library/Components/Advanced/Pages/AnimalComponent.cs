using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWepApp.Components.Library.Components.Advanced.Pages
{
    public class AnimalComponent : ComponentBase
    {
        [Parameter]
        public EventCallback ValidSubmit { get; set; }
    }
}
