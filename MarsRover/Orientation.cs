namespace MarsRover;

public class Orientation : IRoverMovility
{
    public string Direction = "N";

    public void Execute(char command)
    {
        if (command == 'L')
        {
            foreach (var direction in Compass.Values)
            {
                if (Direction.Equals(direction.Value))
                {
                    Direction = direction.Left;
                    break;
                }
            }
        }

        if (command == 'R')
        {
            foreach (var direction in Compass.Values)
            {
                if (Direction.Equals(direction.Value))
                {
                    Direction = direction.Right;
                    break;
                }
            }
        }
    }

    public void RotateLeft()
    {
        foreach (var direction in Compass.Values)
        {
            if (Direction.Equals(direction.Value))
            {
                Direction = direction.Left;
                break;
            }
        }
    }

    public void RotateRight()
    {
        foreach (var direction in Compass.Values)
        {
            if (Direction.Equals(direction.Value))
            {
                Direction = direction.Right;
                break;
            }
        }
    }
}