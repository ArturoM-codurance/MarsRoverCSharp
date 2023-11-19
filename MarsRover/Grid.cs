namespace MarsRover;

public class Grid 
{
    public int XCoordinate { get; set; } = 0;
    public int YCoordinate { get; set; } = 0;
    public int Height { get; }
    public int Width { get; }

    public Grid(int height, int width)
    {
        Height = height;
        Width = width;
    }

}