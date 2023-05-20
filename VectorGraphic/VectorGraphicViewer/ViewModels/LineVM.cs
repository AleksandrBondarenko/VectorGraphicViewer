using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace VectorGraphicViewer.ViewModels
{
    public class LineVM : PrimitiveVM
    {
        Point _a;
        Point _b;

        public LineVM(Point a, Point b, Color color) : base(color)
        {
            _a = a;
            _b = b;
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
    }
}
