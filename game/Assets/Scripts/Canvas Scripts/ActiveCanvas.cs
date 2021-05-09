using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCanvas : MonoBehaviour
{
    [SerializeField]
    private int _numberOfChildrenToActive;
    // Start is called before the first frame update
    void Start()
    {
        // When players starts the "Town" scene show the game canvas with all the player important details
        GameObject canvas = GameObject.Find(Constants.Canvas);
        for (int i=0; i< _numberOfChildrenToActive; i++)
        {
            canvas.transform.GetChild(i).gameObject.SetActive(true);
        }

        Destroy(this.gameObject, 3);
    }

}
