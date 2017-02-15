using Xunit;
using System.Collections.Generic;

namespace GameApp.Objects
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
    [Fact]
    public void Result_P1RockP2Scissors_P1Wins()
    {
      Game testGame = new Game("Rock","Scissors");
      string testResult = testGame.Result();
      string verifyInput = "Player 1 Wins";
      Assert.Equal(testResult, verifyInput);
    }
    [Fact]
    public void Result_P1RockP2Rock_Draw()
    {
      Game testGame = new Game("Rock","Rock");
      string testResult = testGame.Result();
      string verifyInput = "Draw";
      Assert.Equal(testResult, verifyInput);
    }
    [Fact]
    public void Result_P1RockP2Paper_Lose()
    {
      Game testGame = new Game("Rock","Paper");
      string testResult = testGame.Result();
      string verifyInput = "Player 2 Wins";
      Assert.Equal(testResult, verifyInput);
    }
  }
}
