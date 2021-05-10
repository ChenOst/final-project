using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;

public class DeactivateMayor : MonoBehaviour
{
    [SerializeField]
    private GameObject mayor;

    private Story story;

    private StartConversation conversation;

    private bool once = true;

    private void Start()
    {
        story = GameObject.Find(Constants.GameManager).GetComponent<DontDestroyObjects>()
            .GetDontDestroyObject(Constants.TwineTextPlayer).GetComponent<Story>();
    }
    // Update is called once per frame
    void Update()
    {
        if (story.Vars.GetMember("enemyTheMayor").InnerValue != null)
        {
            if ((bool)story.Vars.GetMember("enemyTheMayor").InnerValue && once)
            {
                once = false;
                mayor.GetComponent<MoveObject>().enabled = true;
            }
        }
    }
}
