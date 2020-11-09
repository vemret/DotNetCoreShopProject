#pragma checksum "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0153ba065ef8a7b99d6e65ad35c9d5372f1d44a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductList), @"mvc.1.0.view", @"/Views/Admin/ProductList.cshtml")]
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
#line 2 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\_ViewImports.cshtml"
using dotnetapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\_ViewImports.cshtml"
using dotnetapp.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0153ba065ef8a7b99d6e65ad35c9d5372f1d44a", @"/Views/Admin/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75347b926aa72879185052ea00c0048727e85266", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 90, "\"", 98, 0);
            EndWriteAttribute();
            WriteLiteral(@">Admin Products</h1>
        <hr>
        <table class=""table table-boardered"">
            <thead>
                <tr>
                    <td style=""width: 30px"">ID</td>
                    <td style=""width: 120px"">Image</td>
                    <td >Name</td>
                    <td >Description</td>
                    <td style=""width: 100px"">Price</td>
                    <td >HomaPage</td>
                    <td >Approve</td>
                    <td style=""width: 150px""></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                 if (Model.Products.Count>0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 26 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td");
            BeginWriteAttribute("class", " class=\"", 930, "\"", 938, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e0153ba065ef8a7b99d6e65ad35c9d5372f1d44a5916", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 950, "~/img/", 950, 6, true);
#nullable restore
#line 27 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
AddHtmlAttributeValue("", 956, item.ImageUrl, 956, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            <td");
            BeginWriteAttribute("class", " class=\"", 1037, "\"", 1045, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td");
            BeginWriteAttribute("class", " class=\"", 1095, "\"", 1103, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td");
            BeginWriteAttribute("class", " class=\"", 1160, "\"", 1168, 0);
            EndWriteAttribute();
            WriteLiteral(">₺");
#nullable restore
#line 30 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td >\r\n");
#nullable restore
#line 32 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                                 if (item.IsHome)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 35 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 37 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td >\r\n");
#nullable restore
#line 40 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                                 if (item.IsApprove)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 43 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 45 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td");
            BeginWriteAttribute("class", " class=\"", 1947, "\"", 1955, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1993, "\"", 2030, 2);
            WriteAttributeValue("", 2000, "/admin/product/", 2000, 15, true);
#nullable restore
#line 47 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 2015, item.ProductId, 2015, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n                                <a href=\"#\" class=\"btn btn-danger btn-sm\">Delete</a>\r\n                            </td>\r\n                        </tr>  \r\n");
#nullable restore
#line 51 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
                     
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\"><h3");
            BeginWriteAttribute("class", " class=\"", 2335, "\"", 2343, 0);
            EndWriteAttribute();
            WriteLiteral(">There is not any Product!</h3></div>\r\n");
#nullable restore
#line 54 "C:\DotNetProjects\dotnetapp\dotnetapp.webui\Views\Admin\ProductList.cshtml"
    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
