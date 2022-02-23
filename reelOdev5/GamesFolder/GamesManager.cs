using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reelOdev5
{
    public class GamesManager
    {
        private GamesProp gamesProp= new GamesProp();
        private PlayersProp playersProp = new PlayersProp();
        public void Add(GamesProp gamesProp , PlayersProp playersProp)
        {
            Console.WriteLine( playersProp.nickName + " kişisine "   +gamesProp.gameName + " eklendi");
        }

        public void Return(GamesProp gamesProp, PlayersProp playersProp)
        {
            Console.WriteLine(playersProp.nickName + " kişisinin " + gamesProp.gameName + " oyunu iade edildi");
        }

        public void Campaign(GamesProp gamesProp, PlayersProp playersProp)
        {
            Console.WriteLine(playersProp.nickName + " kişisine özel " + gamesProp.gameName + " kampanya tanımlandı");
        }

    }
}
