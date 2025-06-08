using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NoteBookManager : MonoBehaviour
{           
    [SerializeField] private NoteUIController notePrefab;
    
    public void Start()
    {
        GenerateNotes();
    }

    private void GenerateNotes()
    {
        AddNewNotes();
        foreach (var note in GameManager.notes)
        {
            GenerateNote(note).transform.SetParent(gameObject.transform, false);
        }
    }
    private GameObject GenerateNote(NoteEntry note)
    {
        GameObject point = Instantiate(notePrefab.gameObject);
        point.GetComponent<NoteUIController>().SetupText(note);
        return point;
    }


    private void AddNewNotes()
    {
        GameManager.notes.Add(new NoteEntry(GameManager.notes.Count+1, "Ivan", "Home", "Birthday", GameManager.dayCount));
        GameManager.notes.Add(new NoteEntry(GameManager.notes.Count+1, "Masha", "Job", "Work", GameManager.dayCount));
        GameManager.notes.Add(new NoteEntry(GameManager.notes.Count+1, "Pasha", "Home", "Sleep", GameManager.dayCount));
    }
}
