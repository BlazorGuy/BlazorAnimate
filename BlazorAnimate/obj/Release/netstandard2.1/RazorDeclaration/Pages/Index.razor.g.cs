#pragma checksum "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3482a8089fc857833faca02e1f1dbc7de2b109c6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAnimate.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using BlazorAnimate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using Blazor.Extensions.Canvas.Canvas2D;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using Blazor.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using Blazor.Extensions.Canvas.WebGL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\Pages\Index.razor"
using BlazorAnimate.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\Pages\Index.razor"
using BlazorAnimate.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\bcollins\Desktop\BlazorGuy\BlazorAnimate\BlazorAnimate\Pages\Index.razor"
      
    private Canvas2DContext ctx;
    private List<Animation> Animations = new List<Animation>();

    protected BECanvasComponent _canvasReference;

    private int fps = 60;
    private bool drawpath = false;
    private bool loopback = false;
    private string backgroundcolor = "#454545";

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender) return;

        ctx = await _canvasReference.CreateCanvas2DAsync();

        var animation = new Animation();
        var animation_l = new Animation();
        var animation_r = new Animation();

        animation_l.Speed = 1.1F;
        animation_r.Speed = 1.5F;

        animation.Words.Add(new Word()
        {
            TextString = "B",
            Path = new BezierCurve()
            {
                StartPoint = new PointF(10, 305),
                ControlPoint1 = new PointF(-10, 164),
                ControlPoint2 = new PointF(245, 166),
                EndPoint = new PointF(235, 300)
            },
            DrawPath = drawpath,
            Color = "#ffb6b3"
        }); ;

        animation.Words.Add(new Word()
        {
            TextString = "rowser",
            Path = new BezierCurve()
            {
                StartPoint = new PointF(53, 300),
                ControlPoint1 = new PointF(35, 300),
                ControlPoint2 = new PointF(35, 300),
                EndPoint = new PointF(35, 900)
            },
            DrawPath = drawpath,
        });

        animation.Words.Add(new Word()
        {
            TextString = "+",
            Path = new BezierCurve()
            {
                StartPoint = new PointF(280, 300),
                ControlPoint1 = new PointF(70, 300),
                ControlPoint2 = new PointF(70, 300),
                EndPoint = new PointF(100, 1300)
            },
            DrawPath = drawpath
        });

        animation_r.Words.Add(new Word()
        {
            TextString = "R",
            Path = new BezierCurve()
            {
                StartPoint = new PointF(320, 300),
                ControlPoint1 = new PointF(350, 300),
                ControlPoint2 = new PointF(350, 300),
                EndPoint = new PointF(350, 900)
            },
            DrawPath = drawpath
        });

        animation.Words.Add(new Word()
        {
            TextString = "azor",
            Path = new BezierCurve()
            {
                StartPoint = new PointF(370, 300),
                ControlPoint1 = new PointF(350, 300),
                ControlPoint2 = new PointF(350, 300),
                EndPoint = new PointF(295, 300)
            },
            DrawPath = drawpath,
            Color = "#ffb6b3"
        });

        animation_l.Words.Add(new Word()
        {
            TextString = "l",
            Path = new BezierCurve()
            {
                StartPoint = new PointF(800, 900),
                ControlPoint1 = new PointF(-10, 164),
                ControlPoint2 = new PointF(245, 166),
                EndPoint = new PointF(280, 300)
            },
            DrawPath = drawpath,
            Color = "#ffb6b3"
        });

        Animations.Add(animation);
        Animations.Add(animation_l);
        Animations.Add(animation_r);

        animate();

        await Task.Delay(2000).ContinueWith(async a => {
            await SetInterval(() => animate(), TimeSpan.FromMilliseconds(1000 / fps));
        });
    }

    async Task SetInterval(Action action, TimeSpan timeout)
    {
        await Task.Delay(timeout).ConfigureAwait(false);

        action();

        await SetInterval(action, timeout);
    }

    async void animate()
    {
        await ctx.ClearRectAsync(0, 0, 700, 600);
        await ctx.SetFillStyleAsync(backgroundcolor);
        await ctx.FillRectAsync(0, 0, 700, 600);

        bool allcomplete = true;

        foreach (Animation a in Animations)
        {
            animationservice.Animate(a);
            animationservice.Draw(ctx,a);
            if (a.Percent != 100 && a.Percent !=0) allcomplete = false;
        }

        if (allcomplete && loopback)
            Animations.ForEach(a => a.Speed *= -1);
    }

    void Restart(){
        Animations.ForEach(a => a.Percent = 0);
    }

    void ToggleLoopBack()
    {
        loopback = !loopback;
    }

    void ToggleDrawPaths()
    {
        Animations.ForEach(a => a.Words.ForEach(w=>w.DrawPath = !w.DrawPath));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AnimationService animationservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BezierCurveService bcs { get; set; }
    }
}
#pragma warning restore 1591
