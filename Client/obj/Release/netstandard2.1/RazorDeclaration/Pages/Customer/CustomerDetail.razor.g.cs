// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ObtsUI.Client.Pages.Customer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Newtonsoft.Json.Converters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Shared.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Shared.Dto.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Shared.Dto.Company;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Shared.Dto.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Shared.Dto.Operation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Shared.Dto.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Shared.Dto.VehicleBrand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Shared.Dto.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Client.Componets.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Client.Componets.Notes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using ObtsUI.Client.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Customer/Detail/{Id:int}")]
    public partial class CustomerDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 409 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Customer\CustomerDetail.razor"
       

    [Parameter]
    public int Id { get; set; }


    CustomerDto customer = new CustomerDto();
    OperationDto operation = new OperationDto();
    OperationDetailDto operationDetail = new OperationDetailDto();

    OperationListDto[] operationList;
    OperationTypesDto[] operationTypes;
    CategoryDto[] categoryList;
    ProductDto[] productList;
    OperationDetailListDto[] _operationDetailList;

    NoteDto notedto = new NoteDto();
    NoteDto[] noteList;

    protected override async Task OnInitializedAsync()
    {
        StateHasChanged();

        customer = await customerService.GetCustomerById(Id);
        operationList = await operationService.GetCustomerById(customer.Id);
        operationTypes = await operationService.GetOperationTypes();

        var userkey = await LocalStorage.GetItemAsync<Guid>("key");
        operation.key = userkey;

        operation.CustomerId = customer.Id;
        operationDetail.RegisterDate = DateTime.Now.Date;

        var CompanyId = await LocalStorage.GetItemAsync<int>("Company");
        categoryList = await categoryService.CategoryList(CompanyId);
        productList = await productService.Products();




    }

    private async Task SelectCategory(int value)
    {

        productList = null;
        operationDetail.CategoryId = value;
        await ResultProductList(value);
        StateHasChanged();

    }
    private async Task ResultProductList(int CategoryId)
    {
        productList = await productService.ProductList(CategoryId);
        StateHasChanged();

    }

    private async void AddOperation()
    {
        try
        {
            await operationService.Add(operation);
        }
        catch (Exception e)
        {

            toastService.ShowSuccess(e.Message, customer.Name + " " + customer.Surname);
        }
        operationList = await operationService.GetCustomerById(customer.Id);
        operationTypes = await operationService.GetOperationTypes();
        ToggleModal();

    }
    private void GetByOperation(int Id)
    {
        operationDetail.OperationId = Id;
        StateHasChanged();
    }
    private void OperationDetail(int Id)
    {
        ToggleProductDelete();
        operationDetail.Id = Id;

    }
    private async void AddOperationDetail()
    {
        try
        {
            await operationDetailService.Add(operationDetail);
        }
        catch (Exception e)
        {

            toastService.ShowSuccess(e.Message, "Bilgi");
        }
        _operationDetailList = await operationDetailService.GetOperationById(operationDetail.OperationId);
        operationDetail.Price = 0;
        operationDetail.Quantity = 1;
        operationDetail.Discount = 0;
        operationDetail.ExternalProduct = false;
        operationDetail.Note = null;

        StateHasChanged();
    }
    private async void OperationDetailList(int Id)
    {
        operationDetail.OperationId = Id;
        _operationDetailList = await operationDetailService.GetOperationById(Id);
        StateHasChanged();
    }

    private async void OperationDetaiDelete()
    {
        try
        {
            await operationDetailService.DeleteModel(operationDetail);
        }
        catch (Exception e)
        {

            toastService.ShowError(e.Message, "Bilgi");
        }
        operationDetail.Id = 0;
        OperationDetailList(operationDetail.OperationId);

        ToggleProductDelete();

        StateHasChanged();
    }


    private void CustomerListBack()
    {
        NavigationManager.NavigateTo("/Customer/List");
    }
    void CustomerEdit(int Id)
    {
        NavigationManager.NavigateTo("/Customer/edit/" + Id);
    }


    void OperationPrint(int Id)
    {
        NavigationManager.NavigateTo("/Print/"+ Id);
    }

    void ProductEdit(int Id)
    {
        NavigationManager.NavigateTo("/OperationDetail/Edit/" + Id);
    }

    #region



    [Parameter]
    public RenderFragment ChildContent { get; set; }


    bool open = false;
    string modalClass => open ? "modal fade show" : "modal fade";
    string displayMode => open ? "block" : "none";

    private void ToggleModal()
    {
        open = !open;
        StateHasChanged();
    }


    [Parameter]
    public RenderFragment ChildContentDeleteProduct { get; set; }

    bool openDelete = false;
    string modalDeleteClass => openDelete ? "modal fade show" : "modal fade";
    string displayModeDelete => openDelete ? "block" : "none";

    private void ToggleProductDelete()
    {
        openDelete = !openDelete;
        StateHasChanged();
    }

    #endregion

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INoteService noteService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService categoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOperationDetailService operationDetailService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOperationService operationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService customerService { get; set; }
    }
}
#pragma warning restore 1591
