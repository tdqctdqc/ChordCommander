using Godot;
using System;
using System.Collections.Generic;

public class Chord 
{
    public Note Root;
    public List<Interval> Intervals;
    public Chord(Note root)
    {
        Root = root; 
    }
    public void AddInterval(Interval interval)
    {
        Intervals.Add(interval);
    }
}
