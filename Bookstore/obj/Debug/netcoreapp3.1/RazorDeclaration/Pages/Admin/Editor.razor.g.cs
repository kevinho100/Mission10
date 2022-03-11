// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/create")]
    public partial class Editor : OwningComponentBase<IBooksRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "/Users/kevin/Desktop/untitled folder/mission9/Mission10books/Bookstore/Pages/Admin/Editor.razor"
       

    [Parameter]
    public long Id { get; set; } = 0;

    public string ThemeColor => Id == 0 ? "primary" : "warning";

    public string TitleText => Id == 0 ? "Create" : "Edit";

    public Book p { get; set; } = new Book();

    public IBooksRepository repo => Service;

    protected override void OnParametersSet()
    {
        if (Id != 0) //Existing Project
        {
            p = repo.Books.FirstOrDefault(x => x.BookId == Id);
        }
    }

    public void SaveBook()
    {
        if (Id == 0) //new project
        {
            repo.CreateBook(p);
        }
        else
        {
            repo.SaveBook(p);
        }

        NavManager.NavigateTo("/admin/books", true);
    }

    [Inject]
    public NavigationManager NavManager { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
