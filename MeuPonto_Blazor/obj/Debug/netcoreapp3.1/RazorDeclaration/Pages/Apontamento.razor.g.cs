// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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