#pragma checksum "C:\Users\umitk\Documents\blogger\uiweb\views\shared\components\socialcomponent\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edd929e01a6413be066b0f62bd0df60c668091a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_shared_components_socialcomponent_default), @"mvc.1.0.view", @"/views/shared/components/socialcomponent/default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edd929e01a6413be066b0f62bd0df60c668091a2", @"/views/shared/components/socialcomponent/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"825b43eaa0e89b849133edcfb426d0731fe1ea9d", @"/views/_ViewImports.cshtml")]
    public class views_shared_components_socialcomponent_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<SocialModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\components\socialcomponent\default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=", 74, "", 95, 1);
#nullable restore
#line 5 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\components\socialcomponent\default.cshtml"
WriteAttributeValue("", 80, item.SocialUrl, 80, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" style=\"text-decoration: none;color:black\">\r\n        <i");
            BeginWriteAttribute("class", " class=", 166, "", 187, 1);
#nullable restore
#line 6 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\components\socialcomponent\default.cshtml"
WriteAttributeValue("", 173, item.IconName, 173, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n    </a>\r\n");
#nullable restore
#line 8 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\components\socialcomponent\default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal\"> <i class=\"fas fa-file-pdf fa-2x\"></i></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<SocialModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
