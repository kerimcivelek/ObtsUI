#pragma checksum "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f46b16405e7ee26c96e9e25083f45dd3fb690166"
// <auto-generated/>
#pragma warning disable 1591
namespace ObtsUI.Client.Pages.User
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/User/Detail/{UserId:int}")]
    public partial class Detail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "register-page bg-dark");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-8");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card card-info");
            __builder.AddMarkupContent(6, "<div class=\"card-header\"><h3 class=\"card-title\">Profil</h3></div>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                              loginDto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "card-body form-horizontal bg-dark");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group row");
                __builder2.AddMarkupContent(18, "<label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Kullanıcı Adı</label>\r\n                        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "Class", "form-control  bg-dark");
                __builder2.AddAttribute(23, "Id", "Surname");
                __builder2.AddAttribute(24, "required", "required");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                                                                loginDto.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginDto.UserName = __value, loginDto.UserName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginDto.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                            ");
                __Blazor.ObtsUI.Client.Pages.User.Detail.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 29 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                      ()=>loginDto.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group row");
                __builder2.AddMarkupContent(34, "<label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Adı</label>\r\n                        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "Class", "form-control  bg-dark");
                __builder2.AddAttribute(39, "Id", "Name");
                __builder2.AddAttribute(40, "required", "required");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                                                             loginDto.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginDto.FirstName = __value, loginDto.FirstName))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginDto.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "alert-danger");
                __Blazor.ObtsUI.Client.Pages.User.Detail.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#nullable restore
#line 37 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                          ()=>loginDto.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group row");
                __builder2.AddMarkupContent(52, "<label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Soyadı</label>\r\n                        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "Class", "form-control  bg-dark");
                __builder2.AddAttribute(57, "Id", "LastName");
                __builder2.AddAttribute(58, "required", "required");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                                                                 loginDto.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginDto.LastName = __value, loginDto.LastName))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginDto.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n                            ");
                __Blazor.ObtsUI.Client.Pages.User.Detail.TypeInference.CreateValidationMessage_2(__builder2, 63, 64, 
#nullable restore
#line 46 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                      ()=>loginDto.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n                    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group row");
                __builder2.AddMarkupContent(68, "<label for=\"inputPassword3\" class=\"col-sm-2 col-form-label\">Parola</label>\r\n                        ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(71);
                __builder2.AddAttribute(72, "Class", "form-control  bg-dark");
                __builder2.AddAttribute(73, "Id", "Plaka");
                __builder2.AddAttribute(74, "required", "required");
                __builder2.AddAttribute(75, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                                                              loginDto.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginDto.Password = __value, loginDto.Password))));
                __builder2.AddAttribute(77, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginDto.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n                            ");
                __Blazor.ObtsUI.Client.Pages.User.Detail.TypeInference.CreateValidationMessage_3(__builder2, 79, 80, 
#nullable restore
#line 54 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                      ()=>loginDto.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n                    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group row");
                __builder2.AddMarkupContent(84, "<label for=\"inputPassword3\" class=\"col-sm-2 col-form-label\">Aktif</label>\r\n                        ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(87);
                __builder2.AddAttribute(88, "Class", "form-control-sm bg-dark");
                __builder2.AddAttribute(89, "Id", "Address");
                __builder2.AddAttribute(90, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 61 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                                                                      loginDto.Status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginDto.Status = __value, loginDto.Status))));
                __builder2.AddAttribute(92, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => loginDto.Status));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n\r\n                    ");
                __builder2.OpenElement(94, "input");
                __builder2.AddAttribute(95, "type", "hidden");
                __builder2.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                       loginDto.Role

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginDto.Role = __value, loginDto.Role));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                    ");
                __builder2.OpenElement(99, "input");
                __builder2.AddAttribute(100, "type", "hidden");
                __builder2.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                       loginDto.key

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginDto.key = __value, loginDto.key));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n                    ");
                __builder2.OpenElement(104, "button");
                __builder2.AddAttribute(105, "type", "submit");
                __builder2.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
                                                    Update

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(107, "class", "btn btn-dark float-right");
                __builder2.AddContent(108, "Kaydet");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\Detail.razor"
       
    [Parameter]
    public int UserId { get; set; }
    LoginDto loginDto = new LoginDto();
    protected override async Task OnInitializedAsync()
    {
        loginDto = await AutService.GetByUserId(UserId);
    }

    private async void Update()
    {
        try
        {

            await AutService.Update(loginDto);
        }
        catch (Exception e)
        {
            toastService.ShowSuccess(e.Message.ToString(), loginDto.FirstName + " " + loginDto.LastName);
        }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AutService { get; set; }
    }
}
namespace __Blazor.ObtsUI.Client.Pages.User.Detail
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
