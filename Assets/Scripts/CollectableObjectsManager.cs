using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableObjectsManager : MonoBehaviour
{
    [SerializeField] private List<CollectableObject> collectableObjects = new List<CollectableObject>();
    [SerializeField] private GameObject prefab;


    private void Start()
    {
        for (var i = 0; i < collectableObjects.Count; i++)
        {   
            GameObject buttonObject = Instantiate(prefab, transform, false);
            buttonObject.name = collectableObjects[i].GetObjectName();
            buttonObject.transform.SetParent(transform);
            buttonObject.transform.position = collectableObjects[i].GetRandomPlace().position;
            Button button = buttonObject.GetComponent<Button>();
            Image image = buttonObject.GetComponent<Image>();
            image.sprite = collectableObjects[i].GetImage();
            image.SetNativeSize();
            button.onClick.AddListener(() => AddNote(buttonObject));
            
        }
    }
    
    private void AddNote(GameObject buttonObject)
    {
        GameManager.notes.Add(new NoteEntry(GameManager.notes.Count, GameManager.levelName,  buttonObject.name, "Room", GameManager.dayCount));
        Destroy(buttonObject);
    }
}
