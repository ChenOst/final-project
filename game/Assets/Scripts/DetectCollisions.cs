using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisions : MonoBehaviour
{

    [SerializeField]
    private bool _active;

    [SerializeField]
    [Range(0,9)]
    private int _sceneNumber;

    [SerializeField]
    [Range(0, 9)]
    private int _controllerNumber;

    private GameObject _manager;

    private const string _managerName = "Game Manager";

    void Start()
    {
        _manager = GameObject.Find(_managerName);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            DontDestroyOnLoad(_manager);
            _manager.transform.GetChild(_controllerNumber).gameObject.SetActive(_active);
            SceneManager.LoadScene(_sceneNumber);
        }
    }

}
