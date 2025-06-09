using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    public static int dayCount;
    public static List<NoteEntry> notes = new();
    public static string levelName;
    
    static GameManager()
    {
        dayCount = 1;
        
    }
    public static void PlayButtonSound(AudioSource audioSource)
    {
        
        audioSource.PlayOneShot(audioSource.clip);
    }
}
