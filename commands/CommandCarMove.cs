using Godot;

[GlobalClass]
public partial class CommandCarMove : Command
{
    [Export]
    public Node3D CarFrontLWheel { get; set; }
    [Export]
    public Node3D CarFrontRWheel { get; set; }
    [Export]
    public Node3D CarBackWheels { get; set; }
    [Export(hintString: "- for move forw | + for move back | 0 for no move")]
    public float MoveDegrees { get; set; }

    public override void Execute()
    {
        float carFrontLWheelRotationDegreesX = CarFrontLWheel.RotationDegrees.X;
        float carFrontRWheelRotationDegreesX = CarFrontRWheel.RotationDegrees.X;
        float carBackWheelsRotationDegreesX = CarBackWheels.RotationDegrees.X;
        carFrontLWheelRotationDegreesX += MoveDegrees;
        carFrontRWheelRotationDegreesX += MoveDegrees;
        carBackWheelsRotationDegreesX += MoveDegrees;
        CarFrontLWheel.RotationDegrees =
        CarFrontLWheel.RotationDegrees with { X = carFrontLWheelRotationDegreesX, };
        CarFrontRWheel.RotationDegrees =
        CarFrontRWheel.RotationDegrees with { X = carFrontRWheelRotationDegreesX, };
        CarBackWheels.RotationDegrees =
        CarBackWheels.RotationDegrees with { X = carBackWheelsRotationDegreesX, };
    }
}
