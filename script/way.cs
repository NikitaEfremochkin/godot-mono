using Godot;
using System;

public class way : Node2D
{
    [Export]
    int SPEED = 5;
    Random random = new Random();

    public void entered(KinematicBody2D body)
    {
      if(body.Name == "KinematicBody2D")
        GetTree().ChangeScene("res://scene/menu.tscn");
    }
    public override void _Ready()
    {
      int result = random.Next(0,2);
      if(result == 1 && this.Filename == "res://scene/battle.tscn")
      GetNode<Node2D>("Up").Free();
      
      if(result == 0 && this.Filename == "res://scene/battle.tscn")
      GetNode<Node2D>("Down").Free();
      
    }
    public override void _Process(float delta)
    {
      this.Position = new Vector2(this.Position.x -(SPEED + (Global.score/1000)) , this.Position.y);
      if(this.Name == "battle" && this.Position.x == -500)
      {
        this.Free();
      }
    }

}
