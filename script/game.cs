using Godot;
using System;

public class game : Node2D
{
    Random random = new Random();
    int i= 0;
    [Export]
    PackedScene barickad;
    [Export]
    PackedScene sky;
    
    public void timeout()
    {
        Node2D inst = (Node2D)sky.Instance();  
         AddChild(inst);
        inst.Position = new Vector2(1000 , new Random().Next(0,100));
    }
    public void spawn()
    {
        Node2D insta = (Node2D)barickad.Instance();
        AddChild(insta);
        insta.Position = new Vector2(1000,530);
        i++;
        if(i==3)
        i=0;
        GetNode<Timer>("spawnbarack").WaitTime = random.Next(2 - 100/Global.score,5-100/Global.score);
    }
    public override void _Process(float delta)
    {   
        GetNode<Label>("Label").Text = Global.score.ToString();
        if(GetNode<Node2D>("way/way1").Position.x <= -500)
            GetNode<Node2D>("way/way1").Position = new Vector2(1000,  GetNode<Node2D>("way/way1").Position.y);
        if(GetNode<Node2D>("way/way2").Position.x <= -500)
            GetNode<Node2D>("way/way2").Position = new Vector2(1000,  GetNode<Node2D>("way/way2").Position.y);
        if(GetNode<Node2D>("way/way3").Position.x <= -500)
            GetNode<Node2D>("way/way3").Position = new Vector2(1000,GetNode<Node2D>("way/way3").Position.y); 
            Global.score++;
    }
}
