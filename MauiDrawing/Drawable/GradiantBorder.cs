namespace MauiDrawing.Drawable
{
    public class GradiantBorder : IDrawable
    {                
        public RadialGradientPaint radialGradientPaint { get; set; } = new RadialGradientPaint
        {
            StartColor = Colors.Cyan,
            EndColor = Colors.Magenta,
            Center = new Point(0.0, 0.0)                        
            // Radius is already 0.5
        };

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {            
            RectF radialRectangle = new RectF(0, 0, dirtyRect.Width, dirtyRect.Height);
            canvas.SetFillPaint(radialGradientPaint, radialRectangle);
            //canvas.SetShadow(new SizeF(10, 10), 10, Colors.Grey);
            canvas.FillRoundedRectangle(radialRectangle, 12);
            
        }
    }
}
