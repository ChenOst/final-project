using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumNames
{
    public enum SceneNames
    {
        Town = 1,
        BSPRoomsAndRPCLevel1,
        BSPRoomsAndRPCLevel2,
        BSPRoomsAndRPCLevel3,
        BSPRoomsAndBSPCorridorsLevel1,
        BSPRoomsAndBSPCorridorsLevel2,
        BSPRoomsAndBSPCorridorsLevel3,
        BSPRoomsAndDWLevel1,
        BSPRoomsAndDWLevel2,
        BSPRoomsAndDWLevel3,
        RRPAndRPCLevel1,
        RRPAndRPCLevel2,
        RRPAndRPCLevel3,
        RRPAndDWLevel1,
        RRPAndDWLevel2,
        RRPAndDWLevel3
    }

    public enum ControllerNames
    {
        Controller2,
        Controller3
    }

    public enum AlgorithmName
    { 
        BSPRoomsAndRPC,
        BSPRoomsAndBSPCorridors,
        BSPRoomsAndDW,
        RRPAndRPC,
        RRPAndDW 
    }
}
