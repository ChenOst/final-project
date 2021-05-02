using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : CharacterHP
{
    private Animator _anim;

    void Start()
    {
        HP = _hP;
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            _anim.SetBool("Destroy", true);
        }
    }
}
