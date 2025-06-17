using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    [SerializeField] private ColorManager _colorToPrint;

    private void Awake()
    {
        _colorToPrint = GameObject.FindObjectOfType<ColorManager>();
    }
    private void OnMouseDown()
    {
        if (_colorToPrint == null)
        {
            Debug.LogWarning("_colorNow is not assigned. Please assign a GameObject with a Renderer component.");
            return;
        }

        gameObject.GetComponent<Renderer>().material.color = _colorToPrint.GetComponent<Renderer>().material.color;
        Debug.Log("Color set to: " + _colorToPrint.GetComponent<Renderer>().material.color);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _colorToPrint.GetComponent<Renderer>().material.SetColor("_BaseColor", Color.white);
        }
    }

}
