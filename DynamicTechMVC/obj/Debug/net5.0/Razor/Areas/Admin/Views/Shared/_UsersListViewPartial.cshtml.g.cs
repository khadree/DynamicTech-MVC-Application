#pragma checksum "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "919a0ab9c810696f4319b959b0ab921178f1733e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__UsersListViewPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_UsersListViewPartial.cshtml")]
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
#line 1 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\_ViewImports.cshtml"
using DynamicTechMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\_ViewImports.cshtml"
using DynamicTechMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
using DynamicTechMVC.Comparers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"919a0ab9c810696f4319b959b0ab921178f1733e", @"/Areas/Admin/Views/Shared/_UsersListViewPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9966d5f8812b61ef7d07693702b8a51a142eabf7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__UsersListViewPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DynamicTechMVC.Areas.Admin.Models.UsersCategoryListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/UsersToCategory.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/BootstrapAlerts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th>First Name</th>\r\n            <th> Last Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
         if (Model.Users != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
             foreach (var user in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"text-align:center\">\r\n");
#nullable restore
#line 18 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                         if (Model.UsersSelected != null && Model.UsersSelected.Contains(user, new CompareUsers()))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\" checked");
            BeginWriteAttribute("value", " value=\"", 741, "\"", 757, 1);
#nullable restore
#line 20 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 749, user.Id, 749, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 21 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\"");
            BeginWriteAttribute("value", " value=\"", 962, "\"", 978, 1);
#nullable restore
#line 24 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 970, user.Id, 970, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 25 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                   Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                   Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Engr. Khadree\Documents\Visual Studio 2019\Projects\DynamicTechMVC\DynamicTechMVC\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "919a0ab9c810696f4319b959b0ab921178f1733e8821", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "919a0ab9c810696f4319b959b0ab921178f1733e9920", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DynamicTechMVC.Areas.Admin.Models.UsersCategoryListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
