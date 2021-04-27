using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyObjects : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(GameObject.Find(Constants.GameManager));
        DontDestroyOnLoad(GameObject.Find(Constants.Canvas));
        DontDestroyOnLoad(GameObject.Find(Constants.Cameras));
        DontDestroyOnLoad(GameObject.Find(Constants.Player));
    }
}
