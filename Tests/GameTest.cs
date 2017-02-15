using Xunit;
using System.Collections.Generic;

namespace Game.Objects
{
  public class GameTest
  {
    [Fact]
    public void stringTestPlayer1_RockReturn_Rock()
    {
      Game testGame = new Game("Rock","Scissors");
      string verifyInput = "Rock";
      Assert.Equal(testGame.GetP1(), verifyInput);
    }
    [Fact]
    public void stringTestPlayer2_RockReturn_Rock()
    {
      Game testGame = new Game("Rock","Scissors");
      string verifyInput = "Scissors";
      Assert.Equal(testGame.GetP2(), verifyInput);
    }
  }
}
