using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealCameraScript : MonoBehaviour
{
    [SerializeField] RawImage img = default;
    private WebCamTexture webCam;
    // Start is called before the first frame update
    void Start()
    {
        webCam = new WebCamTexture();
        if(!webCam.isPlaying)webCam.Play();

        img.texture=webCam;
    }

    
}
