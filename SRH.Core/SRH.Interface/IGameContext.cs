using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRH.Core;

namespace SRH.Interface
{
    public interface IGameContext
    {
        Game CurrentGame { get; }
    }
}
