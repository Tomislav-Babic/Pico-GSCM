using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnExitLoad3AndUnload2 : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TransitionScript.Instance.AddScene3();
            TransitionScript.Instance.RemoveScene2();
            
        }
    }
}
