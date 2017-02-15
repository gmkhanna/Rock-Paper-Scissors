using System.Collections.Generic;
using System;

namespace GameApp.Objects
{
  public class Game
  {
    private string _player1;
    private string _player2;
    public string _result = "";
    public static float _counter = 0;
    public static float _player1Win = 0;

    public static List<string> stringList = new List<string>{};
    public static List<float> floatList = new List<float>{};


    public string CompChoice()
    {
      Random compChoice = new Random();
      int compWeapon = compChoice.Next(0, 3);
      string comMove = "";
      // return compWeapon;
        if(compWeapon == 0)
        {
          comMove = "Rock";
        }
        else if(compWeapon == 1)
        {
          comMove = "Paper";
        }
        else
        {
          comMove = "Scissors";
        }
      return comMove;
    }

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


    public string Result()
    {
      if(_player1 == _player2)
      {
        _result = "Draw";
      }
      else if( (_player1 == "Rock") & (_player2 == "Scissors") | (_player1 == "Paper") & (_player2 == "Rock") | (_player1 == "Scissors") & (_player2 == "Paper") )
      {
        _result = "Player 1 Wins";
        _player1Win+=1;
        _counter+=1;
      }
      else
      {
       _result = "Player 2 Wins";
       _counter+=1;
      }
      return _result;
    }

    public static List<string> GetListString()
    {
      string counter = Convert.ToString(_counter);
      string player1Win = Convert.ToString(_player1Win);
      string percentage = Convert.ToString(_player1Win/_counter);
      stringList.Add(counter);
      stringList.Add(player1Win);
      stringList.Add(percentage);
      return stringList;
    }

    // public static float GetCounter()
    // {
    //   return _counter;
    // }
    //
    // public static float GetPlayer1Win()
    // {
    //   return _player1Win;
    // }
    //
    // public static float PieChartP1()
    // {
    //   return _player1Win/_counter;
    // }

    // public static List<float> GetListFloat()
    // {
    //   floatList.Add(_counter);
    //   floatList.Add(_player1Win);
    //   floatList.Add(_player1Win/_counter;);
    //   return floatList;
    // }
  }
}
