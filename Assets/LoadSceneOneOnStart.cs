using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneOneOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TransitionScript.Instance.AddScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
