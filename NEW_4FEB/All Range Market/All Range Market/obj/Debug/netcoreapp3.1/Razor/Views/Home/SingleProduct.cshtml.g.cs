#pragma checksum "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\SingleProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d18b10259e653729b11f864a178400b286a9dad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SingleProduct), @"mvc.1.0.view", @"/Views/Home/SingleProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d18b10259e653729b11f864a178400b286a9dad", @"/Views/Home/SingleProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f8aec55724d050ab3e99763102476ceed82a33", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SingleProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<All_Range_Market.Models.Product>
    {
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
            WriteLiteral(@"
    <div class=""cont span_2_of_3"">
        <div class=""labout span_1_of_a1"">
            <ul id=""etalage"">
                <li>
                    <a href=""optionallink.html"">
                        <img class=""etalage_thumb_image"" src=""images/t1.jpg "" />
                        <img class=""etalage_source_image"" src=""images/t2.jpg"" />
                    </a>
                </li>
                <li>
                    <img class=""etalage_thumb_image"" src=""images/t2.jpg"" />
                    <img class=""etalage_source_image"" src=""images/t2.jpg"" />
                </li>
            </ul>
        </div>
        <div class=""cont1 span_2_of_a1"">
            <h3 class=""m_3"">");
#nullable restore
#line 19 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\SingleProduct.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n            <div class=\"price_single\">\r\n                <span class=\"actual\">");
#nullable restore
#line 22 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\SingleProduct.cshtml"
                                Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span><a href=""#"">Заказать</a>
            </div>
            <ul class=""options"">
                <h4 class=""m_9"">Выберите размер</h4>
                <!-- avaible sizes for--> <li><a href=""#"">6</a></li>
                <div class=""clear""></div>
            </ul>
            <div class=""btn_form"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d18b10259e653729b11f864a178400b286a9dad5206", async() => {
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Быстрая покупка\"");
                BeginWriteAttribute("title", " title=\"", 1248, "\"", 1256, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <ul class=\"add-to-links\">\r\n                <li><img src=\"images/wish.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1390, "\"", 1396, 0);
            EndWriteAttribute();
            WriteLiteral(" /><a href=\"#\">В избранное</a></li>\r\n            </ul>\r\n            <p class=\"m_desc\">");
#nullable restore
#line 37 "C:\Users\akant\source\repos\All Range Market\All Range Market\Views\Home\SingleProduct.cshtml"
                         Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

            <div class=""social_single"">
                <ul>
                    <li class=""fb""><a href=""#""><span> </span></a></li>
                    <li class=""tw""><a href=""#""><span> </span></a></li>
                    <li class=""g_plus""><a href=""#""><span> </span></a></li>
                    <li class=""rss""><a href=""#""><span> </span></a></li>
                </ul>
            </div>
        </div>
        <div class=""clear""></div>


        <ul id=""flexiselDemo3"">
            <!-- Familliar foreach-->
            <li><img src=""images/pic11.jpg"" /><div class=""grid-flex""><a href=""#"">Bloch</a><p>Rs 850</p></div></li>
        </ul>
        <script type=""text/javascript"">
		 $(window).load(function() {
			$(""#flexiselDemo1"").flexisel();
			$(""#flexiselDemo2"").flexisel({
				enableResponsiveBreakpoints: true,
		    	responsiveBreakpoints: {
		    		portrait: {
		    			changePoint:480,
		    			visibleItems: 1
		    		},
		    		landscape: {
		    			changePoint:640,
		    	");
            WriteLiteral(@"		visibleItems: 2
		    		},
		    		tablet: {
		    			changePoint:768,
		    			visibleItems: 3
		    		}
		    	}
		    });

			$(""#flexiselDemo3"").flexisel({
				visibleItems: 5,
				animationSpeed: 1000,
				autoPlay: true,
				autoPlaySpeed: 3000,
				pauseOnHover: true,
				enableResponsiveBreakpoints: true,
		    	responsiveBreakpoints: {
		    		portrait: {
		    			changePoint:480,
		    			visibleItems: 1
		    		},
		    		landscape: {
		    			changePoint:640,
		    			visibleItems: 2
		    		},
		    		tablet: {
		    			changePoint:768,
		    			visibleItems: 3
		    		}
		    	}
		    });

		});
        </script>
        <script type=""text/javascript"" src=""js/jquery.flexisel.js""></script>
        <div class=""toogle"">
            <h3 class=""m_3"">Характеристики</h3>
            <p class=""m_text"">Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim");
            WriteLiteral(@" veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum.</p>
        </div>
        <!-- Comments section-->
    </div>
    <div class=""clear""></div>
");
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