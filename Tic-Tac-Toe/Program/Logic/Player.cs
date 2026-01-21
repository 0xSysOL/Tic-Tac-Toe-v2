using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Program.Main
{
    internal class Player
    { 

        public int Win      {set; get;}
        public bool IsWinner { set; get; }

        public string Name { set; get; }
        public int Rounds   {set; get;}
        public bool LastWin {set; get;}
        public bool IsFirstPlayer { set; get; }
        public Player() 
        {

            Win = 0;
            Rounds = 0;
            LastWin = false;
            IsFirstPlayer = false;

        }


    }
}
