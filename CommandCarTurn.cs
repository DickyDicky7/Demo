using Godot;

[GlobalClass]
public partial class CommandCarTurn : Command
{
    [Export]
    public Node3D CarFrontLWheel { get; set; }
    [Export]
    public Node3D CarFrontRWheel { get; set; }
    [Export(hintString: "- for turn R | + for turn L | 0 for no turn")]
    public float TurnDegrees { get; set; }
    [Export]
    public float TurnDegreesMin { get; set; } = -210;
    [Export]
    public float TurnDegreesMax { get; set; } = -150;

    public override void Execute()
    {
        float carFrontLWheelRotationDegreesY = CarFrontLWheel.RotationDegrees.Y;
        float carFrontRWheelRotationDegreesY = CarFrontRWheel.RotationDegrees.Y;
        carFrontLWheelRotationDegreesY = Mathf.Clamp(
        carFrontLWheelRotationDegreesY + TurnDegrees, TurnDegreesMin, TurnDegreesMax);
        carFrontRWheelRotationDegreesY = Mathf.Clamp(
        carFrontRWheelRotationDegreesY + TurnDegrees, TurnDegreesMin, TurnDegreesMax);
        CarFrontLWheel.RotationDegrees =
        CarFrontLWheel.RotationDegrees with { Y = carFrontLWheelRotationDegreesY, };
        CarFrontRWheel.RotationDegrees =
        CarFrontRWheel.RotationDegrees with { Y = carFrontRWheelRotationDegreesY, };
    }
}
