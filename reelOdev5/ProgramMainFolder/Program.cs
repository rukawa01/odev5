// See https://aka.ms/new-console-template for more information

using reelOdev5;

Console.WriteLine("Hello, World!");



/*************************************
 
 *************************************/
PlayerManager playerManager = new PlayerManager();

PlayersProp player1 = new PlayersProp()
{
    nickName = "Ömer",
    password = "123456",
    TC = 12345678901,
    birthYear = 2002
};

PlayersProp player2 = new PlayersProp()
{
    nickName = "Ragnar Batu",
    password = "82norvec",
    TC = 12345678901,
    birthYear = 2002
};

PlayersProp player3 = new PlayersProp()
{
    nickName = "Emir Oyunda",
    password = "yoksaa5757",
    TC = 12345678905,
    birthYear = 2002
};

PlayersProp player4 = new PlayersProp()
{
    nickName = "Emre Balonu",
    password = "Patladı",
    TC = 12345678906,
    birthYear = 2003
};

PlayersProp player5 = new PlayersProp()
{
    nickName = "Judas Balonu",
    password = "judas1234",
    TC = 12345678907,
    birthYear = 2003
};
/************************************************************
*******************************************************/

playerManager.Add(player5);

playerManager.Remove(player3);


/*********************************************************
 * ********************************************************/
GamesManager gamesManager = new GamesManager();


GamesProp game1= new GamesProp()
{
    gameName = "Valorant",
    gameID = 1221
};

GamesProp game2 = new GamesProp()
{
    gameName = "Rainbow Six Siege",
    gameID = 3131
};

GamesProp game3 = new GamesProp()
{
    gameName = "CS Go",
    gameID = 3434
};

gamesManager.Add(game1 , player1);
gamesManager.Campaign(game3 , player4);


/**************************************************
 **************************************************/
 
Login login = new Login();

var resultBool = login.CheckAll(player1);
var resultBool2 = login.CheckAll(player2);

Console.WriteLine(player1.nickName+" adlı oyuncunun doğrulaması : "+resultBool);
Console.WriteLine(player2.nickName + " adlı oyuncunun doğrulaması : " + resultBool2);
// Normalde aynı anda sadece bir taneyi kontrol edebiliyor :(


