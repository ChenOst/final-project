using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    private int _energy;

    [SerializeField]
    [Range(0,100)]
    public int[] _attackEnergy;

    [SerializeField]
    [Range(0, 100)]
    private int[] _attackDamage;

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
            if (Input.GetKeyDown(KeyCode.Alpha1) && (Time.time - lastTime > 3.0f)  && (Energy >= _attackEnergy[0]))
            {
                _attack.attackDamage = _attackDamage[0];
                Energy -= _attackEnergy[0];
                lastTime = Time.time;
                _anim.SetBool("Attack1", true);

            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) && (Time.time - lastTime > 3.0f)  && (Energy >= _attackEnergy[1]))
            {
                _attack.attackDamage = _attackDamage[1];
                Energy -= _attackEnergy[1];
                lastTime = Time.time;
                _anim.SetBool("Attack2", true);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) && (Time.time - lastTime > 3.0f)  && (Energy >= _attackEnergy[2]))
            {
                _attack.attackDamage = _attackDamage[2];
                Energy -= _attackEnergy[2];
                lastTime = Time.time;
                _anim.SetBool("Attack3", true);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4) && (Time.time - lastTime > 3.0f)  && (Energy >= _attackEnergy[3]))
            {
                _attack.attackDamage = _attackDamage[3];
                Energy -= _attackEnergy[3];
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
