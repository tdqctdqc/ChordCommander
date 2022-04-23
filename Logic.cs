using Godot;
using System;
using System.Collections.Generic;

public class Logic : Node
{
    private Game game; 
    private StringParser stringParser; 

    public void Init(Game game)
    {
        this.game = game; 
        game.Input.Connect("text_entered", this, nameof(GotInput));

        stringParser = new StringParser();
        
    }

    private void GotInput(string inputString)
    {
        List<Note> notes = stringParser.ParseString(inputString);
        
    }
}
