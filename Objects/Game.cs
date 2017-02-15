using System.Collections.Generic;
using System;

namespace Game.Objects
{
  public class Game
  {
    private string _player1;
    private string _player2;
    public string _result = "";

    public static List<string> _results = new List<string>{};

    public Game(string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;
    }

    public string GetP1()
    {
      return _player1;
    }

    public void SetP1(string newPlayer1)
    {
      _player1 = newPlayer1;
    }

    public string GetP2()
    {
      return _player2;
    }

    public void SetP2(string newPlayer2)
    {
      _player2 = newPlayer2;
    }

    public string Result(string player1, string player2)
    {
      if(player1 == player2)
      {
        _result = "Draw";
      }
      else if( (player1 == "Rock") & (player2 == "Scissors") | (player1 == "Paper") & (player2 == "Rock") | (player1 == "Scissors") & (player2 == "Paper") )
      {
        _result = "Player 1 Wins";
      }
      else
      {
         _result = "Player 2 Wins";
      }
      return _result;
    }
  }
}
