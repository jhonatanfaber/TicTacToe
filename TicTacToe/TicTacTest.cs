using System;
using System.Media;
using NUnit.Framework;
namespace TicTacToe{
    [TestFixture]
    public class TicTacTest{
        private Board boardGame;
        
        [SetUp]
        public void setup(){
            boardGame = new Board();
        }
            [Test]
            public void playerX_set_on_selected_position_with_empty_vector() {
                String[] expected = new string[] {"X",null,null,null,null,null,null,null,null};
                Player p = new Player("X");
                String[] res = boardGame.setToken(1,p.getTypeOfPlayer());
                Assert.AreEqual(expected, res);
            }
        
            [Test]
            public void playerX_tries_to_use_same_field_as_playerO() {
                String[] expected = new string[] {null,null,"O",null,null,null,null,null,null};
                Player p = new Player("O");
                Player p2 = new Player("X");
                String[] res = boardGame.setToken(3,p.getTypeOfPlayer());
                boardGame.setToken(3, p2.getTypeOfPlayer());
                Assert.AreEqual(expected, res);
            }
        
            [Test]
            public void any_player_wins_with_second_column() {
                Player p = new Player("O");
                boardGame.setToken(2,p.getTypeOfPlayer());
                boardGame.setToken(5,p.getTypeOfPlayer());
                boardGame.setToken(8,p.getTypeOfPlayer());
                Assert.AreEqual("Player "+ p.getTypeOfPlayer() +" wins", boardGame.column_wins(p.getTypeOfPlayer()));
            } 
        
            [Test]
            public void any_player_wins_with_second_row() {
                Player p = new Player("X");
                boardGame.setToken(3,p.getTypeOfPlayer());
                boardGame.setToken(2,p.getTypeOfPlayer());
                boardGame.setToken(1,p.getTypeOfPlayer());
                Assert.AreEqual("Player "+ p.getTypeOfPlayer()+" wins", boardGame.row_wins(p.getTypeOfPlayer()));
            }
        
            [Test]
            public void any_player_wins_with_diagonal() {
                Player p = new Player("X");
                boardGame.setToken(1,p.getTypeOfPlayer());
                boardGame.setToken(5,p.getTypeOfPlayer());
                boardGame.setToken(9,p.getTypeOfPlayer());
                Assert.AreEqual("Player "+ p.getTypeOfPlayer() +" wins", boardGame.diagonal_wins(p.getTypeOfPlayer()));
            }
        
            [Test]
            public void check_game_is_over() {
                Player p = new Player("X");
                Player p2 = new Player("O");
                boardGame.setToken(1,p2.getTypeOfPlayer());
                boardGame.setToken(1,p.getTypeOfPlayer());
                boardGame.setToken(2,p.getTypeOfPlayer());
                boardGame.setToken(3,p.getTypeOfPlayer());
                boardGame.setToken(4,p.getTypeOfPlayer());
                boardGame.setToken(5,p.getTypeOfPlayer());
                boardGame.setToken(6,p.getTypeOfPlayer());
                boardGame.setToken(7,p.getTypeOfPlayer());
                boardGame.setToken(8,p.getTypeOfPlayer());
                boardGame.setToken(9,p.getTypeOfPlayer());
                Assert.AreEqual("Game is over", boardGame.gameOver());
            }
        
        }
    }
