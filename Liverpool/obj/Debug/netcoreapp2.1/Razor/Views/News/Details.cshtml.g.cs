#pragma checksum "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa922d05693a0bff209d184aa770fdb027d072f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Details), @"mvc.1.0.view", @"/Views/News/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Details.cshtml", typeof(AspNetCore.Views_News_Details))]
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
#line 1 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\_ViewImports.cshtml"
using Liverpool;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\_ViewImports.cshtml"
using Liverpool.Models;

#line default
#line hidden
#line 3 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\_ViewImports.cshtml"
using Liverpool.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa922d05693a0bff209d184aa770fdb027d072f3", @"/Views/News/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf89978fd76ec1c0bea808e640f7600111cc7c70", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(71, 442, true);
            WriteLiteral(@"
<!-- Start Slide Section -->

<section id=""news-details"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 col-md-3""></div>
            <div class=""col-12 col-md-6"">
                <div class=""news-details-img"">
                    <i class=""fas fa-angle-left arrow-left position-absolute""></i>
                    <div class=""window"">
                        <ul class=""d-flex slider-lent"">
");
            EndContext();
#line 18 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
                             foreach (var p in Model.News.Photos)
                            {

#line default
#line hidden
            BeginContext(611, 74, true);
            WriteLiteral("                                <li>\r\n                                    ");
            EndContext();
            BeginContext(685, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f64936eb1ab4e8883de3ccee9a734a6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 695, "~/images/", 695, 9, true);
#line 21 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
AddHtmlAttributeValue("", 704, p.PhotoURL, 704, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(717, 41, true);
            WriteLiteral("\r\n                                </li>\r\n");
            EndContext();
#line 23 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
                            }

#line default
#line hidden
            BeginContext(789, 347, true);
            WriteLiteral(@"
                        </ul>
                    </div>
                    <i class=""fas fa-angle-right arrow-right position-absolute""></i>
                </div>
            </div>
            <div class=""col-12 col-md-3""></div>
            <div class=""col-12"">
                <div class=""news-details-info"">
                    <h4>");
            EndContext();
            BeginContext(1137, 16, false);
#line 33 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
                   Write(Model.News.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1153, 30, true);
            WriteLiteral("</h4>\r\n                    <p>");
            EndContext();
            BeginContext(1184, 19, false);
#line 34 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
                  Write(Model.News.MainInfo);

#line default
#line hidden
            EndContext();
            BeginContext(1203, 819, true);
            WriteLiteral(@" </p>
                </div>
                <div class=""fb-share-button mt-3"" data-href=""https://developers.facebook.com/docs/plugins/"" data-layout=""button"" data-size=""large""><a target=""_blank"" href=""https://www.facebook.com/sharer/sharer.php?u=https%3A%2F%2Fdevelopers.facebook.com%2Fdocs%2Fplugins%2F&amp;src=sdkpreparse"" class=""fb-xfbml-parse-ignore"">Paylaş</a></div>
            </div>
        </div>
    </div>
</section>

<!-- End Slide Section -->
<!-- Start Latest News -->

<section id=""latest-news"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""heading-section d-flex justify-content-between align-items-center"">
                    <h2>Son Xəbərlər :</h2>
                    <div class=""more"">
                        ");
            EndContext();
            BeginContext(2022, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "860b1d727068433bacca277ac690014a", async() => {
                BeginContext(2066, 8, true);
                WriteLiteral("Daha Çox");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2078, 122, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row mt-3\">\r\n");
            EndContext();
#line 58 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
             foreach (var n in Model.AllNews)
            {

#line default
#line hidden
            BeginContext(2262, 85, true);
            WriteLiteral("                <div class=\"col-12 col-sm-6 col-md-4 col-lg-3\">\r\n                    ");
            EndContext();
            BeginContext(2347, 716, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "502c78db70314e44bf724278ebf29a3e", async() => {
                BeginContext(2414, 141, true);
                WriteLiteral("\r\n                        <div class=\"last-content\">\r\n                            <div class=\"last-images\">\r\n                                ");
                EndContext();
                BeginContext(2555, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e2e836707ba4e3cabcc4499d65e404f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2565, "~/images/", 2565, 9, true);
#line 64 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
AddHtmlAttributeValue("", 2574, n.Photos.FirstOrDefault().PhotoURL, 2574, 35, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2618, 97, true);
                WriteLiteral("\r\n                                <div class=\"img-info\">\r\n                                    <p>");
                EndContext();
                BeginContext(2716, 15, false);
#line 66 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
                                  Write(n.Category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2731, 171, true);
                WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"last-info\">\r\n                                <h4>");
                EndContext();
                BeginContext(2903, 7, false);
#line 70 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
                               Write(n.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2910, 45, true);
                WriteLiteral("</h4>\r\n                                <span>");
                EndContext();
                BeginContext(2956, 6, false);
#line 71 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
                                 Write(n.Time);

#line default
#line hidden
                EndContext();
                BeginContext(2962, 97, true);
                WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
                                                                    WriteLiteral(n.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3063, 43, true);
            WriteLiteral("                 \r\n                </div>\r\n");
            EndContext();
#line 76 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\News\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(3121, 222, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- End Latest News -->\r\n\r\n<div id=\"fb-root\"></div>\r\n<script async defer crossorigin=\"anonymous\" src=\"https://connect.facebook.net/tr_TR/sdk.js#xfbml=1&version=v5.0\"></script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
