using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BSPRoomsBSPCorridors : MonoBehaviour
{
    GameObject _lambdaObject;

    ConnectToLambda _lambda;

    public int index;

    public void OnTriggerEnter(Collider other) 
    {
        Debug.Log(other.name);
        //other.transform.position = new Vector3(0, 10, 0);
       // DontDestroyOnLoad(other.gameObject);
        //SceneManager.LoadScene(index);
    }

}
