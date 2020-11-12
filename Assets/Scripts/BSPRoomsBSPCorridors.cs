using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BSPRoomsBSPCorridors : MonoBehaviour
{
    ConnectToLambda _lambda;
    ConvertJArrayToMatrix _converter;
    JArray _jsonBoard;
    string[,] _algo1matrix;

    // Start is called before the first frame update
    void Start()
    {/*
        _jsonBoard = _lambda.getAlgo1MatrixBoard;
        Debug.Log(_jsonBoard);
        
        _algo1matrix = _converter.Convert(_jsonBoard);
        
for (int i = 0; i < _algo1matrix.GetLength(0); i++)
{
    for (int j = 0; j < _algo1matrix.GetLength(1); j++)
    {
        Debug.Log(_algo1matrix[i, j]);
    }
}*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
