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
        Game newGame = new Game(Request.Form["player1"],Request.Form["player2"]);
        string result = newGame.Result();
        return View["index.cshtml", result];
      };
    }
  }
}
