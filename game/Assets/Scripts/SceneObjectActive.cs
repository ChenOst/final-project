using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneObjectActive : MonoBehaviour
{
    [SerializeField]
    private GameObject npcs;

    [SerializeField]
    private GameObject miniMap;

    [SerializeField]
    private GameObject info;

    // Start is called before the first frame update
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Town")
        {
            info.SetActive(true);
            npcs.SetActive(true);
            miniMap.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().name == "MainMenuScene")
        {
            info.SetActive(true);
            npcs.SetActive(false);
            miniMap.SetActive(false);
        }
        else
        {
            info.SetActive(false);
            npcs.SetActive(false);
            miniMap.SetActive(true);
        }

    }
}
