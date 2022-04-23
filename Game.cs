using Godot;
using System;

public class Game : Node
{
    public LineEdit Input; 
    public Label Output; 
    public Logic Logic;
    public override void _Ready()
    {
        Input = GetNode<CanvasLayer>("Canvas").GetNode<LineEdit>("Input");
        Output = GetNode<CanvasLayer>("Canvas").GetNode<Panel>("OutputPanel").GetNode<Label>("OutputLabel");
        Logic = GetNode<Logic>("Logic");
        NoteUtility.Init();
        Logic.Init(this);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
