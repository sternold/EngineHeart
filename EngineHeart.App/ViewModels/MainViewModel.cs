using System.Collections.Generic;
using EngineHeart.Core.Entity;
using EngineHeart.Database.Repositories;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;
using EngineHeart.App.Models;

namespace EngineHeart.App.ViewModels
{
    public class MainViewModel : Base.ViewModelBase
    {
        public ICollection<ComponentInfo> ComponentInfos { get; set; }
        public ComponentInfo SelectedComponentInfo { get; set; }
        public Robot Robot { get; set; }

        public MainViewModel() : this(new ComponentRepository())
        {
        }

        public MainViewModel(ComponentRepository componentRepository)
        {
            Robot = new ReactiveRobot();
            ComponentInfos = new ObservableCollection<ComponentInfo>(componentRepository.GetAll());
            AddCommand = ReactiveCommand.Create(() 
                => Robot.Components.Add(new Component { ComponentInfo = SelectedComponentInfo }));
        }

        public ReactiveCommand<Unit, Unit> AddCommand { get; }
    }
}
