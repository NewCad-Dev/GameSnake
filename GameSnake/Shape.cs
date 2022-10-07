using System.Collections.Generic;

namespace GameSnake
{
    class Shape
    {
        protected List<Point> _points;

        public void DrawLine()
        {
            foreach (Point point in _points)
            {
                point.DrawPoint();
            }
        }

        internal bool Collision(Shape shape)
        {
            foreach (Point point in _points)
            {
                if (shape.CompaarePoints(point))
                    return true;
            }
            return false;
        }

        private bool CompaarePoints(Point point)
        {
            foreach (Point item in _points)
            {
                if (point.ComperePoints(item))
                    return true;
            }
            return false;
        }
    }
}