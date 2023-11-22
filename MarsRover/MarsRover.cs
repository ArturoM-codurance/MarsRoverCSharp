using System;

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

    public string Execute(string commands)
    {
        foreach (var command in commands)
        {
            var handlers = CreateHandlers();
            
            handlers.First().Handle(command);
        }

        return _grid.XCoordinate + ":" + _grid.YCoordinate + ":" + _orientation.Direction;
    }

    private IEnumerable<IHandlerMovility> CreateHandlers()
    {
        var handlerList = new List<IHandlerMovility>();
        var turnLeftHandler = new TurnLeft(_orientation);
        var turnRightHandler = new TurnRight(_orientation);
        var moveHandler = new Move(_orientation, _grid);
        
        //Set the chain of Responsibility
        turnLeftHandler.SetNext(turnRightHandler);
        turnRightHandler.SetNext(moveHandler);
        
        handlerList.AddRange(new List<IHandlerMovility>()
        {
            turnLeftHandler,
            turnRightHandler,
            moveHandler
        });
        return handlerList;
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
//
// - chain of responsibility pattern -