using AutoMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicViewer.Models;
using VectorGraphicViewer.PrimitivesProviders;
using System.Windows.Media;
using System.Windows;

namespace VectorGraphicViewer.ViewModels
{
    public class MainVM : INotifyPropertyChanged
    {
        IPrimitivesProvider _primitivesProvider;
        IMapper _mapper;

        public ObservableCollection<PrimitiveVM> Primitives { get; set; }

        public MainVM(IPrimitivesProvider primitivesProvider, IMapper mapper)
        {
            _mapper = mapper;
            _primitivesProvider = primitivesProvider;
            Primitives = new ObservableCollection<PrimitiveVM>(
                _primitivesProvider.Primitives()
                .Select(x => (PrimitiveVM)_mapper.Map(x, x.GetType(), typeof(PrimitiveVM))));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
