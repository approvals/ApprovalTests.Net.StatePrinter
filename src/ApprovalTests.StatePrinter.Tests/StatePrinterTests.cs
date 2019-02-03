using ApprovalTests.StatePrinter;
using Xunit;

#region usage

public class StatePrinterTests
{
    [Fact]
    public void TestVerifyCircleReferences()
    {
        var turtle = new Turtle("jim",
            new Turtle("kasper",
                new Turtle("llewellyn", null)));
        turtle.On.On.On = turtle;
        StatePrinterApprovals.Verify(turtle);
    }
}

#endregion

#region model

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
#endregion