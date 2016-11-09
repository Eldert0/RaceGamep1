using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;

namespace RaceGameExample
{
    class Road
    {
        public Image image;
        private Point position;
        private Rectangle screenBounds;


        public Road()
        {
            position.X = 1;
            position.Y = 1;


            // set screen bounds
            Point d = new Point(0, 0);
            screenBounds = Screen.GetBounds(d);
            this.CreateBackground();
            //this.environment();
        }
        public Bitmap getBitmap()
        {
           Bitmap flag = new System.Drawing.Bitmap(1, 1);
            for (int x = 0; x < flag.Height; ++x)
                for (int y = 0; y < flag.Width; ++y)
                    flag.SetPixel(x, y, Color.Green);
            return flag;
        }

        public void CreateBackground()
        {
            using (Bitmap grass = new Bitmap(Path.Combine(Environment.CurrentDirectory, "grass.jpg")))
            {
                Console.WriteLine("grass ok 1 ");
                using (Graphics g = Graphics.FromImage(grass))
                {
                    Console.WriteLine("grass ok 2 ");
                    TextureBrush tBrushGrass = new TextureBrush(grass);

                    // Create rectangle.
                    Rectangle rect = new Rectangle(0, 0, screenBounds.Width, screenBounds.Height);
                    g.FillRectangle(tBrushGrass, rect);
                    g.DrawImage(grass, screenBounds.Width, screenBounds.Height);
                }
                this.image = grass;
            }
        }

        public void CreateRoad()
        {

        }

        public Image getImage()
        {
            return this.image;
        }

        public Image environment(Graphics e)
        {
            
            // load image
            Bitmap grass = new Bitmap(Path.Combine(Environment.CurrentDirectory, "grass.jpg"));
            TextureBrush tBrushGrass = new TextureBrush(grass);

            // Create rectangle.
            Rectangle rect = new Rectangle(0, 0, screenBounds.Width, screenBounds.Height);

            e.FillRectangle(tBrushGrass, rect);
            
            // Load Road
            // load image
            Bitmap Road = new Bitmap(Path.Combine(Environment.CurrentDirectory, "racegame.png"));
            TextureBrush tBrushRoad = new TextureBrush(Road);
            Rectangle rectR = new Rectangle(0, 0, 1200,1200);
            e.FillRectangle(tBrushRoad, rectR);

            return grass;
        }
        public Point getPosition()
        {
            return position;
        }
    }
}
