using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible update the PosiotionManager about the player's position in specific scene.
/// It will use if the player going to new scene and we don't want him to start from the begginning (like going in levels).
/// </summary>
public class PositionController : MonoBehaviour
{
    [SerializeField]
    private int _sceneIndex;

    [SerializeField]
    private PositionManager positionManager;

    private GameObject player;

    void Start()
    {
        positionManager = GameObject.Find(Constants.GameManager).GetComponent<PositionManager>();
        player = GameObject.Find(Constants.Player);
    }

    void Update()
    {
        // While the player in the scene, always update the saved position.
        Vector3 position = player.transform.position;
        positionManager.AddSavedPosition(_sceneIndex, position.x, position.y, position.z);
    }
}
