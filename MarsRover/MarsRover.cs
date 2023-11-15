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

    public string Move(string commands)
    {
        foreach (var command in commands)
        {
            _orientation.Execute(command);
            _grid.Execute(command);
        }

        return _grid.XCoordinate + ":" + _grid.YCoordinate + ":" + _orientation.Direction;
    }
}

// {
// var commandObj = createNewCommand(command);
// var state = commandObj.Execute(_grid, _orientation);
// _grid = state._grid;
// _orientation = state._orientation;
// }
//
// moveCommand.Execute(_grid, _orientation);
// turnLeftCommand.Execute(_grid, _orientation);
//
// -chain of responsibility pattern-