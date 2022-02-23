using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reelOdev5
{
    internal class Login : ILogin
    {
        private PlayersProp playersProp = new PlayersProp();
       

        public bool CheckAll(PlayersProp playersProp)
        {
            if (playersProp == null) return false;

            if (playersProp.TC == 12345678901 && playersProp.nickName == "Ömer" &&
                playersProp.password == "123456"  && playersProp.birthYear == 2002)
            {return true;}

            return false;
        }
    }
}
