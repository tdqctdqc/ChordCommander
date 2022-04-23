using Godot;
using System;
using System.Collections.Generic;

public class NoteUtility
{
    public static Dictionary<char, int> CharNote; 
    public static Dictionary<int, char> NoteChar; 
    public static List<char> LegalChar; 
    public static Dictionary<int, int> DiatonicChromatic;
    public static Dictionary<int, int> ChromaticDiatonic;


    public static int GetAccidentalInt(char c)
    {
        if(c == "b".ToCharArray()[0])
        {
            return -1;
        }
        else if (c == "#".ToCharArray()[0])
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static string GetAccidentalString(int i)
    {
        if(i == -1)
        {
            return "b";
        }
        else if (i == 1)
        {
            return "#";
        }
        else
        {
            return "";
        }
    }

    public static void Init()
    {
        InitCharNote();
        InitDiatonicChromatic();
        InitChromaticDiatonic();
        InitLegalChar();
    }

    private static void InitCharNote()
    {
        CharNote = new Dictionary<char, int>();
        CharNote.Add("C"[0], 0);
        CharNote.Add("c"[0], 0);
        CharNote.Add("D"[0], 1);
        CharNote.Add("d"[0], 1);
        CharNote.Add("E"[0], 2);
        CharNote.Add("e"[0], 2);
        CharNote.Add("F"[0], 3);
        CharNote.Add("f"[0], 3);
        CharNote.Add("G"[0], 4);
        CharNote.Add("g"[0], 4);
        CharNote.Add("A"[0], 5);
        CharNote.Add("a"[0], 5);
        CharNote.Add("B"[0], 6);
    }
    private static void InitNoteChar()
    {
        NoteChar = new Dictionary<int,char>();
        NoteChar.Add(0,"C"[0]);
        NoteChar.Add(1,"D"[0]);
        NoteChar.Add(2,"E"[0]);
        NoteChar.Add(3,"F"[0]);
        NoteChar.Add(4,"G"[0]);
        NoteChar.Add(5,"A"[0]);
        NoteChar.Add(6,"B"[0]);
    }

    private static void InitDiatonicChromatic()
    {
        DiatonicChromatic = new Dictionary<int, int>();
        DiatonicChromatic.Add(0,0);
        DiatonicChromatic.Add(1,2);
        DiatonicChromatic.Add(2,4);
        DiatonicChromatic.Add(3,5);
        DiatonicChromatic.Add(4,7);
        DiatonicChromatic.Add(5,9);
        DiatonicChromatic.Add(6,11);
    }

    private static void InitChromaticDiatonic()
    {
        ChromaticDiatonic = new Dictionary<int, int>();
        ChromaticDiatonic.Add(0,0);
        ChromaticDiatonic.Add(1,0);
        ChromaticDiatonic.Add(2,1);
        ChromaticDiatonic.Add(3,1);
        ChromaticDiatonic.Add(4,2);
        ChromaticDiatonic.Add(5,3);
        ChromaticDiatonic.Add(6,3);
        ChromaticDiatonic.Add(7,4);
        ChromaticDiatonic.Add(8,4);
        ChromaticDiatonic.Add(9,5);
        ChromaticDiatonic.Add(10,5);
        ChromaticDiatonic.Add(11,6);
    }

    private static void InitLegalChar()
    {
        LegalChar = new List<char>();
        LegalChar.Add("A"[0]);
        LegalChar.Add("a"[0]);
        LegalChar.Add("B"[0]);
        LegalChar.Add("b"[0]);
        LegalChar.Add("C"[0]);
        LegalChar.Add("c"[0]);
        LegalChar.Add("D"[0]);
        LegalChar.Add("d"[0]);
        LegalChar.Add("E"[0]);
        LegalChar.Add("e"[0]);
        LegalChar.Add("F"[0]);
        LegalChar.Add("f"[0]);
        LegalChar.Add("G"[0]);
        LegalChar.Add("G"[0]);
        LegalChar.Add("A"[0]);
        LegalChar.Add("a"[0]);
        LegalChar.Add("B"[0]);
        LegalChar.Add("b"[0]);
        LegalChar.Add("#"[0]);


    }
}
