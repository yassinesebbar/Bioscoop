#pragma checksum "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Home\IndexApp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5c95e54060e728a7f0ae7ee252f399dbd815022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexApp), @"mvc.1.0.view", @"/Views/Home/IndexApp.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\_ViewImports.cshtml"
using Bioscoop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\_ViewImports.cshtml"
using Bioscoop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5c95e54060e728a7f0ae7ee252f399dbd815022", @"/Views/Home/IndexApp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e35e84aa9dccdbb7a84ff441625572d0eba9cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexApp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bioscoop.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bd-placeholder-img card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Placeholder: Thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("preserveAspectRatio", new global::Microsoft.AspNetCore.Html.HtmlString("xMidYMid slice"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("focusable", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Home\IndexApp.cshtml"
  
    ViewData["Title"] = "Home page app";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n  <div id=\"pdfUrl\" style=\"display: none;\">");
#nullable restore
#line 8 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Home\IndexApp.cshtml"
                                     Write(ViewBag.url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n  <div class=\"album py-5\">\r\n    <div class=\"container\">\r\n      <div class=\"row\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Home\IndexApp.cshtml"
         foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"col-md-4\"");
            BeginWriteAttribute("href", " href=\"", 317, "\"", 361, 2);
            WriteAttributeValue("", 324, "/Events/EventsMovieFilterApp/", 324, 29, true);
#nullable restore
#line 15 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Home\IndexApp.cshtml"
WriteAttributeValue("", 353, item.ID, 353, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                  <div>\r\n                    <div class=\"card mb-4 shadow-sm\">\r\n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f5c95e54060e728a7f0ae7ee252f399dbd8150227233", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
#nullable restore
#line 18 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Home\IndexApp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/");
#nullable restore
#line 18 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Home\IndexApp.cshtml"
                                                                                               WriteLiteral(item.ImageCover);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                      <div class=\"card-body\">\r\n                        <h3 class=\"card-text text-center\"> ");
#nullable restore
#line 20 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Home\IndexApp.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                        <div class=\"d-flex justify-content-between align-items-center\">\r\n                          <div class=\"btn-group\">\r\n                          </div>\r\n                          <small class=\"text-muted\">");
#nullable restore
#line 24 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Home\IndexApp.cshtml"
                                               Write(item.ReleaseDate.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                      </div>\r\n                    </div>\r\n                  </div>\r\n            </a>\r\n");
#nullable restore
#line 30 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Home\IndexApp.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n   \r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bioscoop.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591