#pragma checksum "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87833ac62eb7f1859c028d7940dd8a3d29203d6f"
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
    public partial class PromotionForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor"
                     Promotion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor"
                                               OnDataAnnotationsValidated

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<label for=\"name\">Name</label>\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor"
                                                              Promotion.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Promotion.Name = __value, Promotion.Name))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Promotion.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __Blazor.Lottery.Client.Pages.Promotions.PromotionForm.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 11 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor"
                                          () => Promotion.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.AddMarkupContent(27, "<label>Active</label>\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(30);
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor"
                                            Promotion.Active

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Promotion.Active = __value, Promotion.Active))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Promotion.Active));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                ");
                __Blazor.Lottery.Client.Pages.Promotions.PromotionForm.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 19 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor"
                                          () => Promotion.Active

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.AddMarkupContent(43, "<label for=\"description\">Description</label>\r\n            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor"
                                                              Promotion.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Promotion.Description = __value, Promotion.Description))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Promotion.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __Blazor.Lottery.Client.Pages.Promotions.PromotionForm.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 27 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor"
                                          () => Promotion.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.AddMarkupContent(60, "<label>Gifts selection:</label>\r\n            ");
                __builder2.OpenElement(61, "div");
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.OpenComponent<Lottery.Client.Shared.MultipleSelectorImages>(63);
                __builder2.AddAttribute(64, "Selected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Lottery.Client.Helpers.MultipleSelectorModel>>(
#nullable restore
#line 34 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor"
                                                  Selected

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "NoSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Lottery.Client.Helpers.MultipleSelectorModel>>(
#nullable restore
#line 34 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor"
                                                                        NotSelected

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n        ");
                __builder2.AddMarkupContent(69, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Pages\Promotions\PromotionForm.razor"
       
    [Parameter] public Promotion Promotion { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Gift> SelectedGifts { get; set; } = new List<Gift>();
    [Parameter] public List<Gift> NotSelectedGifts { get; set; } = new List<Gift>();

    private List<MultipleSelectorModel> Selected = new List<MultipleSelectorModel>();
    private List<MultipleSelectorModel> NotSelected = new List<MultipleSelectorModel>();

    protected override void OnInitialized()
    {
        Selected = SelectedGifts.Select(x => new MultipleSelectorModel(x.Id.ToString(), x.Name)).ToList();
        NotSelected = NotSelectedGifts.Select(x => new MultipleSelectorModel(x.Id.ToString(), x.Name)).ToList();
    }

    private async Task OnDataAnnotationsValidated()
    {
       Promotion.GiftsPromotions = Selected
            .Select(x => new GiftsPromotions { GiftId = int.Parse(x.Key)}).ToList();
        await OnValidSubmit.InvokeAsync(null);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGiftRepository giftRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPromotionRepository promotionRepository { get; set; }
    }
}
namespace __Blazor.Lottery.Client.Pages.Promotions.PromotionForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
