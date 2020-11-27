using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BSPRoomsBSPCorridors : MonoBehaviour
{
    [SerializeField]
    GameObject _lambdaObject;
    ConnectToLambda _lambda;
    ConvertJArrayToMatrix _converter;
    JArray _algo1JsonBoard;
    string[,] _board;

    // Start is called before the first frame update
    void Start()
    {
        _lambda = _lambdaObject.GetComponent<ConnectToLambda>();
        _converter = this.GetComponent<ConvertJArrayToMatrix>();
        _algo1JsonBoard = _lambda.getAlgo1JsonBoard;
        _board = _converter.Convert(_algo1JsonBoard);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
