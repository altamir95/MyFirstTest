#pragma checksum "C:\Users\Администратор\source\repos\MyFirstTest\MyFirstTest\Views\Home\UpdateFounders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea0585e81eea0f5fa8014f7515276fc7686546b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UpdateFounders), @"mvc.1.0.view", @"/Views/Home/UpdateFounders.cshtml")]
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
#line 1 "C:\Users\Администратор\source\repos\MyFirstTest\MyFirstTest\Views\_ViewImports.cshtml"
using MyFirstTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Администратор\source\repos\MyFirstTest\MyFirstTest\Views\_ViewImports.cshtml"
using MyFirstTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea0585e81eea0f5fa8014f7515276fc7686546b8", @"/Views/Home/UpdateFounders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff66582b58425a9b369e62f7557674556468f528", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UpdateFounders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyFirstTest.Models.Founders>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    <h1>Обновите бланк учредителя</h1>\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Администратор\source\repos\MyFirstTest\MyFirstTest\Views\Home\UpdateFounders.cshtml"
     foreach (var founders in Model)
    {
        if (founders.FoundersId == ViewBag.FoundersId)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea0585e81eea0f5fa8014f7515276fc7686546b83976", async() => {
                WriteLiteral("\r\n                <!-- Клиент -->\r\n                <!-- ИНН -->\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 338, "\"", 365, 1);
#nullable restore
#line 12 "C:\Users\Администратор\source\repos\MyFirstTest\MyFirstTest\Views\Home\UpdateFounders.cshtml"
WriteAttributeValue("", 346, ViewBag.FoundersId, 346, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"FoundersId\" />\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleInputITN\">ИНН</label>\r\n                    <input required type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 542, "\"", 563, 1);
#nullable restore
#line 15 "C:\Users\Администратор\source\repos\MyFirstTest\MyFirstTest\Views\Home\UpdateFounders.cshtml"
WriteAttributeValue("", 550, founders.ITN, 550, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" name=""ITN"" id=""exampleInputITN"" pattern=""\d{10}"">
                </div>
                <!-- Наиминование -->
                <div class=""form-group"">
                    <label for=""exampleInputCustomerName"">Имя</label>
                    <input required type=""text""");
                BeginWriteAttribute("value", " value=\"", 860, "\"", 887, 1);
#nullable restore
#line 20 "C:\Users\Администратор\source\repos\MyFirstTest\MyFirstTest\Views\Home\UpdateFounders.cshtml"
WriteAttributeValue("", 868, founders.FirstName, 868, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" name=""FirstName"" id=""exampleInputCustomerName"">
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputCustomerName"">Фамилия</label>
                    <input required type=""text""");
                BeginWriteAttribute("value", " value=\"", 1147, "\"", 1173, 1);
#nullable restore
#line 24 "C:\Users\Администратор\source\repos\MyFirstTest\MyFirstTest\Views\Home\UpdateFounders.cshtml"
WriteAttributeValue("", 1155, founders.LastName, 1155, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" name=\"LastName\" id=\"exampleInputCustomerName\">\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Изменить</button>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Администратор\source\repos\MyFirstTest\MyFirstTest\Views\Home\UpdateFounders.cshtml"
        }

    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyFirstTest.Models.Founders>> Html { get; private set; }
    }
}
#pragma warning restore 1591