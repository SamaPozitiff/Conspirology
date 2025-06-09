using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class NoteEntry
{
    public long id;
    public string name;
    public string place;
    public string eventDescriprion;
    public int day;


    public NoteEntry(long id, string name, string place, string eventDescriprion, int day)
    {
        this.id = id;
        this.name = name;
        this.place = place;
        this.eventDescriprion = eventDescriprion;
        this.day = day;
    }
}
