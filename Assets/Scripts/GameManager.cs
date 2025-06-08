using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    public static int dayCount;
    public static List<NoteEntry> notes = new();
    
    static GameManager()
    {
        dayCount = 1;
        notes.Add(new NoteEntry(notes.Count+1, "Ivan", "Home", "Birthday", dayCount));
        notes.Add(new NoteEntry(notes.Count+1, "Masha", "Job", "Work", dayCount));
        notes.Add(new NoteEntry(notes.Count+1, "Pasha", "Home", "Sleep", dayCount));
        
    }
    public static void PlayButtonSound(AudioSource audioSource)
    {
        
        audioSource.PlayOneShot(audioSource.clip);
    }
}
