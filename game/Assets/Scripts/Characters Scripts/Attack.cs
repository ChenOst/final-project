using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UIElements;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField]
    private string targetTag;

    [SerializeField]
    public int attackDamage;

    [SerializeField]
    public GameObject _floatingText;

    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public void CanAttack()
    {
        RaycastHit hit;

        // If the target is still close to the attacker remove HP
        if (Physics.Raycast(transform.position, transform.forward + new Vector3(0, 1, 0), out hit, 2f))
        {

            if (hit.collider.gameObject.tag == targetTag)
            {
                CharacterHP hp = hit.collider.gameObject.GetComponent<CharacterHP>();
                hp.TakeDamage(attackDamage);
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    ShowFloatingText(hit.collider.gameObject);
                }
            }
            
        }
    }
    public void StopAttack(string attackName)
    {
        _anim.SetBool(attackName, false);
    }

    private void ShowFloatingText(GameObject enemy)
    {
        GameObject text = Instantiate(_floatingText, enemy.transform.position + new Vector3(0,1,0.5f), Quaternion.identity, enemy.transform);
        text.GetComponent<TextMesh>().text = $"-{attackDamage}";
        Destroy(text, 1);
    }
}
