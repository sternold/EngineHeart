using EngineHeart.Core.Entity;
using EngineHeart.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineHeart.App.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";


        public IEnumerable<ComponentInfo> Items => new ComponentRepository().GetAll();
    }
}
