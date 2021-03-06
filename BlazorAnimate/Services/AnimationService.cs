﻿using System;
using Blazor.Extensions.Canvas.Canvas2D;
using BlazorAnimate.Models;

namespace BlazorAnimate.Services
{
    public class AnimationService
    {
        private BezierCurveService bezierCurveService;
        private WordService wordService;

        public AnimationService(IServiceProvider serviceProvider)
        {
            bezierCurveService = (BezierCurveService)serviceProvider.GetService(typeof(BezierCurveService));
            wordService = (WordService)serviceProvider.GetService(typeof(WordService));
        }

        public void Animate(Animation animation)
        {
            animation.Percent += animation.Speed;

            if (animation.Percent < 0)
                animation.Percent = 0;
            else if (animation.Percent > 100)
                animation.Percent = 100;

        }

        public void Draw(Canvas2DContext ctx,Animation animation)
        {
            foreach (Word word in animation.Words)
            {
                if (word.Path != null)
                {
                    word.Location = bezierCurveService.getCubicBezierXYatPercent(word.Path, animation.Percent);
                    if (word.DrawPath) bezierCurveService.DrawCurve(ctx, word.Path);
                }
                wordService.DrawText(ctx, word);
            }
        }
    }
}
