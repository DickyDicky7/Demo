using Godot;

public partial class MultiMeshWithCollision : MultiMeshInstance3D
{
    public override void _Ready()
    {
                    base._Ready();

        for (int index = 0; index < Multimesh.InstanceCount;     ++index)
        {
            Transform3D transform = Multimesh.GetInstanceTransform(index);
            CollisionShape3D
            collisionShape        = new      ();
            collisionShape.Shape  = Multimesh
                     .Mesh.CreateTrimeshShape();

            collisionShape.Transform =
            collisionShape.Transform with
            {
                Basis = collisionShape.Transform.Basis
                                     with
                {
                    X = transform.Basis.X,
                    Y = transform.Basis.Y,
                    Z = transform.Basis.Z,
                }
            };
            collisionShape.Scale    = new(01.000f, 01.000f, 01.000f);
            collisionShape.Rotation = new(25.132f, 25.132f, 25.132f);

            StaticBody3D staticBody = new() ;
            staticBody.Transform = transform;
            staticBody.AddChild(collisionShape);
                       AddChild(
            staticBody         );
        }
    }
}
