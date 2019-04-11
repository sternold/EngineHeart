using Avalonia;
using Avalonia.Logging.Serilog;
using EngineHeart.App.ViewModels;
using EngineHeart.App.Views;
using EngineHeart.Database.Context;

namespace EngineHeart.App
{
    static class Program
    {
        public static void Main(string[] args) => BuildAvaloniaApp().Start(AppMain, args);

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<AvaloniaApp>()
                .UsePlatformDetect()
                .LogToDebug();

        private static void AppMain(Application app, string[] args)
        {
            DatabaseContext.Create();
            var window = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
            app.Run(window);
        }
    }
}
