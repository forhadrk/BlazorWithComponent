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
#line 2 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\CustomerInfo.razor"
using MudBlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class CustomerInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\Projects\GIT\MudBlazorApp\MudBlazorApp\Pages\CustomerInfo.razor"
      
    [CascadingParameter]
    MudDialogInstance MudDialog { get; set; }

    private Customer customer = new Customer();
    private List<Customer> customers = new List<Customer>();

    private bool hover = true;
    private bool dense = true;
    private bool striped = true;
    private bool bordered = true;

    private bool visible = false;
    private string searchstring = "";
    private string ModalLabelName = "";
    private string ButtonLabel = "";

    private void OpenDialog()
    {
        customer = new Customer();
        visible = true;
    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            GetAllCustomer();
        }
        catch (Exception)
        {
            Snackbar.Add("Error Occured..!", Severity.Error);
        }
    }

    private List<Customer> GetAllCustomer()
    {
        customers = customerService.GetCustomers();
        return customers;
    }

    private bool Search(Customer customer)
    {
        if (customer.FirstName != null && customer.LastName != null && customer.PhoneNumber != null &&
            (customer.FirstName.Contains(searchstring, StringComparison.OrdinalIgnoreCase)) ||
            (customer.FirstName.Contains(searchstring, StringComparison.OrdinalIgnoreCase)) ||
            (customer.FirstName.Contains(searchstring, StringComparison.OrdinalIgnoreCase)))
        {
            return true;
        }
        return false;
    }

    private void Edit(int Id)
    {
        try
        {
            customer = customers.FirstOrDefault(c => c.Id == Id);
            visible = true;
        }
        catch (Exception)
        {
            Snackbar.Add("Error Occured..!", Severity.Error);
        }
    }

    async Task Delete(int Id)
    {
        try
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure to delete this row?");
            if (confirmed)
            {
                customerService.DeleteCustomer(Id);
                Snackbar.Add("Data Deleted Successfully..!", Severity.Success);
                GetAllCustomer();
            }
        }
        catch (Exception)
        {
            Snackbar.Add("Data Deleted Failed..!", Severity.Error);
        }
    }

    public void SaveCustomerInfo()
    {
        try
        {
            customerService.SaveCustomer(customer);

            if (ButtonLabel == "Update")
                Snackbar.Add("Data Update Successfully..!", Severity.Success);
            else
                Snackbar.Add("Data Save Successfully..!", Severity.Success);

            customer = new Customer();
            GetAllCustomer();
            visible = false;
        }
        catch (Exception)
        {
            Snackbar.Add("Data Process Failed..!", Severity.Error);
        }
    }

    void SubmitModal() => visible = false;
    void CancelModal() => visible = false;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazor.ISnackbar snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService customerService { get; set; }
    }
}
#pragma warning restore 1591