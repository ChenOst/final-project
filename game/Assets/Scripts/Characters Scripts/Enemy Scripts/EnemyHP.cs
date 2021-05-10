using RPGCharacters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : CharacterHP
{
    private Animator _anim;

    [SerializeField]
    [Tooltip("For Skeletons enter true, for The Mayor enter false")]
    private bool _regularEnemy;

    void Start()
    {
        HP = _hP;
        // Skeleton enemies 
        if (_regularEnemy)
        {
            _anim = GetComponent<Animator>();
        } // The Mayor enemy
        else
        {
            _anim = GetComponent<NpcEquipment>().animator;
        }
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
