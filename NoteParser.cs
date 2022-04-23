using Godot;
using System;
using System.Collections.Generic;

public class NoteParser : Node
{
    public Chord GetChord(Note root, List<Note> notes)
    {
        Chord chord = new Chord(root);
        for (int i = 0; i < notes.Count; i++)
        {
            int diatonicWidth = (root.DiatonicIndex - notes[i].DiatonicIndex) % 8;
            int chromaticWidth = (root.ChromaticIndex - notes[i].ChromaticIndex) % 12;

            Interval interval = Interval.IntervalDictionary[diatonicWidth][chromaticWidth];
            chord.AddInterval(interval);
        }
        return chord;
    }
}
