#pragma checksum "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Auth\Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41e2c76565386b9da1cb4f2a869d79a0544c4986"
// <auto-generated/>
#pragma warning disable 1591
namespace Lottery.Client.Pages.Auth
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
#line 6 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Auth\Logout.razor"
using Lottery.Client.Auth;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/logout")]
    public partial class Logout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<text>Login out...</text>");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "E:\Code\Blazor\Lottery\Lottery\Client\Pages\Auth\Logout.razor"
      
    protected async override Task OnInitializedAsync()
    {
        await loginService.Logout();
        navigationManager.NavigateTo("");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
    }
}
#pragma warning restore 1591
