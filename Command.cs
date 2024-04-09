using Godot;

[GlobalClass]
public abstract partial class Command : Node
{
    public override sealed void _Ready ()
    {
                           base._Ready ();
        ProcessMode = ProcessModeEnum.Disabled;
    }

    public abstract        void Execute();
}
