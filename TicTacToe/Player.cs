using System;

namespace TicTacToe{
    public class Player{
        private string typeOfPlayer;
        
        public Player(string typeOfPlayer){
            this.typeOfPlayer = typeOfPlayer;
        }

        public string getTypeOfPlayer(){
            return typeOfPlayer;
        }
        
    }
}