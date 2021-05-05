using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateSceneName : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        string name = SceneManager.GetActiveScene().name;
        this.GetComponent<TextMeshProUGUI>().text = name;
    }
}
