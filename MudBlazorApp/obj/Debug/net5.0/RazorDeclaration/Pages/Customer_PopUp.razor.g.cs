// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MudBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\_Imports.razor"
using MudBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\_Imports.razor"
using MudBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
using MudBlazorApp.Data;

#line default
#line hidden
#nullable disable
    public partial class Customer_PopUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
       

    [Parameter]
    public Customer customer { get; set; }

    [Parameter]
    public bool visible { get; set; } = false;

    [Parameter]
    public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> ModalSubmitCallBack { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> ModalCancelCallBack { get; set; }    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
