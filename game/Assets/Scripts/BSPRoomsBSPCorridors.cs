using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BSPRoomsBSPCorridors : MonoBehaviour
{
    ConnectToLambda _lambda;

    JArray _algo1JsonBoard;

    string[,] _board;

    // Start is called before the first frame update
    void Start()
    {
        GameObject _lambdaObject = GameObject.Find("Lambda");
        _lambda = _lambdaObject.GetComponent<ConnectToLambda>();
        _algo1JsonBoard = _lambda.Algo1JsonBoard;
        _board = _lambdaObject.GetComponent<ConvertJArrayToMatrix>().Convert(_algo1JsonBoard);
        Text t = gameObject.GetComponent<Text>();
        for (int k = 0; k < _board.GetLength(0); k++)
        {
            for (int l = 0; l < _board.GetLength(1); l++)
            {
                t.text += _board[k, l];
            }
            t.text += "\n";
        } 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
