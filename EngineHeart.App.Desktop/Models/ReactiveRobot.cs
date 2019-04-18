using System.Collections.ObjectModel;
using EngineHeart.Core.Entity;

namespace EngineHeart.App.Desktop.Models
{
    public class ReactiveRobot : Robot
    {
        public ReactiveRobot()
        {
            Components = new ObservableCollection<Component>();
        }
    }
}