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
        var actual = game.Players.Count();

        // Assert
        Assert.Equal(2, actual);
    }

    [Fact]
    public void Only_Two_Players_Are_Allowed()
    {
        // Arrange
        var game = new Game();
        game.AddPlayer(new Player("Vijay"));
        game.AddPlayer(new Player("Raj")); ;
        
        // Act
        var actual = Assert.Throws<InvalidOperationException>(() => game.AddPlayer(new Player("Kalpesh")));

        // Assert
        Assert.IsType<InvalidOperationException>(actual);
        Assert.Equal("Only two players are allowed", actual.Message);
    }
}