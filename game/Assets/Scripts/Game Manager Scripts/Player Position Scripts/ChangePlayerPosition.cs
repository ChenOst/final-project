using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerPosition : MonoBehaviour
{
    public int Index { get; set; }
    public bool StartPos { get; set; }

    void Start()
    {
        PositionManager playerPos = GameObject.Find(Constants.GameManager).GetComponent<PositionManager>();
        if (StartPos)
        {
            playerPos.SetStartPosition(Index);
        }
        else
        {
            playerPos.SetSavedPosition(Index);
        }
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
