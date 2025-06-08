using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RoomController : MonoBehaviour
{
    [SerializeField] private Text timerText;
    
    private float maxTimer = 300f;
    private float currrentTimer;

    private void Start()
    {
        currrentTimer = maxTimer;
    }

    private void Update()
    {
        currrentTimer -= Time.deltaTime;
        if (CheckTimerEnd())
        {
            SceneManager.LoadScene("Notebook");
        }
        UpdateText();
    }

    public void UpdateText()
    {
        timerText.text = FormatTime(currrentTimer);
    }


    private string FormatTime(float time)
    {
        int minutes = (int)(time / 60);
        int seconds = (int)(time % 60);
        return $"{minutes:00}:{seconds:00}";
    }

    private bool CheckTimerEnd()
    {
        return currrentTimer <= 0;
    }
}
