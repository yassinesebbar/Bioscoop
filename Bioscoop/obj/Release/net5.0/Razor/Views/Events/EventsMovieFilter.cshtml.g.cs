#pragma checksum "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f53eab75471a1acbb458c13b730152f410987d81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_EventsMovieFilter), @"mvc.1.0.view", @"/Views/Events/EventsMovieFilter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f53eab75471a1acbb458c13b730152f410987d81", @"/Views/Events/EventsMovieFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e35e84aa9dccdbb7a84ff441625572d0eba9cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_EventsMovieFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bioscoop.Models.Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block mx-auto mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("preserveAspectRatio", new global::Microsoft.AspNetCore.Html.HtmlString("xMidYMid slice"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
  
    ViewData["Title"] = "Details";
    Movie Movie = (Movie) ViewData["Movie"];
    List<Event> Events = (List<Event>) ViewData["Events"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    \r\n    <!-- Custom styles for this template -->\r\n    \r\n<div class=\"container\">\r\n  <div class=\"py-5 text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f53eab75471a1acbb458c13b730152f410987d816221", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 726, "~/images/", 726, 9, true);
#nullable restore
#line 31 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
AddHtmlAttributeValue("", 735, Movie.ImageCover, 735, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h2>");
#nullable restore
#line 32 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
   Write(Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p class=\"lead\">");
#nullable restore
#line 33 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
               Write(Movie.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n  </div>\r\n  <div class=\"row\">\r\n    <div class=\"col-md-12 order-md-1\">\r\n      <h4 class=\"mb-3\">Draai momenten</h4>\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f53eab75471a1acbb458c13b730152f410987d818792", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n          <div class=\"col-md-5 mb-3\">\r\n            <select class=\"custom-select d-block w-100\" id=\"country\" required>\r\n");
#nullable restore
#line 42 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
               if(Events != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                     foreach (var Event in Events)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f53eab75471a1acbb458c13b730152f410987d819770", async() => {
#nullable restore
#line 46 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                                             Write(Event.Start.ToString("dd-mm-yyyy"));

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                                                                                 Write(Event.Start.ToString("hh:mm"));

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - ");
#nullable restore
#line 46 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                                                                                                                  Write(Event.End.ToString("hh:mm"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                           WriteLiteral(Event.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </select>
          </div>
      </div>
        <hr class=""mb-4"">
        <h4 class=""mb-3"">Tarieven</h4>
        <div class=""d-block my-3"">
          <div class=""custom-control custom-radio"">
            <input name=""paymentMethod"" type=""radio"" class=""custom-control-input"" checked required>
            <label class=""custom-control-label"" for=""credit"">Normaal</label>
          </div>
          <div class=""custom-control custom-radio"">
            <input id=""debit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" required>
            <label class=""custom-control-label"" for=""debit"">Kinderkorting - Studentkorting - 65+ korting</label>
          </div>
        <hr class=""mb-4"">
        <button class=""btn btn-primary btn-lg btn-block"" type=""submit"">Continue to checkout</button>
      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bioscoop.Models.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591