#pragma checksum "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c7ddc2fae237f7f8c17633903b85aa944f7fca8"
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
#nullable restore
#line 1 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
using ShopApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7ddc2fae237f7f8c17633903b85aa944f7fca8", @"/Views/Shared/_SeafreshHeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec183dece9586ba1fd2fbc1be192ad39c04892c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SeafreshHeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
  
    var cartItems = (List<CartItem>)ViewData["CartItems"];

#line default
#line hidden
#nullable disable
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
            BeginWriteAttribute("alt", " alt=\"", 720, "\"", 726, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c7ddc2fae237f7f8c17633903b85aa944f7fca85042", async() => {
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
            BeginWriteAttribute("href", " href=\"", 957, "\"", 964, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-search\"></i></label>\r\n        <a id=\"cartLink\"");
            BeginWriteAttribute("href", " href=\"", 1029, "\"", 1072, 1);
#nullable restore
#line 28 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 1036, Url.Action("index", "SeafreshCart"), 1036, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-shopping-cart\"></i></a>\r\n    </div>\r\n\r\n    <div id=\"sidebarMenu\"");
            BeginWriteAttribute("class", " class=\"", 1155, "\"", 1163, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <ul class=\"sidebarMenuInner\">\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1224, "\"", 1267, 1);
#nullable restore
#line 33 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 1231, Url.Action("index", "SeafreshHome"), 1231, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1302, "\"", 1346, 1);
#nullable restore
#line 34 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 1309, Url.Action("index", "SeafreshStore"), 1309, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Store</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1382, "\"", 1389, 0);
            EndWriteAttribute();
            WriteLiteral(">Link3</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1425, "\"", 1432, 0);
            EndWriteAttribute();
            WriteLiteral(">About Us</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1471, "\"", 1478, 0);
            EndWriteAttribute();
            WriteLiteral(">Contact</a></li>\r\n        </ul>\r\n\r\n        <br>\r\n\r\n        <ul id=\"sidebarCategories\" class=\"sidebarMenuInner\">\r\n            <li>\r\n                <h4>Product Categories</h4>\r\n            </li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1693, "\"", 1771, 1);
#nullable restore
#line 46 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 1700, Url.Action("Category", "SeafreshStore",new { category = "Wholefish" }), 1700, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Whole</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1807, "\"", 1883, 1);
#nullable restore
#line 47 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 1814, Url.Action("Category", "SeafreshStore",new { category = "Fillets" }), 1814, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Fillet</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 1920, "\"", 2000, 1);
#nullable restore
#line 48 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 1927, Url.Action("Category", "SeafreshStore",new { category = "Crustaceans" }), 1927, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Crustaceans</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 2042, "\"", 2120, 1);
#nullable restore
#line 49 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 2049, Url.Action("Category", "SeafreshStore",new { category = "Shellfish" }), 2049, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Shellfish</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 2160, "\"", 2235, 1);
#nullable restore
#line 50 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 2167, Url.Action("Category", "SeafreshStore",new { category = "Caviar" }), 2167, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Caviar</a></li>\r\n            <li><a");
            BeginWriteAttribute("href", " href=\"", 2272, "\"", 2346, 1);
#nullable restore
#line 51 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Shared/_SeafreshHeaderPartial.cshtml"
WriteAttributeValue("", 2279, Url.Action("Category", "SeafreshStore",new { category = "Sushi" }), 2279, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sushi</a></li>\r\n\r\n        </ul>\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
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
