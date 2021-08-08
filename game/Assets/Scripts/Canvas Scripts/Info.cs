using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    private bool OnOpen = true;

    [SerializeField] private GameObject _info;

    public void ShowInfo()
    {
        if (OnOpen)
        {
            _info.SetActive(true);
            OnOpen = false;
        }
        else
        {
            _info.SetActive(false);
            OnOpen = true;
        }
    }
}
