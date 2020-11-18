using Godot;
using System;

public class sky : Node2D
{
    public override void _Process(float delta)
    {
        this.Position = new Vector2(this.Position.x -(new Random().Next(1,5) + (Global.score/1000)) , this.Position.y);
        if(this.Position.x == -500)
      {
        this.Free();
      }
    }
     
}
