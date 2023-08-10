#pragma checksum "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24989c2e7f62ecef67d40f397e9bc550bb16df03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logedin_history), @"mvc.1.0.view", @"/Views/Logedin/history.cshtml")]
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
#line 1 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\_ViewImports.cshtml"
using Mobie.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24989c2e7f62ecef67d40f397e9bc550bb16df03", @"/Views/Logedin/history.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc96dca77822060eddaeacfac081675f4bf57d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Logedin_history : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserHistory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
  
    ViewBag.Title = "User History";
    
    int no = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-center\">User History</h2>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
 if (ViewData["SuccessMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">");
#nullable restore
#line 13 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
                                Write(ViewData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 14 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
 if (ViewData["ErrorMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">");
#nullable restore
#line 18 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
                               Write(ViewData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 19 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Showing History for User ");
#nullable restore
#line 21 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
                       Write(ViewBag.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Sr. No.</th>\r\n            <th>Product Name</th>\r\n            <th>Product Id</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
           Write(no);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
           Write(item.ProId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 813, "\"", 880, 1);
#nullable restore
#line 38 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
WriteAttributeValue("", 820, Url.Action("Details", "UserHome", new { Pid = item.ProId }), 820, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Details</a></td>\r\n           \r\n");
#nullable restore
#line 40 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
              
                no = no + 1;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Logedin\history.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
