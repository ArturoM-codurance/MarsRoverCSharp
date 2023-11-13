namespace MarsRover;

public class Compass
{
    public string _orientation = "N";

    public Compass()
    {
    }

    public void RotateLeft()
    {
        if (_orientation.Equals("W")) _orientation = "S";
        else if (_orientation.Equals("S")) _orientation = "E";
        else if (_orientation.Equals("E")) _orientation = "N";
        else if (_orientation.Equals("N")) _orientation = "W";
    }

    public void RotateRight()
    {
        if (_orientation.Equals("W")) _orientation = "N";
        else if (_orientation.Equals("S")) _orientation = "W";
        else if (_orientation.Equals("E")) _orientation = "S";
        else if (_orientation.Equals("N")) _orientation = "E";
    }
}