using Cradle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    private string startPassage;

    private string currentPassage;

    private Story story;

    private bool active = false;


    // Start is called before the first frame update
    void Start()
    {
        currentPassage = startPassage;
        GameObject _twineCanvas = GameObject.Find(Constants.GameManager).GetComponent<DontDestroyObjects>()
           .GetDontDestroyObject(Constants.TwineTextPlayer).gameObject;
        story = _twineCanvas.GetComponent<Story>();
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            currentPassage = story.CurrentPassage.Name;
        }
    }
    public void GoToPassage()
    {
        story.GoTo(currentPassage);
    }
    public void ActiveStory(bool flag)
    {
        active = flag;
    }
}
