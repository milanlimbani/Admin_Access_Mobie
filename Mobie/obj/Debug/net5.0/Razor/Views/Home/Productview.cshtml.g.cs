#pragma checksum "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Home\Productview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e10d2929754cd7f72b7c073decf65e03ca181c0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Productview), @"mvc.1.0.view", @"/Views/Home/Productview.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e10d2929754cd7f72b7c073decf65e03ca181c0c", @"/Views/Home/Productview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc96dca77822060eddaeacfac081675f4bf57d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Productview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Products by SubCategory</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Home\Productview.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No products found for the selected Subcategory.</p>\r\n");
#nullable restore
#line 8 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Home\Productview.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Brand</th>
                <th>CatId</th>
               
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Home\Productview.cshtml"
             foreach (var products in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Home\Productview.cshtml"
               Write(products.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Home\Productview.cshtml"
               Write(products.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Home\Productview.cshtml"
               Write(products.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Home\Productview.cshtml"
               Write(products.CatId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Home\Productview.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 34 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Home\Productview.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
