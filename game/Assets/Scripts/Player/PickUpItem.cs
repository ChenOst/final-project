using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    private int _itemId;

    // Start is called before the first frame update
    void Start()
    {
        _itemId = Random.Range(0, 205);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Constants.PlayerTag)
        {
            if (!other.gameObject.GetComponent<Inventory>().Items.Contains(_itemId))
            {
                other.gameObject.GetComponent<Inventory>().Items.Add(_itemId);
            }
            Destroy(this.gameObject);
        }
    }

}
