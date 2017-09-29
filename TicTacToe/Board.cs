using System;
using System.Runtime.InteropServices;

namespace TicTacToe{
    public class Board{
        private string[] boardGame;

        public Board(){
            boardGame=new string[9];
        }

        //con el if no se sobreesciben los datos
        public string[] setToken(int positionToPlaceToken, string typeOfPlayer){
            for (int i = 0; i < boardGame.Length; i++){
                if(boardGame[positionToPlaceToken-1] != null){
                    break;
                }else{
                    boardGame[positionToPlaceToken-1] = typeOfPlayer;
                }
            }
            return boardGame;
        }

        public string column_wins(string typeOfPlayer){
            if (boardGame[0] == typeOfPlayer && boardGame[3] == typeOfPlayer && boardGame[6] == typeOfPlayer ||
                boardGame[1] == typeOfPlayer && boardGame[4] == typeOfPlayer && boardGame[7] == typeOfPlayer ||
                boardGame[2] == typeOfPlayer && boardGame[5] == typeOfPlayer && boardGame[9] == typeOfPlayer){
                return "Player "+ typeOfPlayer +" wins";
            }
            return "Continue";
        }
        
        public string row_wins(string typeOfPlayer){
            if (boardGame[0] == typeOfPlayer && boardGame[1] == typeOfPlayer && boardGame[2] == typeOfPlayer ||
                boardGame[3] == typeOfPlayer && boardGame[4] == typeOfPlayer && boardGame[5] == typeOfPlayer ||
                boardGame[6] == typeOfPlayer && boardGame[7] == typeOfPlayer && boardGame[8] == typeOfPlayer){
                return "Player "+ typeOfPlayer +" wins";
            }
            return "Continue";
        }
        
        public string diagonal_wins(string typeOfPlayer){
            if (boardGame[0] == typeOfPlayer && boardGame[4] == typeOfPlayer && boardGame[8] == typeOfPlayer ||
                boardGame[2] == typeOfPlayer && boardGame[3] == typeOfPlayer && boardGame[6] == typeOfPlayer){
                return "Player "+ typeOfPlayer +" wins";
            }
            return "Continue";
        }
        
        public String gameOver(){
            int count = 0;
            for (int i = 0; i < boardGame.Length; i++){
                if (boardGame[i] != null){
                    count++;
                }
            }
            if (count == 9){
                return "Game is over";
            }
            return "Game hasn´t finish yet";
        }
        
    }
}