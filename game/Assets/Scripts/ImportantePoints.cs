using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantePoints : MonoBehaviour
{
    public Vector3 StartPosition { get; private set; }
    public Vector3 EndPosition { get; private set; }

    [SerializeField]
    private int _sceneIndex;

    private PositionManager positionManager;

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

        // Add to the position manager the start point
        positionManager = GameObject.Find(Constants.GameManager).GetComponent<PositionManager>();
        positionManager.AddStartPosition(_sceneIndex, StartPosition.x, StartPosition.y + 2, StartPosition.z);
    }
}
