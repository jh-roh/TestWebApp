#pragma checksum "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\Portfolios\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8701e5b044bf9fd6efb300fbb991e96f4ec235dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestWebApp.Pages.Portfolios.Pages_Portfolios_List), @"mvc.1.0.razor-page", @"/Pages/Portfolios/List.cshtml")]
namespace TestWebApp.Pages.Portfolios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\_ViewImports.cshtml"
using TestWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\Portfolios\List.cshtml"
using TestWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\Portfolios\List.cshtml"
using TestWebApp.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8701e5b044bf9fd6efb300fbb991e96f4ec235dc", @"/Pages/Portfolios/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"943629611bff68fb78277b0347bdcd2df3dde5b3", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Portfolios_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\Portfolios\List.cshtml"
  
    ViewBag.Title = "Portfolio Detail List";

     var portfolios = PortfolioService.GetPortfolios();


#line default
#line hidden
#nullable disable
            WriteLiteral(@" <!-- Page Content-->
<section class=""py-5"">
    <div class=""container px-5 my-5"">
        <div class=""text-center mb-5"">
            <h1 class=""fw-bolder"">Our Work</h1>
            <p class=""lead fw-normal text-muted mb-0"">Company portfolio</p>
        </div>
        <div class=""row gx-5"">

");
#nullable restore
#line 23 "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\Portfolios\List.cshtml"
             foreach (var item in portfolios)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"col-lg-6\">\r\n                    <div class=\"position-relative mb-5\">\r\n                        <img class=\"portfolio-item-image\"");
            BeginWriteAttribute("src", " src=\"", 793, "\"", 810, 1);
#nullable restore
#line 27 "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\Portfolios\List.cshtml"
WriteAttributeValue("", 799, item.Image, 799, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n                        \r\n                    </div>\r\n                    <div class=\"portfolio-item-container\">\r\n                        <a class=\"h3 fw-bolder text-decoration-none link-dark stretched-link\" href=\"#!\">");
#nullable restore
#line 31 "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\Portfolios\List.cshtml"
                                                                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\Portfolios\List.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n");
            WriteLiteral(@"        </div>
    </div>
</section>
<section class=""py-5 bg-light"">
    <div class=""container px-5 my-5"">
        <h2 class=""display-4 fw-bolder mb-4"">Let's build something together</h2>
        <a class=""btn btn-lg btn-primary"" href=""#!"">Contact us</a>
    </div>
</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public PortfolioServiceJsonFile PortfolioService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestWebApp.Pages.Portfolios.ListModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestWebApp.Pages.Portfolios.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestWebApp.Pages.Portfolios.ListModel>)PageContext?.ViewData;
        public TestWebApp.Pages.Portfolios.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
