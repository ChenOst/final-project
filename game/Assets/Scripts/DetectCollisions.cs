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
    private bool _active;

    [SerializeField]
    [Tooltip("Number of Scene you would like to move to")]
    [Range(0,9)]
    private int _sceneNumber;

    [SerializeField]
    [Tooltip("Number of Controller you want to use")]
    [Range(0, 9)]
    private int _controllerNumber;

    private GameObject _manager, _ePanel;

    private TextMeshProUGUI _sceneName;

    private bool _showPanel = false;

    void Start()
    {
        _manager = GameObject.Find(ObjectNameHelper.GameManager);
        _ePanel = GameObject.Find(ObjectNameHelper.Canvas).transform.Find(ObjectNameHelper.PressEPanel).gameObject;
        _sceneName = _ePanel.transform.Find(ObjectNameHelper.SceneNameTMP).GetComponent<TextMeshProUGUI>();
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

                GameObject sceneController = _manager.transform.GetChild(_controllerNumber).gameObject;
                sceneController.SetActive(_active);
                SceneManager.LoadScene(_sceneNumber);
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == ObjectNameHelper.PlayerTag)
        {
            _showPanel = true;
            _ePanel.SetActive(true);    
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == ObjectNameHelper.PlayerTag)
        {
            _showPanel = false;
            _ePanel.SetActive(false);
        }
    }

}
