#pragma checksum "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f3578d397a449afe84dbde48f1c214aafb38d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\_ViewImports.cshtml"
using Asp.NetCoreData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\_ViewImports.cshtml"
using Asp.NetCoreData.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f3578d397a449afe84dbde48f1c214aafb38d4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5864c929620294b9251148864fde658b10275aba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 style=\"color:orangered;\">This is Viewbag</h2>\r\n<p>");
#nullable restore
#line 9 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(ViewBag.vb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 10 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(ViewBag.vb1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 11 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(ViewBag.vb2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 12 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(ViewBag.vb3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<ul>\r\n");
#nullable restore
#line 14 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
     foreach (var item in ViewBag.vb4)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 16 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<h2 style=\"color:orangered;\">This is Viewdata</h2>\r\n<p>");
#nullable restore
#line 21 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(ViewData["vd"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 22 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(ViewData["vd1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 23 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(ViewData["vd2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 24 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(ViewData["vd3"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<ul>\r\n");
#nullable restore
#line 26 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
     foreach (var item in (List<string>)ViewData["vd4"])
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 28 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<h2 style=\"color:orangered;\">This is Tempdata</h2>\r\n<p>");
#nullable restore
#line 33 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(TempData["td"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 34 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(TempData["td1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 35 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(TempData["td2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 36 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(TempData["td3"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<ul>\r\n");
#nullable restore
#line 38 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
     foreach (var item in (List<int>)TempData["td4"])
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 40 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 41 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n\r\n<h2 style=\"color:orangered;\">This is Session</h2>\r\n\r\n<p>");
#nullable restore
#line 47 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(HttpContextAccesser.HttpContext.Session.GetString("City"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 48 "C:\Users\admin\Desktop\Sanjay-TP6 .NET\Asp.NetCoreData\Asp.NetCoreData\Views\Home\Index.cshtml"
Write(HttpContextAccesser.HttpContext.Session.GetString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccesser { get; private set; }
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
