﻿using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTiles : MonoBehaviour
{
    [SerializeField] private GameObject[] _floorToSpawn;

    [SerializeField] private GameObject[] _wallToSpawn;

    [SerializeField]
    ConnectToLambda _lambda;

    public GameObject EndTile { get; private set; }

    void Start()
    {
        string[,] board = _lambda.Board;

        for (int k = 0; k < board.GetLength(0); k++)
        {
            for (int l = 0; l < board.GetLength(1); l++)
            {
                if (board[k, l] == "#")
                {
                    int index = (int)Random.Range(0, _floorToSpawn.Length);
                    var posToSpawn = new Vector3(k * 2, 0, l * 2);
                    GameObject newTile = Instantiate(_floorToSpawn[index], posToSpawn, Quaternion.identity);
                    newTile.transform.parent = this.transform;
                    EndTile = newTile;
                }
                else
                {
                    int index = (int)Random.Range(0, _wallToSpawn.Length);
                    var posToSpawn = new Vector3(k * 2, 2.2f, l * 2);
                    GameObject newTile =  Instantiate(_wallToSpawn[index], posToSpawn, Quaternion.identity);
                    newTile.transform.parent = this.transform;
                }

            }
        }

    }

}
