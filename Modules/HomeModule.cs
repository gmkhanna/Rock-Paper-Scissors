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
        Console.WriteLine("All members in list are:");
        Console.WriteLine(currentPlay.Count);
        Console.WriteLine("things");
        foreach (string word in currentPlay)
        { Console.WriteLine(word);}
        return View["index.cshtml", currentPlay];
      };
    }
  }
}
