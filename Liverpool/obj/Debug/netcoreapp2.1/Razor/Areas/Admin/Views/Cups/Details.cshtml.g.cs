#pragma checksum "C:\Users\user\source\repos\Liverpool\Liverpool\Areas\Admin\Views\Cups\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01e54236ba16f9dea3d2f8d1d7fc9e156b7d5a1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cups_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Cups/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Cups/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Cups_Details))]
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
#line 1 "C:\Users\user\source\repos\Liverpool\Liverpool\Areas\Admin\_ViewImports.cshtml"
using Liverpool;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\Liverpool\Liverpool\Areas\Admin\_ViewImports.cshtml"
using Liverpool.Models;

#line default
#line hidden
#line 3 "C:\Users\user\source\repos\Liverpool\Liverpool\Areas\Admin\_ViewImports.cshtml"
using Liverpool.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e54236ba16f9dea3d2f8d1d7fc9e156b7d5a1f", @"/Areas/Admin/Views/Cups/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf89978fd76ec1c0bea808e640f7600111cc7c70", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Cups_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cup>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\user\source\repos\Liverpool\Liverpool\Areas\Admin\Views\Cups\Details.cshtml"
  Layout = "_AdminLayout";
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 488, true);
            WriteLiteral(@"
<div class=""page-container"">
    <div class=""main-content"">
        <div class=""section__content section__content--p30"">
            <div class=""container-fluid"">
                <section class=""wrapper"" style=""padding-bottom:50px;"">
                    <div class=""row"">
                        <div class=""col-3""></div>
                        <div class=""col-6 news-wrapper-slider"">
                            <div class=""news-details-img"">
                                ");
            EndContext();
            BeginContext(577, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5675f5d732a3441b830ffd288a2008ba", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 587, "~/images/", 587, 9, true);
#line 17 "C:\Users\user\source\repos\Liverpool\Liverpool\Areas\Admin\Views\Cups\Details.cshtml"
AddHtmlAttributeValue("", 596, Model.BackgroundPhotoURL, 596, 25, false);

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
            BeginContext(623, 230, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-3\"></div>\r\n                        \r\n                        <div class=\"col-12 mt-4\">\r\n                            <h3>");
            EndContext();
            BeginContext(854, 18, false);
#line 23 "C:\Users\user\source\repos\Liverpool\Liverpool\Areas\Admin\Views\Cups\Details.cshtml"
                           Write(Model.CupType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(872, 51, true);
            WriteLiteral("</h3>\r\n                            <p class=\"mt-5\">");
            EndContext();
            BeginContext(924, 11, false);
#line 24 "C:\Users\user\source\repos\Liverpool\Liverpool\Areas\Admin\Views\Cups\Details.cshtml"
                                       Write(Model.Place);

#line default
#line hidden
            EndContext();
            BeginContext(935, 37, true);
            WriteLiteral("</p>\r\n                            <p>");
            EndContext();
            BeginContext(973, 10, false);
#line 25 "C:\Users\user\source\repos\Liverpool\Liverpool\Areas\Admin\Views\Cups\Details.cshtml"
                          Write(Model.Info);

#line default
#line hidden
            EndContext();
            BeginContext(983, 37, true);
            WriteLiteral("</p>\r\n                            <p>");
            EndContext();
            BeginContext(1021, 10, false);
#line 26 "C:\Users\user\source\repos\Liverpool\Liverpool\Areas\Admin\Views\Cups\Details.cshtml"
                          Write(Model.Time);

#line default
#line hidden
            EndContext();
            BeginContext(1031, 293, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""nd-content"">
                        
                    </div>

                    <div class=""row"">
                        <div class=""col-12 text-center"">
                            ");
            EndContext();
            BeginContext(1324, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb4300839e14c5f97ac11e2ba3f6718", async() => {
                BeginContext(1374, 19, true);
                WriteLiteral("Əsas Səhifəyə qayıt");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(1397, 148, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </section>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cup> Html { get; private set; }
    }
}
#pragma warning restore 1591
