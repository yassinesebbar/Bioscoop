#pragma checksum "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\Reservations\TemplateReservationPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa0ffc98fd57ed815074a8f9ec370bcd008931c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_TemplateReservationPDF), @"mvc.1.0.view", @"/Views/Reservations/TemplateReservationPDF.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ffc98fd57ed815074a8f9ec370bcd008931c4", @"/Views/Reservations/TemplateReservationPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e35e84aa9dccdbb7a84ff441625572d0eba9cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_TemplateReservationPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bioscoop.Models.Reservation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n  \r\n");
            WriteLiteral("            \r\n");
#nullable restore
#line 5 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\Reservations\TemplateReservationPDF.cshtml"
    
    ViewBag.Title = "Employee Data";  
    Event Event = (Event)ViewData["event"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n      <div class=\"row no-gutters border rounded overflow-hidden flex-md-row shadow-sm position-relative\">\r\n        <div class=\"col p-4 d-flex flex-column position-static\">\r\n          <strong class=\"d-inline-block mb-2 text-primary\">Reserveringscode: ");
#nullable restore
#line 12 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\Reservations\TemplateReservationPDF.cshtml"
                                                                        Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n          <h3 class=\"mb-0\">");
#nullable restore
#line 13 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\Reservations\TemplateReservationPDF.cshtml"
                      Write(Event.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n          <div class=\"mb-1 text-muted\">");
#nullable restore
#line 14 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\bioscoop\Views\Reservations\TemplateReservationPDF.cshtml"
                                  Write(Event.Start);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
          <p class=""card-text mb-auto"">Neem deze reservering mee om je ticket bij de balie of op een van onze schermen in de Bioscoop te printen.</p>
        </div>
      </div>
    

      <script>
        document.addEventListener(""DOMContentLoaded"", () => {
            $("".footer"").hide();
        });
    </script>");
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
