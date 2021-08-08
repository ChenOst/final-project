using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    private int _itemId;

    private GameObject _itemMessage;

    // Start is called before the first frame update
    void Start()
    {
        _itemId = Random.Range(0, 205);
        _itemMessage = GameObject.Find(Constants.Canvas).transform.Find(Constants.ItemMessage).gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Constants.PlayerTag)
        {
            if (!other.gameObject.GetComponent<Inventory>().Items.Contains(_itemId))
            {
                other.gameObject.GetComponent<Inventory>().Items.Add(_itemId);
                _itemMessage.GetComponent<ShowMessage>().Show();
            }
            Destroy(this.gameObject);
        }
    }

}
