#pragma checksum "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "973de2c3c7ab773eceb36c85707c1fec14ebd171"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserHome_Index), @"mvc.1.0.view", @"/Views/UserHome/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973de2c3c7ab773eceb36c85707c1fec14ebd171", @"/Views/UserHome/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc96dca77822060eddaeacfac081675f4bf57d0", @"/Views/_ViewImports.cshtml")]
    public class Views_UserHome_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
  
    ViewData["Title"] = "UserHome Page";
    string imagePath = string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
 if (ViewBag.message == "Product Liked Successfully.")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">");
#nullable restore
#line 11 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
                                Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
 if(ViewBag.message == "Error: Already Like Product.")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger\">");
#nullable restore
#line 15 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
                           Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row row-cols-1 row-cols-md-3 g-4 ms-1 mt-3 me-1\">\r\n");
#nullable restore
#line 22 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
     foreach (ProductViewModel each in Model)
    {
        if (each.Profile == null)
        {
            imagePath = "/images/img.jpg";
        }
        else
        {
            imagePath = "/images/" + each.Profile;
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col mb-3\">\r\n            <div class=\"card h-100 shadow\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 834, "\"", 850, 1);
#nullable restore
#line 35 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
WriteAttributeValue("", 840, imagePath, 840, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top h-50\" alt=\"image not found\" />\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 37 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
                                      Write(each.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <hr class=\"my-2\" />\r\n                    <p class=\"card-text\"><strong>Category:</strong> ");
#nullable restore
#line 39 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
                                                               Write(each.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\"><strong>SubCategory:</strong> ");
#nullable restore
#line 40 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
                                                                  Write(each.SubCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\"><strong>Price:</strong> ");
#nullable restore
#line 41 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
                                                            Write(each.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1331, "\"", 1395, 1);
#nullable restore
#line 42 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
WriteAttributeValue("", 1338, Url.Action("Details", "UserHome", new { Pid = each.Id }), 1338, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:75px\" class=\"btn btn-primary\">Details</a>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
                     if (signInManager.IsSignedIn(User))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "973de2c3c7ab773eceb36c85707c1fec14ebd1719521", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"Pid\"");
                BeginWriteAttribute("value", " value=\"", 1696, "\"", 1712, 1);
#nullable restore
#line 47 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
WriteAttributeValue("", 1704, each.Id, 1704, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"Uid\"");
                BeginWriteAttribute("value", " value=\"", 1777, "\"", 1800, 1);
#nullable restore
#line 48 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
WriteAttributeValue("", 1785, ViewBag.userId, 1785, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"Pname\"");
                BeginWriteAttribute("value", " value=\"", 1867, "\"", 1885, 1);
#nullable restore
#line 49 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
WriteAttributeValue("", 1875, each.Name, 1875, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button class=\"btn btn-danger\" type=\"submit\" style=\"width:75px\">Like</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
AddHtmlAttributeValue("", 1588, Url.Action("AddLike", "Logedin"), 1588, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 57 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\UserHome\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591