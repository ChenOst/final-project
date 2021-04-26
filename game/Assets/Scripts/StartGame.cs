using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    private GameObject _panel;

    public void OnClick()
    {
        _panel.SetActive(true);
        SceneManager.LoadScene("Town");
    }
}
