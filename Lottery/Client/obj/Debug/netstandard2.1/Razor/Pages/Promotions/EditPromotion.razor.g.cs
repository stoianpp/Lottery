#pragma checksum "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\EditPromotion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "416132ff61cfe8e2a902762767bcd804e7c00e4e"
// <auto-generated/>
#pragma warning disable 1591
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
#line 4 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\EditPromotion.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/promotion/edit/{PromotionId:int}")]
    public partial class EditPromotion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Promotion</h3>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\EditPromotion.razor"
 if (Promotion != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<Lottery.Client.Pages.Promotions.PromotionForm>(2);
            __builder.AddAttribute(3, "Promotion", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Lottery.Shared.Entities.Promotion>(
#nullable restore
#line 10 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\EditPromotion.razor"
                              Promotion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\EditPromotion.razor"
                                                        Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "NotSelectedGifts", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Lottery.Shared.Entities.Gift>>(
#nullable restore
#line 10 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\EditPromotion.razor"
                                                                                NotSelectedGifts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "SelectedGifts", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Lottery.Shared.Entities.Gift>>(
#nullable restore
#line 10 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\EditPromotion.razor"
                                                                                                                 SelectedGifts

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 11 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\EditPromotion.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\EditPromotion.razor"
       
    [Parameter] public int PromotionId { get; set; }

    private Promotion Promotion;
    private List<Gift> SelectedGifts;
    private List<Gift> NotSelectedGifts;

    protected async override Task OnInitializedAsync()
    {
        var model = await promotionRepository.GetPromotionForUpdate(PromotionId);
        Promotion = model.Promotion;
        SelectedGifts = model.SelectedGifts;
        NotSelectedGifts = model.NotSelectedGifts;
    }

    private async Task Edit()
    {
        await promotionRepository.UpdatePromotion(Promotion);
        navigationManager.NavigateTo("promotions");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPromotionRepository promotionRepository { get; set; }
    }
}
#pragma warning restore 1591
