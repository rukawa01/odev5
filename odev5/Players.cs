using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev5
{
    public class Players
    {
        PlayerList playerList = new PlayerList();
        PlayerManager playerManager = new PlayerManager(playerListName: new PlayerList());
       
       // PlayerList _playerListName;
        PlayerProp playerProp = new PlayerProp();
        //public Players(PlayerList playerListName)
        //{
        //    _playerListName = playerListName;
        //}
        public void PlayersMethod()
        {
            PlayerProp player1 = new PlayerProp();
            player1.playerName = "Ömer";
            player1.playerSurname = "Güven";
            player1.password = "123456";
            playerManager.PlayerAdd(player1);


            PlayerProp player2 = new PlayerProp();
            player2.playerName = "Batu";
            player2.playerSurname = "Sütçü";
            player2.password = "456789";
            playerManager.PlayerAdd(player2);


            PlayerProp player3 = new PlayerProp();
            player3.playerName = "Emre";
            player3.playerSurname = "Demir";
            player3.password = "emreBalonu";
            playerManager.PlayerAdd(player3);

            
        }
        
    }
}
