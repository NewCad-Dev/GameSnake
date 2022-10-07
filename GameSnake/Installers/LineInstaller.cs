using GameSnake.Lines;
using System.Collections.Generic;

namespace GameSnake.Installers
{
    class LineInstaller
    {
        List<Shape> _shapes;

        public LineInstaller()
        {
            _shapes = new List<Shape>();

            HorizontalLine upLine = new HorizontalLine(0, 0, '-', 120);
            HorizontalLine downLine = new HorizontalLine(0, 20, '-', 120);

            VerticalLine leftLine = new VerticalLine(0, 1, '|', 20);
            VerticalLine rightLine = new VerticalLine(119, 1, '|', 20);

            _shapes = new List<Shape> { upLine, downLine, leftLine, rightLine };
        }

        public void DrawShapes()
        {
            foreach (Shape shape in _shapes)
            {
                shape.DrawLine();
            }
        }

        public bool Collision(Shape shape)
        {
            foreach (Shape item in _shapes)
            {
                if (item.Collision(shape))
                    return true;
            }
            return false;
        }
    }
}