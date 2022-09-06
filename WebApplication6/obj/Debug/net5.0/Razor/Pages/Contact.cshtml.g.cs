#pragma checksum "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c24745f3c3362751d863a11cdd12fdcab5e5ed4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestWebApp.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c24745f3c3362751d863a11cdd12fdcab5e5ed4", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"943629611bff68fb78277b0347bdcd2df3dde5b3", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-sb-form-api-token", new global::Microsoft.AspNetCore.Html.HtmlString("API_TOKEN"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\Pages\Contact.cshtml"
  
    ViewBag.Title = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page content-->
<section class=""py-5"">
    <div class=""container px-5"">
        <!-- Contact form-->
        <div class=""bg-light rounded-3 py-5 px-4 px-md-5 mb-5"">
            <div class=""text-center mb-5"">
                <div class=""feature bg-primary bg-gradient text-white rounded-3 mb-3""><i class=""bi bi-envelope""></i></div>
                <h1 class=""fw-bolder"">Get in touch</h1>
                <p class=""lead fw-normal text-muted mb-0"">We'd love to hear from you</p>
            </div>
            <div class=""row gx-5 justify-content-center"">
                <div class=""col-lg-8 col-xl-6"">
                    <!-- * * * * * * * * * * * * * * *-->
                    <!-- * * SB Forms Contact Form * *-->
                    <!-- * * * * * * * * * * * * * * *-->
                    <!-- This form is pre-integrated with SB Forms.-->
                    <!-- To make this form functional, sign up at-->
                    <!-- https://startbootstrap.com/solution/contact-forms-->
      ");
            WriteLiteral("              <!-- to get an API token!-->\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c24745f3c3362751d863a11cdd12fdcab5e5ed45129", async() => {
                WriteLiteral(@"
                        <!-- Name input-->
                        <div class=""form-floating mb-3"">
                            <input class=""form-control"" id=""name"" type=""text"" placeholder=""Enter your name..."" data-sb-validations=""required"" />
                            <label for=""name"">Full name</label>
                            <div class=""invalid-feedback"" data-sb-feedback=""name:required"">A name is required.</div>
                        </div>
                        <!-- Email address input-->
                        <div class=""form-floating mb-3"">
                            <input class=""form-control"" id=""email"" type=""email"" placeholder=""name@example.com"" data-sb-validations=""required,email"" />
                            <label for=""email"">Email address</label>
                            <div class=""invalid-feedback"" data-sb-feedback=""email:required"">An email is required.</div>
                            <div class=""invalid-feedback"" data-sb-feedback=""email:email"">Email is not val");
                WriteLiteral(@"id.</div>
                        </div>
                        <!-- Phone number input-->
                        <div class=""form-floating mb-3"">
                            <input class=""form-control"" id=""phone"" type=""tel"" placeholder=""(123) 456-7890"" data-sb-validations=""required"" />
                            <label for=""phone"">Phone number</label>
                            <div class=""invalid-feedback"" data-sb-feedback=""phone:required"">A phone number is required.</div>
                        </div>
                        <!-- Message input-->
                        <div class=""form-floating mb-3"">
                            <textarea class=""form-control"" id=""message"" type=""text"" placeholder=""Enter your message here..."" style=""height: 10rem"" data-sb-validations=""required""></textarea>
                            <label for=""message"">Message</label>
                            <div class=""invalid-feedback"" data-sb-feedback=""message:required"">A message is required.</div>
               ");
                WriteLiteral(@"         </div>
                        <!-- Submit success message-->
                        <!---->
                        <!-- This is what your users will see when the form-->
                        <!-- has successfully submitted-->
                        <div class=""d-none"" id=""submitSuccessMessage"">
                            <div class=""text-center mb-3"">
                                <div class=""fw-bolder"">Form submission successful!</div>
                                To activate this form, sign up at
                                <br />
                                <a href=""https://startbootstrap.com/solution/contact-forms"">https://startbootstrap.com/solution/contact-forms</a>
                            </div>
                        </div>
                        <!-- Submit error message-->
                        <!---->
                        <!-- This is what your users will see when there is-->
                        <!-- an error submitting the form-->
     ");
                WriteLiteral(@"                   <div class=""d-none"" id=""submitErrorMessage""><div class=""text-center text-danger mb-3"">Error sending message!</div></div>
                        <!-- Submit Button-->
                        <div class=""d-grid""><button class=""btn btn-primary btn-lg disabled"" id=""submitButton"" type=""submit"">Submit</button></div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <!-- Contact cards-->
        <div class=""row gx-5 row-cols-2 row-cols-lg-4 py-5"">
            <div class=""col"">
                <div class=""feature bg-primary bg-gradient text-white rounded-3 mb-3""><i class=""bi bi-chat-dots""></i></div>
                <div class=""h5 mb-2"">Chat with us</div>
                <p class=""text-muted mb-0"">Chat live with one of our support specialists.</p>
            </div>
            <div class=""col"">
                <div class=""feature bg-primary bg-gradient text-white rounded-3 mb-3""><i class=""bi bi-people""></i></div>
                <div class=""h5"">Ask the community</div>
                <p class=""text-muted mb-0"">Explore our community forums and communicate with other users.</p>
            </div>
            <div class=""col"">
                <div class=""feature bg-primary bg-gradient text-white rounded-3 mb-3""><i class=""bi bi-question-circle""></i></div>
                <div class=""h5"">Suppor");
            WriteLiteral(@"t center</div>
                <p class=""text-muted mb-0"">Browse FAQ's and support articles to find solutions.</p>
            </div>
            <div class=""col"">
                <div class=""feature bg-primary bg-gradient text-white rounded-3 mb-3""><i class=""bi bi-telephone""></i></div>
                <div class=""h5"">Call us</div>
                <p class=""text-muted mb-0"">Call us during normal business hours at (555) 892-9403.</p>
            </div>
        </div>
    </div>
</section>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *-->
    <!-- * *                               SB Forms JS                               * *-->
    <!-- * * Activate your form at https://startbootstrap.com/solution/contact-forms * *-->
    <!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *-->
    <script src=""https://cdn.startbootstrap.com/sb-forms-latest.js""></script>

");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Contact> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Contact> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Contact>)PageContext?.ViewData;
        public Pages_Contact Model => ViewData.Model;
    }
}
#pragma warning restore 1591
