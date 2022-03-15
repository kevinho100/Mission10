#pragma checksum "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "566a6549b7e17c03bc862f607237391cfd038b92"
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
#line 1 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/_Imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Books : OwningComponentBase<IBooksRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table-dark table-sm table-striped");
            __builder.AddMarkupContent(2, "\n\n    ");
            __builder.AddMarkupContent(3, "<thead>\n        <tr>\n            <th style=\"color:white; font-size:20pt;\">Book ID</th>\n            <th style=\"color:white; font-size:20pt;\">Book Name</th>\n\n        </tr>\n    </thead>\n\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n\n");
#nullable restore
#line 18 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor"
         if (BooksData?.Count() > 0)
        {
            //list books
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor"
             foreach (Book p in BooksData)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\n                    ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 24 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor"
__builder.AddContent(10, p.BookId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                    ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 25 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor"
__builder.AddContent(13, p.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddMarkupContent(16, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
            __builder.AddAttribute(18, "class", "btn btn-outline-primary");
            __builder.AddAttribute(19, "href", 
#nullable restore
#line 29 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor"
                                                                        GetDetailsUrl(p.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(21, " Details ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddMarkupContent(25, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", "btn btn-outline-warning");
            __builder.AddAttribute(28, "href", 
#nullable restore
#line 33 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor"
                                                                        GetEditUrl(p.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(30, " Edit ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddMarkupContent(34, "\n                        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-outline-danger");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor"
                                                                           x => RemoveBook(p)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, " Delete ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n\n\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n");
#nullable restore
#line 42 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "            ");
            __builder.AddMarkupContent(43, "<tr>\n                <td colspan=\"5\" class=\"text-center\"> No Books </td>\n            </tr>\n");
#nullable restore
#line 49 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n<br>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "class", "btn btn-success");
            __builder.AddAttribute(49, "href", "/admin/books/create");
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(51, " Create ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "/Users/kevin/Desktop/Mission10FINAL/Mission10/Bookstore/Pages/Admin/Books.razor"
       

    public IBooksRepository repo => Service;

    public IEnumerable<Book> BooksData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        BooksData = await repo.Books.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/books/details/{id}";

    public string GetEditUrl(long id) => $"/admin/books/edit/{id}";

    public async Task RemoveBook(Book b)
    {
        repo.DeleteBook(b);
        await UpdateData();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
