using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace VectorGraphicViewer.ViewModels
{
    public class TriangleVM : PrimitiveVM
    {
        Point _a;
        Point _b;
        Point _c;
        bool _filled;

        public TriangleVM(Point a, Point b, Point c, bool filled, Color color) : base(color)
        {
            _a = a;
            _b = b;
            _c = c;
            _filled = filled;
        }

        public Point A
        {
            get { return _a; }
            set
            {
                _a = value;
                OnPropertyChanged("A");
            }
        }

        public Point B
        {
            get { return _b; }
            set
            {
                _b = value;
                OnPropertyChanged("B");
            }
        }

        public Point C
        {
            get { return _c; }
            set
            {
                _c = value;
                OnPropertyChanged("C");
            }
        }

        public bool Filled
        {
            get { return _filled; }
            set
            {
                _filled = value;
                OnPropertyChanged("Filled");
            }
        }
    }
}
