#pragma checksum "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23ed82665c0bb0e77f3f64feea3f8ccfc2af2cb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CRUD_AllFounders), @"mvc.1.0.view", @"/Views/CRUD/AllFounders.cshtml")]
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
#line 1 "C:\MyFirstTest\MyFirstTest\Views\_ViewImports.cshtml"
using MyFirstTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MyFirstTest\MyFirstTest\Views\_ViewImports.cshtml"
using MyFirstTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ed82665c0bb0e77f3f64feea3f8ccfc2af2cb7", @"/Views/CRUD/AllFounders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff66582b58425a9b369e62f7557674556468f528", @"/Views/_ViewImports.cshtml")]
    public class Views_CRUD_AllFounders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyFirstTest.Models.Founder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Все учредители</h1>\r\n        <h1 class=\"text-danger\" role=\"alert\">");
#nullable restore
#line 3 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
                                        Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <table class=\"table table-dark \">\r\n            <tr>\r\n                <td>Имя</td>\r\n                <td>Фамилия</td>\r\n                <td>ИНН</td>\r\n                <td></td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 12 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
             foreach (var founders in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ed82665c0bb0e77f3f64feea3f8ccfc2af2cb74866", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
AddHtmlAttributeValue("", 524, founders.FounderId, 524, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 598, "\"", 628, 1);
#nullable restore
#line 17 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 606, founders.CreationData, 606, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"CreationData\"");
            BeginWriteAttribute("form", " form=\"", 649, "\"", 675, 1);
#nullable restore
#line 17 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 656, founders.FounderId, 656, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 725, "\"", 753, 1);
#nullable restore
#line 18 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 733, founders.CustomerId, 733, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"CustomerId\"");
            BeginWriteAttribute("form", " form=\"", 772, "\"", 798, 1);
#nullable restore
#line 18 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 779, founders.FounderId, 779, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 848, "\"", 875, 1);
#nullable restore
#line 19 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 856, founders.FounderId, 856, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"FounderId\"");
            BeginWriteAttribute("form", " form=\"", 893, "\"", 919, 1);
#nullable restore
#line 19 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 900, founders.FounderId, 900, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 969, "\"", 997, 1);
#nullable restore
#line 20 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 977, founders.FounderITN, 977, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"OldITN\"");
            BeginWriteAttribute("form", " form=\"", 1012, "\"", 1038, 1);
#nullable restore
#line 20 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 1019, founders.FounderId, 1019, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input required type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1095, "\"", 1122, 1);
#nullable restore
#line 21 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 1103, founders.FirstName, 1103, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" name=\"FirstName\"");
            BeginWriteAttribute("form", " form=\"", 1161, "\"", 1187, 1);
#nullable restore
#line 21 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 1168, founders.FounderId, 1168, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </td>\r\n                    <td>\r\n                        <input required type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1295, "\"", 1321, 1);
#nullable restore
#line 24 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 1303, founders.LastName, 1303, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" name=\"LastName\"");
            BeginWriteAttribute("form", " form=\"", 1359, "\"", 1385, 1);
#nullable restore
#line 24 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 1366, founders.FounderId, 1366, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </td>\r\n\r\n                    <td>\r\n                        <input required type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1495, "\"", 1523, 1);
#nullable restore
#line 28 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 1503, founders.FounderITN, 1503, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" name=\"FounderITN\"");
            BeginWriteAttribute("form", " form=\"", 1563, "\"", 1589, 1);
#nullable restore
#line 28 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 1570, founders.FounderId, 1570, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </td>\r\n                    <td><button type=\"submit\" class=\"btn btn-primary\"");
            BeginWriteAttribute("form", " form=\"", 1689, "\"", 1715, 1);
#nullable restore
#line 30 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
WriteAttributeValue("", 1696, founders.FounderId, 1696, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Изменить</button></td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ed82665c0bb0e77f3f64feea3f8ccfc2af2cb712754", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1798, "~/CRUD/RemoveFounders/", 1798, 22, true);
#nullable restore
#line 31 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"
AddHtmlAttributeValue("", 1820, founders.FounderId, 1820, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\MyFirstTest\MyFirstTest\Views\CRUD\AllFounders.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyFirstTest.Models.Founder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
