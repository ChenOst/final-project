using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyObjects : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(GameObject.Find(ObjectNameHelper.GameManager));
        DontDestroyOnLoad(GameObject.Find(ObjectNameHelper.Canvas));
        DontDestroyOnLoad(GameObject.Find(ObjectNameHelper.MainCamera));
        DontDestroyOnLoad(GameObject.Find(ObjectNameHelper.Player));
    }
}
