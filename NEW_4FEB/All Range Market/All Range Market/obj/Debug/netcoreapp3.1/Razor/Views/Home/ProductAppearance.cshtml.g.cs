#pragma checksum "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7bf6909b7ff64f5f8459178c480e1692052f536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductAppearance), @"mvc.1.0.view", @"/Views/Home/ProductAppearance.cshtml")]
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
#line 1 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\_ViewImports.cshtml"
using All_Range_Market.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\_ViewImports.cshtml"
using All_Range_Market.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\_ViewImports.cshtml"
using All_Range_Market.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7bf6909b7ff64f5f8459178c480e1692052f536", @"/Views/Home/ProductAppearance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f8aec55724d050ab3e99763102476ceed82a33", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductAppearance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<All_Range_Market.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SingleProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(" \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7bf6909b7ff64f5f8459178c480e1692052f5364019", async() => {
                WriteLiteral("\r\n    <div class=\"view view-fifth\">\r\n        <div class=\"top_box\">\r\n            <h3 class=\"m_1\">");
#nullable restore
#line 6 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n            <p class=\"m_2\">");
#nullable restore
#line 7 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
                      Write(Model.Vendor.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n            <div class=\"grid_img\">\r\n                <div class=\"css3\"><img");
                BeginWriteAttribute("src", " src=\"", 413, "\"", 440, 1);
#nullable restore
#line 9 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
WriteAttributeValue("", 419, Model.Images[0].Path, 419, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 441, "\"", 447, 0);
                EndWriteAttribute();
                WriteLiteral(" /></div>\r\n                <div class=\"mask\">\r\n                    <div class=\"info\">Быстрый просмотр</div>\r\n                </div>\r\n            </div>\r\n            <div class=\"price\">");
#nullable restore
#line 14 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
                          Write(Model.Price.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("ru-ru")));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n    <span class=\"rating\">\r\n");
#nullable restore
#line 18 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
           for (int i = 5; i > 0; i--)
            {
                if (5 - Model.Vendor.TrustRate >= i)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"radio\" class=\"rating-input\"");
                BeginWriteAttribute("id", " id=\"", 967, "\"", 989, 2);
                WriteAttributeValue("", 972, "rating-input-1-", 972, 15, true);
#nullable restore
#line 22 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
WriteAttributeValue("", 987, i, 987, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"rating-input-1\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1041, "\"", 1064, 2);
                WriteAttributeValue("", 1047, "rating-input-1-", 1047, 15, true);
#nullable restore
#line 23 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
WriteAttributeValue("", 1062, i, 1062, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rating-star\"></label>\r\n");
#nullable restore
#line 24 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"radio\" class=\"rating-input\"");
                BeginWriteAttribute("id", " id=\"", 1216, "\"", 1238, 2);
                WriteAttributeValue("", 1221, "rating-input-1-", 1221, 15, true);
#nullable restore
#line 27 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
WriteAttributeValue("", 1236, i, 1236, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"rating-input-1\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1290, "\"", 1313, 2);
                WriteAttributeValue("", 1296, "rating-input-1-", 1296, 15, true);
#nullable restore
#line 28 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
WriteAttributeValue("", 1311, i, 1311, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rating-star1\"></label>\r\n");
#nullable restore
#line 29 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        (45)\r\n    </span>\r\n    <ul class=\"list\">\r\n        <li>\r\n            <img src=\"images/plus.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1493, "\"", 1499, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
            <ul class=""icon1 sub-icon1 profile_img"">
                <li>
                    <a class=""active-icon c1"" href=""#"">В корзину </a>
                    <ul class=""sub-icon1 list"">
                        <li><h3>sed diam nonummy</h3><a");
                BeginWriteAttribute("href", " href=\"", 1756, "\"", 1763, 0);
                EndWriteAttribute();
                WriteLiteral("></a></li>\r\n                        <li><p>");
#nullable restore
#line 42 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
                          Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></li>\r\n                    </ul>\r\n                </li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    <div class=\"clear\"></div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-brand", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 3 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
                                                         WriteLiteral(Model.Vendor.Brand);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brand"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-brand", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brand"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 3 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\ProductAppearance.cshtml"
                                                                                                   WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<All_Range_Market.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
