namespace kata_dotnet_core_start.Lib;

public class Board
{
    public Board()
    {
        Boxes = Enumerable.Range(1, 9).Select(x => new Box(x));
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
    public object Player { get; set; }
}