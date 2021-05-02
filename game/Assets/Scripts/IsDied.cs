using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsDied : MonoBehaviour
{
    // This function called when the enemy is died
    public void CanDestroy()
    {
        Destroy(this.gameObject, 5);
    }

    // This function called when the player is died
    public void GameOver()
    {
        Debug.Log("Player is died GAME OVER!");
    }
}
