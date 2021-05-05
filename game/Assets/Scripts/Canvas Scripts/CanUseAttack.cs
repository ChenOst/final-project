using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanUseAttack : MonoBehaviour
{
    [SerializeField]
    private PlayerAttack _player;

    [SerializeField]
    [Range(1,4)]
    private int _attackNumber;

    private Image _image;

    // Start is called before the first frame update
    void Start()
    {
        _image = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_player._attackEnergy[_attackNumber-1] > _player.Energy)
        {
            _image.color = new Color32(121, 121, 121, 100);
        }
        else
        {
            _image.color = new Color32(255, 223, 136, 255);
        }
    }
}
