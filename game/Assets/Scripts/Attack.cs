using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UIElements;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField]
    private string targetTag;

    public void CanAttack(int attackDamage)
    {
        RaycastHit hit;

        // If the target is still close to the attacker attack
        if (Physics.Raycast(transform.position, transform.forward + new Vector3(0, 1, 0), out hit, 2f))
        {

            if (hit.collider.gameObject.tag == targetTag)
            {
                CharacterHP hp = hit.collider.gameObject.GetComponent<CharacterHP>();
                hp.TakeDamage(attackDamage);
                Debug.Log("HP: " + hp.HP);
            }
            
        }
    }
}
