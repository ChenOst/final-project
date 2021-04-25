using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Number of Scene you would like to move to")]
    [Range(1, 15)]
    private int _sceneNumber;

    [SerializeField]
    [Tooltip("Where the player character start in the scene")]
    private bool _takeToStartPosition;

    [SerializeField]
    [Tooltip("Number of Controller you want to use")]
    [Range(0, 14)]
    private int _controllerNumber;

    [SerializeField]
    [Tooltip("Active or deactivate the chosen controller")]
    private bool _active;

    private GameObject _ePanel;

    private bool _showPanel = false;

    void Start()
    {
        _ePanel = GameObject.Find(Constants.Canvas)
                    .transform.Find(Constants.PressEPanel).gameObject;

        // Add text with scene name to the panel
        TextMeshProUGUI _sceneName = _ePanel.transform.Find(Constants.SceneNameTMP).GetComponent<TextMeshProUGUI>();
        string name = SceneUtility.GetScenePathByBuildIndex(_sceneNumber).Replace("Assets/Scenes/", "").Replace(".unity","");
        _sceneName.text = name;
    }

    void Update()
    {
        if (_showPanel)
        {
            if (Input.GetKey(KeyCode.E))
            {
                _showPanel = false;
                _ePanel.SetActive(false);

                foreach (Transform child in GameObject.Find(Constants.GameManager).transform)
                {
                    child.gameObject.SetActive(false);
                }

                if (_active)
                {
                    GameObject sceneController = GameObject.Find(Constants.GameManager)
                                              .transform.GetChild(_controllerNumber).gameObject;
                    sceneController.SetActive(true);
                }

                SpawnPlayerAtPosition();
                SceneManager.LoadScene(_sceneNumber);
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == Constants.PlayerTag)
        {
            _showPanel = true;
            _ePanel.SetActive(true);    
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == Constants.PlayerTag)
        {
            _showPanel = false;
            _ePanel.SetActive(false);
        }
    }

    private void SpawnPlayerAtPosition()
    {
        GameObject playersNewPosition = new GameObject();
        playersNewPosition.AddComponent<ChangePlayerPosition>().Index = _sceneNumber;
        playersNewPosition.GetComponent<ChangePlayerPosition>().StartPos = _takeToStartPosition;
        DontDestroyOnLoad(playersNewPosition);
    }
}
