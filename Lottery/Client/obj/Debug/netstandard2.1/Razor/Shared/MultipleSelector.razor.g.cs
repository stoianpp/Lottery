#pragma checksum "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cf9d9863b7dfbb37a3bf32dda33a669d5fa39f9"
// <auto-generated/>
#pragma warning disable 1591
namespace Lottery.Client.Shared
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
    public partial class MultipleSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "multiple-selector");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "selectable-ul");
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 3 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor"
         foreach (var item in NoSelected)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor"
                            () => Select(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, 
#nullable restore
#line 5 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor"
                                                  item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 6 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "multiple-selector-buttons");
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor"
                                        SelectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "\r\n            <img class=\"arrow\" src=\"greens.png\">\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor"
                                        DeselectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n            <img class=\"arrow\" src=\"reds.png\">\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    ");
            __builder.OpenElement(27, "ul");
            __builder.AddAttribute(28, "class", "selectable-ul");
            __builder.AddMarkupContent(29, "\n");
#nullable restore
#line 17 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor"
         foreach (var item in Selected)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "            ");
            __builder.OpenElement(31, "li");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor"
                            () => Deselect(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, 
#nullable restore
#line 19 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor"
                                                    item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 20 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\stoia\Source\repos\Lottery\Lottery\Client\Shared\MultipleSelector.razor"
       
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
