using Cradle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpecialObject : MonoBehaviour
{

    [SerializeField]
    private string _missionName;

    [SerializeField]
    private GameObject _gameObject;

    [SerializeField]
    private ImportantePoints _points;

    [SerializeField]
    private InstantiateTiles _tiles;

    [SerializeField]
    private Vector3 _location;

    private bool once = false;

    private Story story;

    private void Start()
    {
        story = GameObject.Find(Constants.GameManager).GetComponent<DontDestroyObjects>()
            .GetDontDestroyObject(Constants.TwineTextPlayer).GetComponent<Story>();
    }

    // Start is called before the first frame update
    void Update()
    {
        if (story.Vars.GetMember(_missionName).InnerValue != null && !once)
        {
            once = true;
            _gameObject.SetActive(true);
            _gameObject.transform.position = _points.EndPosition + _location;
        }
    }
}
