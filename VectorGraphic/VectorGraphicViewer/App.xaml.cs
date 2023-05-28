using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using VectorGraphicViewer.PrimitivesProviders;
using VectorGraphicViewer.ViewModels;

namespace VectorGraphicViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        private void ConfigureServices(ServiceCollection services)
        {
            services.AddAutoMapper(typeof(AppMappingProfile));
            services.AddSingleton<IPrimitivesProvider>(new JSONPrimitiveProvider("Primitives.json"));
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainVM>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
