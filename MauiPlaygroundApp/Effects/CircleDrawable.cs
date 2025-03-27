using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPlaygroundApp.Effects
{
    public class CircleDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            // Shadow
            canvas.FillColor = Colors.Gray;
            canvas.SetShadow(new SizeF(10, 10), 10, Colors.Black);
            canvas.FillCircle(35, 35, 35);

            // Main Circle
            canvas.FillColor = Colors.Red;
            canvas.FillCircle(35, 35, 30);
        }
    }

}
