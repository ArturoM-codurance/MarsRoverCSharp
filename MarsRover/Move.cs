namespace MarsRover;

public class Move : IRoverMovility
{
    private Orientation _orientation;
    private Grid _grid;

    public Move(Orientation orientation, Grid grid)
    {
        _orientation = orientation;
        _grid = grid;
    }

    public void Execute(char command)
    {
        var turnLeft = new TurnLeft(_orientation);
        var turnRight = new TurnRight(_orientation);
        turnLeft.Execute(command);
        turnRight.Execute(command);
        
        if ('M' == command)
        {
            if (_orientation.Direction.Equals("N"))
            {
                _grid.XCoordinate += 1;
                if (_grid.XCoordinate > (_grid.Height - 1)) _grid.XCoordinate = 0;
            }

            if (_orientation.Direction.Equals("E"))
            {
                _grid.YCoordinate += 1;
                if (_grid.YCoordinate  > (_grid.Height - 1)) _grid.YCoordinate  = 0;
            }

            if (_orientation.Direction.Equals("S"))
            {
                _grid.XCoordinate -= 1;
                if (_grid.XCoordinate < 0) _grid.XCoordinate = _grid.Height - 1;
            }

            if (_orientation.Direction.Equals("W"))
            {
                _grid.YCoordinate  -= 1;
                if (_grid.YCoordinate  < 0) _grid.YCoordinate  = _grid.Height - 1;
            }
        }
    }
}