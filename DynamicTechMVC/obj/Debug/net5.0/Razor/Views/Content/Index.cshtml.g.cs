#pragma checksum "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0209b3a2b5f7108e3bd06386690c04234d72319f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
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
#line 1 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\_ViewImports.cshtml"
using DynamicTechMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\_ViewImports.cshtml"
using DynamicTechMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\_ViewImports.cshtml"
using DynamicTechMVC.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\_ViewImports.cshtml"
using DynamicTechMVC.Comparers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0209b3a2b5f7108e3bd06386690c04234d72319f", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1acb28a1401f799d19d24487311c877d17dfa4ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DynamicTechMVC.Entities.Content>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 2 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\Content\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\Content\Index.cshtml"
 if (Model.HTMLContent != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div id=\"TextContent\" class=\"mt-3 col-md-10\">\r\n            ");
#nullable restore
#line 8 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\Content\Index.cshtml"
       Write(Html.Raw(Model.HTMLContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\Content\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\Content\Index.cshtml"
 if (Model.VideoLink != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"mt-3 col-md-10\">\r\n            <div id=\"VideoContent\" class=\"video-container mt-3\">\r\n                <iframe width=\"550\" height=\"350\"");
            BeginWriteAttribute("src", " src=\"", 461, "\"", 483, 1);
#nullable restore
#line 17 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\Content\Index.cshtml"
WriteAttributeValue("", 467, Model.VideoLink, 467, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 484, "\"", 502, 0);
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\">\r\n                </iframe>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Views\Content\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DynamicTechMVC.Entities.Content> Html { get; private set; }
    }
}
#pragma warning restore 1591
