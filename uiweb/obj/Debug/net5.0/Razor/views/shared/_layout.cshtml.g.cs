#pragma checksum "C:\Users\umitk\Documents\blogger\uiweb\views\shared\_layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0a045f0409346b6f4148915a71325591cd9a4e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_shared__layout), @"mvc.1.0.view", @"/views/shared/_layout.cshtml")]
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
#line 1 "C:\Users\umitk\Documents\blogger\uiweb\views\_ViewImports.cshtml"
using uiweb.models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a045f0409346b6f4148915a71325591cd9a4e4", @"/views/shared/_layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"825b43eaa0e89b849133edcfb426d0731fe1ea9d", @"/views/_ViewImports.cshtml")]
    public class views_shared__layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" d-md-none my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0a045f0409346b6f4148915a71325591cd9a4e43693", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
#nullable restore
#line 8 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\_layout.cshtml"
      Write(ViewBag.title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <!-- CSS only -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css"" rel=""stylesheet""
        integrity=""sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.4.1/css/all.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0a045f0409346b6f4148915a71325591cd9a4e45427", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 16 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\_layout.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <main class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2  my-2\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12 \">\r\n                        ");
#nullable restore
#line 22 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\_layout.cshtml"
                   Write(await Component.InvokeAsync("tagcomponent"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-12 my-2 d-none d-md-block\">\r\n                       ");
#nullable restore
#line 25 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\_layout.cshtml"
                  Write(await Component.InvokeAsync("socialcomponent"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 my-2\">\r\n                <div class=\"row\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\_layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-3  my-2 d-none d-md-block d-lg-block\">\r\n                <div class=\"row\">\r\n                      ");
#nullable restore
#line 36 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\_layout.cshtml"
                 Write(await Component.InvokeAsync("authorcomponent"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-12 my-2\">\r\n                         ");
#nullable restore
#line 38 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\_layout.cshtml"
                    Write(await Component.InvokeAsync("aboutcomponent"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""offcanvas offcanvas-start"" tabindex=""-1"" id=""offcanvasExample""
            aria-labelledby=""offcanvasExampleLabel"">
            <div class=""offcanvas-header"">
                <button type=""button"" class=""btn-close text-reset"" data-bs-dismiss=""offcanvas""
                    aria-label=""Close""></button>
            </div>
            <div class=""offcanvas-body"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""card p-2"">
                            <div class=""row justify-content-between"">
                                <div class=""col"">
                                    <img src=""../image/profile.jpg"" alt=""profile"" class=""card-img-top"">
                                </div>
                                <div class=""col"">
                                    <h6>Software Engineer<br />Mobile And Web Developer</h6>
    ");
                WriteLiteral(@"                                <h5>Ümit KOÇ</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-12 my-2"">
                        ");
#nullable restore
#line 65 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\_layout.cshtml"
                   Write(await Component.InvokeAsync("aboutcomponent"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-12 my-2\">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                ");
#nullable restore
#line 70 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\_layout.cshtml"
                           Write(await Component.InvokeAsync("socialcomponent"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-12 my-2\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0a045f0409346b6f4148915a71325591cd9a4e410270", async() => {
                    WriteLiteral("\r\n                            ");
#nullable restore
#line 76 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\_layout.cshtml"
                       Write(await Html.PartialAsync("_search"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>
            </div>

        </div>
        </div>

        <!-- Modal -->
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">CV</h5>
                        <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                    </div>
                    <div class=""modal-body"" style=""height:80vh"">
                        <iframe src=""../read.pdf"" frameBorder=""0"" scrolling=""auto"" height=""100%"" width=""100%""></iframe>
                    </div>
                </div>
            </div>
        </div>
    </main>
    <!-- JavaScript Bundle with Popper -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstra");
                WriteLiteral("p.bundle.min.js\"\r\n        integrity=\"sha384-/bQdsTh/da6pkI1MST/rWKFNjaCP5gBSY4sEBT38Q/9RBh9AH40zEOg7Hlq2THRZ\" crossorigin=\"anonymous\">\r\n        </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
