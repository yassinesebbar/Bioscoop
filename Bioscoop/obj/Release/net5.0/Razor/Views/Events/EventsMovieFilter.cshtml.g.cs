#pragma checksum "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c226483f704d15c5e504be0d3ec187c8f8b175"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c226483f704d15c5e504be0d3ec187c8f8b175", @"/Views/Events/EventsMovieFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e35e84aa9dccdbb7a84ff441625572d0eba9cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_EventsMovieFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bioscoop.Models.Reservation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block mx-auto mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("preserveAspectRatio", new global::Microsoft.AspNetCore.Html.HtmlString("xMidYMid slice"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Naam"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Achternaam"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("E-mail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-select d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
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
    List<TicketDiscount> TicketDiscounts = (List<TicketDiscount>) ViewData["TicketDiscounts"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""position-relative overflow-hidden p-3 p-md-5 m-md-3 text-center bg-light"">
  <div class=""col-md-5 p-lg-5 mx-auto my-5""> <h1 class=""display-5 font-weight-normal"">De <b>Bioscoop</b> van Nederland</h1> </div>
  <div class=""movie-logo""> <svg xmlns=""http://www.w3.org/2000/svg"" width=""350"" height=""350"" fill=""none"" stroke=""currentColor""  stroke-width=""2"" class=""d-block mx-auto"" role=""img"" viewBox=""0 0 24 24"" focusable=""false""><path d=""M4.92 4.559c.117.046.213-.05.24-.12V3.12c-.027-.143-.123-.24-.24-.24H2.519c-.139 0-.235.097-.24.24v1.319c.005.07.101.166.24.12H4.92zM4.92 9.36a.335.335 0 0 0 .24-.24V7.8a.397.397 0 0 0-.24-.241H2.519c-.139.045-.235.142-.24.241v1.32c.005.114.101.21.24.24H4.92zM4.92 14.04c.117.016.213-.081.24-.24v-1.201c-.027-.173-.123-.269-.24-.239H2.519c-.139-.03-.235.066-.24.239V13.8c.005.159.101.255.24.24H4.92zM4.92 18.84c.117-.061.213-.156.24-.24v-1.32a.293.293 0 0 0-.24-.24H2.519c-.139.015-.235.111-.24.24v1.32c.005.084.101.18.24.24H4.92zM4.92 23.52c.117-.014.213-.111.24-.24v-1.32c-.");
            WriteLiteral(@"027-.084-.123-.18-.24-.119H2.519c-.139-.061-.235.035-.24.119v1.32c.005.129.101.227.24.24H4.92zM4.92 28.199c.117.031.213-.066.24-.24V26.76c-.027-.158-.123-.256-.24-.24H2.519c-.139-.016-.235.082-.24.24v1.199c.005.174.101.271.24.24H4.92zM4.92 33a.395.395 0 0 0 .24-.24v-1.32a.335.335 0 0 0-.24-.24H2.519c-.139.029-.235.127-.24.24v1.32c.005.1.101.195.24.24H4.92zM30 4.559c-.168.046-.266-.05-.241-.12V3.12c-.025-.143.073-.24.241-.24h2.399c.087 0 .186.097.239.24v1.319c-.054.07-.152.166-.239.12H30zM30 9.36c-.168-.03-.266-.126-.241-.24V7.8c-.025-.099.073-.196.241-.241h2.399a.629.629 0 0 1 .239.241v1.32a.475.475 0 0 1-.239.24H30zM30 14.04c-.168.016-.266-.081-.241-.24v-1.201c-.025-.173.073-.269.241-.239h2.399c.087-.03.186.066.239.239V13.8c-.054.159-.152.255-.239.24H30zM30 18.84c-.168-.061-.266-.156-.241-.24v-1.32c-.024-.129.073-.225.241-.24h2.399c.087.015.186.111.239.24v1.32a.956.956 0 0 1-.239.24H30zM30 23.52c-.168-.014-.266-.111-.241-.24v-1.32c-.024-.084.073-.18.241-.119h2.399c.087-.061.186.035.239.119v1.32c-.054.129-.15");
            WriteLiteral(@"2.227-.239.24H30zM30 28.199c-.168.031-.266-.066-.241-.24V26.76c-.024-.158.073-.256.241-.24h2.399c.087-.016.186.082.239.24v1.199c-.054.174-.152.271-.239.24H30zM30 33c-.168-.045-.266-.141-.241-.24v-1.32c-.024-.113.073-.211.241-.24h2.399a.472.472 0 0 1 .239.24v1.32a.626.626 0 0 1-.239.24H30zM8.759 15.12h6.601L17.279 9l2.041 6.12h6.48l-5.281 3.839 2.04 6.121-5.28-3.721-5.159 3.721 1.92-6.121-5.281-3.839z""/></svg></div>
  <div class=""movie-logo movie-logo-2""><svg xmlns=""http://www.w3.org/2000/svg"" width=""350"" height=""350"" fill=""none"" stroke=""currentColor""  stroke-width=""2"" class=""d-block mx-auto"" role=""img"" viewBox=""0 0 24 24"" focusable=""false""><path d=""M4.92 4.559c.117.046.213-.05.24-.12V3.12c-.027-.143-.123-.24-.24-.24H2.519c-.139 0-.235.097-.24.24v1.319c.005.07.101.166.24.12H4.92zM4.92 9.36a.335.335 0 0 0 .24-.24V7.8a.397.397 0 0 0-.24-.241H2.519c-.139.045-.235.142-.24.241v1.32c.005.114.101.21.24.24H4.92zM4.92 14.04c.117.016.213-.081.24-.24v-1.201c-.027-.173-.123-.269-.24-.239H2.519c-.139-.03-.235.066-.24.239V");
            WriteLiteral(@"13.8c.005.159.101.255.24.24H4.92zM4.92 18.84c.117-.061.213-.156.24-.24v-1.32a.293.293 0 0 0-.24-.24H2.519c-.139.015-.235.111-.24.24v1.32c.005.084.101.18.24.24H4.92zM4.92 23.52c.117-.014.213-.111.24-.24v-1.32c-.027-.084-.123-.18-.24-.119H2.519c-.139-.061-.235.035-.24.119v1.32c.005.129.101.227.24.24H4.92zM4.92 28.199c.117.031.213-.066.24-.24V26.76c-.027-.158-.123-.256-.24-.24H2.519c-.139-.016-.235.082-.24.24v1.199c.005.174.101.271.24.24H4.92zM4.92 33a.395.395 0 0 0 .24-.24v-1.32a.335.335 0 0 0-.24-.24H2.519c-.139.029-.235.127-.24.24v1.32c.005.1.101.195.24.24H4.92zM30 4.559c-.168.046-.266-.05-.241-.12V3.12c-.025-.143.073-.24.241-.24h2.399c.087 0 .186.097.239.24v1.319c-.054.07-.152.166-.239.12H30zM30 9.36c-.168-.03-.266-.126-.241-.24V7.8c-.025-.099.073-.196.241-.241h2.399a.629.629 0 0 1 .239.241v1.32a.475.475 0 0 1-.239.24H30zM30 14.04c-.168.016-.266-.081-.241-.24v-1.201c-.025-.173.073-.269.241-.239h2.399c.087-.03.186.066.239.239V13.8c-.054.159-.152.255-.239.24H30zM30 18.84c-.168-.061-.266-.156-.241-.24v-1.32c-.0");
            WriteLiteral(@"24-.129.073-.225.241-.24h2.399c.087.015.186.111.239.24v1.32a.956.956 0 0 1-.239.24H30zM30 23.52c-.168-.014-.266-.111-.241-.24v-1.32c-.024-.084.073-.18.241-.119h2.399c.087-.061.186.035.239.119v1.32c-.054.129-.152.227-.239.24H30zM30 28.199c-.168.031-.266-.066-.241-.24V26.76c-.024-.158.073-.256.241-.24h2.399c.087-.016.186.082.239.24v1.199c-.054.174-.152.271-.239.24H30zM30 33c-.168-.045-.266-.141-.241-.24v-1.32c-.024-.113.073-.211.241-.24h2.399a.472.472 0 0 1 .239.24v1.32a.626.626 0 0 1-.239.24H30zM8.759 15.12h6.601L17.279 9l2.041 6.12h6.48l-5.281 3.839 2.04 6.121-5.28-3.721-5.159 3.721 1.92-6.121-5.281-3.839z""/></svg></div>
</div>
<div id=""pdfUrl"" style=""display: none;"">");
#nullable restore
#line 15 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                                   Write(ViewBag.url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    \r\n<div class=\"container\">\r\n  <div class=\"py-5 text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9c226483f704d15c5e504be0d3ec187c8f8b17514701", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5186, "~/images/", 5186, 9, true);
#nullable restore
#line 19 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
AddHtmlAttributeValue("", 5195, Movie.ImageCover, 5195, 17, false);

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
#line 20 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
   Write(Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p class=\"lead\">");
#nullable restore
#line 21 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
               Write(Movie.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n  </div>\r\n\r\n  <div class=\"row\">\r\n    <div class=\"col-md-12 order-md-1\">\r\n      <hr class=\"mb-4\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9c226483f704d15c5e504be0d3ec187c8f8b17517261", async() => {
                WriteLiteral("\r\n\r\n\r\n       <div class=\"row\">\r\n          <div class=\"col-md-6 mb-3\">\r\n            <label for=\"cc-name\">Voornaam:</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9c226483f704d15c5e504be0d3ec187c8f8b17517669", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 33 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </div>\r\n\r\n          <div class=\"col-md-6 mb-3\">\r\n            <label for=\"cc-number\">Achternaam:</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9c226483f704d15c5e504be0d3ec187c8f8b17520020", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 38 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LastName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </div>\r\n      </div>\r\n\r\n      <div class=\"row\">\r\n          <div class=\"col-md-12 mb-3\">\r\n            <label for=\"cc-expiration\">E-mail:</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9c226483f704d15c5e504be0d3ec187c8f8b17522421", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 45 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </div>\r\n      </div>\r\n      <div class=\"row\">\r\n          <div class=\"col-md-6 mb-3 form-group\">\r\n            <label for=\"Evenementen\">Evenementen:</label>\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9c226483f704d15c5e504be0d3ec187c8f8b17524830", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                 if(Events != null)
                  {
                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                       foreach (var Event in Events)
                      {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                          ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9c226483f704d15c5e504be0d3ec187c8f8b17525675", async() => {
#nullable restore
#line 56 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                                               Write(Event.Start.ToString("dd-mm-yyyy"));

#line default
#line hidden
#nullable disable
                        WriteLiteral(" ");
#nullable restore
#line 56 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                                                                                   Write(Event.Start.ToString("hh:mm"));

#line default
#line hidden
#nullable disable
                        WriteLiteral(" - ");
#nullable restore
#line 56 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
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
#line 56 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
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
#line 57 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                       
                  }

#line default
#line hidden
#nullable disable
                    WriteLiteral("              ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 51 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IDevent);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </div>\r\n          <div class=\"col-md-6 mb-3 form-group\" >\r\n            <label for=\"Korting\">Speciale korting</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9c226483f704d15c5e504be0d3ec187c8f8b17530703", async() => {
                    WriteLiteral("\r\n              ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9c226483f704d15c5e504be0d3ec187c8f8b17530986", async() => {
                        WriteLiteral("Geen");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_11.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
               if(TicketDiscounts != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                     foreach (var TicketDiscount in TicketDiscounts)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9c226483f704d15c5e504be0d3ec187c8f8b17532865", async() => {
#nullable restore
#line 69 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                                                      Write(TicketDiscount.description);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                           WriteLiteral(TicketDiscount.ID);

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
#line 70 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 63 "C:\Users\yassine.000\Documents\GitHub\Bioscoop\Bioscoop\Views\Events\EventsMovieFilter.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IDdiscount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </div>\r\n        </div>\r\n             <div class=\"col-md-2 mb-3\">\r\n                <button class=\"btn btn-primary btn-lg btn-block\" type=\"submit\">Volgende</button>\r\n          </div>\r\n      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n  </div>\r\n</div>\r\n    <hr>\r\n    <hr>\r\n    <hr>\r\n\r\n");
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
