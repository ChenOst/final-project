using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHP : MonoBehaviour
{
    [SerializeField]
    public int _hP;

    public int HP { get; set; }

    public void TakeDamage(int damage)
    {
        HP -= damage;
    }


}
