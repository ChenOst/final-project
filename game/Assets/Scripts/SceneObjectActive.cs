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

    // Start is called before the first frame update
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Town")
        {
            npcs.SetActive(true);
            miniMap.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().name == "MainMenuScene")
        {
            npcs.SetActive(false);
            miniMap.SetActive(false);
        }
        else
        {
            npcs.SetActive(false);
            miniMap.SetActive(true);
        }

    }
}
