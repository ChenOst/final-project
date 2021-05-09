using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveNPC : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _npcs;

    public void CanStartConversation()
    {
        foreach (GameObject obj in _npcs)
        {
            obj.layer = 9;
        }
    }
}
