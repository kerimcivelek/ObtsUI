#pragma checksum "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f228feaf0016f93259d2b412e2ee68b1222ef99"
// <auto-generated/>
#pragma warning disable 1591
namespace ObtsUI.Client.Pages.Company
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Company/List")]
    public partial class Companies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ObtsUI.Client.Shared.Auth>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card bg-dark");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-header bg-dark");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "h3");
            __builder.AddAttribute(9, "class", "card-title bg-dark");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "type", "submit");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
                                            CompanyNew

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "btn-sm btn-dark");
            __builder.AddContent(15, "Yeni Firma Ekle");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.AddMarkupContent(18, "<span class=\"float-right\"> Firma Listesi </span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 21 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
     if (companyList == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.AddMarkupContent(21, "<p><em>Yükleniyor...</em></p>\r\n");
#nullable restore
#line 24 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table table-responsive-md table-bordered");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.AddMarkupContent(26, @"<thead>
                <tr class=""bg-dark"">
                    <th>İşlem</th>
                    <th>Firma Adı</th>
                    <th>Yetkili</th>
                    <th>Gsm</th>
                    <th>Adres</th>

                </tr>
            </thead>
            ");
            __builder.OpenElement(27, "tbody");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 39 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
                 foreach (var i in companyList)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "                    ");
            __builder.OpenElement(30, "tr");
            __builder.AddAttribute(31, "class", "bg-dark");
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-dark btn-sm");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
                                                                            () => CompanyDetail(i.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "<i class=\"fa fa-edit\"></i> ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 43 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
                             i.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 44 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
                             i.Owner

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 45 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
                             i.Gsm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 46 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
                             i.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 49 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 52 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Company\Companies.razor"
       

    CompanyDto[] companyList;
    protected override async Task OnInitializedAsync()
    {
        companyList = await CopmanyService.GetCompanies();
    }
    void CompanyDetail(int Id)
    {
        NavigationManager.NavigateTo("/Company/companydetail/" + Id);
    }
    void CompanyNew()
    {
        NavigationManager.NavigateTo("/Company/Add/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICopmanyService CopmanyService { get; set; }
    }
}
#pragma warning restore 1591
