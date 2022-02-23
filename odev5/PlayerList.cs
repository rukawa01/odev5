using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev5
{
    public class PlayerList
    {
        List<PlayerProp> playersList = new List<PlayerProp>() {};

        public List<PlayerProp> GetList()
        {
            return playersList;
            
        }

        public void PlayerListPrint()
        {
            Console.WriteLine(playersList);
        }
    }
}
