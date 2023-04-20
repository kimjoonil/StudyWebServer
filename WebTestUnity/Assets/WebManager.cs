using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

public class GameResult
{
    public string UserName;
    public int Score;
}

public class WebManager : MonoBehaviour
{
    string baseUrl = "http://localhost:44395/api";

    void Start()
    {
        var res = new GameResult
        {
            UserName = "rgl",
            Score = 357
        };

        SendPostRequest("ranking", res, (uwr) =>
        {
            Debug.Log("TODO : UI 갱신하기");
        });

        SendGetAllRequest("ranking", (uwr) =>
        {
            Debug.Log("TODO : UI 갱신하기");
        });
    }

    public void SendPostRequest(string url, GameResult obj, Action<UnityWebRequest> callback)
    {
        StartCoroutine(SendWebRequest(url, "POST", obj, callback));
    }

    public void SendGetAllRequest(string url, Action<UnityWebRequest> callback)
    {
        StartCoroutine(SendWebRequest(url, "GET", null, callback));
    }

    private IEnumerator SendWebRequest(string url, string method, object obj, Action<UnityWebRequest> callback)
    {
        string sendUrl = $"{baseUrl}/{url}/";
        byte[] jsonBytes = null;

        if (obj != null)
        {
            string jsonStr = JsonUtility.ToJson(obj);
            jsonBytes = Encoding.UTF8.GetBytes(jsonStr);
        }

        var uwr = new UnityWebRequest(sendUrl, method);
        uwr.uploadHandler = new UploadHandlerRaw(jsonBytes);
        uwr.downloadHandler = new DownloadHandlerBuffer();
        uwr.SetRequestHeader("Content-Type", "application/json");

        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError || uwr.isHttpError)
        {
            Debug.Log(uwr.error);
        }
        else
        {
            Debug.Log("Recv" + uwr.downloadHandler.text);
            callback.Invoke(uwr);
        }
    }
}
