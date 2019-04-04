using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamScript2 : MonoBehaviour
{ 
    public RawImage rawimage;
    void Start()
    {

        WebCamDevice[] devices = WebCamTexture.devices;
        WebCamTexture webcamTexture = new WebCamTexture();
        for (int i = 0; i < devices.Length; i++)
            Debug.Log(devices[i].name);

        if (devices.Length > 0)
        {
            webcamTexture.deviceName = devices[1].name;
            rawimage.texture = webcamTexture;
            rawimage.material.mainTexture = webcamTexture;
            webcamTexture.Play();
        }
        
    }
}