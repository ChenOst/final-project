using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The purpose of this class is to find and save the first point from the begginning of the board with sign #
/// and save the last point (first from the end) of the board with sign #.
/// The points will later use for spawning the doors of each scene.
/// The start point also helps to set the player position at the begginning of new scene.
/// </summary>
public class ImportantePoints : MonoBehaviour
{
    public Vector3 StartPosition { get; private set; }
    public Vector3 EndPosition { get; private set; }

    [SerializeField]
    private int _sceneIndex;

    public void SetPoints(string[,] board)
    {
        bool StartPointWasFound = false;
        bool EndPointWasFound = false;

        // Finds the Start point
        for (int k = 0; k < board.GetLength(0) && !StartPointWasFound; k++)
        {
            for (int l = 0; l < board.GetLength(1); l++)
            {
                if (board[k, l] == "#")
                {
                    StartPosition = new Vector3(k * 2, 0, l * 2);
                    StartPointWasFound = true;
                    break;
                }
            }
        }

        // Finds the End point
        for (int k = board.GetLength(0)-1; k >= 0 && !EndPointWasFound; k--)
        {
            for (int l = board.GetLength(1)-1; l >= 0; l--)
            {

                if (board[k, l] == "#")
                {
                    EndPosition = new Vector3(k * 2, 0, l * 2);
                    EndPointWasFound = true;
                    break;
                }
            }
        }

        // Add to the Position Manager (GameManager GameObject) the start point
        PositionManager positionManager = GameObject.Find(Constants.GameManager).GetComponent<PositionManager>();
        positionManager.AddStartPosition(_sceneIndex, StartPosition.x, StartPosition.y + 2, StartPosition.z);
    }
}
