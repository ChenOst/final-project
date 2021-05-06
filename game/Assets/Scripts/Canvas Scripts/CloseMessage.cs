using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMessage : MonoBehaviour
{
    public void CloseMyMessage()
    {
        this.transform.parent.gameObject.SetActive(false);
    }
}
