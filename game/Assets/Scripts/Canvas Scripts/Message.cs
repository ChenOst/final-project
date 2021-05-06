using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Message : MonoBehaviour
{
    TextMeshProUGUI _text;

    // Start is called before the first frame update
    void Start()
    {
        _text = this.GetComponent<TextMeshProUGUI>();

        // Start Text Message
        _text.text = "Welcome hero!\nThe wizard of the town was invited u to investigate the weird things that have been happening lately.\n\nGood Luck!";
    }

    public void UpdateText(string newText)
    {
        _text.text = newText;
    }
}
