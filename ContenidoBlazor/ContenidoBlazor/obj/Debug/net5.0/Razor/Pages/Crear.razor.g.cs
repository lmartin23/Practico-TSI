#pragma checksum "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30edd5e149fb78ae4b6fe53c9bf1f3c667c4c52f"
// <auto-generated/>
#pragma warning disable 1591
namespace ContenidoBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\_Imports.razor"
using ContenidoBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\_Imports.razor"
using ContenidoBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
using ContenidoBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/crear")]
    public partial class Crear : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Agregar Nuevo Contenido</h3>\r\n\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group col-md-6");
            __builder.AddMarkupContent(7, "<label for=\"inputTitulo\">Titulo</label>\r\n          ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "id", "inputTitulo");
            __builder.AddAttribute(12, "placeholder", "Titulo");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
                                                                            cont.Titulo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cont.Titulo = __value, cont.Titulo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group col-md-6");
            __builder.AddMarkupContent(18, "<label for=\"inputAutor\">Autor</label>\r\n          ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "id", "inputAutor");
            __builder.AddAttribute(23, "placeholder", "Autor");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
                                                                          cont.Autor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cont.Autor = __value, cont.Autor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n      ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group");
            __builder.AddMarkupContent(29, "<label for=\"inputDescripcion\">Descripcion</label>\r\n        ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "id", "inputDescripcion");
            __builder.AddAttribute(34, "placeholder", "Breve descripcion...");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
                                                                              cont.Descripcion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cont.Descripcion = __value, cont.Descripcion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n      ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-row");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-group col-md-4");
            __builder.AddMarkupContent(42, "<label for=\"inputCategoria\">Categoria</label>\r\n          ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "class", "form-control");
            __builder.AddAttribute(46, "id", "inputCategoria");
            __builder.AddAttribute(47, "placeholder", "Categoria");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
                                                                              cont.Categoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cont.Categoria = __value, cont.Categoria));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group col-md-4");
            __builder.AddMarkupContent(53, "<label for=\"inputTipoContenido\">Tipo Contenido</label>\r\n          ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "id", "inputTipoContenido");
            __builder.AddAttribute(58, "placeholder", "Tipo Contenido...");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
                                                                                  cont.TipoContendio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cont.TipoContendio = __value, cont.TipoContendio));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "    \r\n        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-group col-md-4");
            __builder.AddMarkupContent(64, "<label asp-for=\"FechaPublicacion\" class=\"control-label\">Fecha publicacion</label>\r\n            ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "type", "date");
            __builder.AddAttribute(67, "class", "form-control");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
                                                            cont.FechaPublicacion

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cont.FechaPublicacion = __value, cont.FechaPublicacion, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n      \r\n      ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "form-group row mb-1");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col-sm-12");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "class", "btn btn-primary");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
                                                      Alta

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Crear");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\lucas\source\repos\ContenidoBlazor\ContenidoBlazor\Pages\Crear.razor"
       
    private Contenido cont = new Contenido();
    public string Url = "/api/Contenidoes";
    private async Task Alta()
    {
        await Http.PostAsJsonAsync<Contenido>(Url, cont);
        nav.NavigateTo("/contenidopage");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
