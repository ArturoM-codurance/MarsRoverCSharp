namespace MarsRover;

public class Turn : IRoverMovility
{
    private Orientation _orientation;

    public Turn(Orientation orientation)
    {
        _orientation = orientation;
    }

    public void Execute(char command)
    {
        if (command == 'L')
        {
            foreach (var direction in Compass.Values)
            {
                if (_orientation.Direction.Equals(direction.Value))
                {
                    _orientation.Direction = direction.Left;
                    break;
                }
            }
        }

        if (command == 'R')
        {
            foreach (var direction in Compass.Values)
            {
                if (_orientation.Direction.Equals(direction.Value))
                {
                    _orientation.Direction = direction.Right;
                    break;
                }
            }
        }
    }
}