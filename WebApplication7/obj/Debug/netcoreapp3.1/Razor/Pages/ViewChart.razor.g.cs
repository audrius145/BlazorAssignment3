#pragma checksum "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c5e471e38f5184cfb04885cb69f27adf46548e"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using WebApplication7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using WebApplication7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
using WebApplication7.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
using WebApplication7.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\.net\Solution1\WebApplication7\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chart")]
    public partial class ViewChart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<section class=\"hero is-medium is-primary is-bold\">\r\n  <div class=\"hero-body\">\r\n    <div class=\"container\">\r\n      <h1 class=\"title\">View the charts</h1>\r\n    </div>\r\n  </div>\r\n</section>\r\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "section");
            __builder.AddMarkupContent(3, "\r\n  ");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfAccumulationChart>(4);
            __builder.AddAttribute(5, "Title", "Adult eye colors");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeriesCollection>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\r\n      ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeries>(11);
                    __builder3.AddAttribute(12, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
                                            frequencyEye

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "XName", "Color");
                    __builder3.AddAttribute(14, "YName", "Count");
                    __builder3.AddAttribute(15, "Name", "EyeColor");
                    __builder3.AddAttribute(16, "PointColorMapping", "Fill");
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(18, "\r\n        ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.AccumulationDataLabelSettings>(19);
                        __builder4.AddAttribute(20, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(21, "Name", "Value");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n      ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartLegendSettings>(25);
                __builder2.AddAttribute(26, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenElement(30, "section");
            __builder.AddAttribute(31, "class", "section");
            __builder.AddMarkupContent(32, "\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfAccumulationChart>(33);
            __builder.AddAttribute(34, "Title", "Adult hair colors");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n  ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeriesCollection>(37);
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(39, "\r\n    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeries>(40);
                    __builder3.AddAttribute(41, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
                                          frequencyHair

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "XName", "Key");
                    __builder3.AddAttribute(43, "YName", "Value");
                    __builder3.AddAttribute(44, "Name", "HairColor");
                    __builder3.AddAttribute(45, "PointColorMapping", "Fill");
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(47, "\r\n      ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.AccumulationDataLabelSettings>(48);
                        __builder4.AddAttribute(49, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
                                              true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "Name", "Value");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(51, "\r\n    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n  ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n  ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartLegendSettings>(54);
                __builder2.AddAttribute(55, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.OpenElement(59, "section");
            __builder.AddAttribute(60, "class", "section");
            __builder.AddMarkupContent(61, "\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfAccumulationChart>(62);
            __builder.AddAttribute(63, "Title", "Adult sex distribution");
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "\r\n  ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeriesCollection>(66);
                __builder2.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(68, "\r\n    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeries>(69);
                    __builder3.AddAttribute(70, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 36 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
                                         frequencySex

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "XName", "Key");
                    __builder3.AddAttribute(72, "YName", "Value");
                    __builder3.AddAttribute(73, "Name", "Sex");
                    __builder3.AddAttribute(74, "PointColorMapping", "Fill");
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(76, "\r\n      ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.AccumulationDataLabelSettings>(77);
                        __builder4.AddAttribute(78, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
                                              true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(79, "Name", "Value");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(80, "\r\n    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\r\n  ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n  ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartLegendSettings>(83);
                __builder2.AddAttribute(84, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(86, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\.net\Solution1\WebApplication7\Pages\ViewChart.razor"
       
  private Dictionary<string, int> frequencyEye;
  private Dictionary<string, int> frequencyHair;
  private Dictionary<string, int> frequencySex;
  private IList<Adult> allAdults;
  protected override async Task OnInitializedAsync()
  {
    allAdults = await AdultService.getAdultsAsync();
    frequencyEye = allAdults.GroupBy(x => x.EyeColor).ToDictionary(x => x.Key, x=>x.Count());
    frequencyHair = allAdults.GroupBy(x => x.HairColor).ToDictionary(x => x.Key, x => x.Count());
    frequencySex = allAdults.GroupBy(x => x.Sex).ToDictionary(x => x.Key, x => x.Count());
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591