using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _panels;

    public void OnClick()
    {
        foreach(GameObject panel in _panels)
        {
            panel.SetActive(true);
        }
        SceneManager.LoadScene("Town");
    }
}
