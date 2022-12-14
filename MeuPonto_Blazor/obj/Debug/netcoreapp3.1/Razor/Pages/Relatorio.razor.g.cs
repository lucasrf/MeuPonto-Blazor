#pragma checksum "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Relatorio.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f2a36c3788cd082611dc8fb371a2c8ccbf3a6ea"
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
#line 2 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Relatorio.razor"
using MeuPonto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Relatorio.razor"
using MeuPonto_Blazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/relatorio")]
    public partial class Relatorio : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Relatório</h1>\n");
            __builder.AddMarkupContent(1, "<p>Selecione o periodo e o codigo do funcionario para que o relatorio seja gerado.</p>\n\n");
            __builder.AddMarkupContent(2, "<label>Periodo</label>\n\n");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "class", "form-control");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Relatorio.razor"
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
#line 13 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Relatorio.razor"
     foreach (var item in EmpresaService.GetEmpresa().Periodos)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "        ");
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 15 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Relatorio.razor"
                        item.Referencia

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 15 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Relatorio.razor"
__builder.AddContent(14, item.Descricao);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 16 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Relatorio.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n\n");
            __builder.AddMarkupContent(17, "<label>Codigo do funcionario</label>\n");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "name", "nome");
            __builder.AddAttribute(22, "placeholder", "XXXX");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Relatorio.razor"
                                                                  funcionarioCodigo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => funcionarioCodigo = __value, funcionarioCodigo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n<br>\n");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Relatorio.razor"
                                                          p => GeneratePDF()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Gerar PDF");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\320108476\Downloads\MeuPonto-master\MeuPonto_Blazor\Pages\Relatorio.razor"
 
    int funcionarioCodigo;

    private void GeneratePDF()
    {
        var pdf = new Blazor_PDF.PDF.Report();

        List<Funcionario> listaFuncionariosByCodigo = EmpresaService.GetEmpresa().Funcionarios.Where(f => funcionarioCodigo == (f.Codigo)).ToList();

        if (listaFuncionariosByCodigo.Count > 0)
        {
            Funcionario selectedFuncionario = listaFuncionariosByCodigo[0];
            pdf.Generate(js, "Relatorio_" +
                EmpresaService.SelectedPeriodo.Descricao +
                "_FUNC" +
                selectedFuncionario.Codigo +
                ".pdf", listaFuncionariosByCodigo.First(), EmpresaService.SelectedPeriodo);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmpresaService EmpresaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
