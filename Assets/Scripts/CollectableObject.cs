using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    [System.Serializable]
    public class CollectableObject
    {
        [SerializeField] private string objectName;
        [SerializeField] private Sprite Image;
        [SerializeField] private List<Transform> places = new List<Transform>();


        

        public Transform GetRandomPlace()
        {
            return places[Random.Range(0, places.Count)];
            
        }

        public Sprite GetImage()
        {
            return Image;
        }

        public string GetObjectName()
        {
            return objectName;
        }

    }
