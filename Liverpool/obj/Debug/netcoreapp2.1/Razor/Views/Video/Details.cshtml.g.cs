#pragma checksum "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1081ee2f01e8d9e68fd4fa0e9837973a643e4a99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Video_Details), @"mvc.1.0.view", @"/Views/Video/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Video/Details.cshtml", typeof(AspNetCore.Views_Video_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1081ee2f01e8d9e68fd4fa0e9837973a643e4a99", @"/Views/Video/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf89978fd76ec1c0bea808e640f7600111cc7c70", @"/Views/_ViewImports.cshtml")]
    public class Views_Video_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Video", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 445, true);
            WriteLiteral(@"

<section id=""news"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 text-center"">
                <h3>İcmallar</h3>
            </div>
        </div>
    </div>
</section>

<section id=""game-video"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 col-md-8"">
                <div class=""main-video"">
                    <iframe width=""100%"" height=""450""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 515, "\"", 546, 1);
#line 23 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
WriteAttributeValue("", 521, Model.OneVideo.VideoLink, 521, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(547, 369, true);
            WriteLiteral(@"
                            frameborder=""0""
                            allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture""
                            allowfullscreen></iframe>
                </div>
            </div>
            <div class=""col-12 col-md-4"">
                <div class=""main-video-info"">
                    <h3>");
            EndContext();
            BeginContext(917, 20, false);
#line 31 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
                   Write(Model.OneVideo.Title);

#line default
#line hidden
            EndContext();
            BeginContext(937, 31, true);
            WriteLiteral("</h3>\r\n                    <h6>");
            EndContext();
            BeginContext(969, 28, false);
#line 32 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
                   Write(Model.OneVideo.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(997, 56, true);
            WriteLiteral("</h6>\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(1054, 23, false);
#line 34 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
                   Write(Model.OneVideo.MainInfo);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 72, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 38 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
             foreach (var v in Model.Videos)
            {
                if (v.Id != Model.OneVideo.Id)
                {

#line default
#line hidden
            BeginContext(1277, 93, true);
            WriteLiteral("                    <div class=\"col-12 col-sm-6 col-md-4 col-lg-3\">\r\n                        ");
            EndContext();
            BeginContext(1370, 819, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b877c29a19e4e71857acfee6988cdc7", async() => {
                BeginContext(1438, 155, true);
                WriteLiteral("\r\n                            <div class=\"last-content\">\r\n\r\n                                <div class=\"last-images\">\r\n                                    ");
                EndContext();
                BeginContext(1593, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b597b6d0c1804fe9b4ea0ecd2f11192a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1603, "~/images/", 1603, 9, true);
#line 47 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
AddHtmlAttributeValue("", 1612, v.PhotoURL, 1612, 11, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1632, 105, true);
                WriteLiteral("\r\n                                    <div class=\"img-info\">\r\n                                        <p>");
                EndContext();
                BeginContext(1738, 15, false);
#line 49 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
                                      Write(v.Category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1753, 259, true);
                WriteLiteral(@"</p>
                                    </div>
                                    <i class=""far fa-play-circle""></i>
                                </div>
                                <div class=""last-info"">
                                    <h4>");
                EndContext();
                BeginContext(2013, 7, false);
#line 54 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
                                   Write(v.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2020, 49, true);
                WriteLiteral("</h4>\r\n                                    <span>");
                EndContext();
                BeginContext(2070, 6, false);
#line 55 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
                                     Write(v.Time);

#line default
#line hidden
                EndContext();
                BeginContext(2076, 109, true);
                WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
                                                                         WriteLiteral(v.Id);

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
            BeginContext(2189, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 60 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2253, 18, true);
            WriteLiteral("        </div>\r\n\r\n");
            EndContext();
#line 64 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
         if (ViewBag.Count > 13)
        {

#line default
#line hidden
            BeginContext(2316, 257, true);
            WriteLiteral(@"            <div class=""row mt-5"">
                <div class=""col-12 text-center"">
                    <div class=""btn-load-more"">
                        <a href=""#"">Daha Çox</a>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 73 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Video\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2584, 22, true);
            WriteLiteral("    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
