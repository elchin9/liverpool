#pragma checksum "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e27ee6c5c97c8e8eb36a23c97f821c9d37cb00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e27ee6c5c97c8e8eb36a23c97f821c9d37cb00", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf89978fd76ec1c0bea808e640f7600111cc7c70", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Video", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 291, true);
            WriteLiteral(@"<!-- Start Slider -->

<section id=""slider"">
    <div class=""row m-0"">
        <div class=""col-12 p-0"">
            <i class=""fas fa-angle-left arrow-left position-absolute""></i>
            <div class=""window"">
                <ul class=""mb-0 p-0 list-unstyled d-flex slider-lent"">
");
            EndContext();
#line 12 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                     foreach (var s in Model.Sliders)
                    {

#line default
#line hidden
            BeginContext(402, 62, true);
            WriteLiteral("                        <li>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 464, "\"", 488, 2);
            WriteAttributeValue("", 470, "images/", 470, 7, true);
#line 15 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
WriteAttributeValue("", 477, s.PhotoURL, 477, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(489, 34, true);
            WriteLiteral(">\r\n                        </li>\r\n");
            EndContext();
#line 17 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(546, 188, true);
            WriteLiteral("                </ul>\r\n            </div>\r\n            <i class=\"fas fa-angle-right arrow-right position-absolute\"></i>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n<!-- End Slider -->\r\n\r\n");
            EndContext();
#line 28 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
 if (Model.Videos.Count() > 0)
{

#line default
#line hidden
            BeginContext(769, 33, true);
            WriteLiteral("    <!-- Start Last Matches -->\r\n");
            EndContext();
            BeginContext(804, 355, true);
            WriteLiteral(@"    <section id=""last-match"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""heading-section d-flex justify-content-between align-items-center"">
                        <h2>Son İcmallar :</h2>
                        <div class=""more"">
                            ");
            EndContext();
            BeginContext(1159, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4b63f4190344346bc74f9fd96bb6f8a", async() => {
                BeginContext(1204, 8, true);
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
            BeginContext(1216, 142, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row mt-3\">\r\n");
            EndContext();
#line 45 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                 foreach (var v in Model.Videos)
                {

#line default
#line hidden
            BeginContext(1427, 93, true);
            WriteLiteral("                    <div class=\"col-12 col-sm-6 col-md-4 col-lg-3\">\r\n                        ");
            EndContext();
            BeginContext(1520, 815, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d64161928c4460fb5c9dce9a971ba2c", async() => {
                BeginContext(1588, 157, true);
                WriteLiteral("\r\n                            <div class=\"last-content\">\r\n                                <div class=\"last-images\">\r\n                                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1745, "\"", 1769, 2);
                WriteAttributeValue("", 1751, "images/", 1751, 7, true);
#line 51 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
WriteAttributeValue("", 1758, v.PhotoURL, 1758, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1770, 113, true);
                WriteLiteral(" alt=\"\">\r\n                                    <div class=\"img-info\">\r\n                                        <p>");
                EndContext();
                BeginContext(1884, 15, false);
#line 53 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                                      Write(v.Category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1899, 259, true);
                WriteLiteral(@"</p>
                                    </div>
                                    <i class=""far fa-play-circle""></i>
                                </div>
                                <div class=""last-info"">
                                    <h4>");
                EndContext();
                BeginContext(2159, 7, false);
#line 58 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                                   Write(v.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2166, 49, true);
                WriteLiteral("</h4>\r\n                                    <span>");
                EndContext();
                BeginContext(2216, 6, false);
#line 59 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                                     Write(v.Time);

#line default
#line hidden
                EndContext();
                BeginContext(2222, 109, true);
                WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
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
            BeginContext(2335, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 64 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2384, 52, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n");
            EndContext();
            BeginContext(2438, 31, true);
            WriteLiteral("    <!-- End Last Matches -->\r\n");
            EndContext();
#line 70 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2472, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 73 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
 if (Model.News.Count() > 0)
{

#line default
#line hidden
            BeginContext(2509, 32, true);
            WriteLiteral("    <!-- Start Latest News -->\r\n");
            EndContext();
            BeginContext(2543, 356, true);
            WriteLiteral(@"    <section id=""latest-news"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""heading-section d-flex justify-content-between align-items-center"">
                        <h2>Son Xəbərlər :</h2>
                        <div class=""more"">
                            ");
            EndContext();
            BeginContext(2899, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a22e68db2f58451e907c287a608363da", async() => {
                BeginContext(2943, 8, true);
                WriteLiteral("Daha Çox");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            BeginContext(2955, 142, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row mt-3\">\r\n");
            EndContext();
#line 90 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                 foreach (var n in Model.News)
                {

#line default
#line hidden
            BeginContext(3164, 85, true);
            WriteLiteral("                <div class=\"col-12 col-sm-6 col-md-4 col-lg-3\">\r\n                    ");
            EndContext();
            BeginContext(3249, 714, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70772951fd1c45169f46561d59f86c11", async() => {
                BeginContext(3316, 145, true);
                WriteLiteral("\r\n                        <div class=\"last-content\">\r\n                            <div class=\"last-images\">\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3461, "\"", 3509, 2);
                WriteAttributeValue("", 3467, "images/", 3467, 7, true);
#line 96 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
WriteAttributeValue("", 3474, n.Photos.FirstOrDefault().PhotoURL, 3474, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3510, 105, true);
                WriteLiteral(" alt=\"\">\r\n                                <div class=\"img-info\">\r\n                                    <p>");
                EndContext();
                BeginContext(3616, 15, false);
#line 98 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                                  Write(n.Category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3631, 171, true);
                WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"last-info\">\r\n                                <h4>");
                EndContext();
                BeginContext(3803, 7, false);
#line 102 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                               Write(n.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3810, 45, true);
                WriteLiteral("</h4>\r\n                                <span>");
                EndContext();
                BeginContext(3856, 6, false);
#line 103 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                                 Write(n.Time);

#line default
#line hidden
                EndContext();
                BeginContext(3862, 97, true);
                WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
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
            BeginContext(3963, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 108 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4008, 54, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            EndContext();
            BeginContext(4064, 30, true);
            WriteLiteral("    <!-- End Latest News -->\r\n");
            EndContext();
#line 115 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4097, 149, true);
            WriteLiteral("\r\n<!-- Start Events -->\r\n\r\n<section id=\"events\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-lg-5\">\r\n");
            EndContext();
#line 123 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                 if (Model.Event.Time > DateTime.Now)
                {

#line default
#line hidden
            BeginContext(4320, 356, true);
            WriteLiteral(@"                    <div class=""event-main"">
                        <div class=""event-content mt-4"">
                            <div class=""heading-event"">
                                <h2>Fan Klubla oyun izlə</h2>
                            </div>
                            <div class=""event-info-index"">
                                <h4>");
            EndContext();
            BeginContext(4677, 17, false);
#line 131 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                               Write(Model.Event.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4694, 53, true);
            WriteLiteral("</h4>\r\n                                <p>Matchday : ");
            EndContext();
            BeginContext(4748, 49, false);
#line 132 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                                         Write(String.Format("{0:yyyy-MM-dd}", Model.Event.Time));

#line default
#line hidden
            EndContext();
            BeginContext(4797, 57, true);
            WriteLiteral("</p>\r\n                                <p>Toplanış yeri : ");
            EndContext();
            BeginContext(4855, 17, false);
#line 133 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                                              Write(Model.Event.Place);

#line default
#line hidden
            EndContext();
            BeginContext(4872, 48, true);
            WriteLiteral("</p>\r\n                                <p>Saat : ");
            EndContext();
            BeginContext(4921, 17, false);
#line 134 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                                     Write(Model.Event.Clock);

#line default
#line hidden
            EndContext();
            BeginContext(4938, 164, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"event-map-index\">\r\n                            <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5102, "\"", 5124, 1);
#line 138 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
WriteAttributeValue("", 5108, Model.Event.Map, 5108, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5125, 186, true);
            WriteLiteral("\r\n                                    width=\"100%\" height=\"400px\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 142 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(5371, 499, true);
            WriteLiteral(@"                    <div class=""event-main"">
                        <div class=""event-content mt-4"">
                            <div class=""heading-event"">
                                <h2>Fan Klubla oyun izlə</h2>
                            </div>
                            <div class=""event-info-index"">
                                <p class=""m-0"">Hal-hazırda yeni event yoxdur.</p>
                            </div>
                        </div>
                    </div>
");
            EndContext();
#line 155 "C:\Users\user\source\repos\Liverpool\Liverpool\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(5889, 883, true);
            WriteLiteral(@"            </div>
            <div class=""col-12 col-lg-7"">
                <div class=""league-table mt-4"">
                    <div class=""heading-event"">
                        <h2>Turnir Cədvəli :</h2>
                        <iframe class=""mt-4 mt-md-0"" frameborder=""0"" scrolling=""no"" width=""500"" height=""600""
                                src=""https://www.fctables.com/england/premier-league/iframe/?type=table&lang_id=22&country=67&template=10&team=&timezone=Europe/Samara&time=12&po=1&ma=1&wi=1&dr=1&los=1&gf=1&ga=1&gd=1&pts=1&ng=1&form=0&width=500&height=700&font=Verdana&fs=12&lh=22&bg=FFFFFF&fc=333333&logo=1&tlink=1&ths=1&thb=1&thba=FFFFFF&thc=000000&bc=dddddd&hob=f5f5f5&hobc=ebe7e7&lc=333333&sh=1&hfb=1&hbc=f01d40&hfc=FFFFFF""></iframe>
                    </div>
                </div>
            </div>
        </div>
</section>

<!-- End Events -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
