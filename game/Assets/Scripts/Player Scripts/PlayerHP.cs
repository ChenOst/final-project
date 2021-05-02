using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private int _hP;
    public int HP { get; private set; } 

    [SerializeField]
    private bool _addHpEverySecond;

    private PlayerCharacter _player;

    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        HP = _hP;;
        _player = GetComponent<PlayerCharacter>();
        _anim = _player.animator;
    }

    // Update is called once per frame
    void Update()
    {
        if (_addHpEverySecond && HP < _hP)
        {
            StartCoroutine(AddHp());
        }

        if (HP <= 0)
        {
            _anim.SetBool("Destroy", true);
        }
    }

    IEnumerator AddHp()
    {
        yield return new WaitForSeconds(1);
        HP ++;
    }

    public void TakeDamage(int damage)
    {
        HP = HP - damage;
    }
}
