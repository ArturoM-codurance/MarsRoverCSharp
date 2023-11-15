namespace MarsRover;

public class Grid 
{
    private readonly Orientation _orientation;
    public int XCoordinate { get; set; } = 0;
    public int YCoordinate { get; set; } = 0;
    public int Height { get; }
    public int Width { get; }

    public Grid(int height, int width, Orientation orientation)
    {
        _orientation = orientation;
        Height = height;
        Width = width;
    }

}