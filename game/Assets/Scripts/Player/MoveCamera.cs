using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    private Transform _playerTransform;

    private Vector3 _cameraoffset;

    void Start()
    {
        _cameraoffset = transform.position - _playerTransform.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = _playerTransform.position + _cameraoffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, 1);
    }
}
