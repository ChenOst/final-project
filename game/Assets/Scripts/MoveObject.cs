using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField]
    private Vector3 _newLocation;

    [SerializeField]
    private GameObject _explosion;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        GameObject newExplosion = Instantiate(_explosion, this.transform.position, Quaternion.identity);
        this.transform.position = _newLocation;
        Destroy(newExplosion,2);
    }
}
