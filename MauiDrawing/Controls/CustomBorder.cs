using MauiDrawing.Drawable;

namespace MauiDrawing.Controls
{
    public class CustomBorder : GraphicsView
    {
        GradiantBorder myBorder = new();
        public CustomBorder()
        {
            Drawable = myBorder;


            var animation = new Animation {
                //Change X
               { 0, .25, new Animation(x => {
                myBorder.radialGradientPaint.Center = new Point(x, 0.0);
                Invalidate();},
                0.0, 1.0)},
               //Change Y
               { .25, .5, new Animation(x => {
                myBorder.radialGradientPaint.Center = new Point(1.0, x);
                Invalidate();},
                0.0, 1.0)},
               //Change X Back
               { .5, .75, new Animation(x => {
                myBorder.radialGradientPaint.Center = new Point(x, 1.0);
                Invalidate();},
                1.0, 0.0)},
               //Change Y Back
               { .75, 1, new Animation(x => {
                myBorder.radialGradientPaint.Center = new Point(0.0, x);
                Invalidate();},
                1.0, 0.0)}
            };

    animation.Commit(this, "BorderAnimation", 16, 10000, Easing.Linear, finished: (d, b) =>
    {
        myBorder.radialGradientPaint.Center = new Point(0, 0);
        Invalidate();
    }, () => true);
        }
    }
}
