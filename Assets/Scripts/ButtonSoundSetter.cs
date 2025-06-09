using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundSetter : MonoBehaviour
{
    [SerializeField]private AudioSource audioSource;

    public void Start()
    {
        SetSoundsToAllButtons();
    }

    private void SetSoundsToAllButtons()
    {
        Button[] buttons = FindObjectsOfType<Button>();
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => GameManager.PlayButtonSound(audioSource));
        }

    }
}
