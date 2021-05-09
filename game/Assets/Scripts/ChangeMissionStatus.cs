using Cradle;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMissionStatus : MonoBehaviour
{

    [SerializeField]
    private string[] _missionName;

    private Story story;

    private void Start()
    {
        story = GameObject.Find(Constants.GameManager).GetComponent<DontDestroyObjects>()
            .GetDontDestroyObject(Constants.TwineTextPlayer).GetComponent<Story>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == Constants.PlayerTag)
        {
            if (story.Vars.GetMember(_missionName[0]).InnerValue != null)
            {
                foreach (string name in _missionName)
                {
                    story.Vars.SetMember(name, true);
                }
            }
        }
    }
}
