using System.Runtime.InteropServices;

namespace MarsRover;

public class MarsRoverShould
{
    private static MarsRover _marsRover;

    public MarsRoverShould()
    {
        var orientation = new Orientation();
        var grid = new Grid(10, 10, orientation);
        _marsRover = new MarsRover(grid, orientation);
    }

    [Theory]
    [InlineData("", "0:0:N")]
    [InlineData("R", "0:0:E")]
    [InlineData("RR", "0:0:S")]
    [InlineData("RRR", "0:0:W")]
    [InlineData("RRRR", "0:0:N")]
    public void rotate_right(string commands, string output)
    {
        Assert.Equal(output, _marsRover.HandleCommands(commands));
    }

    [Theory]
    [InlineData("L", "0:0:W")]
    [InlineData("LL", "0:0:S")]
    [InlineData("LLL", "0:0:E")]
    [InlineData("LLLL", "0:0:N")]
    public void rotate_left(string commands, string output)
    {
        Assert.Equal(output, _marsRover.HandleCommands(commands));
    }

    [Theory]
    [InlineData("LR", "0:0:N")]
    [InlineData("LRLLLR", "0:0:S")]
    public void rotate_both_directions(string commands, string output)
    {
        Assert.Equal(output, _marsRover.HandleCommands(commands));
    }

    [Theory]
    [InlineData("MMMM", "4:0:N")]
    [InlineData("RMMM", "0:3:E")]
    [InlineData("MMMRRRLMM", "1:0:S")]
    [InlineData("RMMMLLM", "0:2:W")]
    public void move_vertically(string commands, string output)
    {
        Assert.Equal(output, _marsRover.HandleCommands(commands));
    }

    [Theory]
    [InlineData("LM", "0:9:W")]
    [InlineData("MMMMMMMMMM", "0:0:N")]
    [InlineData("RMMMMMMMMMM", "0:0:E")]
    [InlineData("RRM", "9:0:S")]
    public void use_grid(string commands, string output)
    {
        Assert.Equal(output, _marsRover.HandleCommands(commands));
    }
}