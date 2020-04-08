#pragma checksum "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\IndexPromotions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62a6bc43f6108801c29c8e5d86bf7ed7eebe74ff"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Lottery.Client.Pages.Promotions
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Lottery.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\IndexPromotions.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/promotions")]
    public partial class IndexPromotions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\IndexPromotions.razor"
       
    List<Promotion> Promotions;
    PaginationDTO paginationDTO = new PaginationDTO() { RecordsPerPage = 10 };
    private int totalAmountPages;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadPromotions();
        }
        catch (Exception ex)
        {

        }
    }

    private async Task LoadPromotions()
    {
        var paginatedResponse = await promotionRepository.GetPromotions(paginationDTO);
        Promotions = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;

    }

    private async Task SelectedPage(int page)
    {
        paginationDTO.Page = page;
        await LoadPromotions();
    }

    private async Task DeletePromotion(int id)
    {
        await promotionRepository.DeletePromotion(id);
        await LoadPromotions();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPromotionRepository promotionRepository { get; set; }
    }
}
#pragma warning restore 1591
