using logic_gates.Services;
using Microsoft.Extensions.DependencyInjection;

namespace logic_gates
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

            services.AddSingleton<RunService>();

            services.AddTransient<MainForm>();

            Application.Run(new MainForm());
        }
    }
}