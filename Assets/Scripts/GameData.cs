using UnityEngine;

namespace Serialization
{
    [System.Serializable]
    public class GameData
    {
        // Character of player
        public Character Player;

        // New character Beginning stats/default stats including the players name
        public GameData()
        {
            Player = new Character("Player", 10, 10, 10, 10, 10, 10, 10, 10, 10, 10);

        }
    }


}