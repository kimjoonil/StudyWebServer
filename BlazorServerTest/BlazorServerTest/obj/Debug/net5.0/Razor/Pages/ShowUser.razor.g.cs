#pragma checksum "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\ShowUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce5fd0c93fb7a94cfe264939fb6fff98d537baf4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\_Imports.razor"
using BlazorServerTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\_Imports.razor"
using BlazorServerTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\ShowUser.razor"
using BlazorServerTest.Data;

#line default
#line hidden
#nullable disable
    public partial class ShowUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddMarkupContent(1, "\r\n    Users: ");
            __builder.OpenElement(2, "b");
            __builder.AddContent(3, 
#nullable restore
#line 4 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\ShowUser.razor"
               Users.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<BlazorServerTest.Pages.Counter>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "ul");
            __builder.AddAttribute(8, "class", "list-group");
#nullable restore
#line 12 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\ShowUser.razor"
     foreach (UserData user in Users)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "class", "list-group-item");
            __builder.SetKey(
#nullable restore
#line 14 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\ShowUser.razor"
                  user

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "class", "btn btn-link");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\ShowUser.razor"
                                                                (() => KickUser(user))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "[Kick]");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "label");
            __builder.AddAttribute(18, "style", "color:" + (
#nullable restore
#line 16 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\ShowUser.razor"
                                 Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, 
#nullable restore
#line 16 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\ShowUser.razor"
                                         user.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\ShowUser.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\ShowUser.razor"
       

    [CascadingParameter(Name = "ThemeColor")]
    string Color { get; set; }

    [Parameter]
    public List<UserData> Users { get; set; }

    [Parameter]
    public Action CallbackTest { get; set; }

    // asp.net core 함수 설명: 렌더링 트리의 부모로부터 초기 매개 변수를 수신하여 구성 요소를 시작할 준비가 되면 호출되는 메서드입니다.
    protected override void OnInitialized()
    {
        Users.Add(new UserData() { Name = "rgl" });
        Users.Add(new UserData() { Name = "rgll" });
        Users.Add(new UserData() { Name = "rglll" });
    }

    public void AddUser(UserData user)
    {
        Users.Add(user);
    }

    public void KickUser(UserData user)
    {
        Users.Remove(user);

        CallbackTest.Invoke();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
