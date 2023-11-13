namespace MarsRover;

public class MarsRover
{
    private string _orientation = "N";
    private int _XCoordinate = 0;
    private int _YCoordinate = 0;
    private readonly int MAX_WIDTH;
    private readonly int MAX_HEIGHT;

    public MarsRover(Grid grid)
    {
        MAX_WIDTH = grid.Width;
        MAX_HEIGHT = grid.Height;
    }

    public string Execute(string commands)
    {
        foreach (var command in commands)
        {
            if (command == 'R') RotateRight();
            if (command == 'L') RotateLeft();
            if (command == 'M') Move();
        }

        return _XCoordinate + ":" + _YCoordinate + ":" + _orientation;
    }

    private void Move()
    {
        if (_orientation.Equals("N"))
        {
            _XCoordinate += 1;
            if (_XCoordinate > (MAX_HEIGHT - 1)) _XCoordinate = 0;
        }

        if (_orientation.Equals("E"))
        {
            _YCoordinate += 1;
            if (_YCoordinate > (MAX_WIDTH - 1)) _YCoordinate = 0;
        }

        if (_orientation.Equals("S"))
        {
            _XCoordinate -= 1;
            if (_XCoordinate < 0) _XCoordinate = MAX_HEIGHT - 1;
        }

        if (_orientation.Equals("W"))
        {
            _YCoordinate -= 1;
            if (_YCoordinate < 0) _YCoordinate = MAX_WIDTH - 1;
        }
    }

    private void RotateLeft()
    {
        if (_orientation.Equals("W")) _orientation = "S";
        else if (_orientation.Equals("S")) _orientation = "E";
        else if (_orientation.Equals("E")) _orientation = "N";
        else if (_orientation.Equals("N")) _orientation = "W";
    }

    private void RotateRight()
    {
        if (_orientation.Equals("W")) _orientation = "N";
        else if (_orientation.Equals("S")) _orientation = "W";
        else if (_orientation.Equals("E")) _orientation = "S";
        else if (_orientation.Equals("N")) _orientation = "E";
    }

    private void Rotate(string command)
    {
        _compass.getNewDirection(command);
    }
    
}