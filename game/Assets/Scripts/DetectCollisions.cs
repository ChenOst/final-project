using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisions : MonoBehaviour
{

    [SerializeField]
    private bool _active;

    private GameObject _canvas;

    private GameObject _manager;

    private GameObject _ePanel;

    [SerializeField]
    [Tooltip("Number of Scene you would like to move to")]
    [Range(0,9)]
    private int _sceneNumber;

    [SerializeField]
    [Tooltip("Number of Controller you want to use")]
    [Range(0, 9)]
    private int _controllerNumber;

    private const string _managerName = "Game Manager";

    private const string _canvasName = "Canvas";

    private bool _showPanel = false;

    void Start()
    {
        _manager = GameObject.Find(_managerName);
        _canvas = GameObject.Find(_canvasName);
        _ePanel = _canvas.transform.FindChild("Press E Panel").gameObject;
    }

    void Update()
    {
        if (_showPanel)
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameObject sceneController = _manager.transform.GetChild(_controllerNumber).gameObject;
                sceneController.SetActive(_active);

                // Move Objects to the another scenes
                DontDestroyOnLoad(_manager);
                DontDestroyOnLoad(_canvas);
                DontDestroyOnLoad(GameObject.Find("Main Camera"));
                DontDestroyOnLoad(GameObject.Find("Prefab_PlayerCharacter"));
                SceneManager.LoadScene(_sceneNumber);

                _showPanel = false;
                _ePanel.SetActive(false);
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _showPanel = true;
            _ePanel.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _showPanel = false;
            _ePanel.SetActive(false);
        }
    }

}
