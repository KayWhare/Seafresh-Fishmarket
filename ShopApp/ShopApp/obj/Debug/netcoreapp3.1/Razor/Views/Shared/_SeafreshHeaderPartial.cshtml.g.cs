#pragma checksum "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5c52c61fca9b0ce84cf204d605da122d50b47f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SeafreshHeaderPartial), @"mvc.1.0.view", @"/Views/Shared/_SeafreshHeaderPartial.cshtml")]
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
#line 1 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/_ViewImports.cshtml"
using ShopApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5c52c61fca9b0ce84cf204d605da122d50b47f2", @"/Views/Shared/_SeafreshHeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec183dece9586ba1fd2fbc1be192ad39c04892c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SeafreshHeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Snapper-Medium-Whole.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/newlogoWhite.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""container"">
    <div class=""header"" id=""nav"">
        <div id='hamburger'>
            <input type=""checkbox"" class=""openSidebarMenu"" id=""openSidebarMenu"">
            <label for=""openSidebarMenu"" class=""sidebarIconToggle"">
                <div class=""spinner diagonal part-1""></div>
                <div class=""spinner horizontal""></div>
                <div class=""spinner diagonal part-2""></div>
            </label>
            <label id=""menuLabel"" for=""openSidebarMenu"">Menu</label>
        </div>

        <div class=""back-shader"">
            <img src=""/images/newlogoWhite.png"" id=""logo-sm""");
            BeginWriteAttribute("alt", " alt=\"", 626, "\"", 632, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5c52c61fca9b0ce84cf204d605da122d50b47f26144", async() => {
                WriteLiteral("\r\n            <input type=\"text\" class=\"text search-input\" placeholder=\"Type here to search...\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <label for=\"search-input\" id=\"searchIcon\"");
            BeginWriteAttribute("href", " href=\"", 863, "\"", 870, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-search\"></i></label>\r\n        <a id=\"cartLink\"");
            BeginWriteAttribute("href", " href=\"", 935, "\"", 978, 1);
#nullable restore
#line 22 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 942, Url.Action("index", "SeafreshCart"), 942, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-shopping-cart\"></i></a>\r\n    </div>\r\n\r\n    <div id=\"sidebarMenu\"");
            BeginWriteAttribute("class", " class=\"", 1061, "\"", 1069, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <ul class=\"sidebarMenuInner\">\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1130, "\"", 1173, 1);
#nullable restore
#line 27 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 1137, Url.Action("index", "SeafreshHome"), 1137, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1208, "\"", 1215, 0);
            EndWriteAttribute();
            WriteLiteral(">Link2</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1251, "\"", 1258, 0);
            EndWriteAttribute();
            WriteLiteral(">Link3</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1294, "\"", 1301, 0);
            EndWriteAttribute();
            WriteLiteral(">About Us</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1340, "\"", 1347, 0);
            EndWriteAttribute();
            WriteLiteral(">Contact</a></li>\r\n        </ul>\r\n\r\n        <br>\r\n\r\n        <ul id=\"sidebarCategories\" class=\"sidebarMenuInner\">\r\n            <li>\r\n                <h4>Product Categories</h4>\r\n            </li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1562, "\"", 1640, 1);
#nullable restore
#line 40 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 1569, Url.Action("Category", "SeafreshStore",new { category = "Wholefish" }), 1569, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Whole</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1676, "\"", 1752, 1);
#nullable restore
#line 41 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 1683, Url.Action("Category", "SeafreshStore",new { category = "Fillets" }), 1683, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Fillet</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1789, "\"", 1869, 1);
#nullable restore
#line 42 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 1796, Url.Action("Category", "SeafreshStore",new { category = "Crustaceans" }), 1796, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Crustaceans</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1911, "\"", 1989, 1);
#nullable restore
#line 43 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 1918, Url.Action("Category", "SeafreshStore",new { category = "Shellfish" }), 1918, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Shellfish</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 2029, "\"", 2104, 1);
#nullable restore
#line 44 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 2036, Url.Action("Category", "SeafreshStore",new { category = "Caviar" }), 2036, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Caviar</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 2141, "\"", 2215, 1);
#nullable restore
#line 45 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 2148, Url.Action("Category", "SeafreshStore",new { category = "Sushi" }), 2148, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Sushi</a></li>

        </ul>

    </div>

    <div class=""cart-quickview"">
        <div class=""quickview-container"">

            <div class=""cart-item"">

                <div class=""cart-item-button-wrapper"">
                    <span class=""cart-item-delete-btn""><i class=""fas fa-times-circle""></i></span>
                </div>

                <div class=""cart-item-image"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5c52c61fca9b0ce84cf204d605da122d50b47f213105", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>

                <div class=""cart-item-description"">
                    <span class=""item-category"">Red Emperor</span>
                    <span></span>
                    <span></span>
                </div>

                <div class=""cart-item-quantity"">
                    <button class=""minus-btn"" type=""button"" name=""button"">
                        <i class=""far fa-minus-square""></i>
                    </button>
                    <input type=""number"" name=""quantitiy-btn"" value=""1"">
                    <button class=""plus-btn"" type=""button"" name=""button"">
                        <i class=""far fa-plus-square""></i>
                    </button>
                </div>

                <span class=""cart-item-price"">$50.00</span>

            </div>

            <div class=""total-section"">
                <span>Total</span>
                <span class=""total-price"">$200.00</span>
            </div>

        </div>
    </div>

    <div class=""banner-");
            WriteLiteral("outer\">\r\n        <div class=\"banner\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d5c52c61fca9b0ce84cf204d605da122d50b47f215348", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <h4>Now delivering</h4>\r\n            <input type=\"button\" value=\"Details\">\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
