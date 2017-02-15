using System.Collections.Generic;
using System;

namespace Game.Objects
{
  public class Game
  {
    private string _player1;
    private string _player2;

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
  }
}
