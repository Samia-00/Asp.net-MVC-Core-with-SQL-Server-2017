#pragma checksum "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2f65d0a754a00c73ffa5b071fabec6a122912f5"
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
#line 1 "F:\mvc project\Project_02\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f65d0a754a00c73ffa5b071fabec6a122912f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af032e4f848c706f6de3249ca97f32c67ea681d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication.Models.ViewModel.LaborWorkVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(106, 228, true);
            WriteLiteral("\r\n<h1>Labor Work Info</h1>\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <table class=\"table table-bordered table-striped table-hover\">\r\n            <thead class=\"thead-dark\">\r\n                <tr>\r\n                    <th>");
            EndContext();
            BeginContext(335, 37, false);
#line 12 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.LobarName));

#line default
#line hidden
            EndContext();
            BeginContext(372, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(404, 35, false);
#line 13 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.PayRate));

#line default
#line hidden
            EndContext();
            BeginContext(439, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(471, 37, false);
#line 14 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(508, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(540, 38, false);
#line 15 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.FinishDate));

#line default
#line hidden
            EndContext();
            BeginContext(578, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(610, 38, false);
#line 16 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.DaysWorked));

#line default
#line hidden
            EndContext();
            BeginContext(648, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(680, 37, false);
#line 17 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.TotalBill));

#line default
#line hidden
            EndContext();
            BeginContext(717, 77, true);
            WriteLiteral("</th>\r\n\r\n                </tr>\r\n\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 23 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                 foreach (var l in Model)
                {

#line default
#line hidden
            BeginContext(856, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(903, 11, false);
#line 26 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(l.LobarName);

#line default
#line hidden
            EndContext();
            BeginContext(914, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(946, 9, false);
#line 27 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(l.PayRate);

#line default
#line hidden
            EndContext();
            BeginContext(955, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(987, 34, false);
#line 28 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(l.StartDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1053, 36, false);
#line 29 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(l.FinishDate?.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1121, 12, false);
#line 30 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(l.DaysWorked);

#line default
#line hidden
            EndContext();
            BeginContext(1133, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1165, 11, false);
#line 31 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                   Write(l.TotalBill);

#line default
#line hidden
            EndContext();
            BeginContext(1176, 32, true);
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 34 "F:\mvc project\Project_02\WebApplication\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1227, 66, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication.Models.ViewModel.LaborWorkVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
