#pragma checksum "E:\Code\Blazor\Lottery\Lottery\Client\Shared\InputMarkdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "965ef5152d109391e54724834a8053ecfad3b58f"
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
#line 2 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\InputMarkdown.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
    public partial class InputMarkdown<TValue> : InputTextArea
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n    ");
            __builder.OpenElement(2, "label");
            __builder.AddContent(3, 
#nullable restore
#line 6 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\InputMarkdown.razor"
            Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(7);
            __builder.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\InputMarkdown.razor"
                                    CurrentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentValue = __value, CurrentValue))));
            __builder.AddAttribute(10, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrentValue));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n        ");
            __Blazor.Lottery.Client.Shared.InputMarkdown.TypeInference.CreateValidationMessage_0(__builder, 12, 13, 
#nullable restore
#line 9 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\InputMarkdown.razor"
                                For

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
            __builder.OpenElement(17, "div");
            __builder.AddMarkupContent(18, "\n    ");
            __builder.OpenElement(19, "label");
            __builder.AddContent(20, 
#nullable restore
#line 13 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\InputMarkdown.razor"
            Label

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " (preview):");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "markdown-container");
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenComponent<Lottery.Client.Shared.RenderMarkdown>(26);
            __builder.AddAttribute(27, "MarkdownContent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\InputMarkdown.razor"
                                          CurrentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\InputMarkdown.razor"
       
    [Parameter] public Expression<Func<TValue>> For { get; set; }
    [Parameter] public string Label { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Lottery.Client.Shared.InputMarkdown
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
    }
}
#pragma warning restore 1591
