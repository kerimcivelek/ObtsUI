#pragma checksum "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6d371b96f899993c33db09bf507b449f9eeabc1"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/User/Add")]
    public partial class UserAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ObtsUI.Client.Shared.Auth>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "register-page bg-dark");
            __builder.AddMarkupContent(4, "\r\n        \r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-8");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card card-info");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.AddMarkupContent(11, "<div class=\"card-header\">\r\n                    <h3 class=\"card-title\">Profil</h3>\r\n                </div>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                  dto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "card-body form-horizontal bg-dark");
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.AddMarkupContent(26, "<label for=\"inputPassword3\" class=\"col-sm-2 col-form-label\">Marka</label>\r\n                            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-sm-10");
                __builder2.AddMarkupContent(29, "\r\n");
#nullable restore
#line 26 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                 if (companyList != null)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(30, "                                    ");
                __Blazor.ObtsUI.Client.Pages.User.UserAdd.TypeInference.CreateInputSelectNumber_0(__builder2, 31, 32, "CompanyId", 33, "form-control bg-dark", 34, 
#nullable restore
#line 28 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                                                                                 dto.CompanyId

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.CompanyId = __value, dto.CompanyId)), 36, () => dto.CompanyId, 37, (__builder3) => {
                    __builder3.AddMarkupContent(38, "\r\n                                        ");
                    __builder3.AddMarkupContent(39, "<option>-Firma Seçiniz-</option>\r\n");
#nullable restore
#line 30 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                         foreach (var data in companyList)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(40, "                                            ");
                    __builder3.OpenElement(41, "option");
                    __builder3.AddAttribute(42, "value", 
#nullable restore
#line 32 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                            data.CompanyId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(43, 
#nullable restore
#line 32 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                                             data.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\r\n");
#nullable restore
#line 33 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(45, "                                    ");
                }
                );
                __builder2.AddMarkupContent(46, "\r\n");
#nullable restore
#line 35 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(47, "                                ");
                __Blazor.ObtsUI.Client.Pages.User.UserAdd.TypeInference.CreateValidationMessage_1(__builder2, 48, 49, 
#nullable restore
#line 36 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                          ()=>dto.CompanyId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group row");
                __builder2.AddMarkupContent(55, "\r\n                            ");
                __builder2.AddMarkupContent(56, "<label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Kullanıcı Adı</label>\r\n                            ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-sm-10");
                __builder2.AddMarkupContent(59, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "Class", "form-control  bg-dark");
                __builder2.AddAttribute(62, "Id", "Surname");
                __builder2.AddAttribute(63, "required", "required");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                                                                    dto.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.UserName = __value, dto.UserName))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dto.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                                ");
                __Blazor.ObtsUI.Client.Pages.User.UserAdd.TypeInference.CreateValidationMessage_2(__builder2, 68, 69, 
#nullable restore
#line 43 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                          () => dto.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(70, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                        ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group row");
                __builder2.AddMarkupContent(75, "\r\n                            ");
                __builder2.AddMarkupContent(76, "<label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Adı</label>\r\n                            ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-sm-10");
                __builder2.AddMarkupContent(79, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(80);
                __builder2.AddAttribute(81, "Class", "form-control  bg-dark");
                __builder2.AddAttribute(82, "Id", "Name");
                __builder2.AddAttribute(83, "required", "required");
                __builder2.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                                                                 dto.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.FirstName = __value, dto.FirstName))));
                __builder2.AddAttribute(86, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dto.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n                                ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "alert-danger");
                __builder2.AddMarkupContent(90, "\r\n                                    ");
                __Blazor.ObtsUI.Client.Pages.User.UserAdd.TypeInference.CreateValidationMessage_3(__builder2, 91, 92, 
#nullable restore
#line 51 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                              () => dto.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(93, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group row");
                __builder2.AddMarkupContent(99, "\r\n                            ");
                __builder2.AddMarkupContent(100, "<label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Soyadı</label>\r\n                            ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "col-sm-10");
                __builder2.AddMarkupContent(103, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(104);
                __builder2.AddAttribute(105, "Class", "form-control  bg-dark");
                __builder2.AddAttribute(106, "Id", "LastName");
                __builder2.AddAttribute(107, "required", "required");
                __builder2.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                                                                     dto.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.LastName = __value, dto.LastName))));
                __builder2.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dto.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\r\n                                ");
                __Blazor.ObtsUI.Client.Pages.User.UserAdd.TypeInference.CreateValidationMessage_4(__builder2, 112, 113, 
#nullable restore
#line 60 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                          () => dto.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(114, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n\r\n                        ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "form-group row");
                __builder2.AddMarkupContent(119, "\r\n                            ");
                __builder2.AddMarkupContent(120, "<label for=\"inputPassword3\" class=\"col-sm-2 col-form-label\">Parola</label>\r\n                            ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "col-sm-10");
                __builder2.AddMarkupContent(123, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(124);
                __builder2.AddAttribute(125, "Class", "form-control  bg-dark");
                __builder2.AddAttribute(126, "Id", "Plaka");
                __builder2.AddAttribute(127, "required", "required");
                __builder2.AddAttribute(128, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                                                                  dto.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(129, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dto.Password = __value, dto.Password))));
                __builder2.AddAttribute(130, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dto.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(131, "\r\n                                ");
                __Blazor.ObtsUI.Client.Pages.User.UserAdd.TypeInference.CreateValidationMessage_5(__builder2, 132, 133, 
#nullable restore
#line 68 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                          () => dto.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(134, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n\r\n                        ");
                __builder2.OpenElement(137, "button");
                __builder2.AddAttribute(138, "type", "submit");
                __builder2.AddAttribute(139, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
                                                        Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "class", "btn btn-dark float-right");
                __builder2.AddContent(141, "Kaydet");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(144, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\User\UserAdd.razor"
           

        UserDto dto = new UserDto();


        SelectCompanyDto[] companyList;
        protected override async Task OnInitializedAsync()
        {

            companyList = await CopmanyService.SelectCompany();
        }

        private async void Save()
        {
            try
            {
                await AutService.Add(dto);
                CompanyBack();
            }
            catch (Exception e)
            {
                toastService.ShowInfo(e.Message.ToString(), dto.FirstName + " " + dto.LastName);
            }
        }

        void CompanyBack()
        {
            NavigationManager.NavigateTo("/User/List/");
        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICopmanyService CopmanyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AutService { get; set; }
    }
}
namespace __Blazor.ObtsUI.Client.Pages.User.UserAdd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelectNumber_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::ObtsUI.Client.Utilities.InputSelectNumber<T>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
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
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591