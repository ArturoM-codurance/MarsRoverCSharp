namespace MarsRover;

public class MarsRover
{
    private readonly Grid _grid;
    private readonly Orientation _orientation;

    public MarsRover(Grid grid, Orientation orientation)
    {
        _grid = grid;
        _orientation = orientation;
    }

    public string Execute(string commands)
    {
        foreach (var command in commands)
        {
            if (command == 'R') _orientation.RotateRight();
            if (command == 'L') _orientation.RotateLeft();
            if (command == 'M') _grid.Move();
        }

        return _grid.XCoordinate + ":" + _grid.YCoordinate + ":" + _orientation._orientation;
    }
    
}