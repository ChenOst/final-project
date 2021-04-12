﻿using RPGCharacters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public CharacterBase selectedCharacter;

    public Texture2D tex_white;

    public List<int> itemList = new List<int>();

    Vector2 scrollView;

    public int itemsCount = 205;

    bool showInventory = false;

    // Use this for initialization
    void Start()
    {
        selectedCharacter.EquipItem(37);
        selectedCharacter.EquipItem(38);
        selectedCharacter.EquipItem(1);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            if (showInventory)
            {
                showInventory = false;
            }
            else
            {
                showInventory = true;
            }
        }
    }

    private void OnGUI()
    {
        if (showInventory)
        {
            scrollView = GUI.BeginScrollView(new Rect(5, 5, 110, Screen.height - 10), scrollView, new Rect(0, 0, 90, 100 + itemsCount * 65));
            int counter = 1;
            for (int i = 1; i <= itemsCount; i++)
            {
                if (GUI.Button(new Rect(5, counter * 65, 64, 64), ""))
                {
                    selectedCharacter.EquipItem(i);
                }

                if (IconLoader.GetInstance().GetIcon(i) != null)
                {
                    GUI.DrawTexture(new Rect(5, counter * 65, 64, 64), IconLoader.GetInstance().GetIcon(i));
                    GUI.Label(new Rect(5, counter * 65, 64, 64), "" + i);
                }

                else
                {
                    Debug.Log("null " + i);
                }

                counter++;
            }

            GUI.EndScrollView();

            if (selectedCharacter != null)
            {
                float buttonSize = Screen.height * 0.1f;
                float startY = Screen.height * 0.2f;
                DrawEquipmentSlot(selectedCharacter.GetEquipmentSlot(Item.EquipmentSlots.head), Screen.width - Screen.width * 0.20f, startY + buttonSize * 0, buttonSize);
                DrawEquipmentSlot(selectedCharacter.GetEquipmentSlot(Item.EquipmentSlots.neck), Screen.width - Screen.width * 0.20f, startY + buttonSize * 1, buttonSize);
                DrawEquipmentSlot(selectedCharacter.GetEquipmentSlot(Item.EquipmentSlots.back), Screen.width - Screen.width * 0.20f + buttonSize, startY + buttonSize * 1, buttonSize);
                DrawEquipmentSlot(selectedCharacter.GetEquipmentSlot(Item.EquipmentSlots.body), Screen.width - Screen.width * 0.20f, startY + buttonSize * 2, buttonSize);
                DrawEquipmentSlot(selectedCharacter.GetEquipmentSlot(Item.EquipmentSlots.mainhand), Screen.width - Screen.width * 0.2f - buttonSize, startY + buttonSize * 2, buttonSize);
                DrawEquipmentSlot(selectedCharacter.GetEquipmentSlot(Item.EquipmentSlots.offhand), Screen.width - Screen.width * 0.2f + buttonSize, startY + buttonSize * 2, buttonSize);

                DrawEquipmentSlot(selectedCharacter.GetEquipmentSlot(Item.EquipmentSlots.hands), Screen.width - Screen.width * 0.2f - buttonSize, startY + buttonSize * 3, buttonSize);
                DrawEquipmentSlot(selectedCharacter.GetEquipmentSlot(Item.EquipmentSlots.legs), Screen.width - Screen.width * 0.2f, startY + buttonSize * 3, buttonSize);

                DrawEquipmentSlot(selectedCharacter.GetEquipmentSlot(Item.EquipmentSlots.feet), Screen.width - Screen.width * 0.2f, startY + buttonSize * 4, buttonSize);
            }
        }

    }
    void DrawEquipmentSlot(CharacterBase.EquipmentSlot s, float x, float y, float size)
    {
        if (s.inUse)
        {
            if (GUI.Button(new Rect(x, y, size, size), ""))
            {
                selectedCharacter.UnequipSlot(s.slot);
            }
            GUI.DrawTexture(new Rect(x, y, size, size), IconLoader.GetInstance().GetIcon(s.itemId));
        }
        else
        {
            GUI.Box(new Rect(x, y, size, size), "" + s.slot.ToString());
        }
    }
}