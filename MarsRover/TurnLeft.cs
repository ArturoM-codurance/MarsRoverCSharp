namespace MarsRover;

public class TurnLeft : BasicHandler
{
    private Orientation _orientation;

    public TurnLeft(Orientation orientation)
    {
        _orientation = orientation;
    }

    public override void Handle(char command)
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
        else
        {
            base.Handle(command);
        }
    }

}