#pragma checksum "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc0cffe64330dedae40f7214f7efc5a78f45b70d"
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
#line 3 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\Counter.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-secondary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\Counter.razor"
                                            AutoIncrement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Auto Increment");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

    void AutoIncrement()
    {
        var timer = new Timer(x =>
        {
            InvokeAsync(() =>
            {
                IncrementCount();
                StateHasChanged();
            });
        }, null, 1000, 1000);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
