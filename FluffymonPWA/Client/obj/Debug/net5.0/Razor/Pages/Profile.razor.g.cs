#pragma checksum "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d26e9c1f50e54c12aac2de5de936707f5654c663"
// <auto-generated/>
#pragma warning disable 1591
namespace FluffymonPWA.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using FluffymonPWA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\_Imports.razor"
using FluffymonPWA.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Profile.razor"
using FluffymonPWA.Client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile/{id}")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "b-mk2n0tthi3");
#nullable restore
#line 7 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Profile.razor"
     if (user == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<h1 b-mk2n0tthi3>Just a second</h1>");
#nullable restore
#line 10 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Profile.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "login-container");
            __builder.AddAttribute(5, "b-mk2n0tthi3");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-container");
            __builder.AddAttribute(8, "b-mk2n0tthi3");
            __builder.OpenElement(9, "form");
            __builder.AddAttribute(10, "method", "post");
            __builder.AddAttribute(11, "b-mk2n0tthi3");
            __builder.AddMarkupContent(12, "<h5 class=\"text-center\" b-mk2n0tthi3>Profile</h5>\r\n                    ");
            __builder.OpenElement(13, "h2");
            __builder.AddAttribute(14, "b-mk2n0tthi3");
            __builder.AddContent(15, "Username: ");
            __builder.AddContent(16, 
#nullable restore
#line 17 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Profile.razor"
                                   user.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "h2");
            __builder.AddAttribute(19, "b-mk2n0tthi3");
            __builder.AddContent(20, "First Name: ");
            __builder.AddContent(21, 
#nullable restore
#line 18 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Profile.razor"
                                     user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "h2");
            __builder.AddAttribute(24, "b-mk2n0tthi3");
            __builder.AddContent(25, "Last Name: ");
            __builder.AddContent(26, 
#nullable restore
#line 19 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Profile.razor"
                                    user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "h2");
            __builder.AddAttribute(29, "b-mk2n0tthi3");
            __builder.AddContent(30, "Phone: ");
            __builder.AddContent(31, 
#nullable restore
#line 20 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Profile.razor"
                                user.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "h2");
            __builder.AddAttribute(34, "b-mk2n0tthi3");
            __builder.AddContent(35, "Phone: ");
            __builder.AddContent(36, 
#nullable restore
#line 21 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Profile.razor"
                                user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Profile.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\Dot Net Speciale\Where-s-Fluffymon\FluffymonPWA\Client\Pages\Profile.razor"
       
    public string Id { get; set; }
    public string loggedIn { get; set; }

    private User user = new User();


    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5001")
    };
    protected override async Task OnInitializedAsync()
    {
        Id = await localStorage.GetItemAsStringAsync("id");
        loggedIn = await localStorage.GetItemAsStringAsync("authenticated");
        user = await httpClient.GetFromJsonAsync<User>("/api/v1/users/" + Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
