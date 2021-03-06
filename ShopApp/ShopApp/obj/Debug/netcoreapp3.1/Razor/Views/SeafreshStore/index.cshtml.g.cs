#pragma checksum "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e5285c27040f4154de9e655b0f97485837eae04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SeafreshStore_index), @"mvc.1.0.view", @"/Views/SeafreshStore/index.cshtml")]
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
#line 1 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
using ShopApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e5285c27040f4154de9e655b0f97485837eae04", @"/Views/SeafreshStore/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec183dece9586ba1fd2fbc1be192ad39c04892c", @"/Views/_ViewImports.cshtml")]
    public class Views_SeafreshStore_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/SeafreshStore/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("shop-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
  
    Layout = "_SeafreshLayout";

    string title;
    int itemQuantity = 1;

    var products = (List<Product>)ViewData["Products"];
    var cartItems = (List<CartItem>)ViewData["CartItems"];


    if(products == null)
    {
        title = "Seafresh Store";
    }
    else if(products.First().Category == products.Last().Category)
    {
        title = products.First().Category.ToString();
    }
    else
    {
        title = "Seafresh Store";
    }



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>");
#nullable restore
#line 29 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
    Write(Html.Partial("_QuickviewCartPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n<div class=\"shop-container\">\r\n\r\n    <h1>");
#nullable restore
#line 34 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
   Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <div class=\"product-gallery\">\r\n\r\n");
#nullable restore
#line 38 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
         foreach (var p in products)
        {


            if (p.DiscountPrice != null)
            {

                var itemTotal = p.DiscountPrice * itemQuantity;


#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e5285c27040f4154de9e655b0f97485837eae045829", async() => {
                WriteLiteral("\r\n\r\n                    <span class=\"special-tag\">Special</span>\r\n\r\n                    <img class=\"shop-item-image\"");
                BeginWriteAttribute("src", " src=\"", 1027, "\"", 1045, 1);
#nullable restore
#line 51 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
WriteAttributeValue("", 1033, p.ImagePath, 1033, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1046, "\"", 1060, 1);
#nullable restore
#line 51 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
WriteAttributeValue("", 1052, p.Title, 1052, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                    <h3>");
#nullable restore
#line 53 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
                   Write(p.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n                    <p class=\"shop-item-product-description\">\r\n                        ");
#nullable restore
#line 56 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
                   Write(p.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </p>\r\n\r\n                    <input type=\"hidden\" name=\"itemPrice\"");
                BeginWriteAttribute("value", " value=\"", 1297, "\"", 1321, 1);
#nullable restore
#line 59 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
WriteAttributeValue("", 1305, p.DiscountPrice, 1305, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                    <div class=\"shop-item-quantity\">\r\n                        <input type=\"hidden\" name=\"ProductID\"");
                BeginWriteAttribute("value", " value=\"", 1442, "\"", 1455, 1);
#nullable restore
#line 62 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
WriteAttributeValue("", 1450, p.Id, 1450, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <button onclick=""minusbtn(event)"" class=""minus-btn"" type=""button"" name=""button"">
                            <i class=""far fa-minus-square""></i>
                        </button>
                        <input class=""quantity-input"" type=""number"" name=""Quantity""");
                BeginWriteAttribute("value", " value=\"", 1748, "\"", 1769, 1);
#nullable restore
#line 66 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
WriteAttributeValue("", 1756, itemQuantity, 1756, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <button onclick=""plusbtn(event)"" class=""plus-btn"" type=""button"" name=""button"">
                            <i class=""far fa-plus-square""></i>
                        </button>
                    </div>

                    <p>Price: $<span class=""shop-item-price"">");
#nullable restore
#line 72 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
                                                        Write(itemTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n\r\n                    <div class=\"add-cart-btn flex-center-style\">\r\n                        <input class=\"addToCart\" type=\"submit\" value=\"ADD TO CART\">\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 78 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
            }
            else
            {

                var itemTotal = p.Price * itemQuantity;


#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e5285c27040f4154de9e655b0f97485837eae0411620", async() => {
                WriteLiteral("\r\n\r\n                    <span class=\"special-tag\"></span>\r\n\r\n                    <img class=\"shop-item-image\"");
                BeginWriteAttribute("src", " src=\"", 2593, "\"", 2611, 1);
#nullable restore
#line 88 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
WriteAttributeValue("", 2599, p.ImagePath, 2599, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2612, "\"", 2626, 1);
#nullable restore
#line 88 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
WriteAttributeValue("", 2618, p.Title, 2618, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                    <h3>");
#nullable restore
#line 90 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
                   Write(p.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n                    <p class=\"shop-item-product-description\">\r\n                        ");
#nullable restore
#line 93 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
                   Write(p.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </p>\r\n\r\n                    <input type=\"hidden\" name=\"itemPrice\"");
                BeginWriteAttribute("value", " value=\"", 2863, "\"", 2879, 1);
#nullable restore
#line 96 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
WriteAttributeValue("", 2871, p.Price, 2871, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                    <div class=\"shop-item-quantity\">\r\n                        <input type=\"hidden\" name=\"ProductID\"");
                BeginWriteAttribute("value", " value=\"", 3000, "\"", 3013, 1);
#nullable restore
#line 99 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
WriteAttributeValue("", 3008, p.Id, 3008, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <button onclick=""minusbtn(event)"" class=""minus-btn"" type=""button"" name=""button"">
                            <i class=""far fa-minus-square""></i>
                        </button>
                        <input class=""quantity-input"" type=""number"" name=""Quantity"" value=""1"">
                        <button onclick=""plusbtn(event)"" class=""plus-btn"" type=""button"" name=""button"">
                            <i class=""far fa-plus-square""></i>
                        </button>
                    </div>

                    <p>Price: $<span class=""shop-item-price"">");
#nullable restore
#line 109 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
                                                        Write(p.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n\r\n\r\n                    <div class=\"add-cart-btn flex-center-style\">\r\n                        <input class=\"addToCart\" type=\"submit\" value=\"ADD TO CART\">\r\n                    </div>\r\n\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 118 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/SeafreshStore/index.cshtml"
            }


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
