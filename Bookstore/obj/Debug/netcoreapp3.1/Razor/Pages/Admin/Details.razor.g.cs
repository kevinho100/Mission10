#pragma checksum "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "256698b0f346044967f4d662f160fa96d49e49ec"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\"> Details </h3>\n\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-bordered table-striped");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th> Book ID: </th>");
            __builder.OpenElement(8, "td");
#nullable restore
#line 7 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Details.razor"
__builder.AddContent(9, p.BookId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<th> Title: </th>");
            __builder.OpenElement(13, "td");
#nullable restore
#line 8 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Details.razor"
__builder.AddContent(14, p.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "<th> Author: </th>");
            __builder.OpenElement(18, "td");
#nullable restore
#line 9 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Details.razor"
__builder.AddContent(19, p.Author);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "<th> Publisher: </th>");
            __builder.OpenElement(23, "td");
#nullable restore
#line 10 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Details.razor"
__builder.AddContent(24, p.Publisher);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "<th> ISBN: </th>");
            __builder.OpenElement(28, "td");
#nullable restore
#line 11 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Details.razor"
__builder.AddContent(29, p.Isbn);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n        ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "<th> Classification: </th>");
            __builder.OpenElement(33, "td");
#nullable restore
#line 12 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Details.razor"
__builder.AddContent(34, p.Classification);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n        ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "<th> Caregory: </th>");
            __builder.OpenElement(38, "td");
#nullable restore
#line 13 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Details.razor"
__builder.AddContent(39, p.Category);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n        ");
            __builder.OpenElement(41, "tr");
            __builder.AddMarkupContent(42, "<th> Price: </th>");
            __builder.OpenElement(43, "td");
#nullable restore
#line 14 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Details.razor"
__builder.AddContent(44, p.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", "btn btn-warning");
            __builder.AddAttribute(50, "href", 
#nullable restore
#line 18 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(52, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "class", "btn btn-secondary");
            __builder.AddAttribute(56, "href", "/admin/books");
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(58, "back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Details.razor"
       

    [Inject]
    public IBooksRepository repo { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Book p { get; set; }

    protected override void OnParametersSet()
    {
        p = repo.Books.FirstOrDefault(x => x.BookId == Id);
    }

    public string EditUrl => $"/admin/books/edit/{p.BookId}";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
