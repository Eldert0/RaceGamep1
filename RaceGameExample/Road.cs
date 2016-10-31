using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace RaceGameExample
{
    class Road
    {
        public Bitmap Image;
        private Point position;
        
        public Road()
        {
            position.X = 1;
            position.Y = 1;
        }
        public Bitmap getBitmap()
        {
           Bitmap flag = new System.Drawing.Bitmap(1, 1);
            for (int x = 0; x < flag.Height; ++x)
                for (int y = 0; y < flag.Width; ++y)
                    flag.SetPixel(x, y, Color.Green);
            return flag;
        }
        public Image environment()
        {
            Image img = new Bitmap(100, 100);

            Graphics g = Graphics.FromImage(img);
            Rectangle rect = new Rectangle(60, 30, 100, 100);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Yellow, LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lBrush, rect);

            
            return img;
        }
        public Point getPosition()
        {
            return position;
        }
    }
}
