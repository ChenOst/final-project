using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(new Vector3
            (Input.GetAxis("Horizontal") *7 * Time.deltaTime
            , 0, Input.GetAxis("Vertical") * 7 * Time.deltaTime
            )
        );
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
      
    }
}
