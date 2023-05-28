using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace VectorGraphicViewer.ViewModels
{
    public abstract class PrimitiveVM : INotifyPropertyChanged
    {
        Color _color;

        protected PrimitiveVM(Color color) 
        {
            _color = color;
        }

        public Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                OnPropertyChanged("Color");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}