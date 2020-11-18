using Godot;
using System;

public class But : Button
{
    [Export]
    PackedScene sky;
    [Export]
    public Color mouse_entered_color = Color.Color8(255,255,255,255);
    
    [Export]
    public Color mouse_exited_color = Color.Color8(255,255,255,255);
    public void pressed()
    {
        GetTree().ChangeScene("res://scene/game.tscn");
        Global.score =0;
    }

    public override void _Ready()
    {
        GetNode<Label>("Label").Text = Global.score.ToString();
        this.Connect("mouse_entered" , this , nameof(entred));
        this.Connect("mouse_exited" , this , nameof(exited));
    }
    public void entred()
    {
        this.Modulate = mouse_entered_color;
    }
    
    public void exited()
    {
        this.Modulate = mouse_exited_color;
    }
    public void timeout()
    {
        Node2D inst = (Node2D)sky.Instance();  
         AddChild(inst);
        inst.Position = new Vector2(1000 , new Random().Next(-350, 350));
    }
}
