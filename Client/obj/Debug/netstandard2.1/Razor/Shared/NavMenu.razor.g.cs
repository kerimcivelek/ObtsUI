#pragma checksum "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3ca29b6da513cc604b19d10ff9610e52eeedc3"
// <auto-generated/>
#pragma warning disable 1591
namespace ObtsUI.Client.Shared
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
#nullable restore
#line 8 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Shared\NavMenu.razor"
using ObtsUI.Client.Pages;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ObtsUI.Client.Shared.Auth>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n\r\n");
            __builder.OpenElement(2, "nav");
            __builder.AddAttribute(3, "class", "main-header navbar navbar-expand navbar-dark navbar-light");
            __builder.AddMarkupContent(4, "\r\n    \r\n    ");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "navbar-nav");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<li class=\"nav-item\">\r\n            <a class=\"nav-link\" data-widget=\"pushmenu\" href=\"#\" role=\"button\"><i class=\"fas fa-bars\"></i></a>\r\n        </li>\r\n        ");
            __builder.OpenComponent<ObtsUI.Client.Componets.Customer.NewCustomer>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    \r\n    ");
            __builder.OpenComponent<ObtsUI.Client.Pages.CustomerFilter>(12);
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n    \r\n    ");
            __builder.OpenComponent<ObtsUI.Client.Shared.UserLogOut>(14);
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n\r\n");
            __builder.OpenElement(17, "aside");
            __builder.AddAttribute(18, "class", "main-sidebar sidebar-dark-primary elevation-4");
            __builder.AddMarkupContent(19, "\r\n    \r\n    ");
            __builder.AddMarkupContent(20, "<a class=\"brand-link\">\r\n        <img src=\"../../dist/img/21718720.jpg\" alt=\"AdminLTE Logo\" class=\"brand-image img-circle elevation-3\" style=\"opacity: .8\">\r\n        <span class=\"brand-text font-weight-light\">Car-Med</span>\r\n    </a>\r\n\r\n    \r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "sidebar");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenComponent<ObtsUI.Client.Shared.UserInfo>(24);
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "nav");
            __builder.AddAttribute(27, "class", "mt-2");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "ul");
            __builder.AddAttribute(30, "class", "nav nav-pills nav-sidebar flex-column");
            __builder.AddAttribute(31, "data-widget", "treeview");
            __builder.AddAttribute(32, "role", "menu");
            __builder.AddAttribute(33, "data-accordion", "false");
            __builder.AddMarkupContent(34, "\r\n                \r\n\r\n                ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "nav-item");
            __builder.AddMarkupContent(37, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddAttribute(40, "href", "");
            __builder.AddAttribute(41, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 43 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Shared\NavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "\r\n                        <i class=\"nav-icon fas fa-tachometer-alt\"></i>\r\n                        ");
                __builder2.AddMarkupContent(44, "<p>Ana Sayfa</p>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(46);
            __builder.AddAttribute(47, "class", "nav-link");
            __builder.AddAttribute(48, "href", "/Customer/Add");
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(50, "\r\n                        <i class=\"nav-icon fas fa-user-plus\"></i>\r\n                        ");
                __builder2.AddMarkupContent(51, "<p>Yeni Müşteri</p>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
            __builder.AddAttribute(54, "class", "nav-link");
            __builder.AddAttribute(55, "href", "/Customer/List");
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(57, "\r\n                        <i class=\"nav-icon fas fa-address-book\"></i>\r\n                        ");
                __builder2.AddMarkupContent(58, "<p>Müşteri Listesi</p>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
            __builder.AddAttribute(61, "class", "nav-link");
            __builder.AddAttribute(62, "href", "/Product/Add");
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(64, "\r\n                        <i class=\"nav-icon fas fa-list-ol\"></i>\r\n                        ");
                __builder2.AddMarkupContent(65, "<p>Ürün İşlemleri</p>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(67);
            __builder.AddAttribute(68, "class", "nav-link");
            __builder.AddAttribute(69, "href", "/Report/Index");
            __builder.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(71, "\r\n                        <i class=\"nav-icon fas fa-chart-bar\"></i>\r\n                        ");
                __builder2.AddMarkupContent(72, "<p>Raporlar</p>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n\r\n");
#nullable restore
#line 64 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Shared\NavMenu.razor"
                      

                        if (key == "6a55ce62-586a-4195-99f9-acfff002ec8b")
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(75);
            __builder.AddAttribute(76, "class", "nav-link");
            __builder.AddAttribute(77, "href", "/Company/List");
            __builder.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(79, "\r\n                                <i class=\"nav-icon fas fa-th\"></i>\r\n                                ");
                __builder2.AddMarkupContent(80, "<p>Firmalar</p>\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.AddContent(82, "                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(83);
            __builder.AddAttribute(84, "class", "nav-link");
            __builder.AddAttribute(85, "href", "/User/List");
            __builder.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(87, "\r\n                                <i class=\"nav-icon fas fa-users-cog\"></i>\r\n                                ");
                __builder2.AddMarkupContent(88, "<p>Kullanıcılar</p>\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 77 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Shared\NavMenu.razor"
                        }
                    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(90, "\r\n\r\n\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n\r\n\r\n");
            __builder.OpenComponent<ObtsUI.Client.Shared.CompanyInfo>(96);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Shared\NavMenu.razor"
 
    public string key { get; set; }
    protected override async Task OnInitializedAsync()
    {
        key = await LocalStorage.GetItemAsync<string>("role");


    }

    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591