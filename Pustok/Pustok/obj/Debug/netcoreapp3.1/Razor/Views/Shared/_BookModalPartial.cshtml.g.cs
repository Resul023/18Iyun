#pragma checksum "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cd744244d658313dc1e8d6a8de7ace98c0f6745"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BookModalPartial), @"mvc.1.0.view", @"/Views/Shared/_BookModalPartial.cshtml")]
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
#line 1 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd744244d658313dc1e8d6a8de7ace98c0f6745", @"/Views/Shared/_BookModalPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8d2ec98bcfff3ea842b43546fdef4a1a134b952", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BookModalPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Books>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("poster-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<button type=""button"" class=""close modal-close-btn ml-auto"" data-dismiss=""modal"" aria-label=""Close"">
    <span aria-hidden=""true"">&times;</span>
</button>
<div class=""product-details-modal"">
    <div class=""row"">
        <div class=""col-lg-5"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4cd744244d658313dc1e8d6a8de7ace98c0f67454289", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 309, "~/upload/book/", 309, 14, true);
#nullable restore
#line 10 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
AddHtmlAttributeValue("", 323, Model.BookImages.FirstOrDefault(x=>x.PosterStatus == true)?.Name, 323, 65, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-lg-7 mt--30 mt-lg--30"">
            <div class=""product-details-info pl-lg--30 "">
                <p class=""tag-block"">Tags: <a href=""#"">Movado</a>, <a href=""#"">Omega</a></p>
                <h3 class=""product-title"">");
#nullable restore
#line 15 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <ul class=\"list-unstyled\">\r\n                    <li>Author: <span class=\"list-value\"> ");
#nullable restore
#line 17 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
                                                     Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li>Genre: <a href=\"#\" class=\"list-value font-weight-bold\">");
#nullable restore
#line 18 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
                                                                          Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    <li>Name: <span class=\"list-value\"> ");
#nullable restore
#line 19 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
                                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li>Page Size: <span class=\"list-value\"> ");
#nullable restore
#line 20 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
                                                        Write(Model.PageSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n\r\n                </ul>\r\n                <div class=\"price-block\">\r\n");
#nullable restore
#line 24 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
                     if (Model.DiscountPercent > 0)
                    {
                        double discountedPrice = Model.SalePrice * (100 - Model.DiscountPercent) / 100;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"price-new\">$");
#nullable restore
#line 27 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
                                            Write(discountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <del class=\"price-old\">$");
#nullable restore
#line 28 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
                                           Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n");
#nullable restore
#line 29 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"price-new\">$");
#nullable restore
#line 32 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
                                            Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 33 "C:\Users\User\Desktop\18Iyun\Pustok\Pustok\Views\Shared\_BookModalPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""rating-widget"">
                    <div class=""rating-block"">
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star ""></span>
                    </div>
                    <div class=""review-widget"">
                        <a href=""#"">(1 Reviews)</a> <span>|</span>
                        <a href=""#"">Write a review</a>
                    </div>
                </div>
                <article class=""product-details-article"">
                    <h4 class=""sr-only"">Product Summery</h4>
                    <p>
                        Long printed dress with thin adjustable straps. V-neckline and wiring under
                        the Dust with ruffles
                        at the b");
            WriteLiteral(@"ottom
                        of the
                        dress.
                    </p>
                </article>
                <div class=""add-to-cart-row"">
                    <div class=""count-input-block"">
                        <span class=""widget-label"">Qty</span>
                        <input type=""number"" class=""form-control text-center"" value=""1"">
                    </div>
                    <div class=""add-cart-btn"">
                        <a href=""#"" class=""btn btn-outlined--primary"">
                            <span class=""plus-icon"">+</span>Add to Cart
                        </a>
                    </div>
                </div>
                <div class=""compare-wishlist-row"">
                    <a href=""#"" class=""add-link""><i class=""fas fa-heart""></i>Add to Wish List</a>
                    <a href=""#"" class=""add-link""><i class=""fas fa-random""></i>Add to Compare</a>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""mo");
            WriteLiteral(@"dal-footer"">
    <div class=""widget-social-share"">
        <span class=""widget-label"">Share:</span>
        <div class=""modal-social-share"">
            <a href=""#"" class=""single-icon""><i class=""fab fa-facebook-f""></i></a>
            <a href=""#"" class=""single-icon""><i class=""fab fa-twitter""></i></a>
            <a href=""#"" class=""single-icon""><i class=""fab fa-youtube""></i></a>
            <a href=""#"" class=""single-icon""><i class=""fab fa-google-plus-g""></i></a>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Books> Html { get; private set; }
    }
}
#pragma warning restore 1591
