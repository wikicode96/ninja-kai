using Godot;
using System;

public partial class PlayerController : CharacterBody2D
{
	[Export]
	public int Speed = 400; // Velocidad del personaje

	public void GetInput()
    {
        Vector2 inputDirection = Input.GetVector("move_left", "move_right", "move_up", "move_down");
        Velocity = inputDirection * Speed;
    }

    public override void _PhysicsProcess(double delta)
    {
        GetInput();
        MoveAndSlide();
    }
}
