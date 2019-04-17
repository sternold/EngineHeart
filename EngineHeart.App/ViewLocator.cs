using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using EngineHeart.App.ViewModels.Base;

namespace EngineHeart.App
{
    public class ViewLocator : IDataTemplate
    {
        public bool SupportsRecycling => false;
        public bool Match(object data) => data is ViewModelBase;
        
        public IControl Build(object data)
        {
            var name = data.GetType().FullName.Replace("ViewModel", "View");
            var type = Type.GetType(name);
            if (type != null) return (Control) Activator.CreateInstance(type);
            return new TextBlock { Text = $"Not Found: {name}"};
        }
    }
}