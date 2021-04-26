using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static EnumNames;

public class DetectCollisions : MonoBehaviour
{
    [SerializeField]
    private SceneNames sceneName;

    [SerializeField]
    private ControllerNames controllerNumber;

    [SerializeField]
    [Tooltip("Where the player character start in the scene")]
    private bool _takeToStartPosition;

    [SerializeField]
    [Tooltip("Active or deactivate the chosen controller")]
    private bool _active;

    private GameObject _ePanel;

    private bool _showPanel = false;

    TextMeshProUGUI _sceneName;

    void Start()
    {
        _ePanel = GameObject.Find(Constants.Canvas)
                    .transform.Find(Constants.PressEPanel).gameObject;

        // Add text with scene name to the panel
        _sceneName = _ePanel.transform.Find(Constants.SceneNameTMP).GetComponent<TextMeshProUGUI>();
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
                    foreach (Transform grandchild in child)
                    {
                        grandchild.gameObject.SetActive(false);
                    }
                }

                if (_active)
                {
                    Transform sceneController = GameObject.Find(Constants.GameManager)
                                              .transform.GetChild((int)controllerNumber);
                    foreach (Transform grandchild in sceneController)
                    {
                        grandchild.gameObject.SetActive(true);
                    }
                }

                SpawnPlayerAtPosition();
                SceneManager.LoadScene((int)sceneName);
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == Constants.PlayerTag)
        {
            _showPanel = true;
            _ePanel.SetActive(true);
            string name = SceneUtility.GetScenePathByBuildIndex((int)sceneName).Replace("Assets/Scenes/", "").Replace(".unity", "");
            _sceneName.text = name;
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
        playersNewPosition.AddComponent<ChangePlayerPosition>().Index = (int)sceneName;
        playersNewPosition.GetComponent<ChangePlayerPosition>().StartPos = _takeToStartPosition;
        DontDestroyOnLoad(playersNewPosition);
    }

}
