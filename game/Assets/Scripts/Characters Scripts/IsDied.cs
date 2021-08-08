﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EnumNames;

public class IsDied : MonoBehaviour
{

    [SerializeField]
    private bool _activeSpawner;

    [SerializeField]
    private GameObject _spawnItem;

    // This function called when the enemy is died
    public void CanDestroy()
    {
        Vector3 posToSpawn = this.gameObject.transform.position;
        
        if (this.gameObject.name.Equals("Armature_0(Clone)"))
        {
            GameObject newItem = Instantiate(_spawnItem, posToSpawn, Quaternion.identity);
            Destroy(this.transform.parent.gameObject);
        }
        else
        {
            GameObject newItem = Instantiate(_spawnItem, posToSpawn, Quaternion.identity, this.transform.parent);
            Destroy(this.gameObject);
        }

    }
}
