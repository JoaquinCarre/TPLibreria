using Microsoft.Extensions.DependencyInjection;
using TPLibreria.Modelos;

namespace TPLibreria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
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