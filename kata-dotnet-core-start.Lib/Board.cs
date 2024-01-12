namespace kata_dotnet_core_start.Lib;

public class Board
{
    public Board()
    {
        Boxes = new List<Box>
        {
            new Box(1),
            new Box(2),
            new Box(3),
            new Box(4),
            new Box(5),
            new Box(6),
            new Box(7),
            new Box(8),
            new Box(9),
        };
    }
    public IEnumerable<Box> Boxes { get; }
        
}

public class Box
{
    public Box(int position)
    {
        Position = position;
    }
    
    public int Position { get; }
}