using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteUIController : MonoBehaviour
{
    [SerializeField] private Text nameText;
    [SerializeField] private Text placeText;
    [SerializeField] private Text eventText;
    [SerializeField] private Text dayText;


    public void SetupText (NoteEntry noteEntry)
    {
        nameText.text = noteEntry.name;
        placeText.text = noteEntry.place;
        eventText.text = noteEntry.eventDescriprion;
        dayText.text = noteEntry.day.ToString();
    }
}
