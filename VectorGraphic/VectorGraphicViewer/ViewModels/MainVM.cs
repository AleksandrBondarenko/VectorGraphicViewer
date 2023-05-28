using AutoMapper;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VectorGraphicViewer.PrimitivesProviders;

namespace VectorGraphicViewer.ViewModels
{
    public class MainVM : INotifyPropertyChanged
    {
        IPrimitivesProvider _primitivesProvider;
        IMapper _mapper;

        public ObservableCollection<PrimitiveVM> Primitives { get; set; } = new ObservableCollection<PrimitiveVM>();
        public Task Initialization { get; private set; }

        public MainVM(IPrimitivesProvider primitivesProvider, IMapper mapper)
        {
            _mapper = mapper;
            _primitivesProvider = primitivesProvider;
            Initialization = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            var primitives = await _primitivesProvider.PrimitivesAsync();
            foreach (var primitive in primitives)
                Primitives.Add(_mapper.Map<PrimitiveVM>(primitive));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
