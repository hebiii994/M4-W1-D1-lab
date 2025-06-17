using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator2d : MonoBehaviour
{
    [SerializeField] private GameObject _quadPrefab;
    [SerializeField] private int _indX = 10;
    [SerializeField] private int _indZ = 10;
    [SerializeField] private float _offsetX = 5f;
    [SerializeField] private float _offsetZ = 5f;
    [SerializeField] private float _spacing = 10f;


    private void Awake()
    {
        if ( _quadPrefab == null)
        {
            Debug.Log("Nessun prefab inserito");
            return;
        }
        

    }

    private void Start()
    {
        CreateGrid(_indX, _indZ);
    }

    private void CreateGrid(int numX, int numZ)
    {

        for(int x = 0; x < numX; x++)
        {
            for (int z = 0; z < numZ; z++)
            {
                float posX = _offsetX + (x * _spacing);
                float posZ = _offsetZ + (z * _spacing);
                Vector3 spawnPosition = new Vector3(posX, 0, posZ);
                Instantiate(_quadPrefab, spawnPosition, Quaternion.identity, this.transform);
                
            }
        }


    }
}
