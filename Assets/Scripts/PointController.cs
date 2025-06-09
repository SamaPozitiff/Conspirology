using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class PointController : MonoBehaviour
{   
  
    [SerializeField] public string levelField { get; private set; }
    [SerializeField] public string nameField { get; private set; }
    private MapController mapController;

    public void Initialize(MapController mapController, string levelField, string nameField)
    {
        this.mapController = mapController;
        this.levelField = levelField;
        this.nameField = nameField;
    }
    
    
    public void OnPointClicked()
    {
        mapController.SelectPoint(this); 
    }
    
    
}
