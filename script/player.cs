using Godot;
using System;

public class player : KinematicBody2D
{
    [Export]
    int jump = 2000;
    [Export]
    int gravity= 200;
    Vector2 velocity = new Vector2();
    Vector2 floor = new Vector2(0 , -1);
    public override void _Process(float delta)
    {
        
        if(Input.IsActionPressed("jump") &&  IsOnFloor())
        {
            velocity.y -= jump;
        }

        if(Input.IsActionPressed("down"))
        {
            velocity.y += jump;
            this.Scale = new Vector2(1 , 0.5f);
        }
        else
        {
            this.Scale = new Vector2(1f , 1f);    
        }
        velocity.y += gravity;

        velocity = MoveAndSlide(velocity, floor);
    }
}
