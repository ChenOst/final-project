using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartConversation : MonoBehaviour
{
    [SerializeField]
    private GameObject background;

    private NPC otherObject;

    private bool isEnter = false;

    private GameObject _ePanel;

    private TextMeshProUGUI _sceneName;

    void Start()
    {
        _ePanel = GameObject.Find(Constants.Canvas)
                    .transform.Find(Constants.PressEPanel).gameObject;

        _sceneName = _ePanel.transform.Find(Constants.SceneNameTMP).GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (isEnter)
        {
            if (Input.GetKey(KeyCode.E))
            {
                _ePanel.SetActive(false);
                background.SetActive(true);
                otherObject.GoToPassage();
                otherObject.ActiveStory(true);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == Constants.NPCTag)
        {
            _ePanel.SetActive(true);

            otherObject = other.gameObject.GetComponent<NPC>();
            isEnter = true;
            _sceneName.text = "To Talk";
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == Constants.NPCTag)
        {
            _ePanel.SetActive(false);
            background.SetActive(false);
            otherObject.ActiveStory(false);
            isEnter = false;
        }
    }

}
