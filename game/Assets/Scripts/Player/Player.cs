using RPGCharacters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterBase selectedCharacter;

    public List<int> ItemsId { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        ItemsId = new List<int>();
        selectedCharacter = this.GetComponent<CharacterBase>();

        DressPlayerDefault();
    }

    private void DressPlayerDefault()
    {
        selectedCharacter.EquipItem(37);
        selectedCharacter.EquipItem(38);
        selectedCharacter.EquipItem(1);

        ItemsId.Add(37);
        ItemsId.Add(38);
        ItemsId.Add(1);
    }
}
