#pragma checksum "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Users\IndexUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5f9f3a8bb3b9cdaf4f6737b7690dad98fed3287"
// <auto-generated/>
#pragma warning disable 1591
namespace Lottery.Client.Pages.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Code\Blazor\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Users\IndexUsers.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class IndexUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Lottery.Client.Shared.Pagination>(0);
            __builder.AddAttribute(1, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Users\IndexUsers.razor"
                          paginationDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 5 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Users\IndexUsers.razor"
                                                            SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Users\IndexUsers.razor"
                              totalAmountOfPages

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.AddMarkupContent(5, "<h3>Index Users</h3>\n\n");
            __Blazor.Lottery.Client.Pages.Users.IndexUsers.TypeInference.CreateGenericList_0(__builder, 6, 7, 
#nullable restore
#line 10 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Users\IndexUsers.razor"
                   Users

#line default
#line hidden
#nullable disable
            , 8, (__builder2) => {
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenElement(10, "table");
                __builder2.AddAttribute(11, "class", "table");
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.AddMarkupContent(13, "<thead>\n                <tr>\n                    <th></th>\n                    <th>User</th>\n                </tr>\n            </thead>\n            ");
                __builder2.OpenElement(14, "tbody");
                __builder2.AddMarkupContent(15, "\n");
#nullable restore
#line 20 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Users\IndexUsers.razor"
                 foreach (var user in Users)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(16, "                    ");
                __builder2.OpenElement(17, "tr");
                __builder2.AddMarkupContent(18, "\n                        ");
                __builder2.OpenElement(19, "td");
                __builder2.AddMarkupContent(20, "\n                            ");
                __builder2.OpenElement(21, "a");
                __builder2.AddAttribute(22, "href", "/users/edit/" + (
#nullable restore
#line 24 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Users\IndexUsers.razor"
                                                  user.UserId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "class", "btn btn-success");
                __builder2.AddContent(24, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n                        ");
                __builder2.OpenElement(27, "td");
                __builder2.AddMarkupContent(28, "\n                            ");
                __builder2.AddContent(29, 
#nullable restore
#line 27 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Users\IndexUsers.razor"
                             user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(30, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n");
#nullable restore
#line 30 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Users\IndexUsers.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(33, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Users\IndexUsers.razor"
       
    List<UserDTO> Users;
    PaginationDTO paginationDTO = new PaginationDTO();
    int totalAmountOfPages;

    protected override async Task OnInitializedAsync()
    {
        await LoadUsers();
    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadUsers();
    }

    private async Task LoadUsers()
    {
        var paginatedResponse = await usersRepository.GetUsers(paginationDTO);
        Users = paginatedResponse.Response;
        totalAmountOfPages = paginatedResponse.TotalAmountPages;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUsersRepository usersRepository { get; set; }
    }
}
namespace __Blazor.Lottery.Client.Pages.Users.IndexUsers
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Lottery.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591