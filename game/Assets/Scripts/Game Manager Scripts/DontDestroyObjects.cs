using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyObjects : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _dontDestroyObjects;
    void Start()
    {
        foreach (GameObject obj in _dontDestroyObjects)
        {
            DontDestroyOnLoad(obj);
        }
    }

    public GameObject GetDontDestroyObject(string name)
    {
        foreach (GameObject obj in _dontDestroyObjects)
        {
            if(obj.name == name)
            {
                return obj;
            }
        }
        throw new Exception($"This object can't be found: {name}");
    }
}
