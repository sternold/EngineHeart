using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeart.Data
{
    public interface IPart
    {
        string Name { get; set; }
        int Rank { get; set; }
    }
}
