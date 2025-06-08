using System.Collections;
using System.Collections.Generic;using Unity.VisualScripting;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private Transform firstPosition;
    [SerializeField] private Transform secondPosition;

    void Start()
    {
        gameObject.transform.position = firstPosition.position;
    }

    public void onClick()
    {
       
        gameObject.transform.position = gameObject.transform.position == firstPosition.position ? secondPosition.position : firstPosition.position;
    }
}