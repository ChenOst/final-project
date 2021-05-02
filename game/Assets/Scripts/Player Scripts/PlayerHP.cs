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
    }

    // Update is called once per frame
    void Update()
    {
        //if (HP < _hP)
        //{
        //    StartCoroutine(RegenHealth());
        //}

        if (HP <= 0)
        {
            _anim.SetBool("Destroy", true);
        }

    }

    IEnumerator RegenHealth()
    {
        yield return new WaitForSeconds(1 * Time.deltaTime);
        HP ++;
    }

}
