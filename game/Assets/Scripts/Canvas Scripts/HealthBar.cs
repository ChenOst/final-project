using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private PlayerHP _player;

    private Image _healthBar;

    // Start is called before the first frame update
    void Start()
    {
        _healthBar = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        _healthBar.fillAmount = _player.HP / 100f;
    }
}
