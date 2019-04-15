using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace EngineHeart.App.Views
{
    public class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
