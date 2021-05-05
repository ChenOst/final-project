using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShowMessage : MonoBehaviour
{
    [SerializeField]
    private int _waitSeconds;

    public void Show()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(_waitSeconds);
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }
}
