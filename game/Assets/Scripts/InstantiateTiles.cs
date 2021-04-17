using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTiles : MonoBehaviour
{
    [SerializeField] private GameObject[] _floorToSpawn;

    [SerializeField] private GameObject[] _wallToSpawn;

    [SerializeField] private GameObject _boardController;

    public Vector3 StartPosition { get; private set; }
    public Vector3 EndPosition { get; private set; }

    private static bool startPositionIsSet = false;

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
                    if (!startPositionIsSet)
                    {
                        StartPosition = new Vector3(k * 2, 0, l * 2);
                        SetPlayerLocation(k * 2, 0, l * 2);
                        startPositionIsSet = true;
                    }
                    GameObject newTile = Instantiate(_floorToSpawn[index], posToSpawn, Quaternion.identity);
                    newTile.transform.parent = _boardController.transform;
                    EndPosition = new Vector3(k * 2, 0, l * 2);
                }
                else
                {
                    int index = (int)Random.Range(0, _wallToSpawn.Length);
                    var posToSpawn = new Vector3(k * 2, 2.2f, l * 2);
                    GameObject newTile =  Instantiate(_wallToSpawn[index], posToSpawn, Quaternion.identity);
                    newTile.transform.parent = _boardController.transform;
                }

            }
        }
    }

    private void SetPlayerLocation(float x, float y, float z)
    {
        GameObject player = GameObject.Find("Prefab_PlayerCharacter");
        player.transform.position = new Vector3(x, y + 1, z);
    }

}
