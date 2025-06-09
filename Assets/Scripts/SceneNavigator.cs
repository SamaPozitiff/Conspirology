using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public void LoadRoomScene()
    {
        
        SceneManager.LoadScene("Room");
    }
    
    public void LoadNotebookScene()
    {
        SceneManager.LoadScene("Notebook");
    }
    
    public void LoadMapScene()
    {
        SceneManager.LoadScene("Map");
    }
    
    public void QuitApplication()
    {
        Application.Quit();
    }

    
    
}
