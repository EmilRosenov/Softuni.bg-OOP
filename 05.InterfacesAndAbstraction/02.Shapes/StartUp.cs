using System;
using System.Collections.Generic;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IDrawable> drawableObjects = new List<IDrawable>();
            IDrawable rectangle = new Rectangle(6, 4);
            //rectangle.Draw();
            IDrawable circle = new Circle(3);
            //circle.Draw();

            drawableObjects.Add(circle);
            drawableObjects.Add(rectangle);
            
            foreach (IDrawable item in drawableObjects)
            {
                item.Draw();
            }
        }
    }
}
