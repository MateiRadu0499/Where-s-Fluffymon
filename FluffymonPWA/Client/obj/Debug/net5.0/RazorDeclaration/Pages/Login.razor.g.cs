// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FluffymonPWA.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using FluffymonPWA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using FluffymonPWA.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Login.razor"
using FluffymonPWA.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Login.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Matei Radu\OneDrive\Desktop\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Login.razor"
       
    private User user = new User();
    private string res = "";
    private static Timer timer;
    private string localId;


    protected async Task LoginUser()
    {
        HttpResponseMessage response = await Http.PostAsJsonAsync<User>("/api/v1/Login", user);
        if (response.StatusCode.ToString() == "OK")
        {
            localId = Convert.ToString(response.Content.ReadAsStringAsync());
            await localStorage.SetItemAsync("authenticated", "True");
            await localStorage.SetItemAsync("id", response.Content.ReadAsStringAsync());
            res = "Logged in succesfully!";

            timer = new Timer();
            timer.Interval = 2000;

            timer.Elapsed += (sender, args) =>
            {
                NavManager.NavigateTo("/profile", true);
            };

            timer.AutoReset = true;
            timer.Enabled = true;
        }
        else
        {
            res = "Username or password incorrect, try again.";
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
