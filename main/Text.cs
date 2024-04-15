using Godot;

public partial class Text : Node3D
{
    [Export]
    public MeshInstance3D MeshFPS { get; set; }
    [Export]
    public MeshInstance3D MeshOS  { get; set; }
    [Export]
    public MeshInstance3D MeshGyroscope     { get; set; }
    [Export]
    public MeshInstance3D MeshAccelerometer { get; set; }

    public override void _Process(double delta)
    {
                    base._Process(       delta);

        if (MeshFPS.Mesh is TextMesh meshFPS)
        {
            meshFPS.Text = $"FPS: {Engine.GetFramesPerSecond()}";
        }
        if (MeshOS .Mesh is TextMesh meshOS)
        {
            meshOS .Text = $"OS : {OS    .GetName           ()}";
        }
        if (MeshGyroscope    .Mesh is TextMesh meshGyroscope    )
        {
            meshGyroscope    .Text = $"Gyroscope    : {Input.GetGyroscope    ()}";
        }
        if (MeshAccelerometer.Mesh is TextMesh meshAccelerometer)
        {
            meshAccelerometer.Text = $"Accelerometer: {Input.GetAccelerometer()}";
        }
    }
}
