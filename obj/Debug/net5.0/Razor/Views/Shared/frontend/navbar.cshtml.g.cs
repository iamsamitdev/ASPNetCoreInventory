#pragma checksum "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\Shared\frontend\navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a96cc13e797dc93b57d07754788a6d8a8fff31cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_frontend_navbar), @"mvc.1.0.view", @"/Views/Shared/frontend/navbar.cshtml")]
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
#line 1 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\_ViewImports.cshtml"
using ASPNetCoreInventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\_ViewImports.cshtml"
using ASPNetCoreInventory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96cc13e797dc93b57d07754788a6d8a8fff31cb", @"/Views/Shared/frontend/navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581af0b1db14ac4b6ed983111f43a9c2c7e33217", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_frontend_navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar navbar-expand-md navbar-light bg-light"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""/"">SmartINV</a>
        <button class=""navbar-toggler d-lg-none"" type=""button"" data-toggle=""collapse"" data-target=""#collapsibleNavId"" aria-controls=""collapsibleNavId""
                aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""collapsibleNavId"">
            <ul class=""navbar-nav ml-auto mt-2 mt-lg-0"">
                <li class=""nav-item"">
                    ");
#nullable restore
#line 11 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\Shared\frontend\navbar.cshtml"
               Write(Html.ActionLink("หน้าหลัก", "Index", "Frontend", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    ");
#nullable restore
#line 14 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\Shared\frontend\navbar.cshtml"
               Write(Html.ActionLink("เกี่ยวกับเรา", "About", "Frontend", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </li>

                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-expanded=""false"">
                        ผลงานของเรา
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                        ");
#nullable restore
#line 22 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\Shared\frontend\navbar.cshtml"
                   Write(Html.ActionLink("ออกแบบเว็บไซต์", "Webdev", "Frontend", null, new { @class = "dropdown-item" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 23 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\Shared\frontend\navbar.cshtml"
                   Write(Html.ActionLink("พัฒนาโมบายแอพ", "Mobiledev", "Frontend", null, new { @class = "dropdown-item" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 24 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\Shared\frontend\navbar.cshtml"
                   Write(Html.ActionLink("ออกแบบกราฟฟิก", "Graphic", "Frontend", null, new { @class = "dropdown-item" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </li>\r\n\r\n                <li class=\"nav-item\">\r\n                    ");
#nullable restore
#line 29 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\Shared\frontend\navbar.cshtml"
               Write(Html.ActionLink("ลงทะเบียน", "Register", "Frontend", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    ");
#nullable restore
#line 32 "G:\TrainingWorkshop\ASPNetCoreMVC\ASPNetCoreInventory\Views\Shared\frontend\navbar.cshtml"
               Write(Html.ActionLink("เข้าสู่ระบบ", "Login", "Frontend", null, new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</nav>\r\n");
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
