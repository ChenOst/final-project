using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using UnityEngine;

public class ConnectToLambda : MonoBehaviour
{
    public JArray Algo1JsonBoard { get; private set; }
    public JArray Algo2JsonBoard { get; private set; }
    public JArray Algo3JsonBoard { get; private set; }
    public JArray Algo4JsonBoard { get; private set; }
    public JArray Algo5JsonBoard { get; private set; }

    public static ConnectToLambda Instance { get; private set; }


    // Awake is called before Start - RestCalls() function need to run first
    void Start()
    {
        
        if(Instance == null)
        {
            RestCalls();
            this.GetComponent<InstantiateTiles>().Instantiate(ConvertJArrayToMatrix.Convert(Algo1JsonBoard));
        }
    }

    // Get info from the AWS Lambda function
    void RestCalls()
    {
        try
        {
            string url = "https://a9hhrixjaa.execute-api.eu-west-2.amazonaws.com/default/createGameLevel";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("x-api-key", "PJ720kVG8v5yCZxXLafyt59AyJrRX4Dt8q6nFC9e");
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode != HttpStatusCode.OK)
            {
                Debug.Log("RestCalls, HttpWebRequest GET not worked, StatusCode: " + response.StatusCode);
            }
            else
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string strResponse = reader.ReadToEnd();
                JObject json = JObject.Parse(strResponse);

                // Boards of all the algorithms
                Algo1JsonBoard = (JArray)json.GetValue("BSP Rooms and BSP Corridors");
                Algo2JsonBoard = (JArray)json.GetValue("BSP Rooms and RPC");
                Algo3JsonBoard = (JArray)json.GetValue("BSP Rooms and DW");
                Algo4JsonBoard = (JArray)json.GetValue("RRP and RPC");
                Algo5JsonBoard = (JArray)json.GetValue("RRP and DW");
            }
            response.Close();
        }
        catch (WebException e)
        {
            if (e.Status == WebExceptionStatus.ProtocolError)
            {
                WebResponse resp = e.Response;
                using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
                {
                    Debug.Log("RestCalls, HttpWebRequest error: " + sr.ReadToEnd());
                }
            }
        }
        catch (Exception e)
        {
            Debug.Log("RestCalls, HttpWebRequest error: " + e.Message);
        }
    }

}
