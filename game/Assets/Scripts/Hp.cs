using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    [SerializeField]
    private int _hp { get; set; }

    [SerializeField]
    private bool _addHpEverySecond;

    private int _maxHP;

    // Start is called before the first frame update
    void Start()
    {
        _maxHP = _hp;
    }

    // Update is called once per frame
    void Update()
    {
        if (_addHpEverySecond && _hp < _maxHP)
        {
            StartCoroutine(AddHp());
        }

        if (_hp <= 0)
        {
            Debug.Log("Destory Object");
            // Animation
            // Destory (this);
        }
    }

    IEnumerator AddHp()
    {
        yield return new WaitForSeconds(1);
        _hp++;
    }

    public void TakeDamage(int damage)
    {
        _hp = _hp - damage;
    }
}
