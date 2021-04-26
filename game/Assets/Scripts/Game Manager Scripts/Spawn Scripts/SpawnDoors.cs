using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDoors : MonoBehaviour
{

    [SerializeField]
    private bool _activeStartDoor;

    [SerializeField]
    private bool _activeEndDoor;

    [SerializeField]
    private GameObject _startDoor;

    [SerializeField]
    private GameObject _endDoor;

    [SerializeField]
    private ImportantePoints _points;

    [SerializeField]
    private InstantiateTiles _tiles;

    // Start is called before the first frame update
    void Start()
    {
        if (_activeStartDoor)
        {
            _startDoor.SetActive(true);
            _startDoor.transform.position = new Vector3(0, 1, 0) + _points.StartPosition;
        }
        if (_activeEndDoor)
        {
            _endDoor.SetActive(true);
            _endDoor.transform.position = _points.EndPosition;
            Destroy(_tiles.EndTile);
        }
    }
}
