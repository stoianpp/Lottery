#pragma checksum "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7c13b5ac08e6aa20c6adffaaa21cb37a094aa54"
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
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
 if (List == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
     if (NullTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
         NullTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
                     
    }
    else
    {
        // Default Content

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "        <img src=\"https://media.giphy.com/media/3oEjI6SIIHBdRxXI40/giphy.gif\">\r\n        ");
            __builder.AddMarkupContent(2, "<h3>If the page doesn\'t show up, please, check if you are logged in!</h3>\r\n");
#nullable restore
#line 14 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
                                                                                                  
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
     
}
else if (List.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
     if (EmptyTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 21 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
         EmptyTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 21 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
                      
    }
    else
    {
        // Default Content
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "There are no records to show");
#nullable restore
#line 26 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
                                                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
     
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
     if (ElementTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
         foreach (var element in List)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 35 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
             ElementTemplate(element)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
                                     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
         
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 40 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
         WholeListTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 40 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
                          
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "E:\Code\Blazor\Lottery\Lottery\Client\Shared\GenericList.razor"
       
    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }
    [Parameter] public RenderFragment<TItem> ElementTemplate { get; set; }
    [Parameter] public RenderFragment WholeListTemplate { get; set; }
    [Parameter] public List<TItem> List { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
