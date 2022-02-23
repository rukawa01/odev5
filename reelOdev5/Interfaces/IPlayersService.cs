using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reelOdev5
{
    internal interface IPlayersService
    {
        void Add(PlayersProp playersProp);
        void Remove(PlayersProp playersProp);
        void Update(PlayersProp playersProp);
    }
}
