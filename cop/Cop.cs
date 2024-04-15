using Godot;

public partial class Cop : VehicleBody3D
{
    [Export]
    public float MaxRotate = 10.00f;
    [Export]
    public float MaxSteerr = 00.80f;
    [Export]
    public float EnginePower = 300.0f;

    [Export]
    public float AccelerationRotate = 10.0f;
    [Export]
    public float AccelerationSteerr = 02.5f;

    [Export]
    public Node3D Camera3DPivot { get; set; }

    public override void _Ready()
    {
                    base._Ready();

        //Input.MouseMode = Input.MouseModeEnum.Captured;
    }

    public override void _PhysicsProcess(double delta)
    {
                    base._PhysicsProcess(       delta);

        Steering = Mathf.MoveToward(Steering, Input.GetAxis("R","L") *   MaxSteerr, (float)delta * AccelerationSteerr);
     EngineForce = Input.GetAxis("D","U")                            * EnginePower;

        Camera3DPivot.RotationDegrees =
        Camera3DPivot.RotationDegrees.MoveToward
        (
        Camera3DPivot.RotationDegrees with
        {
            Y = Input.GetAxis("R", "L") * MaxRotate,
            Z = Input.GetAxis("R", "L") * MaxRotate,
        }
        , (float)delta * AccelerationRotate);
    }
}
