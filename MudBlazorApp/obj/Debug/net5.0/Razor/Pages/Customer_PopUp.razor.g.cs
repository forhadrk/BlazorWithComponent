#pragma checksum "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a632777cda97376e6c69dfa15ab7c939fb6d9d"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                             visible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "IsVisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => visible = __value, visible))));
            __builder.AddAttribute(3, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCard>(4);
                __builder2.AddAttribute(5, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                            10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(7);
                    __builder3.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(9);
                        __builder4.AddAttribute(10, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudCardHeader>(12);
                            __builder5.AddAttribute(13, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudText>(14);
                                __builder6.AddAttribute(15, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 11 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                           Typo.h6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(17, 
#nullable restore
#line 12 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                  customer.Id > 0 ? "Update Customer":"Save Customer"

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(18, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(19);
                            __builder5.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __Blazor.MudBlazorApp.Pages.Customer_PopUp.TypeInference.CreateMudTextField_0(__builder6, 21, 22, "First Name", 23, 
#nullable restore
#line 17 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                                                                   Variant.Text

#line default
#line hidden
#nullable disable
                                , 24, 
#nullable restore
#line 17 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                                                                                         Margin.Normal

#line default
#line hidden
#nullable disable
                                , 25, 
#nullable restore
#line 17 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                   customer.FirstName

#line default
#line hidden
#nullable disable
                                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.FirstName = __value, customer.FirstName)));
                                __builder6.AddMarkupContent(27, "\r\n                        ");
                                __Blazor.MudBlazorApp.Pages.Customer_PopUp.TypeInference.CreateMudTextField_1(__builder6, 28, 29, "Last Name", 30, 
#nullable restore
#line 18 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                                                                 Variant.Text

#line default
#line hidden
#nullable disable
                                , 31, 
#nullable restore
#line 18 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                                                                                       Margin.Normal

#line default
#line hidden
#nullable disable
                                , 32, 
#nullable restore
#line 18 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                   customer.LastName

#line default
#line hidden
#nullable disable
                                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.LastName = __value, customer.LastName)));
                                __builder6.AddMarkupContent(34, "\r\n                        ");
                                __Blazor.MudBlazorApp.Pages.Customer_PopUp.TypeInference.CreateMudTextField_2(__builder6, 35, 36, "Phone Number", 37, 
#nullable restore
#line 19 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                                                                       Variant.Text

#line default
#line hidden
#nullable disable
                                , 38, 
#nullable restore
#line 19 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                                                                                             Margin.Normal

#line default
#line hidden
#nullable disable
                                , 39, 
#nullable restore
#line 19 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                   customer.PhoneNumber

#line default
#line hidden
#nullable disable
                                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.PhoneNumber = __value, customer.PhoneNumber)));
                                __builder6.AddMarkupContent(41, "\r\n                        <br>\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudButton>(42);
                                __builder6.AddAttribute(43, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 21 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                            Variant.Filled

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(44, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 21 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                                   Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                                                            OnClickCallback

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(47, 
#nullable restore
#line 22 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                              customer.Id > 0 ? "Update":"Save"

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(48, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(49);
                __builder2.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                             ModalCancelCallBack

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(52, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(54);
                __builder2.AddAttribute(55, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 31 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                          Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
                                                   ModalSubmitCallBack

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(58, "Ok");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.MudBlazorApp.Pages.Customer_PopUp
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
