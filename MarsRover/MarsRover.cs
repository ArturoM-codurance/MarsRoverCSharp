namespace MarsRover;

public class MarsRover
{
    private int _XCoordinate = 0;
    private int _YCoordinate = 0;
    private readonly int MAX_WIDTH;
    private readonly int MAX_HEIGHT;
    private readonly Compass _compass;

    public MarsRover(Grid grid, Compass compass)
    {
        MAX_WIDTH = grid.Width;
        MAX_HEIGHT = grid.Height;
        _compass = compass;
    }

    public string Execute(string commands)
    {
        foreach (var command in commands)
        {
            if (command == 'R') _compass.RotateRight();
            if (command == 'L') _compass.RotateLeft();
            if (command == 'M') Move();
        }

        return _XCoordinate + ":" + _YCoordinate + ":" + _compass._orientation;
    }

    private void Move()
    {
        if (_compass._orientation.Equals("N"))
        {
            _XCoordinate += 1;
            if (_XCoordinate > (MAX_HEIGHT - 1)) _XCoordinate = 0;
        }

        if (_compass._orientation.Equals("E"))
        {
            _YCoordinate += 1;
            if (_YCoordinate > (MAX_WIDTH - 1)) _YCoordinate = 0;
        }

        if (_compass._orientation.Equals("S"))
        {
            _XCoordinate -= 1;
            if (_XCoordinate < 0) _XCoordinate = MAX_HEIGHT - 1;
        }

        if (_compass._orientation.Equals("W"))
        {
            _YCoordinate -= 1;
            if (_YCoordinate < 0) _YCoordinate = MAX_WIDTH - 1;
        }
    }
    
}