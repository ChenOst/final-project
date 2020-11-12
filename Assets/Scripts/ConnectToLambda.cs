using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class ConnectToLambda : MonoBehaviour
{
    private JArray _Algo1MatrixBoard; // BSP_rooms&BSP_corridors
    private JArray _Algo2MatrixBoard;
    private JArray _Algo3MatrixBoard;
    private JArray _Algo4MatrixBoard;
    private JArray _Algo5MatrixBoard;

    // Awake is called before Start - RestCalls() function need to run first
    void Awake()
    {
        RestCalls();
    }

    // Get info from the AWS Lambda function
    // name (?)
    void RestCalls()
    {
        try
        {
            string url = "https://c3lwvoy7j0.execute-api.eu-west-2.amazonaws.com/default/calcGame";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            // Need to add token 

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
                Debug.Log("RestCalls, HttpWebResponse response: " + json); //Can do json.GetValue("value")

                // Boards of all the algorithms
                _Algo1MatrixBoard = (JArray)json.GetValue("BSP_rooms&BSP_corridors"); // Newtonsoft.Json.Linq.JArray
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

    public JArray getAlgo1MatrixBoard { get { return _Algo1MatrixBoard; } }
}
