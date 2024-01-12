namespace kata_dotnet_core_start.Lib;

public class Game
{
    private List<Player>? _players;

    public List<Player> Players => _players ??= new List<Player>();

    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }
}