#pragma checksum "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b5e57dbd01e79b0b3115618ee29dba01d3d9f82"
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
#line 3 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
using BlazorServerTest.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 10 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorServerTest.Pages.TableTemplate<WeatherForecast>>(3);
            __builder.AddAttribute(4, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IReadOnlyList<WeatherForecast>>(
#nullable restore
#line 16 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
                      forecasts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "<th>Date</th>\r\n        ");
                __builder2.AddMarkupContent(7, "<th>Temp. (C)</th>\r\n        ");
                __builder2.AddMarkupContent(8, "<th>Temp. (F)</th>\r\n        ");
                __builder2.AddMarkupContent(9, "<th>Summary</th>");
            }
            ));
            __builder.AddAttribute(10, "Row", (Microsoft.AspNetCore.Components.RenderFragment<WeatherForecast>)((forecast) => (__builder2) => {
                __builder2.OpenElement(11, "td");
                __builder2.AddContent(12, 
#nullable restore
#line 24 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
             forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "td");
                __builder2.AddContent(15, 
#nullable restore
#line 25 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
             forecast.TemperatureC

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "td");
                __builder2.AddContent(18, 
#nullable restore
#line 26 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
             forecast.TemperatureF

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "td");
                __builder2.AddContent(21, 
#nullable restore
#line 27 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
             forecast.Summary

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table");
            __builder.AddMarkupContent(25, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(26, "tbody");
#nullable restore
#line 40 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 43 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 44 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 45 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 46 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "E:\StudyWebServer\BlazorServerTest\BlazorServerTest\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
