namespace MarsRover;

public interface IHandlerMovility
{
    IHandlerMovility SetNext(IHandlerMovility handler);
    public void Handle(char command);
}