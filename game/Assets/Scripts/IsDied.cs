using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EnumNames;

public class IsDied : MonoBehaviour
{
    [SerializeField]
    private bool _activeSpawner;

    [SerializeField]
    [ConditionalHide("_activeSpawner", true)]
    private GameObject _spawnItem;

    // This function called when the enemy is died
    public void CanDestroy()
    {
        Vector3 posToSpawn = this.gameObject.transform.position;
        GameObject newItem = Instantiate(_spawnItem, posToSpawn, Quaternion.identity, this.transform.parent);
        Destroy(this.gameObject);
    }

    // This function called when the player is died
    public void GameOver()
    {
        DisableKeyboard.IsInputEnabled = false;
        Debug.Log("Player is died GAME OVER!");
    }
}
