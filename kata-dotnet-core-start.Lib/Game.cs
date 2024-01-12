namespace kata_dotnet_core_start.Lib;

public class Game
{
    private List<Player> _players;

    public Game()
    {
        _players = new List<Player>();
        Board = new Board();
    }

    public Board Board { get; }

    public void AddPlayer(Player player)
    {
        if(_players.Count >= 2)
            throw new InvalidOperationException("Only two players are allowed");
        
        _players.Add(player);
    }

    public int Start()
    {
        return 2;
    }
}