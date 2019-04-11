using EngineHeart.Core.Entity;
using EngineHeart.Database.Repositories;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;

namespace EngineHeart.App.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ComponentRepository _componentRepository;

        public ObservableCollection<ComponentInfo> ComponentInfos { get; set; }
        public ComponentInfo SelectedComponentInfo { get; set; }

        public ObservableCollection<Component> InstalledFeatures { get; set; }
        public ObservableCollection<Component> InstalledDefects { get; set; }

        public MainViewModel() : this(new ComponentRepository())
        {
        }

        public MainViewModel(ComponentRepository componentRepository)
        {
            _componentRepository = componentRepository;
            ComponentInfos = new ObservableCollection<ComponentInfo>(_componentRepository.GetAll());
            InstalledFeatures = new ObservableCollection<Component>();
            InstalledDefects = new ObservableCollection<Component>();
            AddCommand = ReactiveCommand.Create(() =>
            {
                if (SelectedComponentInfo.Type == ComponentInfo.ComponentType.FEATURE)
                    InstalledFeatures.Add(new Component { ComponentInfo = SelectedComponentInfo });
                else
                    InstalledDefects.Add(new Component { ComponentInfo = SelectedComponentInfo });
            });
        }

        public ReactiveCommand<Unit, Unit> AddCommand { get; }
    }
}
