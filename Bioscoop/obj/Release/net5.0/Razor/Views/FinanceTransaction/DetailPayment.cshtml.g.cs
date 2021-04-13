#pragma checksum "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\FinanceTransaction\DetailPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "235097c31541dc7ec3e15faa5c323e8897fc98a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FinanceTransaction_DetailPayment), @"mvc.1.0.view", @"/Views/FinanceTransaction/DetailPayment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"235097c31541dc7ec3e15faa5c323e8897fc98a1", @"/Views/FinanceTransaction/DetailPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e35e84aa9dccdbb7a84ff441625572d0eba9cd", @"/Views/_ViewImports.cshtml")]
    public class Views_FinanceTransaction_DetailPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bioscoop.Models.FinanceTransaction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelPayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\FinanceTransaction\DetailPayment.cshtml"
  
    ViewData["Title"] = "Details";
    Reservation reservation = (Reservation) ViewData["Reservation"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""position-relative overflow-hidden p-3 p-md-5 m-md-3 text-center bg-light"">
  <div class=""col-md-5 p-lg-5 mx-auto my-5"">
    <h1 class=""display-5 font-weight-normal"">De <b>Bioscoop</b> van Nederland</h1>
    <p class=""lead font-weight-normal""></p>
  </div>
  <div class=""movie-logo"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""350"" height=""350"" fill=""none"" stroke=""currentColor""  stroke-width=""2"" class=""d-block mx-auto"" role=""img"" viewBox=""0 0 24 24"" focusable=""false""><path d=""M4.92 4.559c.117.046.213-.05.24-.12V3.12c-.027-.143-.123-.24-.24-.24H2.519c-.139 0-.235.097-.24.24v1.319c.005.07.101.166.24.12H4.92zM4.92 9.36a.335.335 0 0 0 .24-.24V7.8a.397.397 0 0 0-.24-.241H2.519c-.139.045-.235.142-.24.241v1.32c.005.114.101.21.24.24H4.92zM4.92 14.04c.117.016.213-.081.24-.24v-1.201c-.027-.173-.123-.269-.24-.239H2.519c-.139-.03-.235.066-.24.239V13.8c.005.159.101.255.24.24H4.92zM4.92 18.84c.117-.061.213-.156.24-.24v-1.32a.293.293 0 0 0-.24-.24H2.519c-.139.015-.235.111-.24.2");
            WriteLiteral(@"4v1.32c.005.084.101.18.24.24H4.92zM4.92 23.52c.117-.014.213-.111.24-.24v-1.32c-.027-.084-.123-.18-.24-.119H2.519c-.139-.061-.235.035-.24.119v1.32c.005.129.101.227.24.24H4.92zM4.92 28.199c.117.031.213-.066.24-.24V26.76c-.027-.158-.123-.256-.24-.24H2.519c-.139-.016-.235.082-.24.24v1.199c.005.174.101.271.24.24H4.92zM4.92 33a.395.395 0 0 0 .24-.24v-1.32a.335.335 0 0 0-.24-.24H2.519c-.139.029-.235.127-.24.24v1.32c.005.1.101.195.24.24H4.92zM30 4.559c-.168.046-.266-.05-.241-.12V3.12c-.025-.143.073-.24.241-.24h2.399c.087 0 .186.097.239.24v1.319c-.054.07-.152.166-.239.12H30zM30 9.36c-.168-.03-.266-.126-.241-.24V7.8c-.025-.099.073-.196.241-.241h2.399a.629.629 0 0 1 .239.241v1.32a.475.475 0 0 1-.239.24H30zM30 14.04c-.168.016-.266-.081-.241-.24v-1.201c-.025-.173.073-.269.241-.239h2.399c.087-.03.186.066.239.239V13.8c-.054.159-.152.255-.239.24H30zM30 18.84c-.168-.061-.266-.156-.241-.24v-1.32c-.024-.129.073-.225.241-.24h2.399c.087.015.186.111.239.24v1.32a.956.956 0 0 1-.239.24H30zM30 23.52c-.168-.014-.266-.111-.241-.24v-1.3");
            WriteLiteral(@"2c-.024-.084.073-.18.241-.119h2.399c.087-.061.186.035.239.119v1.32c-.054.129-.152.227-.239.24H30zM30 28.199c-.168.031-.266-.066-.241-.24V26.76c-.024-.158.073-.256.241-.24h2.399c.087-.016.186.082.239.24v1.199c-.054.174-.152.271-.239.24H30zM30 33c-.168-.045-.266-.141-.241-.24v-1.32c-.024-.113.073-.211.241-.24h2.399a.472.472 0 0 1 .239.24v1.32a.626.626 0 0 1-.239.24H30zM8.759 15.12h6.601L17.279 9l2.041 6.12h6.48l-5.281 3.839 2.04 6.121-5.28-3.721-5.159 3.721 1.92-6.121-5.281-3.839z""/></svg>
  </div>
  <div class=""movie-logo movie-logo-2"">
    <svg xmlns=""http://www.w3.org/2000/svg"" width=""350"" height=""350"" fill=""none"" stroke=""currentColor""  stroke-width=""2"" class=""d-block mx-auto"" role=""img"" viewBox=""0 0 24 24"" focusable=""false""><path d=""M4.92 4.559c.117.046.213-.05.24-.12V3.12c-.027-.143-.123-.24-.24-.24H2.519c-.139 0-.235.097-.24.24v1.319c.005.07.101.166.24.12H4.92zM4.92 9.36a.335.335 0 0 0 .24-.24V7.8a.397.397 0 0 0-.24-.241H2.519c-.139.045-.235.142-.24.241v1.32c.005.114.101.21.24.24H4.92zM4.92 14.04c.117.");
            WriteLiteral(@"016.213-.081.24-.24v-1.201c-.027-.173-.123-.269-.24-.239H2.519c-.139-.03-.235.066-.24.239V13.8c.005.159.101.255.24.24H4.92zM4.92 18.84c.117-.061.213-.156.24-.24v-1.32a.293.293 0 0 0-.24-.24H2.519c-.139.015-.235.111-.24.24v1.32c.005.084.101.18.24.24H4.92zM4.92 23.52c.117-.014.213-.111.24-.24v-1.32c-.027-.084-.123-.18-.24-.119H2.519c-.139-.061-.235.035-.24.119v1.32c.005.129.101.227.24.24H4.92zM4.92 28.199c.117.031.213-.066.24-.24V26.76c-.027-.158-.123-.256-.24-.24H2.519c-.139-.016-.235.082-.24.24v1.199c.005.174.101.271.24.24H4.92zM4.92 33a.395.395 0 0 0 .24-.24v-1.32a.335.335 0 0 0-.24-.24H2.519c-.139.029-.235.127-.24.24v1.32c.005.1.101.195.24.24H4.92zM30 4.559c-.168.046-.266-.05-.241-.12V3.12c-.025-.143.073-.24.241-.24h2.399c.087 0 .186.097.239.24v1.319c-.054.07-.152.166-.239.12H30zM30 9.36c-.168-.03-.266-.126-.241-.24V7.8c-.025-.099.073-.196.241-.241h2.399a.629.629 0 0 1 .239.241v1.32a.475.475 0 0 1-.239.24H30zM30 14.04c-.168.016-.266-.081-.241-.24v-1.201c-.025-.173.073-.269.241-.239h2.399c.087-.03.186.066.23");
            WriteLiteral(@"9.239V13.8c-.054.159-.152.255-.239.24H30zM30 18.84c-.168-.061-.266-.156-.241-.24v-1.32c-.024-.129.073-.225.241-.24h2.399c.087.015.186.111.239.24v1.32a.956.956 0 0 1-.239.24H30zM30 23.52c-.168-.014-.266-.111-.241-.24v-1.32c-.024-.084.073-.18.241-.119h2.399c.087-.061.186.035.239.119v1.32c-.054.129-.152.227-.239.24H30zM30 28.199c-.168.031-.266-.066-.241-.24V26.76c-.024-.158.073-.256.241-.24h2.399c.087-.016.186.082.239.24v1.199c-.054.174-.152.271-.239.24H30zM30 33c-.168-.045-.266-.141-.241-.24v-1.32c-.024-.113.073-.211.241-.24h2.399a.472.472 0 0 1 .239.24v1.32a.626.626 0 0 1-.239.24H30zM8.759 15.12h6.601L17.279 9l2.041 6.12h6.48l-5.281 3.839 2.04 6.121-5.28-3.721-5.159 3.721 1.92-6.121-5.281-3.839z""/></svg>
  </div>
</div>

<div class=""container"">
    <div class=""row d-flex justify-content-center"">
        <div class=""col-md-6 mb-4 center-block"">
        <h4 class=""d-flex justify-content-between align-items-center mb-3"">
            <span class=""text-muted"">Winkelwagen</span>
        </h4>
        <ul c");
            WriteLiteral("lass=\"list-group mb-3\">\r\n            <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\r\n            <div>\r\n                <h6 class=\"my-0\">");
#nullable restore
#line 31 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\FinanceTransaction\DetailPayment.cshtml"
                            Write(reservation.Event.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <small class=\"text-muted\">Normale ticket</small>\r\n            </div>\r\n            <span class=\"text-muted\">€");
#nullable restore
#line 34 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\FinanceTransaction\DetailPayment.cshtml"
                                 Write(reservation.Event.BasePrijs.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n            </li>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\FinanceTransaction\DetailPayment.cshtml"
             if(Model.Discount != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\r\n                <div>\r\n                    <h6 class=\"my-0\">");
#nullable restore
#line 40 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\FinanceTransaction\DetailPayment.cshtml"
                                Write(Model.Discount.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>                    \r\n                </div>\r\n                <span class=\"text-muted\">- €");
#nullable restore
#line 42 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\FinanceTransaction\DetailPayment.cshtml"
                                       Write(Model.Discount.discountAmount.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n");
#nullable restore
#line 44 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\FinanceTransaction\DetailPayment.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <li class=\"list-group-item d-flex justify-content-between\">\r\n            <span>Totaal</span>\r\n            <strong>€");
#nullable restore
#line 48 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\FinanceTransaction\DetailPayment.cshtml"
                Write(Model.totalPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </li>\r\n        </ul>\r\n\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "235097c31541dc7ec3e15faa5c323e8897fc98a113010", async() => {
                WriteLiteral("Annuleren");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\FinanceTransaction\DetailPayment.cshtml"
                                                WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "235097c31541dc7ec3e15faa5c323e8897fc98a115377", async() => {
                WriteLiteral("Afrekenen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\FinanceTransaction\DetailPayment.cshtml"
                                                WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bioscoop.Models.FinanceTransaction> Html { get; private set; }
    }
}
#pragma warning restore 1591