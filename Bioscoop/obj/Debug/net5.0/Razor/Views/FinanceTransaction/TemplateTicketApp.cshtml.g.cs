#pragma checksum "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\FinanceTransaction\TemplateTicketApp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfd6ba24725f9635db9cf1b35d4c8e6f087f1c05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FinanceTransaction_TemplateTicketApp), @"mvc.1.0.view", @"/Views/FinanceTransaction/TemplateTicketApp.cshtml")]
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
#line 1 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\_ViewImports.cshtml"
using Bioscoop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\_ViewImports.cshtml"
using Bioscoop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfd6ba24725f9635db9cf1b35d4c8e6f087f1c05", @"/Views/FinanceTransaction/TemplateTicketApp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e35e84aa9dccdbb7a84ff441625572d0eba9cd", @"/Views/_ViewImports.cshtml")]
    public class Views_FinanceTransaction_TemplateTicketApp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bioscoop.Models.Reservation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("        \r\n      \r\n");
#nullable restore
#line 4 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\FinanceTransaction\TemplateTicketApp.cshtml"
    
    ViewBag.Title = "Employee Data";  
    Event Event = (Event)ViewData["event"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   
    <div class=""card mb-12 shadow-sm"">
      <div class=""card-header"">
        <h4 class=""my-0 font-weight-normal text-center"">Ticket</h4>
      </div>
      <div class=""card-body"">
        <h4 class=""card-title pricing-card-title centered text-center"">");
#nullable restore
#line 14 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\FinanceTransaction\TemplateTicketApp.cshtml"
                                                                  Write(Event.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <ul class=\"list-unstyled mt-3 mb-4 text-center\">\r\n          <li>");
#nullable restore
#line 16 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\FinanceTransaction\TemplateTicketApp.cshtml"
         Write(Event.Start.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 16 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\FinanceTransaction\TemplateTicketApp.cshtml"
                                          Write(Event.End.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n          <li>");
#nullable restore
#line 17 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\FinanceTransaction\TemplateTicketApp.cshtml"
         Write(Event.Hall.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\FinanceTransaction\TemplateTicketApp.cshtml"
                            Write(Model.StoelNr.ChairNr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n      </div><div class=\"card-footer\">\r\n        <h4 class=\"my-0 font-weight-normal text-center\"><small class=\"text-muted\">");
#nullable restore
#line 20 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\FinanceTransaction\TemplateTicketApp.cshtml"
                                                                             Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h4>\r\n      </div>\r\n    </div>\r\n\r\n    <script>\r\n        document.addEventListener(\"DOMContentLoaded\", () => {\r\n            $(\".footer\").hide();\r\n        });\r\n    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bioscoop.Models.Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591
