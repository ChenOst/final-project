using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void OnClick()
    {
        // Enable the keyboard
        DisableKeyboard.IsInputEnabled = true;
        SceneManager.LoadScene("Town");
    }
}
