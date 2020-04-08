#pragma checksum "E:\Code\Blazor\Lottery\Lottery\Client\Shared\MultipleSelectorImages.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cceeceef40db920a5d0cb3d6ad128c53bbd37afb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Lottery.Client.Shared
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
    public partial class MultipleSelectorImages : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\MultipleSelectorImages.razor"
       
    private string removeAllText = "<<";
    [Parameter]
    public List<MultipleSelectorModel> NoSelected { get; set; } = new List<MultipleSelectorModel>();
    [Parameter]
    public List<MultipleSelectorModel> Selected { get; set; } = new List<MultipleSelectorModel>();

    private void Select(MultipleSelectorModel item)
    {
        NoSelected.Remove(item);
        Selected.Add(item);
    }

    private void Deselect(MultipleSelectorModel item)
    {
        Selected.Remove(item);
        NoSelected.Add(item);
    }

    private void SelectAll()
    {
        Selected.AddRange(NoSelected);
        NoSelected.Clear();
    }

    private void DeselectAll()
    {
        NoSelected.AddRange(Selected);
        Selected.Clear();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
