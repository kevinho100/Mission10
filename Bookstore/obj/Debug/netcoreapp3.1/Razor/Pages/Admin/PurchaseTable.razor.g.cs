#pragma checksum "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5165b0c683bea8b60e5410c8bc595780d195bcd"
// <auto-generated/>
#pragma warning disable 1591
namespace Bookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/_Imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    public partial class PurchaseTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\n\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenElement(7, "th");
            __builder.AddAttribute(8, "colspan", "5");
            __builder.AddAttribute(9, "class", "text-center");
#nullable restore
#line 5 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
__builder.AddContent(10, TableTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n\n    ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 11 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
         if (Purchases?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
             foreach (Purchase d in Purchases)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\n            ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 16 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
__builder.AddContent(20, d.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n            ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 17 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
__builder.AddContent(23, d.Zip);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n            ");
            __builder.AddMarkupContent(25, "<th>Book</th>\n            ");
            __builder.AddMarkupContent(26, "<th>Quantity</th>\n\n            ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\n                ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
                                                                  x => PurchaseSelected.InvokeAsync(d.PurchaseId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "\n                    ");
#nullable restore
#line 23 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
__builder.AddContent(33, ButtonLabel);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
#nullable restore
#line 28 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
                 foreach (BasketLineItem bli in d.Lines)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                    ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\n                        <td colspan=\"2\"></td>\n                        ");
            __builder.OpenElement(41, "td");
#nullable restore
#line 32 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
__builder.AddContent(42, bli.Books.Title);

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, " d");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                        ");
            __builder.OpenElement(45, "td");
#nullable restore
#line 33 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
__builder.AddContent(46, bli.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n");
#nullable restore
#line 35 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "            ");
            __builder.AddMarkupContent(50, "<tr>\n                <td colspan=\"5\" class=\"text-center\"> No Orders </td>\n            </tr>\n");
#nullable restore
#line 43 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n\n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/PurchaseTable.razor"
       

    [Parameter]
    public string TableTitle { get; set; } = "Purchases";

    [Parameter]
    public IEnumerable<Purchase> Purchases { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Purchased";

    [Parameter]
    public EventCallback<int> PurchaseSelected { get; set; }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
