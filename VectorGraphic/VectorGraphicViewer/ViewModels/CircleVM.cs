using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace VectorGraphicViewer.ViewModels
{
    public class CircleVM : PrimitiveVM
    {
        Point _center;
        double _radius;
        bool _filled;

        public CircleVM(Point center, double radius, bool filled, Color color) : base(color)
        {
            _center = center;
            _radius = radius;
            _filled = filled;
        }

        public Point Center
        {
            get { return _center; }
            set
            {
                _center = value;
                OnPropertyChanged("Center");
            }
        }

        public double Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                OnPropertyChanged("Radius");
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
