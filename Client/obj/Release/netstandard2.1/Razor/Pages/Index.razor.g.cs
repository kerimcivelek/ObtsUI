#pragma checksum "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e8bb64a903338b26ca05a43b3f329f838be4660"
// <auto-generated/>
#pragma warning disable 1591
namespace ObtsUI.Client.Pages
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
#line 3 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card card-info card-outline row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-12");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, @"<div class=""card-header""><h5 class=""card-title""><i class=""fas fa-chart-area""></i> Bilgi Paneli </h5>

                <div class=""card-tools""><button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse""><i class=""fas fa-minus""></i></button></div></div>

            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-12 col-sm-6 col-md-3 ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "info-box ");
            __builder.AddMarkupContent(15, "<span class=\"info-box-icon bg-info elevation-1\"><i class=\"fas fa-users-cog\"></i></span>\r\n\r\n                            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "info-box-content dark-mode");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "info-box-text");
            __builder.AddMarkupContent(20, "Toplam M????teri ");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "class", "float-right");
            __builder.AddContent(23, 
#nullable restore
#line 33 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                                                                      DateTime.Now.ToString("MMMM")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                                ");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "class", "info-box-number");
#nullable restore
#line 35 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                     if (DashboardTotalMonthDto == null)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<span>0</span>");
#nullable restore
#line 38 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, 
#nullable restore
#line 41 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                         DashboardTotalMonthDto.TotalCustomerThisMonth

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 41 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                                                      
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<small></small>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n                    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-12 col-sm-6 col-md-3");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "info-box mb-3");
            __builder.AddMarkupContent(35, "<span class=\"info-box-icon bg-info elevation-1\"><i class=\"fas fa-wrench\"></i></span>\r\n\r\n                            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "info-box-content dark-mode");
            __builder.AddMarkupContent(38, "<span class=\"info-box-text\">Toplam M????teri <span class=\"float-right\">Bug??n</span></span>");
#nullable restore
#line 57 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                 if (DashboardTotalDayDto == null)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "<span>0</span>");
#nullable restore
#line 60 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, 
#nullable restore
#line 63 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                     DashboardTotalDayDto.TotalCustomerThisDay

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 63 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                                              
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    \r\n                    \r\n                    <div class=\"clearfix hidden-md-up\"></div>\r\n                    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-12 col-sm-6 col-md-3 ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "info-box ");
            __builder.AddMarkupContent(46, "<span class=\"info-box-icon bg-info elevation-1\"><i class=\"fas fa-money-check-alt\"></i></span>\r\n\r\n                            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "info-box-content dark-mode");
            __builder.OpenElement(49, "span");
            __builder.AddAttribute(50, "class", "info-box-text");
            __builder.AddContent(51, " Toplam Tutar ");
            __builder.OpenElement(52, "span");
            __builder.AddAttribute(53, "class", "float-right");
            __builder.AddContent(54, 
#nullable restore
#line 78 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                                                                      DateTime.Now.ToString("MMMM")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                ");
            __builder.OpenElement(56, "span");
            __builder.AddAttribute(57, "class", "info-box-number");
#nullable restore
#line 80 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                     if (DashboardTotalMonthDto == null)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(58, "<span>0</span>");
#nullable restore
#line 83 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, 
#nullable restore
#line 86 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                         DashboardTotalMonthDto.TotalPriceThisMonth.ToString("C")

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 86 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                                                                 
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(60, "<small></small>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    \r\n                    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col-12 col-sm-6 col-md-3");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "info-box mb-3");
            __builder.AddMarkupContent(66, "<span class=\"info-box-icon bg-info elevation-1\"><i class=\"fas fa-money-check\"></i></span>\r\n\r\n                            ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "info-box-content dark-mode");
            __builder.AddMarkupContent(69, "<span class=\"info-box-text\">Toplam Tutar <span class=\"float-right\">Bug??n</span></span>");
#nullable restore
#line 102 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                 if (DashboardTotalDayDto == null)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(70, "<span>0</span>");
#nullable restore
#line 105 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, 
#nullable restore
#line 108 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                     DashboardTotalDayDto.TotalPriceThisDay.ToString("C")

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 108 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                                                         ;
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "card card-info card-outline row");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col-md-12");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "card");
            __builder.AddMarkupContent(79, @"<div class=""card-header""><h5 class=""card-title""><i class=""fas fa-chart-area""></i>Ayl??k ????lem ??nceleme </h5>

                <div class=""card-tools""><button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse""><i class=""fas fa-minus""></i></button></div></div>

            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "card-body");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "row");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "col-sm-6");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "card");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "card-header");
            __builder.OpenElement(90, "h3");
            __builder.AddAttribute(91, "class", "card-title");
            __builder.AddMarkupContent(92, "<i class=\"fa fa-calendar-day\"></i>  ");
            __builder.AddContent(93, 
#nullable restore
#line 144 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                                                            DateTime.Now.ToString("MMMM")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(94, "  -   ????lem T??r?? Da????l??m??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                            \r\n                            ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "card-body table-responsive p-0");
            __builder.AddAttribute(98, "style", "height: 200px;");
#nullable restore
#line 148 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                 if (OperataionTypeReport == null)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(99, "<div class=\"text-center\"><div class=\"spinner-border text-info\" role=\"status\"><span class=\"sr-only\"> Kay??t Yok</span></div></div>");
#nullable restore
#line 155 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(100, "table");
            __builder.AddAttribute(101, "class", "table table-hover table-head-fixed text-nowrap");
            __builder.AddMarkupContent(102, "<thead><tr><th> ????lem T??r??</th>\r\n                                                <th>Toplam Dosya</th>\r\n                                                <th>Toplam Tutar</th></tr></thead>\r\n                                        ");
            __builder.OpenElement(103, "tbody");
#nullable restore
#line 168 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                             foreach (var i in OperataionTypeReport)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(104, "tr");
            __builder.AddAttribute(105, "class", "bg-dark");
            __builder.OpenElement(106, "td");
            __builder.AddContent(107, 
#nullable restore
#line 171 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                          i.OperationTypeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                                                    ");
            __builder.OpenElement(109, "td");
            __builder.AddContent(110, 
#nullable restore
#line 172 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                         i.totalOperation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                                    ");
            __builder.OpenElement(112, "td");
            __builder.AddContent(113, 
#nullable restore
#line 173 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                         i.totalPrice.ToString("C")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 175 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 178 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                    <div class=\"clearfix hidden-md-up\"></div>\r\n                    ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "col-sm-6");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "card");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "card-header");
            __builder.OpenElement(121, "h3");
            __builder.AddAttribute(122, "class", "card-title");
            __builder.AddMarkupContent(123, "<i class=\"fa fa-calendar-day\"></i> ");
            __builder.AddContent(124, 
#nullable restore
#line 188 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                                                           DateTime.Now.ToString("MMMM")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(125, " - Kategoriye G??re ??r??n Da????l??m??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                            \r\n                            ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "card-body table-responsive p-0");
            __builder.AddAttribute(129, "style", "height: 200px;");
#nullable restore
#line 192 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                 if (ProductByCategoryReport == null)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(130, "<div class=\"text-center\"><div class=\"spinner-border text-info\" role=\"status\"><span class=\"sr-only\">Kay??t Yok</span></div></div>");
#nullable restore
#line 199 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(131, "table");
            __builder.AddAttribute(132, "class", "table table-hover table-head-fixed text-nowrap");
            __builder.AddMarkupContent(133, @"<thead><tr><th> Kategori</th>
                                                <th>??r??n</th>
                                                <th>Toplam Adet</th>
                                                <th>Toplam Tutar</th></tr></thead>
                                        ");
            __builder.OpenElement(134, "tbody");
#nullable restore
#line 212 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                             foreach (var i in ProductByCategoryReport)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(135, "tr");
            __builder.AddAttribute(136, "class", "bg-dark");
            __builder.OpenElement(137, "td");
            __builder.AddContent(138, 
#nullable restore
#line 215 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                          i.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                                                    ");
            __builder.OpenElement(140, "td");
            __builder.AddContent(141, 
#nullable restore
#line 216 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                         i.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                                                    ");
            __builder.OpenElement(143, "td");
            __builder.AddContent(144, 
#nullable restore
#line 217 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                         i.totalOperation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                                                    ");
            __builder.OpenElement(146, "td");
            __builder.AddContent(147, 
#nullable restore
#line 218 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                         i.totalPrice.ToString("C")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 220 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 223 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "card card-info card-outline row");
            __builder.OpenElement(151, "div");
            __builder.AddAttribute(152, "class", "col-12");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "card");
            __builder.OpenElement(155, "div");
            __builder.AddAttribute(156, "class", "card-header");
            __builder.OpenElement(157, "h3");
            __builder.AddAttribute(158, "class", "card-title");
            __builder.AddMarkupContent(159, "<i class=\"fa fa-calendar-check\"></i> Bug??n ( ");
            __builder.AddContent(160, 
#nullable restore
#line 248 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                                                      DateTime.Now.Date.ToString("dd.MM.yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(161, " )  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n\r\n                ");
            __builder.AddMarkupContent(163, "<div class=\"card-tools\"><span> M????teri Listesi</span></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n            \r\n            ");
            __builder.OpenElement(165, "div");
            __builder.AddAttribute(166, "class", "card-body table-responsive p-0");
            __builder.AddAttribute(167, "style", "height: 300px;");
#nullable restore
#line 256 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                 if (customerList == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(168, "<div class=\"text-center\"><div class=\"spinner-border text-info\" role=\"status\"><span class=\"sr-only\">Y??kleniyor...</span></div></div>");
#nullable restore
#line 263 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(169, "table");
            __builder.AddAttribute(170, "id", "example");
            __builder.AddAttribute(171, "class", "table table-hover table-head-fixed text-nowrap");
            __builder.AddMarkupContent(172, @"<thead><tr><th>????lemler</th>
                                <th>Kay??t Tarihi</th>
                                <th>M????teri Ad??</th>
                                <th>Soyad??</th>
                                <th>Plaka</th>
                                <th>Marka-Model</th>
                                <th>Gsm</th>
                                <th>Not</th></tr></thead>
                        ");
            __builder.OpenElement(173, "tbody");
#nullable restore
#line 280 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                             foreach (var i in customerList)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(174, "tr");
            __builder.AddAttribute(175, "class", "bg-dark");
            __builder.OpenElement(176, "td");
            __builder.OpenElement(177, "button");
            __builder.AddAttribute(178, "class", "btn btn-dark btn-sm");
            __builder.AddAttribute(179, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 284 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                                                        () => CustomerDetail(i.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(180, "<i class=\"fa fa-wrench\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                                        ");
            __builder.OpenElement(182, "button");
            __builder.AddAttribute(183, "class", "btn btn-dark btn-sm");
            __builder.AddAttribute(184, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 285 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                                                                        () => CustomerEdit(i.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(185, "<i class=\"fa fa-edit\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                                    ");
            __builder.OpenElement(187, "td");
            __builder.AddContent(188, 
#nullable restore
#line 288 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                         i.RegisterDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                                    ");
            __builder.OpenElement(190, "td");
            __builder.AddContent(191, 
#nullable restore
#line 289 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                         i.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n                                    ");
            __builder.OpenElement(193, "td");
            __builder.AddContent(194, 
#nullable restore
#line 290 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                         i.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n                                    ");
            __builder.OpenElement(196, "td");
            __builder.AddContent(197, 
#nullable restore
#line 291 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                         i.Plaka

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n                                    ");
            __builder.OpenElement(199, "td");
            __builder.AddContent(200, 
#nullable restore
#line 292 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                         i.Brand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n                                    ");
            __builder.OpenElement(202, "td");
            __builder.AddContent(203, 
#nullable restore
#line 293 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                         i.Gsm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\r\n                                    ");
            __builder.OpenElement(205, "td");
            __builder.AddContent(206, 
#nullable restore
#line 294 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                                         i.Note

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 297 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 300 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 309 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Pages\Index.razor"
 
    CustomerDto[] customerList;

    DashboardTotalMonthDto DashboardTotalMonthDto = new DashboardTotalMonthDto();
    DashboardTotalDayDto DashboardTotalDayDto = new DashboardTotalDayDto();
    DashboardListDto[] OperataionTypeReport;
    DashboardListDto[] ProductByCategoryReport;

    protected override async Task OnInitializedAsync()
    {
        var CompanyId = await LocalStorage.GetItemAsync<int>("Company");


        DashboardTotalMonthDto = await DashBoardService.TotalDashboardInfoMonth(CompanyId);
        DashboardTotalDayDto = await DashBoardService.TotalDashboardInfoDay(CompanyId);

        OperataionTypeReport = await DashBoardService.OperataionTypeReport(CompanyId);
        ProductByCategoryReport = await DashBoardService.ProductByCategoryReport(CompanyId);

        var date = DateTime.Now.Date.ToString("yyyy-MM-dd");

        customerList = await CustomerService.GetCustomerDate(date, CompanyId);

    }



    void CustomerDetail(int Id)
    {
        NavigationManager.NavigateTo("/Customer/Detail/" + Id);
    }

    void CustomerEdit(int Id)
    {
        NavigationManager.NavigateTo("/Customer/edit/" + Id);
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDashBoardService DashBoardService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService CustomerService { get; set; }
    }
}
#pragma warning restore 1591
