using Godot;
using System;

public class Player : KinematicBody2D
{
    private Vector2 velocity = Vector2.Zero;
    private int moveSpeed = 480;
    private int gravity = 1200;
    private int jumpForce = -720;

    public override void _PhysicsProcess(float delta)
    {
         base._PhysicsProcess(delta);
        velocity.y += gravity * delta;
        var moveDirection = 0;
        if (Input.IsActionPressed("move_right")) 
            moveDirection = 1;
        if (Input.IsActionPressed("move_left"))
            moveDirection = -1;
        if (Input.IsActionPressed("jump"))
            velocity.y = jumpForce / 2;
        
            
        velocity.x = moveSpeed * moveDirection;
        MoveAndSlide(velocity);
    }
}
