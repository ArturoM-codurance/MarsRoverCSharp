namespace MarsRover;

public abstract class BasicHandler : IHandlerMovility
{
    private IHandlerMovility _nextHandler;

    public IHandlerMovility SetNext(IHandlerMovility handler)
    {
        this._nextHandler = handler;

        return handler;
    }

    public virtual void Handle(char command)
    {
        if (this._nextHandler != null)
        {
            this._nextHandler.Handle(command);
        }
    }
}