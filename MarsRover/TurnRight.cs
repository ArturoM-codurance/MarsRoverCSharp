namespace MarsRover;

public class TurnRight : BasicHandler
{
    private Orientation _orientation;

    public TurnRight(Orientation orientation)
    {
        _orientation = orientation;
    }

    public override void Handle(char command)
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
        else
        {
            base.Handle(command);
        }
    }
}