#pragma checksum "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf19c1ab46234f7043ac487909c5cb1a63029903"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
using ShopApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf19c1ab46234f7043ac487909c5cb1a63029903", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec183dece9586ba1fd2fbc1be192ad39c04892c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
  
    var cartItems = (List<CartItem>)ViewData["CartItems"];
    var totalCartItemQuantities = cartItems.Sum(ci => ci.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
Write(Html.Partial("_UserSummaryPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"cart-section\">\n    <div class=\"validation-summary\">\n        ");
#nullable restore
#line 11 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"cart-container\">\n        <h1>Basket</h1>\n");
#nullable restore
#line 15 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
         if (totalCartItemQuantities == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>No items in cart</h4>\n");
#nullable restore
#line 18 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
        }
        else
        {
            foreach (var item in cartItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf19c1ab46234f7043ac487909c5cb1a630299035620", async() => {
                WriteLiteral("\n                    <strong>");
#nullable restore
#line 24 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
                       Write(item.Product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> ");
#nullable restore
#line 24 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
                                                     Write($"x{item.Quantity}");

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 741, "\"", 764, 1);
#nullable restore
#line 25 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
WriteAttributeValue("", 749, item.ProductId, 749, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    <input type=\"submit\" value=\"Remove\" />\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 28 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>TOTAL = ");
#nullable restore
#line 29 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
                   Write(totalCartItemQuantities);

#line default
#line hidden
#nullable disable
            WriteLiteral(" items</h4>\n");
#nullable restore
#line 30 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <div class=\"payment-container\">\n        <h1>Pay Now</h1>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf19c1ab46234f7043ac487909c5cb1a630299038912", async() => {
                WriteLiteral(@"
            <div id=""card-element"">
                <!-- Elements will create input elements here -->
            </div>

            <!-- We'll put the error messages in this element -->
            <div id=""card-errors"" role=""alert""></div>

            <button id=""submit"">Pay</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</section>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://js.stripe.com/v3/""></script>
    <script>
        // Set your publishable key: remember to change this to your live publishable key in production
        // See your keys here: https://dashboard.stripe.com/account/apikeys
        var stripe = Stripe('pk_test_SDBRLigKpRgzRoPqZL99TMdl');
        var elements = stripe.elements();

        // Set up Stripe.js and Elements to use in checkout form
        var style = {
            base: {
                color: ""#32325d"",
            }
        };

        var card = elements.create(""card"", { style: style });
        card.mount(""#card-element"");

        card.addEventListener('change', function(event) {
            var displayError = document.getElementById('card-errors');
            if (event.error) {
                displayError.textContent = event.error.message;
            } else {
                displayError.textContent = '';
            }
        });

        var form = document.getElementById('payment-form');

        form.addEvent");
                WriteLiteral("Listener(\'submit\', function(ev) {\n            ev.preventDefault();\n            stripe.confirmCardPayment(\'");
#nullable restore
#line 78 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
                                  Write(ViewData["ClientSecret"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', {\n                payment_method: {\n                    card: card,\n                    billing_details: {\n                        name: \'");
#nullable restore
#line 82 "/Users/kwhare/Desktop/Dev/Team-2 Repo/ShopApp/ShopApp/Views/Cart/Index.cshtml"
                          Write(ViewData["LoggedInName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                    }
                }
            }).then(function(result) {
                if (result.error) {
                    // Show error to your customer (e.g., insufficient funds)
                    console.log(result.error.message);
                } else {
                    // The payment has been processed!
                    if (result.paymentIntent.status === 'succeeded') {
                        // Show a success message to your customer
                        // There's a risk of the customer closing the window before callback
                        // execution. Set up a webhook or plugin to listen for the
                        // payment_intent.succeeded event that handles any business critical
                        // post-payment actions.
                        alert('Payment success!');

                    }
                }
            });
        });
    </script>
");
            }
            );
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
