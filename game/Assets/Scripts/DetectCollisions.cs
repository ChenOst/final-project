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
    [Tooltip("Number of Scene you would like to move to")]
    [Range(0,9)]
    private int _sceneNumber;

    [SerializeField]
    [Tooltip("Number of Controller you want to use")]
    [Range(0, 9)]
    private int _controllerNumber;

    private GameObject _manager;

    private const string _managerName = "Game Manager";

    void Start()
    {
        _manager = GameObject.Find(_managerName);
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            GameObject sceneController = _manager.transform.GetChild(_controllerNumber).gameObject;
            sceneController.SetActive(_active);

            // Move Object to the another scenes

                DontDestroyOnLoad(_manager);
                DontDestroyOnLoad(GameObject.Find("Main Camera"));
                DontDestroyOnLoad(GameObject.Find("Prefab_PlayerCharacter"));
                SceneManager.LoadScene(_sceneNumber);
        }
    }

}
