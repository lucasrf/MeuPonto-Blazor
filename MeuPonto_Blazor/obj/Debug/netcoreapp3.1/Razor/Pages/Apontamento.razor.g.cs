#pragma checksum "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cf6c5f20cca55a6c9edad0c72bf1f3653a151aa"
// <auto-generated/>
#pragma warning disable 1591
namespace MeuPonto_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\_Imports.razor"
using MeuPonto_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\_Imports.razor"
using MeuPonto_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
using MeuPonto_Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
using MeuPonto;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/apontamento")]
    public partial class Apontamento : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Apontamento</h1>\n");
            __builder.AddMarkupContent(1, "<p>Marque abaixo o apontamento de horas conforme periodo selecionado.</p>\n\n");
            __builder.OpenElement(2, "select");
            __builder.AddAttribute(3, "class", "form-control selectpicker");
            __builder.AddAttribute(4, "ontimeupdate", (
#nullable restore
#line 12 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
                                                                                                           UpdateApontamento()

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
                                                 EmpresaService.SelectedPeriodo.Referencia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EmpresaService.SelectedPeriodo.Referencia = __value, EmpresaService.SelectedPeriodo.Referencia));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(7, "\n    ");
            __builder.OpenElement(8, "option");
            __builder.AddContent(9, "Selecione um valor");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 14 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
     foreach (var item in EmpresaService.GetEmpresa().Periodos)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "        ");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 16 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
                        item.Referencia

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 16 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
__builder.AddContent(14, item.Descricao);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 17 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n\n");
#nullable restore
#line 20 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
 if (apontamentos != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table");
            __builder.AddMarkupContent(20, "\n        ");
            __builder.AddMarkupContent(21, "<thead>\n            <tr>\n                <th>Data</th>\n                <th>Marcacoes</th>\n                <th>Status</th>\n                <th>Observacoes</th>\n                <th></th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(22, "tbody");
            __builder.AddMarkupContent(23, "\n");
#nullable restore
#line 33 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
             foreach (var apontamento in apontamentos)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "            ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\n                ");
            __builder.OpenElement(27, "td");
#nullable restore
#line 36 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
__builder.AddContent(28, apontamento.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.OpenElement(30, "td");
#nullable restore
#line 37 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
__builder.AddContent(31, apontamento.GetMarcacoes());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                ");
            __builder.OpenElement(33, "td");
#nullable restore
#line 38 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
__builder.AddContent(34, apontamento.GetJornada().ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "placeholder", "Observacoes");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
                                                                                              apontamento.Observacao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => apontamento.Observacao = __value, apontamento.Observacao));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                ");
            __builder.OpenElement(44, "td");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "class", "btn btn-primary");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
                                                              () => RedirectMarcacao(apontamento)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n");
#nullable restore
#line 42 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n");
#nullable restore
#line 45 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Apontamento.razor"
       
    private Ponto[] apontamentos;

    protected override async Task OnInitializedAsync()
    {
        await UpdateApontamento();
    }
    public async Task UpdateApontamento()
    {
        if (EmpresaService.SelectedPeriodo.Referencia != DateTime.MinValue)
        {
            apontamentos = await ApontamentoService.GetApontamentos(EmpresaService.GetEmpresa().Funcionarios.First(), EmpresaService.SelectedPeriodo);
        }
    }
    private void RedirectMarcacao(Ponto selectedPonto)
    {
        EmpresaService.SelectedPonto = selectedPonto;
        NavManager.NavigateTo("/marcacao");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApontamentoService ApontamentoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmpresaService EmpresaService { get; set; }
    }
}
#pragma warning restore 1591