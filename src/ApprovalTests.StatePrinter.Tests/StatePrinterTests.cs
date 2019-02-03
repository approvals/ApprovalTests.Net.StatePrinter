using ApprovalTests.StatePrinter;
using Xunit;

public class StatePrinterTests
{
    [Fact]
    public void TestVerifyCircleReferences()
    {
        var turtle = new Turtle("jim", new Turtle("kasper", new Turtle("llewellyn", null)));
        turtle.On.On.On = turtle;
        StatePrinterApprovals.Verify(turtle);
    }
}

public class Turtle
{
    public string Name { get; set; }
    public Turtle On { get; set; }

    public Turtle(string name, Turtle onTurtle)
    {
        Name = name;
        On = onTurtle;
    }
}