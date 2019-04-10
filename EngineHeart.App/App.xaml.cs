using Avalonia;
using Avalonia.Markup.Xaml;

namespace EngineHeart.App
{
    public class AvaloniaApp : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
