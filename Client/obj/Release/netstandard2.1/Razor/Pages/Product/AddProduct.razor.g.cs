#pragma checksum "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ce488c52343aec5a03dcffe3580eb48394c8e4d"
// <auto-generated/>
#pragma warning disable 1591
namespace ObtsUI.Client.Pages.Product
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/Add")]
    public partial class AddProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card card-info card-outline");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.AddMarkupContent(8, "<div class=\"card-header\"><h3 class=\"card-title\">Ürün Giriş Formu</h3>\r\n\r\n                    <div class=\"card-tools\"><button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"collapse\"><i class=\"fas fa-minus\"></i></button></div></div>\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body p-0");
            __builder.OpenElement(11, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 28 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                          product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 28 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                  Insert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "card-body form-horizontal bg-dark");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group row");
                __builder2.AddMarkupContent(24, "<label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Kategori</label>\r\n                                    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-sm-10");
#nullable restore
#line 35 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                         if (categories != null)
                                        {

#line default
#line hidden
#nullable disable
                __Blazor.ObtsUI.Client.Pages.Product.AddProduct.TypeInference.CreateInputSelectNumber_0(__builder2, 27, 28, "ProductId", 29, "form-control bg-dark ", 30, 
#nullable restore
#line 37 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                             product.CategoryId

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.CategoryId = __value, product.CategoryId)), 32, () => product.CategoryId, 33, (__builder3) => {
                    __builder3.AddMarkupContent(34, "<option tabindex=\"0\" value=\"0\" selected>--- Lütfen Kategori Seçiniz--- </option>");
#nullable restore
#line 39 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                 foreach (var data in categories)
                                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(35, "option");
                    __builder3.AddAttribute(36, "value", 
#nullable restore
#line 41 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                    data.CategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(37, 
#nullable restore
#line 41 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                                      data.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 42 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"

                                                    }

#line default
#line hidden
#nullable disable
                }
                );
#nullable restore
#line 45 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                                ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group row");
                __builder2.AddMarkupContent(41, "<label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Ürün Adı</label>\r\n                                    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "Class", "form-control  bg-dark");
                __builder2.AddAttribute(46, "Id", "ProductName");
                __builder2.AddAttribute(47, "required", "required");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                                                                product.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductName = __value, product.ProductName))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.ProductName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                                        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "alert-danger");
                __Blazor.ObtsUI.Client.Pages.Product.AddProduct.TypeInference.CreateValidationMessage_1(__builder2, 54, 55, 
#nullable restore
#line 54 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                      ()=>product.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                                ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group row");
                __builder2.AddMarkupContent(59, "<label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Alış Tarihi</label>\r\n                                    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-sm-10");
                __Blazor.ObtsUI.Client.Pages.Product.AddProduct.TypeInference.CreateInputDate_2(__builder2, 62, 63, "form-control  bg-dark", 64, "RegisterDate", 65, "required", 66, 
#nullable restore
#line 62 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                                                                 product.RegisterDate

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.RegisterDate = __value, product.RegisterDate)), 68, () => product.RegisterDate);
                __builder2.AddMarkupContent(69, "\r\n                                        ");
                __Blazor.ObtsUI.Client.Pages.Product.AddProduct.TypeInference.CreateValidationMessage_3(__builder2, 70, 71, 
#nullable restore
#line 63 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                  ()=>product.RegisterDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                                ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group row");
                __builder2.AddMarkupContent(75, "<label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Alış Fiyatı</label>\r\n                                    ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col-sm-10");
                __Blazor.ObtsUI.Client.Pages.Product.AddProduct.TypeInference.CreateInputNumber_4(__builder2, 78, 79, "form-control  bg-dark", 80, "PurchasePrice", 81, "required", 82, 
#nullable restore
#line 69 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                                                                    product.PurchasePrice

#line default
#line hidden
#nullable disable
                , 83, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.PurchasePrice = __value, product.PurchasePrice)), 84, () => product.PurchasePrice);
                __builder2.AddMarkupContent(85, "\r\n                                        ");
                __Blazor.ObtsUI.Client.Pages.Product.AddProduct.TypeInference.CreateValidationMessage_5(__builder2, 86, 87, 
#nullable restore
#line 70 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                  ()=>product.PurchasePrice

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group row");
                __builder2.AddMarkupContent(91, "<label for=\"inputPassword3\" class=\"col-sm-2 col-form-label\">Satış fiyatı</label>\r\n                                    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "col-sm-10");
                __Blazor.ObtsUI.Client.Pages.Product.AddProduct.TypeInference.CreateInputNumber_6(__builder2, 94, 95, "form-control  bg-dark", 96, "SalePrice", 97, "required", 98, 
#nullable restore
#line 76 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                                                                product.SalePrice

#line default
#line hidden
#nullable disable
                , 99, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.SalePrice = __value, product.SalePrice)), 100, () => product.SalePrice);
                __builder2.AddMarkupContent(101, "\r\n                                        ");
                __Blazor.ObtsUI.Client.Pages.Product.AddProduct.TypeInference.CreateValidationMessage_7(__builder2, 102, 103, 
#nullable restore
#line 77 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                  ()=>product.SalePrice

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n\r\n                                ");
                __builder2.AddMarkupContent(105, "<button type=\"submit\" class=\"btn btn-dark float-right\"><i class=\"fas fa-user-check\"></i> Kaydet</button>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            \r\n            ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "card");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "card-header");
            __builder.AddMarkupContent(111, "<h3 class=\"card-title\"><i class=\"fa fa-list\"></i> Kategoriler</h3>\r\n\r\n                    ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "card-tools");
            __builder.OpenElement(114, "button");
            __builder.AddAttribute(115, "type", "button");
            __builder.AddAttribute(116, "class", "btn btn-sm bg-dark");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                                   newCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(118, "<i class=\"fas fa-plus\"> Yeni Ekle</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "card-body p-0");
#nullable restore
#line 100 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                     if (categories == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(122, "<p class=\"bg-dark\"><em>Yükleniyor...</em></p>");
#nullable restore
#line 103 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(123, "ul");
            __builder.AddAttribute(124, "class", "nav nav-pills flex-column");
#nullable restore
#line 107 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                             foreach (var i in categories)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(125, "li");
            __builder.AddAttribute(126, "class", "nav-link");
            __builder.OpenElement(127, "a");
            __builder.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                   () => ProductList(i.CategoryId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(129, "class", "nav-link");
            __builder.AddMarkupContent(130, "<i class=\"fa fa-search bg-dark \"></i>\r\n                                        ");
            __builder.AddContent(131, 
#nullable restore
#line 112 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                         i.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 115 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 117 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n    \r\n    ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "col-md-8");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "card card-info card-outline");
            __builder.AddMarkupContent(137, @"<div class=""card-header""><h3 class=""card-title""><i class=""fa fa-list""></i> Ürün Listesi</h3>

                <div class=""card-tools""><div class=""input-group input-group-sm""><input type=""text"" class=""form-control"" placeholder=""Ürün Ara"">
                        <div class=""input-group-append""><div class=""btn btn-primary""><i class=""fas fa-search""></i></div></div></div></div></div>
            ");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "card-body p-0");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "table-responsive mailbox-messages");
#nullable restore
#line 146 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                     if (products == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(142, "<p class=\"content\">Ürünleri Listelemek İçin <i class=\"fa fa-search\"></i> Kategori Seçiniz...</p>");
#nullable restore
#line 149 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(143, "table");
            __builder.AddAttribute(144, "class", "table table-hover table-striped");
            __builder.AddMarkupContent(145, "<thead><tr><th>Ürün Adı</th></tr></thead>\r\n                            ");
            __builder.OpenElement(146, "tbody");
#nullable restore
#line 159 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                 foreach (var i in products)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(147, "tr");
            __builder.OpenElement(148, "td");
            __builder.OpenElement(149, "button");
            __builder.AddAttribute(150, "class", "btn btn-dark btn-sm");
            __builder.AddAttribute(151, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 163 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                                             () => ProductEdit(i.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(152, "<i class=\"fa fa-edit\"></i>");
            __builder.CloseElement();
            __builder.AddContent(153, " ");
            __builder.AddContent(154, 
#nullable restore
#line 163 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                                                                                                                                             i.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 166 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 169 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 179 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Product\AddProduct.razor"
       

    CategoryDto[] categories;
    Product[] products;
    Product product = new Product();
    protected override async Task OnInitializedAsync()
    {
        var CompanyId = await LocalStorage.GetItemAsync<int>("Company");
        categories = await categoryService.CategoryList(CompanyId);
        product.RegisterDate = DateTime.Now;
    }

    private async void Insert()
    {
        try
        {
            await productService.Add(product);
        }
        catch (Exception e)
        {
            toastService.ShowSuccess(e.Message.ToString(), product.ProductName);
            product.ProductName = null;
            product.PurchasePrice = 0;
            product.SalePrice = 0;
            StateHasChanged();

        }
    }
    void ProductEdit(int Id)
    {
        NavigationManager.NavigateTo("/Product/Detail/" + Id);
    }

    void newCategory()
    {
        NavigationManager.NavigateTo("/Category/Add/");
    }


    private async Task ProductList(int CategoryId)
    {
        products = await productService.Products(CategoryId);
        StateHasChanged();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService categoryService { get; set; }
    }
}
namespace __Blazor.ObtsUI.Client.Pages.Product.AddProduct
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
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "Id", __arg1);
        __builder.AddAttribute(__seq2, "required", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "Id", __arg1);
        __builder.AddAttribute(__seq2, "required", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "Id", __arg1);
        __builder.AddAttribute(__seq2, "required", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
