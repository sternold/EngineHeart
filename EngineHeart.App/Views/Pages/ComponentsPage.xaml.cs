using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace EngineHeart.App.Views.Pages
{
    public class ComponentsPage : UserControl
    {
        public ComponentsPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}