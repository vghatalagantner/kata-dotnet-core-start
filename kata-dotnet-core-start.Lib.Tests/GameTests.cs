namespace kata_dotnet_core_start.Lib.Tests;

public class GameTests
{
    [Fact]
    public void Must_Have_2_Player()
    {
        // Arrange
        var game = new Game();
        game.AddPlayer(new Player("Vijay"));
        game.AddPlayer(new Player("Raj"));

        // Act
        var player = game.Players.Count;

        // Assert
        Assert.Equal(2, player);
    }
}