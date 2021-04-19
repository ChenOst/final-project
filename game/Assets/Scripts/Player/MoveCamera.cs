using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    private Transform _playerTransform;

    private Vector3 _cameraoffset;

    private Transform _obstruction;

    private Transform _tempObstruction;

    void Start()
    {
        _cameraoffset = transform.position - _playerTransform.position;
        _obstruction = _playerTransform;
    }

    void LateUpdate()
    {
        Vector3 newPosition = _playerTransform.position + _cameraoffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, 1);

        ViewObstructed();
    }

    void ViewObstructed()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, _playerTransform.position - transform.position, out hit, 4.5f))
        {
            if (hit.collider.gameObject.tag == Constants.WallTag)
            {
                _obstruction = hit.transform;

                if (_tempObstruction == null)
                {
                    _tempObstruction = _obstruction;
                }
                
                if (_tempObstruction != _obstruction)
                {
                    foreach (Transform walls in _tempObstruction)
                    {
                         walls.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    }
                    _tempObstruction = _obstruction;
                }

                foreach (Transform walls in _obstruction)
                {
                    walls.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                }
                
            }
            else if (hit.collider.gameObject.tag == Constants.PlayerTag)
            {
                if (_tempObstruction != null)
                {
                    foreach (Transform walls in _tempObstruction)
                    {
                        walls.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    }
                    
                }
            }


        }
    }
}
