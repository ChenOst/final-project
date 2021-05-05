using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnegryBar : MonoBehaviour
{
    [SerializeField]
    private PlayerAttack _player;

    private Image _energyBar;

    // Start is called before the first frame update
    void Start()
    {
        _energyBar = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        _energyBar.fillAmount = _player.Energy / 100f;
    }
}
