#pragma checksum "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Shared\UserLogOut.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142dcfdd49c4011fc832b696df198ae6557017c3"
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
    public partial class UserLogOut : ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "navbar-nav ml-auto");
            __builder.OpenElement(2, "li");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "role", "button");
            __builder.AddAttribute(5, "class", "nav-link");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Shared\UserLogOut.razor"
                                                    LogOut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "<i class=\"fas fa-sign-out-alt\"></i>\r\n            ");
            __builder.AddMarkupContent(8, "<span>Çıkış</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Shared\UserLogOut.razor"
       
   

    private async void LogOut()
    {
        await AutService.LogOut();
        NavigationManager.NavigateTo("/login/");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AutService { get; set; }
    }
}
#pragma warning restore 1591
