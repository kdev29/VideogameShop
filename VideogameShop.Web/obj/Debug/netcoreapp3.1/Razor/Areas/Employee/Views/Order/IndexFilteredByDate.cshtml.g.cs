#pragma checksum "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40eb810a8174f911f0253d31a4480b28b8742215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_Order_IndexFilteredByDate), @"mvc.1.0.view", @"/Areas/Employee/Views/Order/IndexFilteredByDate.cshtml")]
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
#line 1 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\_ViewImports.cshtml"
using VideogameShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\_ViewImports.cshtml"
using VideogameShop.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
using VideogameShopLibrary.CVS_Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40eb810a8174f911f0253d31a4480b28b8742215", @"/Areas/Employee/Views/Order/IndexFilteredByDate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebddd7e1913cc07bd5aaaf136a1334eda451d00e", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_Order_IndexFilteredByDate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
  
    ViewData["Title"] = "IndexFilteredByDate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
 using (Html.BeginForm("IndexFilteredByDate", "OrderController", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-borderless"">
        <tr>Filter Criteria</tr>
        <tr>
            <td>From Date:</td>
            <td><input type=""date"" name=""fromDate"" /></td>
        </tr>
        <tr>
            <td>To Date:</td>
            <td><input type=""date"" name=""toDate"" /></td>
        </tr>
        <tr>
            <td><input type=""submit"" /></td>
        </tr>
    </table>
");
#nullable restore
#line 24 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table table-bordered table-striped"">
    <tr>
        <th>Product Name</th>
        <th>Quantity</th>
        <th>Condition</th>
        <th>Date</th>
        <th>Total</th>
        <th>Customer Name</th>
        <th>Customer Phone</th>
        <th>Email</th>
        <th>Type of Sale</th>
        <th>Credit Card Name</th>
        <th>Credit Card Number</th>
        <th>Expiration Date</th>
        <th>Cvv</th>
    </tr>
");
#nullable restore
#line 43 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 47 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].Product);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 48 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].Condition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"display:inline-block\">");
#nullable restore
#line 50 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
                                        Write(Model[i].Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 54 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 55 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].SaleType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].CreditCardName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 57 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].CreditCardNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 58 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].ExpirationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 59 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
           Write(Model[i].SecurityCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<button type=\"button\" class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1884, "\"", 1920, 1);
#nullable restore
#line 65 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
WriteAttributeValue("", 1891, Url.Action("Upload","Order"), 1891, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update Sales from File</button>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 1957, "\"", 1993, 1);
#nullable restore
#line 66 "C:\Users\joshu\source\repos\joshuaconstante2197\Videogame-Shopv\VideogameShop.Web\Areas\Employee\Views\Order\IndexFilteredByDate.cshtml"
WriteAttributeValue("", 1964, Url.Action("Create","Order"), 1964, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add a new order</a>\r\n\r\n<hr />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
