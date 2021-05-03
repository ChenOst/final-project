using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    private int _energy;

    [SerializeField]
    [Range(0,100)]
    private int _attack1Energy, _attack2Energy, _attack3Energy, _attack4Energy;

    [SerializeField]
    [Range(0, 100)]
    private int _attack1Damage, _attack2Damage, _attack3Damage, _attack4Damage;

    public int Energy { get; private set; }

    private Attack _attack;

    private float lastTime;

    private PlayerCharacter _player;

    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        Energy = _energy;
        InvokeRepeating("RegenEnergy", 1.0f, 1.0f);
        _attack = this.GetComponentInChildren<Attack>();
        _player = GetComponent<PlayerCharacter>();
        _anim = _player.animator;
        lastTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (DisableKeyboard.IsInputEnabled )
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) && (Time.time - lastTime > 3.0f)  && (Energy >= _attack1Energy))
            {
                _attack.attackDamage = _attack1Damage;
                Energy -= _attack1Energy;
                lastTime = Time.time;
                _anim.SetBool("Attack1", true);

            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) && (Time.time - lastTime > 3.0f)  && (Energy >= _attack2Energy))
            {
                _attack.attackDamage = _attack2Damage;
                Energy -= _attack2Energy;
                lastTime = Time.time;
                _anim.SetBool("Attack2", true);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) && (Time.time - lastTime > 3.0f)  && (Energy >= _attack3Energy))
            {
                _attack.attackDamage = _attack3Damage;
                Energy -= _attack3Energy;
                lastTime = Time.time;
                _anim.SetBool("Attack3", true);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4) && (Time.time - lastTime > 3.0f)  && (Energy >= _attack4Energy))
            {
                _attack.attackDamage = _attack4Damage;
                Energy -= _attack4Energy;
                lastTime = Time.time;
                _anim.SetBool("Attack4", true);
            }
            
        }
    }

    private void RegenEnergy()
    {
        if (Energy < _energy)
        {
            Energy += 2;
        }
    }
}
