using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : CharacterHP
{

    private PlayerCharacter _player;

    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        HP = _hP;
        _player = GetComponent<PlayerCharacter>();
        _anim = _player.animator;
        InvokeRepeating("RegenHealth", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            _anim.SetBool("Destroy", true);
        }

    }

    private void RegenHealth()
    {
        if (HP < _hP)
        {
            HP++;
        }
    }

}
