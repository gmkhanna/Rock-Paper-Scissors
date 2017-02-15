using Nancy;
using System;
using System.Collections.Generic;
using GameApp.Objects;

namespace GameApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        Game newGame = new Game("","");
        return View["index.cshtml", newGame];
      };
      Post["/result"] = _ => {
        Game newGame = new Game("","");
        string computerMove = newGame.CompChoice();
        Game newTestGame = new Game(Request.Form["player1"],computerMove);
        return View["index.cshtml", newTestGame];
      };
      Get["/testPercentage"] = _ => {
        float player1WinCounts = Game.GetPlayer1Win();
        float totalCounter = Game.GetCounter();
        float player1Percentage = Game.PieChartP1();
        Dictionary<string, float> percentage = new Dictionary<string, float>();
        percentage.Add("player1Wins",player1WinCounts);
        percentage.Add("totalGames",totalCounter);
        percentage.Add("player1Percentage",player1Percentage);
        return View["testPercentage.cshtml", percentage];
      };
    }
  }
}
