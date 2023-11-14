namespace MarsRover;

public class Grid
{
    private readonly Orientation _orientation;
    public int XCoordinate { get; set; } = 0;
    public int YCoordinate { get; set; } = 0;
    public int Height { get; }
    public int Width { get;}
    
    public Grid(int height, int width, Orientation orientation)
    {
        _orientation = orientation;
        Height = height;
        Width = width;
    }
    
    public void Move()
    {
        if (_orientation._orientation.Equals("N"))
        {
            XCoordinate += 1;
            if (XCoordinate > (Height - 1)) XCoordinate = 0;
        }

        if (_orientation._orientation.Equals("E"))
        {
            YCoordinate += 1;
            if (YCoordinate > (Height - 1)) YCoordinate = 0;
        }

        if (_orientation._orientation.Equals("S"))
        {
            XCoordinate -= 1;
            if (XCoordinate < 0) XCoordinate = Height - 1;
        }

        if (_orientation._orientation.Equals("W"))
        {
            YCoordinate -= 1;
            if (YCoordinate < 0) YCoordinate = Height - 1;
        }
    }
}