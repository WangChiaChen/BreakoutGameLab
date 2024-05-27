using System.Drawing;

namespace BreakoutGameLab001
{
    // Brick class
    class Brick
    {
        // Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }

        // Constructor
        public Brick(int x, int y, int width, int height, Color color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
        }

        // Draw the brick
        internal void Draw(Graphics gr)
        {
            gr.FillRectangle(new SolidBrush(this.Color), X, Y, Width, Height);
            gr.DrawRectangle(new Pen(Color.Black, 1), X, Y, Width, Height);
        }
    }
}
