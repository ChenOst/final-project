using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This class is responsible for keeping all information about the player's position in each of the scenes in the game.
/// </summary>
public class PositionManager : MonoBehaviour
{
    // Update Every frame if the game
    private static Dictionary<int, Vector3> _savedPositions = new Dictionary<int, Vector3>();

    // Set only once
    private static Dictionary<int, Vector3> _startPositions = new Dictionary<int, Vector3>();

    private GameObject _player;

    void Start()
    {
        _player = GameObject.Find(Constants.Player);
        _startPositions.Add(1, new Vector3(12, 1.08f, 15));
        _savedPositions.Add(1, new Vector3(12, 1.08f, 15));
    }

    public void AddSavedPosition(int sceneIndex, float x, float y, float z)
    {
        if (_savedPositions.ContainsKey(sceneIndex))
        {
            _savedPositions[sceneIndex] = new Vector3(x, y, z);
        }
        else
        {
            _savedPositions.Add(sceneIndex, new Vector3(x, y, z));
        }
    }

    public void AddStartPosition(int sceneIndex, float x, float y, float z)
    {
        if (_startPositions.ContainsKey(sceneIndex))
        {
            _startPositions[sceneIndex] = new Vector3(x, y, z);
        }
        else
        {
            _startPositions.Add(sceneIndex, new Vector3(x, y, z));
        }
        
    }

    public void SetSavedPosition(int sceneIndex)
    {
        _player.transform.position = _savedPositions[sceneIndex];
    }

    public void SetStartPosition(int sceneIndex)
    {
        _player.transform.position = _startPositions[sceneIndex];
    }

}
