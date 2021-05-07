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
}
