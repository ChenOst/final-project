using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField]
    private int _hP;
    public int HP { get; private set; }

    [SerializeField]
    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        HP = _hP;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            _anim.SetBool("Destroy", true);
        }
    }

    public void TakeDamage(int damage)
    {
        HP = HP - damage;
    }
}
