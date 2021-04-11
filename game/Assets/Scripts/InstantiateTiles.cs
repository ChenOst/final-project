using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTiles : MonoBehaviour
{
    [SerializeField] private GameObject[] _floorToSpawn;

    [SerializeField] private GameObject[] _wallToSpawn;

    [SerializeField] private GameObject _boardController;

    public void Instantiate(string[,] board)
    {
        for (int k = 0; k < board.GetLength(0); k++)
        {
            for (int l = 0; l < board.GetLength(1); l++)
            {
                if (board[k, l] == "#")
                {
                    int index = (int)Random.Range(0, _floorToSpawn.Length);
                    var posToSpawn = new Vector3(k * 2, 0, l * 2);
                    GameObject newTile = Instantiate(_floorToSpawn[index], posToSpawn, Quaternion.identity);
                    newTile.transform.parent = _boardController.transform;
                }
                else
                {
                    int index = (int)Random.Range(0, _wallToSpawn.Length);
                    var posToSpawn = new Vector3(k * 2, 3.7f, l * 2);
                    GameObject newTile =  Instantiate(_wallToSpawn[index], posToSpawn, Quaternion.identity);
                    newTile.transform.parent = _boardController.transform;
                }

            }
        }
    }
}
