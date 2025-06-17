using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    [SerializeField] private GameObject _colorNow;

    private void OnMouseDown()
    {
        
        Color clickedColor = GetComponent<Renderer>().material.color;
        Debug.Log("Clicked Color: " + clickedColor);
        if (_colorNow != null)
        {
            Renderer colorRenderer = _colorNow.GetComponent<Renderer>();
            if (colorRenderer != null)
            {
                colorRenderer.material.color = clickedColor;
                Debug.Log("Color applied to _colorNow object.");
            }
            else
            {
                Debug.LogWarning("_colorNow does not have a Renderer component.");
            }
        }
        else
        {
            Debug.LogWarning("_colorNow is not assigned.");
        }


    }
}

