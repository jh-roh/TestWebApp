#pragma checksum "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\Faq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85f9612754b6e489ad6567e09f4ee7929228772f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestWebApp.Pages.Pages_Faq), @"mvc.1.0.razor-page", @"/Pages/Faq.cshtml")]
namespace TestWebApp.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f9612754b6e489ad6567e09f4ee7929228772f", @"/Pages/Faq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"943629611bff68fb78277b0347bdcd2df3dde5b3", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Faq : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex flex-column h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85f9612754b6e489ad6567e09f4ee7929228772f3458", async() => {
                WriteLiteral("\n        <meta charset=\"utf-8\" />\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n        <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 213, "\"", 223, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n        <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 255, "\"", 265, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
        <title>Modern Business - Start Bootstrap Template</title>
        <!-- Favicon-->
        <link rel=""icon"" type=""image/x-icon"" href=""assets/favicon.ico"" />
        <!-- Bootstrap icons-->
        <link href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css"" rel=""stylesheet"" />
        <!-- Core theme CSS (includes Bootstrap)-->
        <link href=""css/styles.css"" rel=""stylesheet"" />
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85f9612754b6e489ad6567e09f4ee7929228772f5386", async() => {
                WriteLiteral(@"
        <main class=""flex-shrink-0"">
            <!-- Navigation-->
            <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
                <div class=""container px-5"">
                    <a class=""navbar-brand"" href=""index.html"">Start Bootstrap</a>
                    <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation""><span class=""navbar-toggler-icon""></span></button>
                    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                        <ul class=""navbar-nav ms-auto mb-2 mb-lg-0"">
                            <li class=""nav-item""><a class=""nav-link"" href=""index.html"">Home</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""about.html"">About</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""contact.html"">Contact</a></li>
                  ");
                WriteLiteral(@"          <li class=""nav-item""><a class=""nav-link"" href=""pricing.html"">Pricing</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""faq.html"">FAQ</a></li>
                            <li class=""nav-item dropdown"">
                                <a class=""nav-link dropdown-toggle"" id=""navbarDropdownBlog"" href=""#"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">Blog</a>
                                <ul class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""navbarDropdownBlog"">
                                    <li><a class=""dropdown-item"" href=""blog-home.html"">Blog Home</a></li>
                                    <li><a class=""dropdown-item"" href=""blog-post.html"">Blog Post</a></li>
                                </ul>
                            </li>
                            <li class=""nav-item dropdown"">
                                <a class=""nav-link dropdown-toggle"" id=""navbarDropdownPortfolio"" href=""#"" role=""button"" data-bs-toggle=""dropdown"" aria");
                WriteLiteral(@"-expanded=""false"">Portfolio</a>
                                <ul class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""navbarDropdownPortfolio"">
                                    <li><a class=""dropdown-item"" href=""portfolio-overview.html"">Portfolio Overview</a></li>
                                    <li><a class=""dropdown-item"" href=""portfolio-item.html"">Portfolio Item</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <!-- Page Content-->
            <section class=""py-5"">
                <div class=""container px-5 my-5"">
                    <div class=""text-center mb-5"">
                        <h1 class=""fw-bolder"">Frequently Asked Questions</h1>
                        <p class=""lead fw-normal text-muted mb-0"">How can we help you?</p>
                    </div>
                    <div class=""row gx-5"">
                        <div class=""col-xl-8"">
       ");
                WriteLiteral(@"                     <!-- FAQ Accordion 1-->
                            <h2 class=""fw-bolder mb-3"">Account &amp; Billing</h2>
                            <div class=""accordion mb-5"" id=""accordionExample"">
                                <div class=""accordion-item"">
                                    <h3 class=""accordion-header"" id=""headingOne""><button class=""accordion-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">Accordion Item #1</button></h3>
                                    <div class=""accordion-collapse collapse show"" id=""collapseOne"" aria-labelledby=""headingOne"" data-bs-parent=""#accordionExample"">
                                        <div class=""accordion-body"">
                                            <strong>This is the first item's accordion body.</strong>
                                            It is shown by default, until the collapse plugin adds the appropriate classes that we use to style each element.");
                WriteLiteral(@" These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the
                                            <code>.accordion-body</code>
                                            , though the transition does limit overflow.
                                        </div>
                                    </div>
                                </div>
                                <div class=""accordion-item"">
                                    <h3 class=""accordion-header"" id=""headingTwo""><button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">Accordion Item #2</button></h3>
                                    <div class=""accordion-collapse collapse"" id=""collapseTwo"" aria-labelledby=""headingTwo"" data-bs-parent=""#accordio");
                WriteLiteral(@"nExample"">
                                        <div class=""accordion-body"">
                                            <strong>This is the second item's accordion body.</strong>
                                            It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the
                                            <code>.accordion-body</code>
                                            , though the transition does limit overflow.
                                        </div>
                                    </div>
                                </div>
                                <div class=""accordion-item"">
                                    <h3 class=""accordion-header"" id=""headingThree"">");
                WriteLiteral(@"<button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">Accordion Item #3</button></h3>
                                    <div class=""accordion-collapse collapse"" id=""collapseThree"" aria-labelledby=""headingThree"" data-bs-parent=""#accordionExample"">
                                        <div class=""accordion-body"">
                                            <strong>This is the third item's accordion body.</strong>
                                            It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the
                                            <code>.accordion-body</code>
            ");
                WriteLiteral(@"                                , though the transition does limit overflow.
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- FAQ Accordion 2-->
                            <h2 class=""fw-bolder mb-3"">Website Issues</h2>
                            <div class=""accordion mb-5 mb-xl-0"" id=""accordionExample2"">
                                <div class=""accordion-item"">
                                    <h3 class=""accordion-header"" id=""headingOne""><button class=""accordion-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">Accordion Item #1</button></h3>
                                    <div class=""accordion-collapse collapse show"" id=""collapseOne"" aria-labelledby=""headingOne"" data-bs-parent=""#accordionExample2"">
                                        <div class=""accordion-body"">
        ");
                WriteLiteral(@"                                    <strong>This is the first item's accordion body.</strong>
                                            It is shown by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the
                                            <code>.accordion-body</code>
                                            , though the transition does limit overflow.
                                        </div>
                                    </div>
                                </div>
                                <div class=""accordion-item"">
                                    <h3 class=""accordion-header"" id=""headingTwo""><button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-t");
                WriteLiteral(@"arget=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">Accordion Item #2</button></h3>
                                    <div class=""accordion-collapse collapse"" id=""collapseTwo"" aria-labelledby=""headingTwo"" data-bs-parent=""#accordionExample2"">
                                        <div class=""accordion-body"">
                                            <strong>This is the second item's accordion body.</strong>
                                            It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the
                                            <code>.accordion-body</code>
                                            , though the transition does limit overflow.
                     ");
                WriteLiteral(@"                   </div>
                                    </div>
                                </div>
                                <div class=""accordion-item"">
                                    <h3 class=""accordion-header"" id=""headingThree""><button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">Accordion Item #3</button></h3>
                                    <div class=""accordion-collapse collapse"" id=""collapseThree"" aria-labelledby=""headingThree"" data-bs-parent=""#accordionExample2"">
                                        <div class=""accordion-body"">
                                            <strong>This is the third item's accordion body.</strong>
                                            It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding");
                WriteLiteral(@" via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the
                                            <code>.accordion-body</code>
                                            , though the transition does limit overflow.
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4"">
                            <div class=""card border-0 bg-light mt-xl-5"">
                                <div class=""card-body p-4 py-lg-5"">
                                    <div class=""d-flex align-items-center justify-content-center"">
                                        <div class=""text-center"">
                                            <div class=""h6 fw-bolder"">Have more questions?</div>
                                            <p cl");
                WriteLiteral(@"ass=""text-muted mb-4"">
                                                Contact us at
                                                <br />
                                                <a href=""#!"">support@domain.com</a>
                                            </p>
                                            <div class=""h6 fw-bolder"">Follow us</div>
                                            <a class=""fs-5 px-2 link-dark"" href=""#!""><i class=""bi-twitter""></i></a>
                                            <a class=""fs-5 px-2 link-dark"" href=""#!""><i class=""bi-facebook""></i></a>
                                            <a class=""fs-5 px-2 link-dark"" href=""#!""><i class=""bi-linkedin""></i></a>
                                            <a class=""fs-5 px-2 link-dark"" href=""#!""><i class=""bi-youtube""></i></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
    ");
                WriteLiteral(@"                </div>
                </div>
            </section>
        </main>
        <!-- Footer-->
        <footer class=""bg-dark py-4 mt-auto"">
            <div class=""container px-5"">
                <div class=""row align-items-center justify-content-between flex-column flex-sm-row"">
                    <div class=""col-auto""><div class=""small m-0 text-white"">Copyright &copy; Your Website 2022</div></div>
                    <div class=""col-auto"">
                        <a class=""link-light small"" href=""#!"">Privacy</a>
                        <span class=""text-white mx-1"">&middot;</span>
                        <a class=""link-light small"" href=""#!"">Terms</a>
                        <span class=""text-white mx-1"">&middot;</span>
                        <a class=""link-light small"" href=""#!"">Contact</a>
                    </div>
                </div>
            </div>
        </footer>
        <!-- Bootstrap core JS-->
        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstr");
                WriteLiteral("ap.bundle.min.js\"></script>\n        <!-- Core theme JS-->\n        <script src=\"js/scripts.js\"></script>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Faq> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Faq> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Faq>)PageContext?.ViewData;
        public Pages_Faq Model => ViewData.Model;
    }
}
#pragma warning restore 1591
