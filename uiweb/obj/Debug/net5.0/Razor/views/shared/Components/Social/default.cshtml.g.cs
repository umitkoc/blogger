#pragma checksum "C:\Users\umitk\Documents\blogger\uiweb\views\shared\Components\Social\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a5cf1eab3d9cb58f1eddd716c319903767cde99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_shared_Components_Social_default), @"mvc.1.0.view", @"/views/shared/Components/Social/default.cshtml")]
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
#nullable restore
#line 2 "C:\Users\umitk\Documents\blogger\uiweb\views\_ViewImports.cshtml"
using entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5cf1eab3d9cb58f1eddd716c319903767cde99", @"/views/shared/Components/Social/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e73450e0b6b109eee3990b112403f1f6fb7c9e", @"/views/_ViewImports.cshtml")]
    public class views_shared_Components_Social_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Social>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\Components\Social\default.cshtml"
 if(Model.Count()!=0){
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\Components\Social\default.cshtml"
     foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=", 97, "", 118, 1);
#nullable restore
#line 6 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\Components\Social\default.cshtml"
WriteAttributeValue("", 103, item.SocialUrl, 103, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" style=\"text-decoration: none;color:black\">\r\n        <i");
            BeginWriteAttribute("class", " class=", 189, "", 210, 1);
#nullable restore
#line 7 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\Components\Social\default.cshtml"
WriteAttributeValue("", 196, item.IconName, 196, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n    </a>\r\n");
#nullable restore
#line 9 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\Components\Social\default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal\"> <i class=\"fas fa-file-pdf fa-2x\"></i></a>\r\n");
#nullable restore
#line 12 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\Components\Social\default.cshtml"
}else{

#line default
#line hidden
#nullable disable
            WriteLiteral("      <div class=\"alert alert-danger\">Not Social</div>\r\n");
#nullable restore
#line 14 "C:\Users\umitk\Documents\blogger\uiweb\views\shared\Components\Social\default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Social>> Html { get; private set; }
    }
}
#pragma warning restore 1591
