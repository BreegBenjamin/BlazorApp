#pragma checksum "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9da32c94275483ba44f9b91b6d93776ac9817b92"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp3.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using BlazorApp3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using BlazorApp3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class ListaElementos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "style", "display:grid; grid-template-columns:1fr 1fr; grid-gap:20px;");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "<p>Ejercicio 1 desde el iterador <h3>ForEach</h3></p>\r\n        <br>\r\n        ");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "list-group");
#nullable restore
#line 6 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
             foreach (var item in _salmons)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "list-group-item");
            __builder.AddContent(8, 
#nullable restore
#line 8 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                             item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        <br>\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-info");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                                Ejerccio1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Click 1");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "<p>Ejercicio 2 desde el <h3>Bucle For</h3></p>\r\n        <br>\r\n        ");
            __builder.OpenElement(17, "ul");
            __builder.AddAttribute(18, "class", "list-group");
#nullable restore
#line 18 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
             for (int i = 0; i < _salmonsFor.Count; i++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "li");
            __builder.AddAttribute(20, "class", "list-group-item");
            __builder.AddContent(21, 
#nullable restore
#line 20 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                             _salmonsFor[i]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        <br>\r\n        ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-info");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                                Ejerccio2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Click 2");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddMarkupContent(29, "<p>Ejercicio 3 Inicialización de la lista</p>\r\n        <br>\r\n        ");
            __builder.OpenElement(30, "ul");
            __builder.AddAttribute(31, "class", "list-group");
#nullable restore
#line 30 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
             for (int i = 0; i < _salmons3.Count; i++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "list-group-item");
            __builder.AddContent(34, 
#nullable restore
#line 32 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                             _salmons3[i]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        <br>\r\n        ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-info");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                                Ejerccio3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Click 3");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddMarkupContent(42, "<p>Ejercicio 4 Remover Elementos</p>\r\n        <br>\r\n        ");
            __builder.OpenElement(43, "ul");
            __builder.AddAttribute(44, "class", "list-group");
#nullable restore
#line 42 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
             foreach (var item in removeElements)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "list-group-item");
            __builder.AddContent(47, 
#nullable restore
#line 44 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                             item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        <br>\r\n        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn btn-info");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                                Ejerccio4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Click 4");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.OpenElement(54, "div");
            __builder.AddMarkupContent(55, "<p>Ejercicio 5 Numeros pares</p>\r\n        <br>\r\n        ");
            __builder.OpenElement(56, "ul");
            __builder.AddAttribute(57, "class", "list-group");
#nullable restore
#line 54 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
             foreach (var item in numbers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "li");
            __builder.AddAttribute(59, "class", "list-group-item");
            __builder.AddContent(60, 
#nullable restore
#line 56 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                             item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        <br>\r\n        ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-info");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                                Ejerccio5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "Click 5");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.OpenElement(67, "div");
            __builder.AddMarkupContent(68, "<p>Ejercicio 6 Galaxias</p>\r\n        <br>\r\n        ");
            __builder.OpenElement(69, "ul");
            __builder.AddAttribute(70, "class", "list-group");
#nullable restore
#line 66 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
             foreach (var item in galaxieList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "li");
            __builder.AddAttribute(72, "class", "list-group-item");
            __builder.AddContent(73, 
#nullable restore
#line 69 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                     item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(74, "   - ");
            __builder.AddContent(75, 
#nullable restore
#line 69 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                    item.MegaLightYears

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        <br>\r\n        ");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "class", "btn btn-info");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
                                                Ejerccio6

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(80, "Click 6");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\USUARIO\source\repos\BlazorApp3\BlazorApp3\Shared\ListaElementos.razor"
       
    private List<string> _salmons = new List<string> ();
    private List<string> _salmonsFor = new List<string> ();
    private List<string> _salmons3 = new List<string> ();
    private List<string> removeElements = new List<string> { "chinook", "coho", "pink", "sockeye" };
    private List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private List<Galaxy> galaxieList = new List<Galaxy>();


    private void Ejerccio1()
    {
        _salmons = new List<string>{ "chinook", "coho", "pink", "sockeye" };
    }

    private void Ejerccio2()
    {
        _salmonsFor = new List<string> { "chinook", "coho", "pink", "sockeye" };
    }

    private void Ejerccio3()
    {
        _salmons3.Add("chinook");
        _salmons3.Add("coho");
        _salmons3.Add("pink");
        _salmons3.Add("sockeye");
    }

    private void Ejerccio4()
    {
        int index = removeElements.Count -1;
        if (removeElements.Count > 0)
        {
            removeElements.RemoveAt(index);
            index--;
        }
    }

    private void Ejerccio5()
    {
        numbers = numbers.Where(x=> x % 2 == 0 ).ToList();
    }
    private void Ejerccio6()
    {
        galaxieList = new List<Galaxy>
        {
            new Galaxy(){Name="Vía Láctea",MegaLightYears = "200 000 años luz" },
            new Galaxy(){Name="Andrómeda",MegaLightYears = "2.537 años luz" },
            new Galaxy(){Name="Boötes I",MegaLightYears = "23.16 años luz" },
            new Galaxy(){Name="Reticulum II",MegaLightYears = "200 000 años luz" },
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
