using System;
using UnityEngine;
using UnityEngine.UI;


    public class SwitchObject : MonoBehaviour
    {
        [SerializeField]
        private Sprite[] sprites;
        private Button button;
        private int currentSprite;

        void Start()
        {
            button = gameObject.GetComponent<Button>();
        }


        public void SwitchSprite()
        {
            if (currentSprite >= sprites.Length - 1)
            {
                currentSprite = 0;
            }
            else
            {
                currentSprite++;
            }
            button.image.sprite = sprites[currentSprite];
        }
        
    }
