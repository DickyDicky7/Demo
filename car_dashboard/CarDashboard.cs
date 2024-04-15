using Godot;

public partial class CarDashboard : MeshInstance3D
{
    [Export]
    public MeshInstance3D SteeringWheel { get; set; }

    [Export]
    public float          MaxRotate = 45.00f;
    [Export]
    public float AccelerationRotate = 30.00f;

    public override void _Process(double @delta)
    {
                    base._Process(       @delta);

        SteeringWheel.RotationDegrees =
        SteeringWheel.RotationDegrees.MoveToward
        (
        SteeringWheel.RotationDegrees with
        {
            Z = Input.GetAxis("R", "L") *          MaxRotate ,
        }
        , (float)delta                  * AccelerationRotate);
    }
}
