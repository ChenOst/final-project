using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertJArrayToMatrix : MonoBehaviour
{
    // This function convert JArray object received from AWS lambda to string[,]
    public string[,] Convert(JArray json)
    {
        string[,] mat = json.ToObject<string[,]>();
        return mat;
    }
}
