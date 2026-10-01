using Microsoft.Extensions.DependencyInjection;
using TPLibreria.Modelos;

namespace TPLibreria
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddScoped<ILibroRepository, LibroRepositorySQL>();

            services.AddTransient<frmTPLibreria>();

            using var provider = services.BuildServiceProvider();
            var mainForm = provider.GetRequiredService<frmTPLibreria>();

            Application.Run(mainForm);
        }
    }
}