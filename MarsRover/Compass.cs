namespace MarsRover;

public class Compass
{
    public static readonly Compass NORTH = new Compass("N", "W", "E");
    public static readonly Compass EAST   = new Compass("E", "N", "S");
    public static readonly Compass SOUTH   = new Compass("S", "E", "W");
    public static readonly Compass WEST    = new Compass("W", "S", "N");

    public static IEnumerable<Compass> Values
    {
        get
        {
            yield return NORTH;
            yield return EAST;
            yield return SOUTH;
            yield return WEST;
        }
    }

    public string Value   { get; private set; }
    public string Left   { get; private set; }
    public string Right   { get; private set; }

    Compass(string name, string left, string right) => 
        (Value, Left, Right) = (name, left, right);

}