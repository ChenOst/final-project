using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible update the PosiotionManager about the player's position in specific scene.
/// </summary>
public class PositionController : MonoBehaviour
{
    [SerializeField]
    private int _sceneIndex;

    [SerializeField]
    private PositionManager positionManager;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        positionManager = GameObject.Find(Constants.GameManager).GetComponent<PositionManager>();
        player = GameObject.Find(Constants.Player);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = player.transform.position;
        positionManager.AddSavedPosition(_sceneIndex, position.x, position.y, position.z);
    }
}
