using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartConversation : MonoBehaviour
{
    [SerializeField]
    private GameObject _twineText;

    [SerializeField]
    private float rayLength;

    [SerializeField]
    private LayerMask layermask;

    private NPC _npc;

    private bool _inConversation = false;

    float distance;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayLength, layermask) && !_inConversation)
            {
                _npc = hit.collider.gameObject.GetComponent<NPC>();
                Debug.Log("hit " + _npc.name);

                // Calculate the distance between Player and NPC
                distance = Vector3.Distance(_npc.transform.position, transform.position);

                //Open conversation
                _inConversation = true;
                _twineText.SetActive(true);
                _npc.GoToPassage();
                _npc.ActiveStory(true);
            }
        }

        if (_inConversation)
        {
            distance = Vector3.Distance(_npc.transform.position, transform.position);
            // If the player is too far away, close conversation
            if (distance > rayLength)
            {
                _twineText.SetActive(false);
                _npc.ActiveStory(false);
                _inConversation = false;
            }
        }
    }


}
