using System;
using System.Drawing;

namespace BlazorAnimate.Models
{
    public class Word
    {
        public string TextString { get; set; }
        public PointF Location { get; set; }
        public BezierCurve Path { get; set; }
        public bool DrawPath { get; set; }
        public string Color { get; set; }
        public string Font { get; set; }

        public Word()
        {
            Color = "#ffffff";
            Font = "70px Arial";
        }
    }
}
