#pragma checksum "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2506574e60ec1dcc7576bec317ce72c966a32f1"
// <auto-generated/>
#pragma warning disable 1591
namespace ObtsUI.Client.Componets.Notes
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
    public partial class Note : ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card card-dark");
            __builder.AddMarkupContent(2, @"<div class=""card-header bg-info""><h3 class=""card-title""><i class=""fa fa-list""></i> Notlar</h3>
        <h3 class=""card-title float-md-right""><a role=""button"" data-toggle=""modal"" data-target=""#Notes""><i class=""fas fa-file""></i> Not Ekle</a></h3></div>
    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                      notedto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "modal fade");
                __builder2.AddAttribute(8, "id", "Notes");
                __builder2.AddAttribute(9, "tabindex", "-1");
                __builder2.AddAttribute(10, "role", "dialog");
                __builder2.AddAttribute(11, "aria-labelledby", "exampleModalLabel");
                __builder2.AddAttribute(12, "aria-hidden", "true");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "modal-dialog");
                __builder2.AddAttribute(15, "role", "document");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "modal-content bg-dark");
                __builder2.AddMarkupContent(18, "<div class=\"modal-header bg-dark\"><h5 class=\"modal-title\" id=\"exampleModalLabel\">Not İşlemleri</h5>\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button></div>");
#nullable restore
#line 22 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                      
                        notedto.CustomerId = CustomerId;
                    

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "modal-body");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "type", "hidden");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                           notedto.CustomerId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => notedto.CustomerId = __value, notedto.CustomerId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "hidden");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                           notedto.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => notedto.Id = __value, notedto.Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "type", "hidden");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                           notedto.RegisterDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => notedto.RegisterDate = __value, notedto.RegisterDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(36);
                __builder2.AddAttribute(37, "Class", "form-control bg-dark");
                __builder2.AddAttribute(38, "Id", "CustomerId");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                                                                  notedto.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => notedto.Text = __value, notedto.Text))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => notedto.Text));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "modal-footer");
                __builder2.AddMarkupContent(45, "<button type=\"button\" class=\"btn btn-dark\" data-dismiss=\"modal\">Kapat</button>\r\n \r\n                        ");
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "type", "submit");
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                        AddNote

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "class", "btn btn-dark");
                __builder2.AddContent(50, "Kaydet");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "card-body bg-dark overflow-auto");
            __builder.AddAttribute(54, "style", "max-height: 200px;");
#nullable restore
#line 45 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
         if (noteList == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, "<p class=\"bg-dark\">Kayıtlı Not Yok</p>");
#nullable restore
#line 48 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
             foreach (var i in noteList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "p");
            __builder.AddAttribute(57, "class", "bg-dark");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "type", "submit");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                      () => NoteDetail(i.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "data-toggle", "modal");
            __builder.AddAttribute(62, "class", "btn btn-dark");
            __builder.AddMarkupContent(63, "<i class=\"fa fa-trash-alt\"></i>");
            __builder.CloseElement();
            __builder.AddContent(64, " ");
            __builder.AddContent(65, 
#nullable restore
#line 54 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                                                                                                                                    i.Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(66, " (");
            __builder.AddContent(67, 
#nullable restore
#line 54 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                                                                                                                                             i.RegisterDate.ToString("dd.MM.yyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(68, ")\r\n                ");
            __builder.CloseElement();
#nullable restore
#line 56 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n\r\n    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", 
#nullable restore
#line 61 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                 modalDeleteClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(72, "id", "deletemodal");
            __builder.AddAttribute(73, "tabindex", "-1");
            __builder.AddAttribute(74, "style", "display:" + " " + (
#nullable restore
#line 61 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                                                   displayModeDelete

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "modal-dialog");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "modal-content bg-dark");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(79);
            __builder.AddAttribute(80, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 64 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                 notedto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 64 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                         NoteDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(83, "<div class=\"modal-header bg-dark\"><h4 class=\"modal-title\"><i class=\"fa fa-exclamation-circle\"> Uyarı </i></h4></div>\r\n                    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "modal-body bg-dark");
                __builder2.AddContent(86, 
#nullable restore
#line 69 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                         ChildContentDeleteNote

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.OpenElement(88, "input");
                __builder2.AddAttribute(89, "type", "hidden");
                __builder2.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                           notedto.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => notedto.Id = __value, notedto.Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                        ");
                __builder2.AddMarkupContent(93, "<div class=\"alert alert-dark\" role=\"alert\"><b>Not silenecek onaylıyor musun ?</b></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                    ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "modal-footer");
                __builder2.OpenElement(97, "button");
                __builder2.AddAttribute(98, "type", "button");
                __builder2.AddAttribute(99, "class", "btn btn-dark");
                __builder2.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
                                                                             ToggleNoteDelete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "data-dismiss", "modal");
                __builder2.AddMarkupContent(102, "<i class=\"fa fa-times-circle\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                        ");
                __builder2.AddMarkupContent(104, "<button type=\"submit\" class=\"btn btn-dark\"><i class=\"fa fa-trash-alt\"></i></button>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "D:\Projelerim\Blazor\ObtsUI\ObtsUI\Client\Componets\Notes\Note.razor"
       

    [Parameter]
    public int CustomerId { get; set; }

    NoteDto notedto = new NoteDto();

    NoteDto[] noteList;

    protected override async Task OnInitializedAsync()
    {
        noteList = await noteService.NotesList(CustomerId);
        notedto.RegisterDate = DateTime.Now;
        StateHasChanged();
    }
    private async void AddNote()
    {
        try
        {
            await noteService.Add(notedto);
        }
        catch (Exception e)
        {
            toastService.ShowSuccess(e.Message, "Bilgi");
        }

        noteList = await noteService.NotesList(CustomerId);
        StateHasChanged();
    }

    private void NoteDetail(int NoteId)
    {
        ToggleNoteDelete();
        notedto.Id = NoteId;
        notedto.CustomerId = CustomerId;
    }

    private async void NoteDelete()
    {
        try
        {
            await noteService.Delete(notedto);
        }
        catch (Exception e)
        {
            toastService.ShowSuccess(e.Message, "Bilgi");

        }
        noteList = await noteService.NotesList(CustomerId);
        notedto.Id = 0;
        notedto.Text = null;
        ToggleNoteDelete();
        StateHasChanged();
    }






    [Parameter]
    public RenderFragment ChildContentDeleteNote { get; set; }

    bool openDelete = false;
    string modalDeleteClass => openDelete ? "modal fade show" : "modal fade";
    string displayModeDelete => openDelete ? "block" : "none";

    private void ToggleNoteDelete()
    {
        openDelete = !openDelete;
        StateHasChanged();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INoteService noteService { get; set; }
    }
}
#pragma warning restore 1591
