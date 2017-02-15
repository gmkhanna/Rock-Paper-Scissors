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
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        Game newGame = new Game("","");
        string computerMove = newGame.CompChoice();
        Game newTestGame = new Game(Request.Form["player1"],computerMove);
        List<string> currentPlay = Game.GetListString();
        currentPlay.Add(newTestGame.GetP1());
        currentPlay.Add(newTestGame.GetP2());
        currentPlay.Add(newTestGame.Result());
        return View["index.cshtml", currentPlay];
      };
      // Get["/testPercentage"] = _ => {
      //   float player1WinCounts = Game.GetPlayer1Win();
      //   float totalCounter = Game.GetCounter();
      //   float player1Percentage = Game.PieChartP1();
      //   Dictionary<string, float> percentage = new Dictionary<string, float>();
      //   percentage.Add("player1Wins",player1WinCounts);
      //   percentage.Add("totalGames",totalCounter);
      //   percentage.Add("player1Percentage",player1Percentage);
      //   return View["testPercentage.cshtml", percentage];
      // };
    }
  }
}
