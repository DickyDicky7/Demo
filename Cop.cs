using Godot;

public partial class Cop : VehicleBody3D
{
    public const float    MAX_STEER = 000.8f;
    public const float ENGINE_POWER = 300.0f;

    public override void _Ready()
    {
                    base._Ready();

        //Input.MouseMode = Input.MouseModeEnum.Captured;
    }

    public override void _PhysicsProcess(double delta)
    {
                    base._PhysicsProcess(       delta);

        Steering = Mathf.MoveToward(Steering, Input.GetAxis("R","L") *    MAX_STEER, (float)delta * 2.5f);
     EngineForce = Input.GetAxis("D","U")                            * ENGINE_POWER;
    }
}
