using UnityEngine;
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
    
    
}
