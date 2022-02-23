using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reelOdev5
{
    public class PlayerManager : IPlayersService
    {
        private PlayersProp playersProp = new PlayersProp();
        public void Add(PlayersProp playersProp)
        {
            Console.WriteLine(playersProp.nickName + " eklendi");
        }

        public void Remove(PlayersProp playersProp)
        {
            Console.WriteLine(playersProp.nickName + " kaldırıldı");
        }

        public void Update(PlayersProp playersProp)
        {
            Console.WriteLine(playersProp.nickName + " güncellendi");
        }


    }
}
