using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWepApp.Components.Library.Data;

namespace TestWepApp.Components.Library.Components.Advanced.Pages
{
    public partial class DogComponent
    {
        [Parameter]
        public Dog Instance { get; set; } = default!;
    }
}
