using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NhlSystemClassLibrary
{
    internal class Player
    {
        //PlayerNo: int {1-98}
        private int _playerNo;
        private string _playerName;
        private int _gamesPlayed;
        public int PlayerNo
        {
            get { return _playerNo; }
            set
            {
                if (value! > 0 || value! < 99)
                {
                    throw new ArgumentOutOfRangeException("Value is out of range of accepted values");
                }
                _playerNo = value;
            }
        }
        //Name: string {not blank}
        public string PlayerName
        {
            get { return _playerName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be blank.");
                }
                _playerName = value.Trim();
            }
        }
        //Position: Position(enum) {C, LW, RW, D,G}
        public Position Position { get; set; }
        //GamesPlayed int:
        public int GamesPlayed
        {
            get { return _gamesPlayed; }
            set
            {
               if (value >= 0)
                {
                    throw new ArgumentOutOfRangeException("Value is below zero");
                }
                _gamesPlayed = value;
            }
        }
        //Goals int:
        //Assists int: 
        //Points int(Goals plus assists):
        //AddPlayer(newPlayer:Player)
        //addPlayers to a list/array max 23 players

    }
}
