using Godot;
using System;
using System.Collections.Generic;

public class StringParser
{
    public List<Note> ParseString(string s)
    {
        GD.Print(s);
        s = VerifyString(s);
        GD.Print(s);
        var notes = new List<Note>();
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if(NoteUtility.CharNote.ContainsKey(c) == false)
            {
                continue; 
            }

            int diatonicIndex = NoteUtility.CharNote[c];
            int accidental = 0; 

            if(i < s.Length - 1)
            {
                accidental = NoteUtility.GetAccidentalInt(s[i+1]);
            }

            var note = new Note(diatonicIndex, accidental);

            notes.Add(note);
        }
        return notes; 
    }

    private string VerifyString(string s)
    {
        string s1 = ""; 

        for (int i = 0; i < s.Length; i++)
        {   
            if(NoteUtility.LegalChar.Contains(s[i]) && s1.Contains(s[i].ToString()) == false) 
            {
                s1 = String.Join("", s1, s[i].ToString());
            }
        }
        return s1; 
    }
}
