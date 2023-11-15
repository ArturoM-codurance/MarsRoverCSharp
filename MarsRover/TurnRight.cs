namespace MarsRover;

public class TurnRight : IRoverMovility
{
    private Orientation _orientation;

    public TurnRight(Orientation orientation)
    {
        _orientation = orientation;
    }

    public void Execute(char command)
    {

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