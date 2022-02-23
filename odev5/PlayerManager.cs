using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev5
{
    public class PlayerManager
    {
        //private PlayerList playerList = new PlayerList();

          PlayerList _playersListName;

        public PlayerManager(PlayerList playerListName)
        {
            _playersListName = _playersListName;
        }


        Players players = new Players();
         public void PlayerAdd(PlayerProp player)
         {
           _playersListName.GetList().Add(player);
             
         }

         public void PlayerRemove(PlayerProp player)
         {
             _playersListName.GetList().Remove(player);
         }

         public void PlayerAccess()
         {
             _playersListName.PlayerListPrint();
            
             Console.WriteLine(_playersListName.GetList().Count);
            
         }
         
    }
}
