#pragma checksum "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\Pages\Game\Game.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4de066ee6f850a66be88ef4ba058b7ac74c40b4e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DotsAndBoxes.Pages.Game
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\_Imports.razor"
using DotsAndBoxes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\_Imports.razor"
using DotsAndBoxes.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\Pages\Game\Game.razor"
using JsConsole;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/game/{gameId:int}")]
    public partial class Game : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\seibel\IdeaProjects\Privat\DotsAndBoxes\old\Pages\Game\Game.razor"
       

    [Parameter]
    public int GameId { get; set; }

    protected override void OnInitialized()
    {
    // Console.WriteLine($"Server: {GameId}");
        JsConsole.Log(Logger, $"Browser: {GameId}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Logger { get; set; }
    }
}
#pragma warning restore 1591
