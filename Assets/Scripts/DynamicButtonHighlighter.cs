using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class DynamicButtonHighlighter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
 
    [SerializeField] private Image buttonImage;
    [SerializeField] private  Image borderFrameImage;
    [SerializeField] private Color highlightColor;


    void Awake()
    {
        if (buttonImage == null)
        {
            buttonImage = GetComponent<Image>();
            if (buttonImage == null)
            {
                Debug.LogError("Button Image не назначен и не найден на GameObject. Рамка не будет работать.");
                enabled = false; 
                return;
            }
        }

        if (borderFrameImage == null)
        {
            Debug.LogError("Border Frame Image не назначен! Создайте дочерний Image для рамки и назначьте его.");
            enabled = false;
            return;
        }

        borderFrameImage.enabled = false;

      
        SetupBorderFrame();
    }

    private void SetupBorderFrame()
    {
      

        borderFrameImage.color = highlightColor;
        borderFrameImage.transform.SetSiblingIndex(0);
    }
  
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (borderFrameImage != null)
        {
            borderFrameImage.enabled = true;
        }
    }
  
    public void OnPointerExit(PointerEventData eventData)
    {
        if (borderFrameImage != null)
        {
            borderFrameImage.enabled = false;
        }
    }
}