using Godot;
using System;

public class Note 
{
    public int DiatonicIndex {get; private set;} //C is 0
    public int ChromaticIndex {get; private set;} // Ditto
    public int Accidental {get; private set;}
    public string NoteName => NoteUtility.NoteChar[DiatonicIndex] + NoteUtility.GetAccidentalString(Accidental);

    public Note(int diatonicIndex, int accidental)
    {
        Accidental = accidental;
        DiatonicIndex = diatonicIndex;
        ChromaticIndex = NoteUtility.DiatonicChromatic[DiatonicIndex] + accidental; 
    }
}
