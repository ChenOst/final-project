using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public int Index { get; set; }

    void Start()
    {
       PositionManager playerPos = GameObject.Find(Constants.GameManager).GetComponent<PositionManager>();
       playerPos.SetStartPosition(Index);
       StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
