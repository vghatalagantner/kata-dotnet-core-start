namespace kata_dotnet_core_start.Lib.Tests;

public class GameTests
{
    [Fact]
    public void Only_Two_Players_Are_Allowed()
    {
        // Arrange
        var game = new Game();
        game.AddPlayer(new Player("Vijay"));
        game.AddPlayer(new Player("Raj"));
        
        // Act
        var actual = Assert.Throws<InvalidOperationException>(() => game.AddPlayer(new Player("Kalpesh")));

        // Assert
        Assert.IsType<InvalidOperationException>(actual);
        Assert.Equal("Only two players are allowed", actual.Message);
    }
    
    [Fact]
    public void Must_Have_2_Player()
    {
        // Arrange
        var game = new Game();

        // Act
        var actual = game.Start();

        // Assert
        Assert.Equal(2, actual);
    }

    [Fact]
    public void Board_Should_Have_Nine_Boxes()
    {
        // Arrange
        var game = new Game();
        
        // Act
        var boxes = game.Board.Boxes;
        
        // Assert
        Assert.Equal(9, boxes.Count());
    }

    [Fact]
    public void Board_Should_Be_Empty_On_Init()
    {
        // Arrange
        var game = new Game();
        
        // Act
        var board = game.Board.Boxes;

        // Assert
        Assert.True(game.Board.Boxes.All(x => x.Player == null));
    }
}