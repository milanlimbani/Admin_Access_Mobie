#pragma checksum "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7427c4d15685e693bf4196a714fd89fa1cab3d8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7427c4d15685e693bf4196a714fd89fa1cab3d8a", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc96dca77822060eddaeacfac081675f4bf57d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
  
   
    ViewBag.Tile = "Category List";
    int no = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
 if (ViewBag.message == " Category Deleted Sucessfully.")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <h3>");
#nullable restore
#line 13 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
       Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
}
else if (ViewBag.message == "Cannot delete category as it is present in subcategory.")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <h3>");
#nullable restore
#line 19 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
       Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav class=\"navbar navbar-light mt-1\">\r\n    <a class=\"navbar-brand btn btn-outline-info\" data-bs-toggle=\"modal\"\r\n       data-bs-target=\"#AddCategoryModel\">Add Category</a>\r\n\r\n</nav>\r\n<div class=\"text-danger\">");
#nullable restore
#line 27 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
                    Write(ViewData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"text-success\">");
#nullable restore
#line 28 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
                     Write(ViewData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<div class=""modal fade"" id=""AddCategoryModel"" tabindex=""-1"" aria-labelledby=""AddCategory"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""exampleModalLabel"">
                    Add Category
                </h4>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>

            </div>
            <div class=""modal-body"">
                <div class=""row m-2"">
                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id=""txtCategory"" name=""category"" placeholder=""Enter Category name"" />
                        <div class=""text-danger"" id=""divCategoryError"">

                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismis");
            WriteLiteral(@"s=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-success"" id=""btnCategory"">Add Category</button>
                </div>
            </div>
        </div>

    </div>

</div>

<div class=""modal fade"" id=""EditCategoryModel"" tabindex=""-1"" aria-labelledby=""EditCategory"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""exampleModalLabel"">
                    Edit Category
                </h4>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""row m-2"">
                    <div class=""col-sm-12"">
                        <input type=""hidden"" class=""form-control"" id=""editCategoryId"" />
                        <input type=""text"" class=""form-control"" id=""editCategoryName"" name=""Newcategory"" placeholder=""E");
            WriteLiteral(@"nter New Category name"" />
                        <div class=""text-danger"" id=""divEditCategoryError""></div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-success"" id=""btnEditCategory"">Save Changes</button>
                </div>
            </div>
        </div>
    </div>
</div>
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"" class=""col-sm-3"">Sr.No</th>
            <th scope=""col"" class=""col-sm-5"">CategoeyName</th>
            <th scope=""col"" class=""col-sm""></th>
            <th scope=""col"" class=""col-sm""></th>
            <th scope=""col"" class=""col-sm""></th>
        </tr>

    </thead>
    <tbody>
");
#nullable restore
#line 96 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
         foreach (Category cat in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 100 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
                           Write(cat.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 101 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
               Write(cat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 3953, "\"", 4040, 1);
#nullable restore
#line 102 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
WriteAttributeValue("", 3960, Url.Action("GetSubCategoriesByCategoryId", "SubCategory", new { Cid = cat.Id }), 3960, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info m-1\">SubCategories</a></td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4143, "\"", 4221, 1);
#nullable restore
#line 104 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
WriteAttributeValue("", 4150, Url.Action("EditCategory", "Category", new { editCategoryId = cat.Id}), 4150, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info m-1\" data-bs-toggle=\"modal\"\r\n                       data-bs-target=\"#EditCategoryModel\" data-id=\"");
#nullable restore
#line 105 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
                                                               Write(cat.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</a>\r\n\r\n                </td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 4415, "\"", 4485, 1);
#nullable restore
#line 108 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
WriteAttributeValue("", 4422, Url.Action("RemoveCategory", "Category", new { Cid = cat.Id }), 4422, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you sure you want to delete this category?\')\" class=\"btn btn-outline-info m-1\">Delete</a></td>\r\n\r\n");
#nullable restore
#line 110 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
                  
                    no++;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 114 "C:\Users\158648\OneDrive - Arrow Electronics, Inc\Desktop\Mobie\Views\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function IsBlank(input) {
            let value = input.val().trim();

            if (value == undefined || value == '') {
                return true;
            }
            return false;

        }

        function IsOnlyNumeric(input) {
            let value = input.val().trim();
            return isNaN(value);
        }

        $(document).ready(function () {
            $('#btnCategory').on(""click"", function () {
                $(""#divCategoryError"").text("""");
                let category = $('#txtCategory');
                let blank = IsBlank(category);

                if (!blank) {
                    if (!IsOnlyNumeric(category)) {
                        $(""#divCategoryError"").text(""Only numbers are not allowed"");
                        return;
                    }
                    else {
                        console.log(""else"");
                        $.post(""/Category/AddCategory"", {
                            name: category.v");
                WriteLiteral(@"al().trim()
                        },
                            function (data) {
                                if (data) {
                                    alert(""Success"");
                                    window.location.href = ""/Category/Index"";
                                }
                                else {
                                    alert("" Category name already exists"");
                                }
                            });
                    }
                }
                else {
                    $(""#divCategoryError"").text(""Category should not empty"");
                    return;
                }
            })
        })

        $(document).ready(function () {
            $(""#EditCategoryModel"").on(""show.bs.modal"", function (e) {
                // Get the button that triggered the modal
                var button = $(e.relatedTarget);
                // Get the ID of the category to be edited from data-id attribute of the bu");
                WriteLiteral(@"tton
                var categoryId = button.data(""id"");
                // Get the name of the category to be edited from data-name attribute of the button
                var categoryName = button.data(""name"");
                // Fill the form fields with category ID and name
                $(""#editCategoryId"").val(categoryId);
                $(""#editCategoryName"").val(categoryName);
            });

            $(""#btnEditCategory"").on(""click"", function () {
                var categoryId = $(""#editCategoryId"").val();
                var categoryName = $(""#editCategoryName"").val().trim();


                if (!categoryName) {
                    $(""#divEditCategoryError"").text(""Category name is required."");
                    return;
                }

                // Update category using AJAX
                //$.ajax({
                //    url: ""/Category/Edit"",
                //    method: ""POST"",
                //    data: {
                //        Cid: categoryId,
");
                WriteLiteral(@"                //        name: categoryName
                //    },
                //    success: function (data) {
                //        if (data.success) {
                //            location.reload();
                //        } else {
                //            $(""#divEditCategoryError"").text(data.message);
                //        }
                //    },
                //    error: function () {
                //        $(""#divEditCategoryError"").text(""An error occurred while updating the category."");
                //    }
                //});
            });
        });
    </script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
