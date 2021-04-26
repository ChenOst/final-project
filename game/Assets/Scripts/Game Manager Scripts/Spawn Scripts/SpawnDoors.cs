using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDoors : MonoBehaviour
{

    [SerializeField]
    private bool _activeEntryDoor;

    [SerializeField]
    private bool _activeExitDoor;

    [SerializeField]
    private GameObject _entrytDoor;

    [SerializeField]
    private GameObject _exitDoor;

    [SerializeField]
    private ImportantePoints _points;

    [SerializeField]
    private InstantiateTiles _tiles;

    void Start()
    {
        // Spwaning the Entry Door
        if (_activeEntryDoor)
        {
            _entrytDoor.SetActive(true);
            _entrytDoor.transform.position = new Vector3(0, 1, 0) + _points.StartPosition;
        }
        // Spwaning the Exit Door
        if (_activeExitDoor)
        {
            _exitDoor.SetActive(true);
            _exitDoor.transform.position = _points.EndPosition;
            Destroy(_tiles.EndTile);
        }
    }
}
