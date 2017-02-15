using Xunit;
using System.Collections.Generic;

namespace Game.Objects
{
  public class GameTest
  {
    [Fact]
    public void stringTest1_RockReturn_Rock()
    {
      Game testGame = new Game("Rock","Scissors");
      string inputRock = "Rock";
      Assert.Equal(testGame.GetP1(), inputRock);
    }
  }
}
