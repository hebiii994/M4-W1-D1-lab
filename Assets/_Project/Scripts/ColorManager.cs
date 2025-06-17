using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    private Renderer _renderer;


    void Awake()
    {
        _renderer = GetComponent<Renderer>();
        if (_renderer == null)
        {
            Debug.LogError("Renderer component not found on this GameObject.");
        }
    }
}
