#pragma checksum "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc8d4192551d6fc4365071ad3b2c4d50f9ff6bce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShoppingCart/Index.cshtml", typeof(AspNetCore.Views_ShoppingCart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc8d4192551d6fc4365071ad3b2c4d50f9ff6bce", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElectricStore.Models.SessionStateViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(118, 22, true);
            WriteLiteral("    <h2 class=\"title\">");
            EndContext();
            BeginContext(141, 18, false);
#line 8 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                 Write(Model.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(159, 27, true);
            WriteLiteral("\'s Selected Products</h2>\r\n");
            EndContext();
            BeginContext(188, 34, true);
            WriteLiteral("    <div class=\"page-container\">\r\n");
            EndContext();
#line 11 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
         foreach (var item in Model.SelectedProducts)
        {

#line default
#line hidden
            BeginContext(288, 74, true);
            WriteLiteral("            <div class=\"item\">\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(363, 46, false);
#line 15 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(409, 25, true);
            WriteLiteral("\r\n                </h3>\r\n");
            EndContext();
#line 17 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                 if (item.PhotoFileName != null)
                {

#line default
#line hidden
            BeginContext(503, 55, true);
            WriteLiteral("                    <div>\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 558, "\"", 628, 1);
#line 20 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 564, Url.Action("GetImage", "Products", new { productId = item.Id }), 564, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(629, 33, true);
            WriteLiteral(" />\r\n                    </div>\r\n");
            EndContext();
#line 22 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(681, 72, true);
            WriteLiteral("                <div>\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(754, 42, false);
#line 25 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                   Write(Html.DisplayFor(model => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(796, 77, true);
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(874, 36, false);
#line 28 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                   Write(Html.DisplayFor(model => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(910, 72, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 32 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(993, 60, true);
            WriteLiteral("    </div>\r\n    <h5 class=\"title\">\r\n        <span>Thank you ");
            EndContext();
            BeginContext(1054, 18, false);
#line 35 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
                   Write(Model.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(1072, 87, true);
            WriteLiteral("</span>\r\n        <span>for your order, we will contact you shortly.</span>\r\n    </h5>\r\n");
            EndContext();
#line 38 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1171, 244, true);
            WriteLiteral("    <div class=\"title Secondary-heading\">\r\n        <p>Sorry, we don\'t have any information yet</p>\r\n        <p>Please go to the <span class=\"span-col-s\">Shopping List page</span></p>\r\n        <p>and select the wanted products.</p>\r\n    </div>\r\n");
            EndContext();
#line 46 "D:\Web-developer\3. С#\mod\01_ElectricStore_begin\ElectricStore\Views\ShoppingCart\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1418, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElectricStore.Models.SessionStateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
