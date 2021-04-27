using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    [SerializeField]
    private Transform _player;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = _player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
    }
}
